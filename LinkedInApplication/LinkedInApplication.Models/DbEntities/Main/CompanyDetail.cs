using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using LinkedInApplication.Models.Enums.Main;
using LinkedInApplication.BoundedContext.SqlContext;
namespace LinkedInApplication.Models.Main
{
    [Table("CompanyDetails",Schema="dbo")]
    public partial class CompanyDetail
    {
		#region CompanyDetailId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CompanyDetailId Annotations

        public int CompanyDetailId { get; set; }

		#region CompanyId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion CompanyId Annotations

        public int CompanyId { get; set; }

		#region CompanyLogo Annotations

        [MaxLength(50)]
		#endregion CompanyLogo Annotations

        public string CompanyLogo { get; set; }

		#region CompanyTagLine Annotations

        [MaxLength(100)]
		#endregion CompanyTagLine Annotations

        public string CompanyTagLine { get; set; }

		#region CompanyAddress Annotations

        [Required]
        [MaxLength(100)]
		#endregion CompanyAddress Annotations

        public string CompanyAddress { get; set; }

		#region CountryId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion CountryId Annotations

        public int CountryId { get; set; }

		#region StateId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion StateId Annotations

        public int StateId { get; set; }

		#region CityId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion CityId Annotations

        public int CityId { get; set; }


        public Nullable<System.DateTime> FoundDate { get; set; }


        public string OverviewOfCompany { get; set; }


        public CompanyDetail()
        {
        }
	}
}