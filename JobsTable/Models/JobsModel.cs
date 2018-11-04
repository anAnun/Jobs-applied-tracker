using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobsTable.Models
{
    public class JobsModel
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string DateApplied { get; set; }
        public string Website { get; set; }
        public string FollowUp { get; set; }
    }
}