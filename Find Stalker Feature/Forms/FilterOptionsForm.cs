using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature.Forms;

namespace B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature.Forms
{
    public partial class FilterOptionsForm : Form
    {
        public User m_LoggedInUser;
        public FilterOptionsForm(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (!FilterOptionsFormLogic.CheckBoxesValidation(preferredGenderCheckList) || !FilterOptionsFormLogic.CheckBoxesValidation(preferredAgesCheckList))
            {
                MessageBox.Show("You must check at least one item from each checkbox list");
                return;
            }
            // sends checklist box of age ranges and gets a list of the ranges
            List<AgeRange> preferredAgeRanges = FilterOptionsFormLogic.GetAgeRanges(preferredAgesCheckList);
            List<string> preferredGenders = FilterOptionsFormLogic.GetGenders(preferredGenderCheckList);
            FoundSoulmateForm foundSoulmateForm = new FoundSoulmateForm(m_LoggedInUser, preferredGenders, preferredAgeRanges);
            this.Hide();
            foundSoulmateForm.ShowDialog();




        }
    }
}
