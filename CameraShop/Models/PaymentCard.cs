using System.ComponentModel.DataAnnotations;

namespace CameraShop.Models
{
    public class PaymentCard
    {

        public long CardID { get; set; }
        
        [Required, StringLength(20)]
        public string CardName { get; set; }

        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
        public int CvsNumber { get; set; }
    }
}
