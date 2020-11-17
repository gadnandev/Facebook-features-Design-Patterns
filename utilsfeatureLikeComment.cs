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
    class utilsfeatureLikeComment
    {
        public User m_User { get; set; }
        private StringBuilder m_StringText;
        private static string sayThankYou = "Thanks for the good wishes :)!!!";
        private static string likedForYou = "Liked For You";
        private static string commentedForYou = "Commented For You";
        private static string newLine = Environment.NewLine;

        public utilsfeatureLikeComment(User i_User)
        {
            m_User = i_User;
            m_StringText = new StringBuilder();
            fetchDataPosts();
        }

        private void fetchDataPosts()
        {
            DateTime userLastBirthday = LastBirthday();

            foreach (Post post in m_User.Posts)
            {
                if (post.CreatedTime.Value.Date.Equals(userLastBirthday.Date))
                {
                    if (post.From != m_User)
                    {
                        if (!doIlikeThePost(post))
                        {
                            post.Like();
                            updateStringText(post.From.Name, likedForYou);
                        }

                        if (!doICommnetThePost(post))
                        {
                            post.Comment(sayThankYou);
                            updateStringText(post.From.Name, commentedForYou);
                        }
                    }
                }

            }
        }

        private void updateStringText(string i_FriendName, string i_LikeOrComment)
        {
            m_StringText.Append(string.Format("{0} ({1}){2}", i_FriendName, i_LikeOrComment, newLine));
        }

        public string FeatureToText()
        {
            return m_StringText.ToString();
        }

        private bool doICommnetThePost(Post i_post)
        {
            bool doIComment = false;

            foreach (PostedItem postedItem in i_post.Comments)
            {
                if (postedItem.From == m_User)
                {
                    doIComment = true;
                }
            }

            return doIComment;
        }

        private bool doIlikeThePost(Post i_post)
        {
            bool doIlike = false;

            foreach (User user in i_post.LikedBy)
            {
                if (user == m_User)
                {
                    doIlike = true;
                }
            }

            return doIlike;
        }

        private DateTime LastBirthday()
        {
            DateTime userBirthday = DateTime.ParseExact(m_User.Birthday,
                        "d",
                        CultureInfo.InvariantCulture);
            int age = DateTime.Now.Year - userBirthday.Year;

            if (userBirthday.Month > DateTime.Now.Month)
            {
                userBirthday = userBirthday.AddYears(age - 1);
            }
            else
            {
                if ((userBirthday.Month == DateTime.Now.Month)
                     && (userBirthday.Day > DateTime.Now.Day))
                {
                    userBirthday = userBirthday.AddYears(age - 1);
                }
                else
                {
                    userBirthday = userBirthday.AddYears(age);
                }
            }

            return userBirthday;
        }
    }
}
