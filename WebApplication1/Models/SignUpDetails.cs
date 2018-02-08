using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SignUpDetails
    {


        public static string firstname;
        public static string lastname;
        public static string email;
        public static string password;
        public static string country;
        public static string dob;
        public static string gender;
        public static int phone;
        public static string inboxtbl;
        public static string senttbl;
        public static string drafttable;
        public string FIRSTNAME
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }


        public string DRAFTTABLE
        {
            get
            {
                return drafttable;
            }
            set
            {
                drafttable = value;
            }
        }



        public string LASTNAME
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public string EMAIL
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string PASSWORD
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string COUNTRY
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }
        public string GENDER
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public int PHONE
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public string INBOXTBL
        {
            get
            {
                return inboxtbl;
            }
            set
            {
                inboxtbl = value;
            }
        }
        public string SENTTBL
        {
            get
            {
                return senttbl;
            }
            set
            {
                senttbl = value;
            }
        }





    }
}