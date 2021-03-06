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
    [Table("Designations",Schema="dbo")]
    public partial class Designation
    {
		#region DesignationId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion DesignationId Annotations

        public int DesignationId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("LinkedInUsers","dbo","","UserId")]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region DesignationName Annotations

        [Required]
        [MaxLength(50)]
		#endregion DesignationName Annotations

        public string DesignationName { get; set; }

		#region StartMonthYear Annotations

        [Required]
		#endregion StartMonthYear Annotations

        public System.DateTime StartMonthYear { get; set; }

		#region EndMonthYear Annotations

        [Required]
		#endregion EndMonthYear Annotations

        public System.DateTime EndMonthYear { get; set; }

		#region LinkedInUser Annotations

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(LinkedInApplication.Models.Main.LinkedInUser.Designations))]
		#endregion LinkedInUser Annotations

        public virtual LinkedInUser LinkedInUser { get; set; }


        public Designation()
        {
        }
	}
}