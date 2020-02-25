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
		#endregion CountryId Annotations

        public int CountryId { get; set; }


        public State()
        {
        }
	}
}