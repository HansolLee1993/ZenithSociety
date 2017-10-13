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


        [Display(Name = "Activity Description")]
        [Required(ErrorMessage = "Please Enter Activity Description")]
        public String ActivityDescription { get; set; }


        private DateTime _CreationDate = DateTime.Now;
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:F}")]
        //[HiddenInput(DisplayValue = true)]
        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get { return _CreationDate; } set { _CreationDate = value; } }


        public List<Event> Events { get; set; }

    }
}