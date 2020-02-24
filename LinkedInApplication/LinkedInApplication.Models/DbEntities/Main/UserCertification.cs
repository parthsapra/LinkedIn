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
    [Table("UserCertifications",Schema="dbo")]
    public partial class UserCertification
    {
		#region UserCertificationId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion UserCertificationId Annotations

        public int UserCertificationId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region CertificateName Annotations

        [Required]
        [MaxLength(50)]
		#endregion CertificateName Annotations

        public string CertificateName { get; set; }

		#region IssuingOrganizationName Annotations

        [Required]
        [MaxLength(50)]
		#endregion IssuingOrganizationName Annotations

        public string IssuingOrganizationName { get; set; }

		#region IssueDate Annotations

        [Required]
		#endregion IssueDate Annotations

        public System.DateTime IssueDate { get; set; }


        public Nullable<System.DateTime> ExpirationDate { get; set; }

		#region CredentialId Annotations

        [Required]
        [MaxLength(50)]
		#endregion CredentialId Annotations

        public string CredentialId { get; set; }

		#region CredentialURL Annotations

        [MaxLength(50)]
		#endregion CredentialURL Annotations

        public string CredentialURL { get; set; }


        public UserCertification()
        {
        }
	}
}