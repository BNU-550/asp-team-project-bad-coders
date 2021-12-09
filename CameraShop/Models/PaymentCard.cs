namespace CameraShop.Models
{
    public class PaymentCard
    {

        public int CardID { get; set; }
        public string CardName { get; set; }

        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
        public int CvsNumber { get; set; }
    }
}
