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
            string appID = "281360223294764";
            this.m_LoginResult = FacebookService.Login(appID, "user_gender", "user_photos", "email");
            this.m_LoggedInUser = m_LoginResult.LoggedInUser;
            WelcomeForm welcomeForm = new WelcomeForm(this.m_LoginResult);
            this.Hide();
            welcomeForm.ShowDialog();
        }
    }
}
