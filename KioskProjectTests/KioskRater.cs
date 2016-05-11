using System.Linq;
using KioskProject.Models;

namespace KioskProjectTests
{
    internal class KioskRater
    {
        private Kiosk _kiosk;

        public KioskRater(Kiosk kiosk)
        {
            this._kiosk = kiosk;
        }

        public RateResult ComputeOverallRate(int numberOfRatingsToUse)
            => new RateResult { Rating = (int)_kiosk.Reviews.Average(r => r.Rating) };

        public RateResult ComputeWeightedRate(int numberOfRatingsToUse)
        {
            var reviews = _kiosk.Reviews.ToList();
            var counter = 0;
            var total = 0;
            for (int i = 0; i < reviews.Count; i++)
            {
                if (i < reviews.Count / 2)
                {
                    counter += 2;
                    total += reviews[i].Rating * 2;
                }
                else
                {
                    counter++;
                    total += reviews[i].Rating;
                }
            }
            return new RateResult { Rating = total / counter }; ;
        }
    }
}