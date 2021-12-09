using System.ComponentModel.DataAnnotations;


namespace CameraShop.Models
{
    public class Camera
    {
        public int CameraId { get; set; } 

        [Required, StringLength(50)]
        public string Make { get; set; }

        [Required, StringLength(50)]
        public string Model { get; set; }

        [Required, StringLength(50)]
        public string CameraType { get; set; }

        [Required,StringLength(500)]
        public string summary { get; set; }

        [Required,StringLength(1000)]
        public string Description { get; set; }

        public string Image { get; set; }

        public string VideoUrl { get; set; }
        [Required]
        public decimal CurrentPrice { get; set; }
        
        public int CarouselNumber { get; set; }

        public int Discount { get; set; }

        public virtual Review Review { get; set; }


        
    }
}
