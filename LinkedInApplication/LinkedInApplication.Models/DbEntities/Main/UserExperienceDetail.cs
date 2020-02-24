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
    [Table("UserExperienceDetails",Schema="dbo")]
    public partial class UserExperienceDetail
    {
		#region UserExperienceDetailId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion UserExperienceDetailId Annotations

        public int UserExperienceDetailId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region IndustryName Annotations

        [MaxLength(50)]
		#endregion IndustryName Annotations

        public string IndustryName { get; set; }

		#region DesignationId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion DesignationId Annotations

        public int DesignationId { get; set; }

		#region EmploymentType Annotations

        [Required]
        [MaxLength(50)]
		#endregion EmploymentType Annotations

        public string EmploymentType { get; set; }

		#region CompanyName Annotations

        [Required]
        [MaxLength(50)]
		#endregion CompanyName Annotations

        public string CompanyName { get; set; }

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

		#region StartDate Annotations

        [Required]
		#endregion StartDate Annotations

        public System.DateTime StartDate { get; set; }


        public Nullable<System.DateTime> EndDate { get; set; }


        public string Description { get; set; }


        public UserExperienceDetail()
        {
        }
	}
}