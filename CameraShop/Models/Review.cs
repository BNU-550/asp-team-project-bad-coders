namespace CameraShop.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public virtual Camera Camera { get; set; }  
        public string Summary { get; set; }
        public int ReviewSource { get; set; }
        public int Rating { get; set; }
    }
}
