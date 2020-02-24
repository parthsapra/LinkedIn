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


        public string CompanyWebsite { get; set; }


        public string CompanyIndustry { get; set; }


        public string CompanySize { get; set; }


        public string CompanyType { get; set; }


        public string CompanyLogo { get; set; }


        public string CompanyTagLine { get; set; }


        public string CompanyAddress { get; set; }


        public Nullable<System.DateTime> FoundDate { get; set; }


        public string OverviewOfCompany { get; set; }


        public string SpecialityName { get; set; }


        public string CountryName { get; set; }


        public string HeadquarterName { get; set; }


        public string CityName { get; set; }


        public string StateName { get; set; }


        public string Expr1 { get; set; }

		#region CityId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CityId Annotations

        public int CityId { get; set; }


        public vCompanyDetail()
        {
        }
	}
}