using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedInApplication.Models.ViewModels
{
    public class LinkedInUserAuth
    {
        
        public string LIFirstName { get; set; }
        public string LILastName { get; set; }
        public DateTime LIRegistrationDate { get; set; }
        public string LIEmailId { get; set; }
        public string LIMobileNumber { get; set; }
        public string LIPassword { get; set; }        
        public bool IsActive { get; set; }
    }
}
