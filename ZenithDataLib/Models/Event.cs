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

        [DataType(DataType.DateTime)]
        [Display(Name = "Start Date Time")]
        [Required(ErrorMessage = "Start date is requred (Ex 2017-09-09 3:15:00 AM)")]
        public DateTime EventFromDate { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "End Date Time")]
        [Required(ErrorMessage = "End date is requred (Ex 2017-09-09 3:15:00 AM)")]
        public DateTime EventToDate { get; set; }


        private string _Username = "";
        [Display(Name = "Entered By")]
        public string EnteredUserName
        {
            get { return _Username; }
            set { _Username = value; }
        }

        private DateTime _CreationDate = DateTime.Now;
        [DataType(DataType.Date)]
        [Display(Name = "Creation Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:F}")]
        public DateTime CreationDate { get { return _CreationDate; } set { _CreationDate = value; } }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        //FK
        public int ActivityCategoryId { get; set; }
        public ActivityCategory ActivityCategory { get; set; }

    }
}