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
		#endregion StateId Annotations

        public int StateId { get; set; }

		#region CityName Annotations

        [Required]
        [MaxLength(50)]
		#endregion CityName Annotations

        public string CityName { get; set; }


        public City()
        {
        }
	}
}