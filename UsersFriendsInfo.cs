using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceApp
{
    public class UsersFriendsInfo
    {
        public string Name { get; }
        public int Counter { get; set; }

        public UsersFriendsInfo(string i_Name)
        {
            Name = i_Name;
            Counter = 0;
        }
    }
}
