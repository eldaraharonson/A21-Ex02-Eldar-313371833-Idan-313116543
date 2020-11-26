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
        public WelcomeForm.FormName m_FormName;
        public List<AgeRange> m_PreferredAgeRanges;
        public List<string> m_PreferredGenders;
        public Group m_Group;

        public FilterOptionsForm(User i_LoggedInUser, Group i_Group, WelcomeForm.FormName i_FormName)
        {
            m_Group = i_Group;
            m_FormName = i_FormName;
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            switch (m_FormName)
            {
                case WelcomeForm.FormName.findStalker:
                    {
                        if (!hasChosenParameters())
                        {
                            return;
                        }

                        FoundSoulmateForm foundSoulmateForm = new FoundSoulmateForm(m_LoggedInUser, m_PreferredGenders, m_PreferredAgeRanges);
                        this.Hide();
                        foundSoulmateForm.ShowDialog();
                        break;
                    }

                case WelcomeForm.FormName.groupPopularity:
                    {
                        if (!hasChosenParameters())
                        {
                            return;
                        }

                        GroupPopularityForm groupPopularityForm = new GroupPopularityForm(m_Group, m_PreferredGenders, m_PreferredAgeRanges);
                        this.Hide();
                        groupPopularityForm.ShowDialog();
                        break;
                    }

                default:
                    break;
            }
        }

        private bool hasChosenParameters()
        {
            bool isValid = true;
            if (!FilterOptionsFormLogic.CheckBoxesValidation(preferredGenderCheckList) || !FilterOptionsFormLogic.CheckBoxesValidation(preferredAgesCheckList))
            {
                MessageBox.Show("You must check at least one item from each checkbox list");
                isValid = false;
            }

            m_PreferredAgeRanges = FilterOptionsFormLogic.GetAgeRanges(preferredAgesCheckList);
            m_PreferredGenders = FilterOptionsFormLogic.GetGenders(preferredGenderCheckList);
            return isValid;
        }
    }
}
