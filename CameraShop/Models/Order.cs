using System.ComponentModel.DataAnnotations;

namespace CameraShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required, StringLength(10)]
        public string DateOfOrder { get; set; }
        [StringLength(10)]
        public string DateOfDelivery { get; set; }
        public decimal DeliveryCharge { get; set; }
    }
}
