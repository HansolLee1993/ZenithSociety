using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZenithSociety.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public DateTime EventFromDate { get; set; }
        public DateTime EventToDate { get; set; }
        public String EnteredUserName { get; set; }

        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }

        //FK
        public int ActivityCategoryId { get; set; }
        public ActivityCategory ActivityCategory { get; set; }

    }
}