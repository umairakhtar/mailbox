using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Login1
    {



        string username;
        string password;

        public string USERNAME
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
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




    }
}