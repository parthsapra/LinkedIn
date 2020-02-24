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
    [Table("UserEducationDetails",Schema="dbo")]
    public partial class UserEducationDetail
    {
		#region UserEducationDetailId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion UserEducationDetailId Annotations

        public int UserEducationDetailId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region SchoolName Annotations

        [Required]
        [MaxLength(50)]
		#endregion SchoolName Annotations

        public string SchoolName { get; set; }

		#region DegreeName Annotations

        [Required]
        [MaxLength(50)]
		#endregion DegreeName Annotations

        public string DegreeName { get; set; }

		#region FieldofStudy Annotations

        [Required]
        [MaxLength(50)]
		#endregion FieldofStudy Annotations

        public string FieldofStudy { get; set; }

		#region StartYear Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion StartYear Annotations

        public int StartYear { get; set; }


        public Nullable<int> EndYear { get; set; }

		#region Grade Annotations

        [MaxLength(50)]
		#endregion Grade Annotations

        public string Grade { get; set; }


        public string Activities { get; set; }


        public string Description { get; set; }


        public UserEducationDetail()
        {
        }
	}
}