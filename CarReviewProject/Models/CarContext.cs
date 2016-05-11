using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarReviewProject.Models
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public CarContext() : base("CarReviews")
        {
            Database.SetInitializer<CarContext>(new CarInitializer());
        }
    }

    public class CarInitializer : DropCreateDatabaseAlways<CarContext>
    {
        protected override void Seed(CarContext context)
        {
            var cars = new List<Car>
            {
                new Car {CarId = 1, Brand = "Volvo", Color = "Red", Weight = 1700, Length = 4.6, RegistrationNumber = "ABC 123"},
                new Car {CarId = 2, Brand = "Audi", Color = "Silver", Weight = 1950, Length = 4.5, RegistrationNumber = "DEF 456"},
                new Car {CarId = 3, Brand = "Tesla", Color = "White", Weight = 1600, Length = 4.4, RegistrationNumber = "GHI 789"}
            };
            foreach (var car in cars)
                context.Cars.Add(car);

            var reviews = new List<Review>
            {
                new Review {ReviewId = 1, Name = "Top Gear", ReviewText = "Sturdy and reliable!", Stars = 4},
                new Review {ReviewId = 2, Name = "Autocar", ReviewText = "Fast and comfortable!", Stars = 4},
                new Review {ReviewId = 3, Name = "The Telegraph", ReviewText = "Awesome!", Stars = 5}
            };
            foreach (var review in reviews)
                context.Reviews.Add(review);

            context.SaveChanges();
        }
    }
}