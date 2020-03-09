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

		#region LIRegistrationDate Annotations

        [Required]
		#endregion LIRegistrationDate Annotations

        public System.DateTimeOffset LIRegistrationDate { get; set; }

		#region LIEmailId Annotations

        [MaxLength(50)]
		#endregion LIEmailId Annotations

        public string LIEmailId { get; set; }

		#region LIMobileNumber Annotations

        [MaxLength(12)]
		#endregion LIMobileNumber Annotations

        public string LIMobileNumber { get; set; }


        public Nullable<bool> IsActive { get; set; }

		#region Password Annotations

        [Required]
        [MaxLength(50)]
		#endregion Password Annotations

        public byte[] Password { get; set; }

		#region Salt Annotations

        [MaxLength(140)]
		#endregion Salt Annotations

        public byte[] Salt { get; set; }

		#region Documents Annotations

        [InverseProperty("LinkedInUser")]
		#endregion Documents Annotations

        public virtual ICollection<Document> Documents { get; set; }

		#region Posts Annotations

        [InverseProperty("LinkedInUser")]
		#endregion Posts Annotations

        public virtual ICollection<Post> Posts { get; set; }

		#region UserExperienceDetails Annotations

        [InverseProperty("LinkedInUser")]
		#endregion UserExperienceDetails Annotations

        public virtual ICollection<UserExperienceDetail> UserExperienceDetails { get; set; }

		#region Designations Annotations

        [InverseProperty("LinkedInUser")]
		#endregion Designations Annotations

        public virtual ICollection<Designation> Designations { get; set; }

		#region UserCertifications Annotations

        [InverseProperty("LinkedInUser")]
		#endregion UserCertifications Annotations

        public virtual ICollection<UserCertification> UserCertifications { get; set; }

		#region UserDetails Annotations

        [InverseProperty("LinkedInUser")]
		#endregion UserDetails Annotations

        public virtual ICollection<UserDetail> UserDetails { get; set; }

		#region UserEducationDetails Annotations

        [InverseProperty("LinkedInUser")]
		#endregion UserEducationDetails Annotations

        public virtual ICollection<UserEducationDetail> UserEducationDetails { get; set; }


        public LinkedInUser()
        {
			Documents = new HashSet<Document>();
			Posts = new HashSet<Post>();
			UserExperienceDetails = new HashSet<UserExperienceDetail>();
			Designations = new HashSet<Designation>();
			UserCertifications = new HashSet<UserCertification>();
			UserDetails = new HashSet<UserDetail>();
			UserEducationDetails = new HashSet<UserEducationDetail>();
        }
	}
}