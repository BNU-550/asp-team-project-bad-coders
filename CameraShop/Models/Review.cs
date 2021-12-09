using System.ComponentModel.DataAnnotations;

namespace CameraShop.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public virtual Camera CameraID { get; set; } 
        
        [Required, StringLength(500)]
        public string Summary { get; set; }

        public int ReviewSource { get; set; }

        public int Rating { get; set; }
    }
}
