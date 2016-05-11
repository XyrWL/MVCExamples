using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarReviewProject.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public double Length { get; set; }
        public List<Review> Reviews { get; set; }
    }
}