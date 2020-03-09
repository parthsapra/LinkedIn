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
    [Table("Cities",Schema="dbo")]
    public partial class City
    {
		#region CityId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CityId Annotations

        public int CityId { get; set; }

		#region StateId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("States","dbo","","StateId")]
		#endregion StateId Annotations

        public int StateId { get; set; }

		#region CityName Annotations

        [Required]
        [MaxLength(50)]
		#endregion CityName Annotations

        public string CityName { get; set; }

		#region State Annotations

        [ForeignKey(nameof(StateId))]
        [InverseProperty(nameof(LinkedInApplication.Models.Main.State.Cities))]
		#endregion State Annotations

        public virtual State State { get; set; }

		#region Headquarters Annotations

        [InverseProperty("City")]
		#endregion Headquarters Annotations

        public virtual ICollection<Headquarters> Headquarters { get; set; }

		#region CompanyDetails Annotations

        [InverseProperty("City")]
		#endregion CompanyDetails Annotations

        public virtual ICollection<CompanyDetail> CompanyDetails { get; set; }

		#region UserDetails Annotations

        [InverseProperty("City")]
		#endregion UserDetails Annotations

        public virtual ICollection<UserDetail> UserDetails { get; set; }


        public City()
        {
			Headquarters = new HashSet<Headquarters>();
			CompanyDetails = new HashSet<CompanyDetail>();
			UserDetails = new HashSet<UserDetail>();
        }
	}
}