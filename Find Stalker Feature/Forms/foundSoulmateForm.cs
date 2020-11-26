using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature.Forms
{
    public partial class FoundSoulmateForm : Form
    {
        User m_Soulmate;
        User m_LoggedInUser;
        List<string> m_PreferredGenders;
        List<AgeRange> m_PreferredAges;
        public FoundSoulmateForm(User i_LoggedInUser, List<string> i_PreferredGenders, List<AgeRange> i_PreferredAges)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_PreferredGenders = i_PreferredGenders;
            m_PreferredAges = i_PreferredAges;
            m_Soulmate = FoundSoulmateFormLogic.FindFriendThatGaveMostLikes(m_LoggedInUser, m_PreferredGenders, m_PreferredAges);
            InitializeComponent();
            loadUItoForm();
        }

        private void loadUItoForm()
        {
            // Since the app can't access the user's friends I put the user as the soulmate
            if (m_Soulmate == null)
            {
                m_Soulmate = m_LoggedInUser;
            }
            soulmateProfilePicture.ImageLocation = m_Soulmate.PictureNormalURL;
            soulmateNameLabel.Text = string.Format("{0} has given you the most likes!!", m_Soulmate.Name);
        }
    }
}
