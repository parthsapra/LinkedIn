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
    [Table("UserSkills",Schema="dbo")]
    public partial class UserSkill
    {
		#region UserSkillId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion UserSkillId Annotations

        public int UserSkillId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region UserSkillName Annotations

        [Required]
        [MaxLength(50)]
		#endregion UserSkillName Annotations

        public string UserSkillName { get; set; }


        public UserSkill()
        {
        }
	}
}