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
        [RelationshipTableAttribue("LinkedInUsers","dbo","","UserId")]
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

		#region CityId Annotations

        [RelationshipTableAttribue("Cities","dbo","","CityId")]
		#endregion CityId Annotations

        public Nullable<int> CityId { get; set; }

		#region StateId Annotations

        [RelationshipTableAttribue("States","dbo","","StateId")]
		#endregion StateId Annotations

        public Nullable<int> StateId { get; set; }

		#region CountryId Annotations

        [RelationshipTableAttribue("Countries","dbo","","CountryId")]
		#endregion CountryId Annotations

        public Nullable<int> CountryId { get; set; }

		#region Headline Annotations

        [MaxLength(50)]
		#endregion Headline Annotations

        public string Headline { get; set; }

		#region City Annotations

        [ForeignKey(nameof(CityId))]
        [InverseProperty(nameof(LinkedInApplication.Models.Main.City.UserDetails))]
		#endregion City Annotations

        public virtual City City { get; set; }

		#region Country Annotations

        [ForeignKey(nameof(CountryId))]
        [InverseProperty(nameof(LinkedInApplication.Models.Main.Country.UserDetails))]
		#endregion Country Annotations

        public virtual Country Country { get; set; }

		#region LinkedInUser Annotations

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(LinkedInApplication.Models.Main.LinkedInUser.UserDetails))]
		#endregion LinkedInUser Annotations

        public virtual LinkedInUser LinkedInUser { get; set; }

		#region State Annotations

        [ForeignKey(nameof(StateId))]
        [InverseProperty(nameof(LinkedInApplication.Models.Main.State.UserDetails))]
		#endregion State Annotations

        public virtual State State { get; set; }


        public UserDetail()
        {
        }
	}
}