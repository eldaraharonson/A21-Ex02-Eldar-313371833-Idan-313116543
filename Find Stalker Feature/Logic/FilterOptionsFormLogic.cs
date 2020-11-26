using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature
{
    public class FilterOptionsFormLogic
    {

        public static List<AgeRange> GetAgeRanges(CheckedListBox io_AgesCheckedListBox)
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

        public static List<string> GetGenders(CheckedListBox io_GendersCheckedListBox)
        {
            List<string> genders = GetCheckBoxListItems(io_GendersCheckedListBox);
            return genders;
        }

        public static bool CheckBoxesValidation(CheckedListBox checkedListBox)
        {
            return checkedListBox.CheckedItems.Count > 0;
        }


        public static List<string> GetCheckBoxListItems(CheckedListBox  checkedListBox)
        {
            List<string> checkedItems = new List<string>();
            foreach (string item in checkedListBox.CheckedItems)
            {
                checkedItems.Add(item);
            }
            return checkedItems;
        }
    }
}
