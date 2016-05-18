using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CakeProject.Models
{
    public class ReviewModel
    {
        [Required(ErrorMessage = "Id is a required field."), DisplayName("Id")]
        public int ReviewId { get; set; }

        [Required(ErrorMessage = "Name is a required field.")]
        [MaxLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Summary is a required field.")]
        [MaxLength(1000, ErrorMessage = "Summary cannot be longer than 1000 characters.")]
        public string Summary { get; set; }

        [Required(ErrorMessage = "Ingredients is a required field.")]
        [MaxLength(4000, ErrorMessage = "Ingredients cannot be longer than 4000 characters.")]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "Instructions is a required field.")]
        [MaxLength(4000, ErrorMessage = "Instructions cannot be longer than 4000 characters.")]
        public string Instructions { get; set; }

        [Required(ErrorMessage = "Cooking Time is a required field.")]
        [Range(1, 180, ErrorMessage = "Cooking Time must be a value between 1 and 180 (minutes).")]
        [DisplayName("Cooking Time")]
        public int CookingTime { get; set; }
    }
}