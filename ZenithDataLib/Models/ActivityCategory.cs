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

        [Required]
        [Display(Name = "Activity ")]
        public String ActivityDescription { get; set; }


        [Required]
        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; }

        public List<Event> Events { get; set; }

    }
}