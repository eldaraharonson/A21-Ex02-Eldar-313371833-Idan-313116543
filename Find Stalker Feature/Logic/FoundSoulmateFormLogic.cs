using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature
{
    public class FoundSoulmateFormLogic
    {
        public static User FindFriendThatGaveMostLikes(User io_LoggedInUser, List<string> i_PreferredGenders, List<AgeRange> i_PreferredAges)
        {
            
            int maxNumberOfLikesByOneOppositeSexFriend = 0;
            User oppositeSexFriendWithMaxNumberOfLikes = new User();
            foreach (User friend in io_LoggedInUser.Friends)
            {
                if (isOfPreferredGender(friend, i_PreferredGenders) && isOfPreferredAge(friend, i_PreferredAges))
                {
                    int numberOfLikesByFriend = numberOfLikesFriendGaveUser(io_LoggedInUser, friend);
                    if (numberOfLikesByFriend > maxNumberOfLikesByOneOppositeSexFriend)
                    {
                        oppositeSexFriendWithMaxNumberOfLikes = friend;
                        maxNumberOfLikesByOneOppositeSexFriend = numberOfLikesByFriend;
                    }
                }
            }
            
            if (maxNumberOfLikesByOneOppositeSexFriend == 0)
            {
                oppositeSexFriendWithMaxNumberOfLikes = null;
            }

            return oppositeSexFriendWithMaxNumberOfLikes;
        }

        private static int numberOfLikesFriendGaveUser(User i_LoggedInUser, User i_friend)
        {
            int numberOfLikes = 0;
            foreach (Post post in i_LoggedInUser.Posts)
            {
                if (post.LikedBy.Contains(i_friend))
                {
                    numberOfLikes++;
                }
            }

            return numberOfLikes;
        }

        private static bool isOfPreferredGender(User i_Friend, List<string> i_PreferredGender)
        {
            bool isPreferredGender = false;
            foreach (string gender in i_PreferredGender)
            {
                if (string.Equals(i_Friend.Gender, gender))
                {
                    isPreferredGender = true;
                    break;
                }
            }
            return isPreferredGender;
        } 

        private static bool isOfPreferredAge(User i_Friend, List<AgeRange> i_PreferredAges)
        {
            int friendAge = getAge(i_Friend);
            bool preferredAge = false;
            foreach (AgeRange ageRange in i_PreferredAges)
            {
                if (ageRange.isInAgeRange(friendAge))
                {
                    preferredAge = true;
                    break;
                }
            }
            return preferredAge;
        }

        private static int getAge(User user)
        {
            int.TryParse(user.Birthday.Substring(6), out int birthYear);
            int age = DateTime.Now.Year - birthYear;
            return age;
        }
    }
}
