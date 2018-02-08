using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ComposeDetails
    {

        string to;
        string sub;
        string msg;

        public string TO
        {
            get
            {
                return to;
            }
            set
            {
                to = value;
            }
        
    }

        public string SUB
        {
            get
            {
                return sub;
            }
            set
            {
                sub = value;
            }
        }

        public string MSG
        {
            get
            {
                return msg;
            }
            set
            {
                msg = value;
            }
        }
    }
}