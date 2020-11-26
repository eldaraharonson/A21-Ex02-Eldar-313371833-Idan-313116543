using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature;
using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature.Forms;
using FacebookWrapper;
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

namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    public partial class WelcomeForm : Form
    {
        LoginResult m_LoginResult;
        User m_LoggedInUser;
        public WelcomeForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            this.m_LoginResult = i_LoginResult;
            this.m_LoggedInUser = i_LoginResult.LoggedInUser;
            DisplayWelcomeMessage();
        }

        public void DisplayWelcomeMessage()
        {
            this.Text = string.Format("Logged in as {0} {1}", this.m_LoggedInUser.FirstName, this.m_LoggedInUser.LastName);
            userProfilePicture.ImageLocation = this.m_LoggedInUser.PictureNormalURL;
        }

        private void findStalkerButton_Click(object sender, EventArgs e)
        {
            // User soulmate = Logic.FindFriendThatGaveMostLikes(this.m_LoggedInUser);
            //FoundSoulmateForm foundSoulmateForm = new FoundSoulmateForm(m_LoggedInUser);
            this.Hide();
            FilterOptionsForm filterOptionsForm = new FilterOptionsForm(m_LoggedInUser);
            filterOptionsForm.ShowDialog();
            //foundSoulmateForm.ShowDialog();
        }
    }
}
