using System.Collections.Generic;

namespace LinkedInApplication.Models
{
    public class SecurityConfig
    {
        public string[] AllowedHosts { get; set; }

        public string[] AllowedIps { get; set; }
    }
}

