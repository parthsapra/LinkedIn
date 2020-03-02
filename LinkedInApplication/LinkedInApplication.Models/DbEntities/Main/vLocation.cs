using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using LinkedInApplication.BoundedContext.SqlContext;
namespace LinkedInApplication.Models.Main
{
    [Table("vLocations",Schema="dbo")]
    public partial class vLocation
    {

        public string CityName { get; set; }


        public string StateName { get; set; }


        public string CountryName { get; set; }

		#region CityId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CityId Annotations

        public int CityId { get; set; }


        public vLocation()
        {
        }
	}
}