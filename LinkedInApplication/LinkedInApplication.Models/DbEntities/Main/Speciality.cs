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
    [Table("Specialities",Schema="dbo")]
    public partial class Speciality
    {
		#region SpecialityId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion SpecialityId Annotations

        public int SpecialityId { get; set; }

		#region SpecialityName Annotations

        [Required]
        [MaxLength(50)]
		#endregion SpecialityName Annotations

        public string SpecialityName { get; set; }

		#region CompanyId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion CompanyId Annotations

        public int CompanyId { get; set; }


        public Speciality()
        {
        }
	}
}