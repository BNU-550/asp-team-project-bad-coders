using System.ComponentModel.DataAnnotations;

namespace CameraShop.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int AddressID { get; set; }

        [Required, StringLength(20), Display(Name ="First Name")]
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        public string Email { get; set; }  
        public string PhoneNumber { get; set; }
        //Navigation Property
        public virtual Address Address { get; set; }

    }
}
