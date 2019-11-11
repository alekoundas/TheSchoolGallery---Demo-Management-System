using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Front.Models.reCAPTCHA
{
    public class Recaptcha
    {
        public bool success { get; set; }
        public DateTime challenge_ts { get; set; }
        public string hostname { get; set; }
    }
}