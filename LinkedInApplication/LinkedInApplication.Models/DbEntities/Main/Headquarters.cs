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
        [RelationshipTableAttribue("Countries","dbo","","CountryId")]
		#endregion CountryId Annotations

        public int CountryId { get; set; }

		#region StateId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("States","dbo","","StateId")]
		#endregion StateId Annotations

        public int StateId { get; set; }

		#region CityId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Cities","dbo","","CityId")]
		#endregion CityId Annotations

        public int CityId { get; set; }

		#region CompanyId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Companies","dbo","","CompanyId")]
		#endregion CompanyId Annotations

        public int CompanyId { get; set; }


        public Nullable<System.DateTime> FoundDate { get; set; }

		#region City Annotations

        [ForeignKey(nameof(CityId))]
        [InverseProperty(nameof(LinkedInApplication.Models.Main.City.Headquarters))]
		#endregion City Annotations

        public virtual City City { get; set; }

		#region Company Annotations

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty(nameof(LinkedInApplication.Models.Main.Company.Headquarters))]
		#endregion Company Annotations

        public virtual Company Company { get; set; }

		#region Country Annotations

        [ForeignKey(nameof(CountryId))]
        [InverseProperty(nameof(LinkedInApplication.Models.Main.Country.Headquarters))]
		#endregion Country Annotations

        public virtual Country Country { get; set; }

		#region State Annotations

        [ForeignKey(nameof(StateId))]
        [InverseProperty(nameof(LinkedInApplication.Models.Main.State.Headquarters))]
		#endregion State Annotations

        public virtual State State { get; set; }


        public Headquarters()
        {
        }
	}
}