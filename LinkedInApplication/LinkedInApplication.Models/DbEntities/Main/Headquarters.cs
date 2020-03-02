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
    [Table("Headquarters",Schema="dbo")]
    public partial class Headquarters
    {
		#region HeadquarterId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion HeadquarterId Annotations

        public int HeadquarterId { get; set; }

		#region HeadquarterName Annotations

        [Required]
        [MaxLength(50)]
		#endregion HeadquarterName Annotations

        public string HeadquarterName { get; set; }

		#region CountryId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion CountryId Annotations

        public int CountryId { get; set; }

		#region StateId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion StateId Annotations

        public int StateId { get; set; }

		#region CityId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion CityId Annotations

        public int CityId { get; set; }

		#region CompanyId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion CompanyId Annotations

        public int CompanyId { get; set; }


        public Nullable<System.DateTime> FoundDate { get; set; }


        public Headquarters()
        {
        }
	}
}