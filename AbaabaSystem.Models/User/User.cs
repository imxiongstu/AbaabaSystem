using System;
using System.Collections.Generic;
using System.Text;

namespace AbaabaSystem.Models
{
    public class User
    {
        public int UserID { get; set; }
        public int UserTypeID { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public string Email { get; set; }
        public string Signature { get; set; }
        public string Gender { get; set; }
        public string HeadImage { get; set; }
        public DateTime Birthday { get; set; }
        public int[] Favorites { get; set; }
        public int[] Follower { get; set; }
        public int[] Follow { get; set; }
        public string Tel { get; set; }
    }
}
