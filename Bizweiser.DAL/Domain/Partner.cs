using System;
using System.Web;

using System.ComponentModel;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

 namespace Bizweiser.DAL
{
    public class Partner
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _address1;
        private string _address2;
        private string _education;
        private string _email;
        private string _phone;
        private string _mobile;
        private short _gender;
        private string _nationality;
        private User _user;
        private User _userId;

        //[Key, ForeignKey("Users")]
        //protected User UserId
        //{
        //    get { return _userId; }
        //    set { _userId = value; }
        //}
        protected int ID
        {
            get
            {
                return _id; ;
            }
            set
            {
                _id = value;
            }
        }
        protected string First_Name
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        protected string Last_Name
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        protected short Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }
        protected string Nationality
        {
            get
            {
                return _nationality;
            }
            set
            {
                _nationality = value;
            }
        }
        protected string Address1
        {
            get
            {
                return _address1;
            }
            set
            {
                _address1 = value;
            }
        }
        protected string Address2
        {
            get
            {
                return _address2;
            }
            set
            {
                _address2 = value;
            }
        }
        protected string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        protected string Mobile
        {
            get
            {
                return _mobile;

            }
            set
            {
                _mobile = value;
            }
        }
        protected string Email
        {
            get
            {
                return _email;

            }
            set
            {
                _email = value;
            }
        }
        public string Education
        {
            get
            {
                return _education;
            }
            set
            {
                _education = value;
            }
        }
        //protected User User
        //{
        //    get
        //    {
        //        return _user;
        //    }
        //    set
        //    {
        //        _user = value;
        //    }
        //}

    }
}
