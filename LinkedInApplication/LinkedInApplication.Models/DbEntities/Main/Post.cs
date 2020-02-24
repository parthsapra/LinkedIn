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
    [Table("Posts",Schema="dbo")]
    public partial class Post
    {
		#region PostId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostId Annotations

        public int PostId { get; set; }

		#region PostText Annotations

        [MaxLength(50)]
		#endregion PostText Annotations

        public string PostText { get; set; }

		#region PostMediaTypeId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion PostMediaTypeId Annotations

        public int PostMediaTypeId { get; set; }


        public string PostMediaURL { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region PostCreationDateTime Annotations

        [Required]
		#endregion PostCreationDateTime Annotations

        public System.DateTimeOffset PostCreationDateTime { get; set; }


        public Nullable<System.DateTimeOffset> PostUpdateDateTime { get; set; }


        public Post()
        {
        }
	}
}