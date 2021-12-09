using System.ComponentModel.DataAnnotations;

namespace CameraShop.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        [Required, StringLength(10)]
        public string HouseNumber { get; set; }
        [Required, StringLength(10)]
        public string Postcode { get; set; }

    }
}
