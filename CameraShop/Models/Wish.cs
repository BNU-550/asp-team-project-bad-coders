namespace CameraShop.Models
{
    public class Wish
    {
        public virtual Customer CustomerID { get; set; }
        public virtual Camera CameraID { get; set; }  
    }
}
