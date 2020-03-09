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
    [Table("Documents",Schema="dbo")]
    public partial class Document
    {
		#region DocumentId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion DocumentId Annotations

        public int DocumentId { get; set; }

		#region DocumentUrl Annotations

        [Required]
        [MaxLength(50)]
		#endregion DocumentUrl Annotations

        public string DocumentUrl { get; set; }

		#region UploadDateTime Annotations

        [Required]
		#endregion UploadDateTime Annotations

        public System.DateTimeOffset UploadDateTime { get; set; }

		#region LIUserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("LinkedInUsers","dbo","","LIUserId")]
		#endregion LIUserId Annotations

        public int LIUserId { get; set; }

		#region LinkedInUser Annotations

        [ForeignKey(nameof(LIUserId))]
        [InverseProperty(nameof(LinkedInApplication.Models.Main.LinkedInUser.Documents))]
		#endregion LinkedInUser Annotations

        public virtual LinkedInUser LinkedInUser { get; set; }


        public Document()
        {
        }
	}
}