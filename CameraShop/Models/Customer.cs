using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CameraShop.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int AddressID { get; set; }

        public long PaymentCardID { get; set; }

        [Required, StringLength(20), Display(Name ="First Name")]
        public string FirstName { get; set; }
        
        [Required, StringLength(20), Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required, StringLength(255),]
        public string Email { get; set; } 
        
        [Required,StringLength(20)]
        public string PhoneNumber { get; set; }

        //Navigation Property
        public virtual Address Address { get; set; }
        public virtual PaymentCard PaymentCard { get; set; }

    }
}
