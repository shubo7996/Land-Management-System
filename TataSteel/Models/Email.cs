using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TataSteel.Models
{
    public class Email
    {
        public string Receiver
        {
            get;
            set;
        }
        
        public string Subject
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }

    }
}
