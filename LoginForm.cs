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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        User m_LoggedInUser;
        LoginResult m_LoginResult;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (m_LoginResult == null)
            {
                string appID = "281360223294764";
                this.m_LoginResult = FacebookService.Login(appID,
                    "public_profile",
                        "email",
                        "publish_to_groups",
                        "user_birthday",
                        "user_age_range",
                        "user_gender",
                        "user_link",
                        "user_tagged_places",
                        "user_videos",
                        "publish_to_groups",
                        "groups_access_member_info",
                        "user_friends",
                        "user_events",
                        "user_likes",
                        "user_location",
                        "user_photos",
                        "user_posts",
                        "user_hometown");
                this.m_LoggedInUser = m_LoginResult.LoggedInUser;
                WelcomeForm welcomeForm = new WelcomeForm(this.m_LoginResult);
                this.Hide();
                welcomeForm.ShowDialog();
            }

            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage);
            }
        }
    }
}
