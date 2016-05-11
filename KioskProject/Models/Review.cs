using System;
using System.ComponentModel.DataAnnotations;

namespace KioskProject.Models
{
    public class Review
    {
        public virtual int Id { get; set; }
        public virtual Kiosk Kiosk { get; set; }
        [Range(1,10)]
        public virtual int Rating { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public virtual string Body { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public virtual DateTime ReviewDate { get; set; }
    }
}