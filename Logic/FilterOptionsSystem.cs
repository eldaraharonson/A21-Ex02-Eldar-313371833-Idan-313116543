using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature
{
    public class FilterOptionsSystem
    {
        public List<AgeRange> GetAgeRanges(CheckedListBox io_AgesCheckedListBox)
        {
            List<AgeRange> ageRanges = new List<AgeRange>();
            List<string> stringOfAgeRanges = GetCheckBoxListItems(io_AgesCheckedListBox);
            foreach (string ageRangeString in stringOfAgeRanges)
            {
                int.TryParse(ageRangeString.Substring(0, 1), out int lowestAge);
                int.TryParse(ageRangeString.Substring(3), out int highestAge);
                ageRanges.Add(new AgeRange(lowestAge, highestAge));
            }

            return ageRanges;
        }

        public List<string> GetGenders(CheckedListBox io_GendersCheckedListBox)
        {
            List<string> genders = GetCheckBoxListItems(io_GendersCheckedListBox);
            return genders;
        }

        //checks that for all filters at least one filter has been checked
        public bool CheckBoxesValidation(List<CheckedListBox> i_CheckedListBoxes)
        {
            bool allFiltersChecked = true;
            foreach (CheckedListBox checkedListBox in i_CheckedListBoxes)
            {
                if (checkedListBox.CheckedItems.Count == 0)
                {
                    allFiltersChecked = false;
                    break;
                }
            }

            return allFiltersChecked;
        }

        public List<string> GetCheckBoxListItems(CheckedListBox  i_CheckedListBox)
        {
            List<string> checkedItems = new List<string>();
            foreach (string item in i_CheckedListBox.CheckedItems)
            {
                checkedItems.Add(item);
            }
            return checkedItems;
        }

        public static GroupBuilder BuilderMatcher(AgeRange i_AgePreferences, List<string> i_Gender ,int i_likes)
        {
            BuilderMatcher builderMatcher;
            if (i_AgePreferences.HighestAge == 25)
            {
                if ((i_Gender.Capacity == 1) && (i_Gender[0] == "Male"))
                {

                    if (i_likes > 100)
                    {

                    }
                    else
                    {

                    }
                }
                else if ((i_Gender.Capacity == 1) && (i_Gender[0] == "Female"))
                {
                    if (i_likes > 100)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else if(i_AgePreferences.LowestAge == 50)
            {
                if ((i_Gender.Capacity == 1) && (i_Gender[0] == "Male"))
                {

                    if (i_likes > 100)
                    {

                    }
                    else
                    {

                    }
                }
                else if ((i_Gender.Capacity == 1) && (i_Gender[0] == "Female"))
                {
                    if (i_likes > 100)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {

                }

            }
            else
            {

            }
        }

        public enum GroupBuilder
        {
            YoungBoysPopularGroupBuilder = 0,
            YoungBoysNotPopularGroupBuilder = 1,
            OldMenPopularGroupBuilder = 2,
            OldMenNotPopularGroupBuilder = 3,
            YoungGirlsGroupPopularBuilder = 4,
            YoungGirlsGroupNotPopularBuilder = 5,
            OldWomenPopularGroupBuilder = 6,
            OldWomenNotPopularGroupBuilder = 7,
            OtherGroup = 8
        }
    }
}
