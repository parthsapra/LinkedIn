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
    [Table("LinkedInUsers",Schema="dbo")]
    public partial class LinkedInUser
    {
		#region LIUserId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion LIUserId Annotations

        public int LIUserId { get; set; }

		#region LIFirstName Annotations

        [Required]
        [MaxLength(50)]
		#endregion LIFirstName Annotations

        public string LIFirstName { get; set; }

		#region LILastName Annotations

        [Required]
        [MaxLength(50)]
		#endregion LILastName Annotations

        public string LILastName { get; set; }


        public Nullable<System.DateTime> LIRegistrationDate { get; set; }

		#region LIEmailId Annotations

        [MaxLength(50)]
		#endregion LIEmailId Annotations

        public string LIEmailId { get; set; }

		#region LIMobileNumber Annotations

        [MaxLength(12)]
		#endregion LIMobileNumber Annotations

        public string LIMobileNumber { get; set; }


        public Nullable<bool> IsActive { get; set; }

		#region LIPassword Annotations

        [MaxLength(50)]
		#endregion LIPassword Annotations

        public byte[] LIPassword { get; set; }

		#region LISalt Annotations

        [MaxLength(50)]
		#endregion LISalt Annotations

        public byte[] LISalt { get; set; }

		#region UserSkills Annotations

        [InverseProperty("LinkedInUser")]
		#endregion UserSkills Annotations

        public virtual ICollection<UserSkill> UserSkills { get; set; }

		#region UserExperienceDetails Annotations

        [InverseProperty("LinkedInUser")]
		#endregion UserExperienceDetails Annotations

        public virtual ICollection<UserExperienceDetail> UserExperienceDetails { get; set; }

		#region UserEducationDetails Annotations

        [InverseProperty("LinkedInUser")]
		#endregion UserEducationDetails Annotations

        public virtual ICollection<UserEducationDetail> UserEducationDetails { get; set; }

		#region Posts Annotations

        [InverseProperty("LinkedInUser")]
		#endregion Posts Annotations

        public virtual ICollection<Post> Posts { get; set; }

		#region UserCertifications Annotations

        [InverseProperty("LinkedInUser")]
		#endregion UserCertifications Annotations

        public virtual ICollection<UserCertification> UserCertifications { get; set; }

		#region Designations Annotations

        [InverseProperty("LinkedInUser")]
		#endregion Designations Annotations

        public virtual ICollection<Designation> Designations { get; set; }

		#region UserDetails Annotations

        [InverseProperty("LinkedInUser")]
		#endregion UserDetails Annotations

        public virtual ICollection<UserDetail> UserDetails { get; set; }


        public LinkedInUser()
        {
			UserSkills = new HashSet<UserSkill>();
			UserExperienceDetails = new HashSet<UserExperienceDetail>();
			UserEducationDetails = new HashSet<UserEducationDetail>();
			Posts = new HashSet<Post>();
			UserCertifications = new HashSet<UserCertification>();
			Designations = new HashSet<Designation>();
			UserDetails = new HashSet<UserDetail>();
        }
	}
}