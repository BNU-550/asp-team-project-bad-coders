namespace CameraShop.Models
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public int OrderItemCameraID { get; set; }
        public decimal SalePrice { get; set; }
    }
}
