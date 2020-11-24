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
        public FoundSoulmateForm(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            this.m_Soulmate = Logic.FindFriendThatGaveMostLikes(m_LoggedInUser);
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
            soulmateNameLabel.Text = string.Format("{0} has given you the most likes from all your {1} friends", m_Soulmate.Name, m_Soulmate.Gender);
        }

      /*  public void addAllPostsToListBox()
        {
            List<Post> posts = Logic.FindFriendThatGaveMostLikes(m_LoggedInUser);
            foreach (Post post in posts)
            {
                listBox1.Items.Add(post.Message);
            }
        }


        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                listBox1.Items.Add(friend.Name);
            }
        }*/
    }
}
