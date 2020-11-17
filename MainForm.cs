using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Globalization;


namespace FaceApp
{
    public partial class MainForm : Form
    {
        private AppSettings m_AppSetting;
        private User m_LoggedInUser;
        private LoginResult m_logInResult;
        private utilsfeatureBestFriend m_UtilsFeatureBestFriend;
        private utilsfeatureLikeComment m_UtilsFeatureLikeComment;
        private static string newLine = Environment.NewLine;


        public MainForm()
        {
            this.StartPosition = FormStartPosition.Manual;
            InitializeComponent();
            m_AppSetting = AppSettings.LoadFromFile();
            this.Size = m_AppSetting.LastWindowsSize;
            this.Location = m_AppSetting.LastWindowLocation;
            this.checkBoxRememberUser.Checked = m_AppSetting.RememberUser;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_AppSetting.LastWindowsSize = this.Size;
            m_AppSetting.LastWindowLocation = this.Location;
            m_AppSetting.RememberUser = this.checkBoxRememberUser.Checked;
            if (m_AppSetting.RememberUser)
            {
                m_AppSetting.AccessToken = m_logInResult.AccessToken;
            }
            else
            {
                m_AppSetting.AccessToken = null;
            }
            m_AppSetting.SaveToFile();
        }
        protected override void OnShown(EventArgs e)
        {
            if (m_AppSetting.RememberUser &&
           !string.IsNullOrEmpty(m_AppSetting.AccessToken))
            {
                m_logInResult = FacebookService.Connect(m_AppSetting.AccessToken);
                PopulateUIFromFaceBookData();
            }
            base.OnShown(e);
        }

        private void loginAndInit()
        {
            m_logInResult = FacebookService.Login("1317912728372989",
                 "user_birthday",
                 "user_posts",
                 "user_friends",
                 "user_photos",
                 "user_likes");

            if (!string.IsNullOrEmpty(m_logInResult.AccessToken))
            {
                m_LoggedInUser = m_logInResult.LoggedInUser;
                PopulateUIFromFaceBookData();
            }
            else
            {
                MessageBox.Show(m_logInResult.ErrorMessage);
            }
        }

        private void PopulateUIFromFaceBookData()
        {
            this.Text = " Logged in as " + m_LoggedInUser.FirstName + " " + m_LoggedInUser.LastName;
            pictureBoxProfileUser.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
            buttonLikeCommentFeature.Visible = true;
            buttonBestFriendFeature.Visible = true;
            textBoxLikeCommentFriends.Visible = true;
            textBoxBestFriend.Visible = true;
            labelLikeComment.Visible = true;
        }

        private void buttonLikeCommentFeature_Click(object sender, EventArgs e)
        {
            m_UtilsFeatureLikeComment = new utilsfeatureLikeComment(m_LoggedInUser);
            textBoxBestFriend.Text = m_UtilsFeatureLikeComment.FeatureToText();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonBestFriendsFeature_Click(object sender, EventArgs e)
        {
            m_UtilsFeatureBestFriend = new utilsfeatureBestFriend(m_LoggedInUser);

            foreach (string FriendName in m_UtilsFeatureBestFriend.GetBestFriends())
            {
                textBoxBestFriend.Text += string.Format("{0}{1}", FriendName, newLine);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

