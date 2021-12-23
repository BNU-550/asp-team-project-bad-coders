using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CameraShop.Models
{
    public class PaymentCard
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PaymentCardID { get; set; }
        
        [Required, StringLength(20)]
        public string CardName { get; set; }

        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
        public int CvsNumber { get; set; }
    }
}
