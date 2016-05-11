namespace CarReviewProject.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Name { get; set; }
        public int Stars { get; set; }
        public string ReviewText { get; set; }
    }
}