using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature;
using B20_Ex01_Eldar_313371833_Idan_313116543.Logic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    public class Facade
    {
        FilterOptionsSystem filterOptionsSystem = new FilterOptionsSystem();
        FoundSoulmateAndGroupPopularitySystem foundSoulmateAndGroupPopularitySystem = new FoundSoulmateAndGroupPopularitySystem();
        FacebookSystem facebookSystem = new FacebookSystem();



        public LoginResult LoginToFacebook(string io_AppId, params string[] io_AccessableFacebookAttributes)
        {
            return facebookSystem.LoginToFacebook(io_AppId, io_AccessableFacebookAttributes);
        }

        //public void ShowSoulmate()

        public bool CheckBoxesValidation(List<CheckedListBox> io_CheckedListBoxes)
        {
            return filterOptionsSystem.CheckBoxesValidation(io_CheckedListBoxes);
        }

        public List<AgeRange> GetSelectedAgeRanges(CheckedListBox io_AgesCheckedListBox)
        {
            return filterOptionsSystem.GetAgeRanges(io_AgesCheckedListBox);
        }
        
        public List<string> GetSelectedGenders(CheckedListBox io_GendersCheckedListBox)
        {
            return filterOptionsSystem.GetGenders(io_GendersCheckedListBox);
        }

        public User GetFriendThatGaveMostLikes(User io_LoggedInUser, List<string> io_PreferredGenders, List<AgeRange> io_PreferredAges)
        {
            return foundSoulmateAndGroupPopularitySystem.FindFriendThatGaveMostLikes(io_LoggedInUser, io_PreferredGenders, io_PreferredAges);
        }

        public int GetNumberOfMembersInGroup(Group io_Group, List<string> io_PreferredGenders, List<AgeRange> io_PreferredAges)
        {
            return foundSoulmateAndGroupPopularitySystem.numberOfMembersInGroup(io_Group, io_PreferredGenders, io_PreferredAges);
        }
    }
}
