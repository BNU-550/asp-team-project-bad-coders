namespace CameraShop.Models
{
    public class Camera
    {
        public int CameraId { get; set; }    
        public string Make { get; set; }
        public string Model { get; set; }
        public string CameraType { get; set; }
        public string summary { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string VideoUrl { get; set; }
        public decimal CurrentPrice { get; set; }
        public int CarouselNumber { get; set; }
        public int Discount { get; set; }

        public virtual Review Review { get; set; }


        
    }
}
