using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaramelProject.Models
{
    public class CaramelDetailsModel
    {
        public string Name { get; set; }
        public string[] Ingredients { get; set; }
        public NutritionalInformation NutritionalInformation { get; set; }

        public CaramelDetailsModel()
        {
            NutritionalInformation = new NutritionalInformation
            {
                Calories = 103,
                Protein = 0.62,
                Lipids = 0.04,
                Carbohydrates = 27.02,
                Fiber = 0.4,
                Cholesterol = 0.0
            };
        }
    }


    public class NutritionalInformation
    {
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Lipids { get; set; }
        public double Carbohydrates { get; set; }
        public double Fiber { get; set; }
        public double Cholesterol { get; set; }
    }
}