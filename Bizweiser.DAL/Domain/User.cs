using System;
using System.Web;
using System.ComponentModel;

using System.Collections.Generic;

namespace Bizweiser.DAL
{
    public class User
    {
        private int _id;
        private string _username;
        private string _password;
        private string _securityQuestion;
        private string _securityAnswer;
        //private Partner _partner;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public string SecurityQuestion
        {
            get
            {
                return _securityQuestion;
            }
            set
            {
                _securityQuestion = value;
            }
        }
        public string SecurityAnswer
        {
            get
            {
                return _securityAnswer;
            }
            set
            {
               _securityAnswer=value;
            }
        }
        //public Partner Partner
        //{
        //    get
        //    {
        //        return _partner;
        //    }
        //    set
        //    {
        //        _partner = value;
        //    }
        //}
    }
}
