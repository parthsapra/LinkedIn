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


        public Country()
        {
        }
	}
}