using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZenithSociety.Models
{
    public class ActivityCategory
    {
        [Key]
        public int ActivityCategoryId { get; set; }
        public String ActivityDescription { get; set; }
        public DateTime CreationDate { get; set; }

        public List<Event> events { get; set; }

    }
}