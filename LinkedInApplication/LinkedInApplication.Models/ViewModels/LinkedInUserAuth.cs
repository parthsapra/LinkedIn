using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedInApplication.Models.ViewModels
{
   public class LInkedInUserAuth
    {
        public string LIFirstName { get;set;}
        public string LILastName { get;set;}
        public DateTimeOffset LIRegistrationDate { get;set;}
        public string LIEmailId { get;set;}
        public string LIMobileNumber  { get;set;}
        public bool IsActive { get;set;}
        public string Password { get;set;}
    }
}
