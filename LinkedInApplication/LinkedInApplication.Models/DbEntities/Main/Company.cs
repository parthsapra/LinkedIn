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
    [Table("Companies",Schema="dbo")]
    public partial class Company
    {
		#region CompanyId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CompanyId Annotations

        public int CompanyId { get; set; }

		#region CompanyName Annotations

        [Required]
        [MaxLength(50)]
		#endregion CompanyName Annotations

        public string CompanyName { get; set; }

		#region LinkedInPublicURL Annotations

        [Required]
        [MaxLength(50)]
		#endregion LinkedInPublicURL Annotations

        public string LinkedInPublicURL { get; set; }

		#region CompanyWebsite Annotations

        [Required]
        [MaxLength(50)]
		#endregion CompanyWebsite Annotations

        public string CompanyWebsite { get; set; }

		#region CompanyIndustry Annotations

        [Required]
        [MaxLength(50)]
		#endregion CompanyIndustry Annotations

        public string CompanyIndustry { get; set; }

		#region CompanySize Annotations

        [MaxLength(50)]
		#endregion CompanySize Annotations

        public string CompanySize { get; set; }

		#region CompanyType Annotations

        [MaxLength(50)]
		#endregion CompanyType Annotations

        public string CompanyType { get; set; }

		#region Headquarters Annotations

        [InverseProperty("Company")]
		#endregion Headquarters Annotations

        public virtual ICollection<Headquarters> Headquarters { get; set; }

		#region CompanyDetails Annotations

        [InverseProperty("Company")]
		#endregion CompanyDetails Annotations

        public virtual ICollection<CompanyDetail> CompanyDetails { get; set; }

		#region Jobs Annotations

        [InverseProperty("Company")]
		#endregion Jobs Annotations

        public virtual ICollection<Job> Jobs { get; set; }


        public Company()
        {
			Headquarters = new HashSet<Headquarters>();
			CompanyDetails = new HashSet<CompanyDetail>();
			Jobs = new HashSet<Job>();
        }
	}
}