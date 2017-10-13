using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZenithSociety.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required]
        [Display(Name= "Event From Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime EventFromDate { get; set; }

        [Required]
        [Display(Name = "Event to Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime EventToDate { get; set; }

        [Required]
        [Display(Name = "Enter User Name")]
        public String EnteredUserName { get; set; }

        [Required]
        [Display(Name = "Creation Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; }


        public bool IsActive { get; set; }

        //FK
        public int ActivityCategoryId { get; set; }
        public ActivityCategory ActivityCategory { get; set; }

    }
}