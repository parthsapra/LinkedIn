using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using LinkedInApplication.BoundedContext.SqlContext;
namespace LinkedInApplication.Models.Main
{
    [Table("vCountry",Schema="dbo")]
    public partial class vCountry
    {
		#region CountryId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CountryId Annotations

        public int CountryId { get; set; }


        public string CountryName { get; set; }


        public vCountry()
        {
        }
	}
}