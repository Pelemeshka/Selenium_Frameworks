using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Homework_5.business_object
{
    class User
    {
        public string userName { get; set; }
        public string userPassword { get; set; }
        public User (string userName, string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
        }
    }
}
