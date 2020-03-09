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
    [Table("Countries",Schema="dbo")]
    public partial class Country
    {
		#region CountryId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CountryId Annotations

        public int CountryId { get; set; }

		#region CountryName Annotations

        [Required]
        [MaxLength(50)]
		#endregion CountryName Annotations

        public string CountryName { get; set; }

		#region States Annotations

        [InverseProperty("Country")]
		#endregion States Annotations

        public virtual ICollection<State> States { get; set; }

		#region Headquarters Annotations

        [InverseProperty("Country")]
		#endregion Headquarters Annotations

        public virtual ICollection<Headquarters> Headquarters { get; set; }

		#region CompanyDetails Annotations

        [InverseProperty("Country")]
		#endregion CompanyDetails Annotations

        public virtual ICollection<CompanyDetail> CompanyDetails { get; set; }

		#region UserDetails Annotations

        [InverseProperty("Country")]
		#endregion UserDetails Annotations

        public virtual ICollection<UserDetail> UserDetails { get; set; }


        public Country()
        {
			States = new HashSet<State>();
			Headquarters = new HashSet<Headquarters>();
			CompanyDetails = new HashSet<CompanyDetail>();
			UserDetails = new HashSet<UserDetail>();
        }
	}
}