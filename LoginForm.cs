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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string appID = "281360223294764";
            LoginResult result = FacebookService.Login(appID, "user_photos", "user_likes", "email");
            m_LoggedInUser = result.LoggedInUser;
        }
    }
}
