using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobsTable.Models
{
    public class JobsCreateModel
    {
        [Required]
        [MaxLength(50)]
        public string Company { get; set; }

        [MaxLength(150)]
        public string Position { get; set; }

        [MaxLength(50)]
        public string DateApplied { get; set; }

        [MaxLength(50)]
        public string Website { get; set; }

        [MaxLength(50)]
        public string FollowUp { get; set; }
    }
}