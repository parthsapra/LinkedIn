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

        public string CompanyName { get; set; }


        public string CompanyTagLine { get; set; }


        public string OverviewOfCompany { get; set; }


        public string CompanyWebsite { get; set; }


        public string CompanySize { get; set; }


        public string HeadquarterName { get; set; }


        public string SpecialityName { get; set; }


        public string CompanyAddress { get; set; }


        public string CityName { get; set; }


        public string StateName { get; set; }


        public string CountryName { get; set; }


        public string CompanyLogo { get; set; }


        public Nullable<System.DateTime> FoundDate { get; set; }

		#region CompanyId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CompanyId Annotations

        public int CompanyId { get; set; }


        public vCompanyDetail()
        {
        }
	}
}