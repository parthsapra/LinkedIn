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
    [Table("Jobs",Schema="dbo")]
    public partial class Job
    {
		#region JobId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion JobId Annotations

        public int JobId { get; set; }

		#region CompanyId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion CompanyId Annotations

        public int CompanyId { get; set; }

		#region JobTitle Annotations

        [Required]
        [MaxLength(50)]
		#endregion JobTitle Annotations

        public string JobTitle { get; set; }

		#region Designation Annotations

        [Required]
        [MaxLength(50)]
		#endregion Designation Annotations

        public string Designation { get; set; }

		#region Profille Annotations

        [Required]
        [MaxLength(50)]
		#endregion Profille Annotations

        public string Profille { get; set; }


        public Nullable<int> Experience { get; set; }

		#region Description Annotations

        [Required]
		#endregion Description Annotations

        public string Description { get; set; }

		#region JobLocationCityId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion JobLocationCityId Annotations

        public int JobLocationCityId { get; set; }

		#region JobLocationStateId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion JobLocationStateId Annotations

        public int JobLocationStateId { get; set; }

		#region Skills Annotations

        [Required]
		#endregion Skills Annotations

        public string Skills { get; set; }


        public Nullable<System.DateTime> JobCreateDate { get; set; }


        public Job()
        {
        }
	}
}