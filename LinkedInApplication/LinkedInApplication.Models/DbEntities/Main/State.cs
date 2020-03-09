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
    [Table("States",Schema="dbo")]
    public partial class State
    {
		#region StateId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion StateId Annotations

        public int StateId { get; set; }

		#region StateName Annotations

        [Required]
        [MaxLength(50)]
		#endregion StateName Annotations

        public string StateName { get; set; }

		#region CountryId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Countries","dbo","","CountryId")]
		#endregion CountryId Annotations

        public int CountryId { get; set; }

		#region Country Annotations

        [ForeignKey(nameof(CountryId))]
        [InverseProperty(nameof(LinkedInApplication.Models.Main.Country.States))]
		#endregion Country Annotations

        public virtual Country Country { get; set; }

		#region Cities Annotations

        [InverseProperty("State")]
		#endregion Cities Annotations

        public virtual ICollection<City> Cities { get; set; }

		#region Headquarters Annotations

        [InverseProperty("State")]
		#endregion Headquarters Annotations

        public virtual ICollection<Headquarters> Headquarters { get; set; }

		#region CompanyDetails Annotations

        [InverseProperty("State")]
		#endregion CompanyDetails Annotations

        public virtual ICollection<CompanyDetail> CompanyDetails { get; set; }

		#region UserDetails Annotations

        [InverseProperty("State")]
		#endregion UserDetails Annotations

        public virtual ICollection<UserDetail> UserDetails { get; set; }


        public State()
        {
			Cities = new HashSet<City>();
			Headquarters = new HashSet<Headquarters>();
			CompanyDetails = new HashSet<CompanyDetail>();
			UserDetails = new HashSet<UserDetail>();
        }
	}
}