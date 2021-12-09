namespace CameraShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string DateOfOrder { get; set; }
        public string DateOfDelivery { get; set; }
        public decimal DeliveryCharge { get; set; }
    }
}
