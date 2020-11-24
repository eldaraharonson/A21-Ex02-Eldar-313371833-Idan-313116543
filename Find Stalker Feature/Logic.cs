using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature
{
    public class Logic
    {
        
        public static User FindFriendThatGaveMostLikes(User io_LoggedInUser)
        {
            
            int maxNumberOfLikesByOneOppositeSexFriend = 0;
            User oppositeSexFriendWithMaxNumberOfLikes = new User();
            foreach (User friend in io_LoggedInUser.Friends)
            {
                if (isDifferentSex(io_LoggedInUser, friend) && isOfAppropriateAge(io_LoggedInUser, friend))
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

        private static bool isDifferentSex(User i_LoggedInUser, User i_Friend)
        {
            return !string.Equals(i_LoggedInUser.Gender, i_Friend.Gender);
        } 

        private static bool isOfAppropriateAge(User io_LoggedInUser, User i_Friend)
        {
            int loggedInUserBirthYear = getBirthYear(io_LoggedInUser);
            int friendBirthYear = getBirthYear(i_Friend);
            bool appropriateAgeDifference = Math.Abs(loggedInUserBirthYear - friendBirthYear) <= 15 && friendBirthYear >= 18;
            return appropriateAgeDifference;
        }

        private static int getBirthYear(User user)
        {
            int.TryParse(user.Birthday.Substring(6), out int birthYear);
            return birthYear;
        }
    }
}
