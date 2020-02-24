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
    [Table("UserDetails",Schema="dbo")]
    public partial class UserDetail
    {
		#region UserDetailId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion UserDetailId Annotations

        public int UserDetailId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region Gender Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion Gender Annotations

        public int Gender { get; set; }


        public string ProfilePhoto { get; set; }


        public Nullable<System.DateTime> BirthDate { get; set; }


        public Nullable<int> ConnectionCount { get; set; }


        public Nullable<int> CityId { get; set; }


        public Nullable<int> StateId { get; set; }


        public Nullable<int> CountryId { get; set; }

		#region Headline Annotations

        [MaxLength(50)]
		#endregion Headline Annotations

        public string Headline { get; set; }


        public UserDetail()
        {
        }
	}
}