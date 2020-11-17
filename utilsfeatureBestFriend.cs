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

    public class utilsfeatureBestFriend
    {
        private const int k_notFound = -1;
        private User m_User { get; set; }
        private List<UsersFriendsInfo> m_UsersFriends;

        public utilsfeatureBestFriend(User i_User)
        {
            m_User = i_User;
            fetchDataFriends();
            checkingPhotosUser();
        }

        private void fetchDataFriends()
        {
            m_UsersFriends = new List<UsersFriendsInfo>(m_User.Friends.Count);

            for (int i = 0; i < m_UsersFriends.Count; i++)
            {
                m_UsersFriends[i] = new UsersFriendsInfo(m_User.Friends[i].Name);
            }
        }

        private void checkingPhotosUser()
        {
            foreach (Album album in m_User.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    if (photo.Tags != null)
                    {
                        foreach (PhotoTag phototag in photo.Tags)
                        {
                            if (indexByName(phototag.User.Name) != k_notFound)
                            {
                                m_UsersFriends[indexByName(phototag.User.Name)].Counter++;
                            }
                        }
                    }
                }
            }
        }

        public List<string> GetBestFriends()
        {
            int index = 0;
            int amountOfBestFriends = AmountOfBestFriends();
            int maxTags = MaxTags();
            List<string> bestFriends = new List<string>(amountOfBestFriends);

            foreach (UsersFriendsInfo friend in m_UsersFriends)
            {
                if (friend.Counter == maxTags)
                {
                    bestFriends[index] = friend.Name;
                    index++;
                }
            }

            return bestFriends;
        }

        private int MaxTags()
        {
            int maxTags = 0;

            foreach (UsersFriendsInfo friend in m_UsersFriends)
            {
                if (friend.Counter > maxTags)
                {
                    maxTags = friend.Counter;
                }
            }

            return maxTags;
        }

        private int AmountOfBestFriends()
        {
            int maxTag = MaxTags();
            int amountOfBestFriends = 0;

            foreach (UsersFriendsInfo friend in m_UsersFriends)
            {
                if (friend.Counter == maxTag)
                {
                    amountOfBestFriends++;
                }
            }

            return amountOfBestFriends;
        }

        private int indexByName(string i_Name)
        {
            int index = k_notFound;

            for (int i = 0; i < m_UsersFriends.Count; i++)
            {
                if (m_UsersFriends[i].Name.Equals(i_Name))
                {
                    index = i;
                }
            }

            return index;
        }
    }
}
