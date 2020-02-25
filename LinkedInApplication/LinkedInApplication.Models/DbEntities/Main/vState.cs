using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using LinkedInApplication.BoundedContext.SqlContext;
namespace LinkedInApplication.Models.Main
{
    [Table("vState",Schema="dbo")]
    public partial class vState
    {
		#region StateId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion StateId Annotations

        public int StateId { get; set; }


        public string StateName { get; set; }


        public vState()
        {
        }
	}
}