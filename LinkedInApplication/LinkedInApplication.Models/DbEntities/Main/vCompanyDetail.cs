using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using LinkedInApplication.BoundedContext.SqlContext;
namespace LinkedInApplication.Models.Main
{
    [Table("vCompanyDetails",Schema="dbo")]
    public partial class vCompanyDetail
    {

        public string CityName { get; set; }


        public string StateName { get; set; }


        public string CompanyName { get; set; }


        public string CompanyWebsite { get; set; }


        public string SpecialityName { get; set; }


        public string CountryName { get; set; }


        public string HeadquarterName { get; set; }


        public string CompanyLogo { get; set; }


        public string CompanyTagLine { get; set; }


        public vCompanyDetail()
        {
        }
	}
}