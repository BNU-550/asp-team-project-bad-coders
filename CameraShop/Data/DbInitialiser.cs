using CameraShop.Models;
using System.Linq;

namespace CameraShop.Data
{
    public static class DbInitialiser
    {
        /// <summary>
        /// TODO: 
        /// 
        /// </summary>
        /// <param name="context"></param>
        public static void Initialise(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            AddAddresses(context);
            AddPaymentCards(context);
            AddCustomers(context);
            AddCameras(context);
        }

        public static void AddCameras(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Cameras.Any())
            {
                return;   // DB has been seeded
            }

            var cameras = new Camera[]
            {
                new Camera()
                {

                    CameraId = 1,
                    Make = "PE12 EPG",
                    Model = "12",
                    CameraType = "1",
                    Summary = "1",
                    Description = "1",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 1,
                    CarouselNumber = 1,
                    Discount = 1
                },

                new Camera()
                {

                    CameraId = 2,
                    Make = "PE12 EPG",
                    Model = "12",
                    CameraType = "1",
                    Summary = "1",
                    Description = "1",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 1,
                    CarouselNumber = 1,
                    Discount = 1
                },

                new Camera()
                {

                    CameraId = 3,
                    Make = "PE12 EPG",
                    Model = "12",
                    CameraType = "1",
                    Summary = "1",
                    Description = "1",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 1,
                    CarouselNumber = 1,
                    Discount = 1
                },

                new Camera()
                {

                    CameraId = 4,
                    Make = "PE12 EPG",
                    Model = "12",
                    CameraType = "1",
                    Summary = "1",
                    Description = "1",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 1,
                    CarouselNumber = 1,
                    Discount = 1
                },

                new Camera()
                {

                    CameraId = 5,
                    Make = "PE12 EPG",
                    Model = "12",
                    CameraType = "1",
                    Summary = "1",
                    Description = "1",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 1,
                    CarouselNumber = 1,
                    Discount = 1
                },

                new Camera()
                {

                    CameraId = 6,
                    Make = "PE12 EPG",
                    Model = "12",
                    CameraType = "1",
                    Summary = "1",
                    Description = "1",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 1,
                    CarouselNumber = 1,
                    Discount = 1
                },

                new Camera()
                {

                    CameraId = 7,
                    Make = "PE12 EPG",
                    Model = "12",
                    CameraType = "1",
                    Summary = "1",
                    Description = "1",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 1,
                    CarouselNumber = 1,
                    Discount = 1
                },

                new Camera()
                {

                    CameraId = 8,
                    Make = "PE12 EPG",
                    Model = "12",
                    CameraType = "1",
                    Summary = "1",
                    Description = "1",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 1,
                    CarouselNumber = 1,
                    Discount = 1
                },

                new Camera()
                {

                    CameraId = 9,
                    Make = "PE12 EPG",
                    Model = "12",
                    CameraType = "1",
                    Summary = "1",
                    Description = "1",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 1,
                    CarouselNumber = 1,
                    Discount = 1
                },

                new Camera()
                {

                    CameraId = 10,
                    Make = "PE12 EPG",
                    Model = "12",
                    CameraType = "1",
                    Summary = "1",
                    Description = "1",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 1,
                    CarouselNumber = 1,
                    Discount = 1
                },
            };

            foreach (Camera c in cameras)
            {
                context.Cameras.Add(c);
            }
            context.SaveChanges();
        }



        public static void AddAddresses(ApplicationDbContext context)
        {
                // Look for any students.
                if (context.Addresses.Any())
                {
                    return;   // DB has been seeded
                }

                var addresses = new Address[]
                {
                new Address()
                {
                    
                    HouseNumber= "1",
                    Postcode= "PE12 EPG"

                },
                new Address()
                {
                    
                    HouseNumber= "122",
                    Postcode= "AC1 3AB"

                },
                new Address()
                {
                    
                    HouseNumber= "16",
                    Postcode= "EV86 6RE"
                },
                new Address()
                {
                    
                    HouseNumber= "22",
                    Postcode= "NQ98 2TY"

                },
                new Address()
                {
                    
                    HouseNumber= "56",
                    Postcode= "MH46 9JG"

                },
                new Address()
                {
                    
                    HouseNumber= "234",
                    Postcode= "SA74 6NE"

                },
                new Address()
                {
                    
                    HouseNumber= "65",
                    Postcode= "YU76 2UK"

                },
                new Address()
                {
                    
                    HouseNumber= "18",
                    Postcode= "AM17 8KM"

                },
                new Address()
                {
                    
                    HouseNumber= "82",
                    Postcode= "KR19 AM1"

                },
                new Address()
                {
                    
                    HouseNumber= "36",
                    Postcode= "G73 98N"

                }
                };

                foreach (Address a in addresses)
                {
                    context.Addresses.Add(a);
                }
                context.SaveChanges();
        }

        public static void AddPaymentCards(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.PaymentCards.Any())
            {
                return;   // DB has been seeded
            }

            var paymentCards = new PaymentCard[]
            {
                new PaymentCard()
                {
                    PaymentCardID= 8108109342280184,
                    CardName= "B. Johnson",
                    ExpiryMonth= 12,
                    ExpiryYear= 23,
                    CvsNumber= 102
                },
                new PaymentCard()
                {
                    PaymentCardID = 7369204820760494,
                    CardName= "J. Bond",
                    ExpiryMonth= 07,
                    ExpiryYear= 24,
                    CvsNumber= 007
                },
                new PaymentCard()
                {
                    PaymentCardID= 4528898728967346,
                    CardName= "J Johnson",
                    ExpiryMonth= 01,
                    ExpiryYear= 22,
                    CvsNumber= 122
                },
                new PaymentCard()
                {
                    PaymentCardID= 8006414157735322,
                    CardName= "T Jones",
                    ExpiryMonth= 11,
                    ExpiryYear= 22,
                    CvsNumber= 088
                },
                new PaymentCard()
                {
                    PaymentCardID= 6200039714689144,
                    CardName= "P Peterson",
                    ExpiryMonth= 05,
                    ExpiryYear= 24,
                    CvsNumber= 503
                },
                new PaymentCard()
                {
                    PaymentCardID= 2975690378139100,
                    CardName= "S King",
                    ExpiryMonth= 07,
                    ExpiryYear= 22,
                    CvsNumber= 755
                },
                new PaymentCard()
                {
                    PaymentCardID= 2015616913792017,
                    CardName= "L Evans",
                    ExpiryMonth= 12,
                    ExpiryYear= 23,
                    CvsNumber= 123
                },
                new PaymentCard()
                {
                    PaymentCardID = 1700783439618400,
                    CardName= "J Jackson",
                    ExpiryMonth= 09,
                    ExpiryYear= 22,
                    CvsNumber= 911
                },
                new PaymentCard()
                {
                    PaymentCardID= 5952554349752715,
                    CardName= "T Cruise",
                    ExpiryMonth= 03,
                    ExpiryYear= 23,
                    CvsNumber= 203
                },
                new PaymentCard()
                {
                    PaymentCardID= 8804239747397707,
                    CardName= "T Thompson",
                    ExpiryMonth= 12,
                    ExpiryYear= 22,
                    CvsNumber= 504
                },

            };

            foreach (PaymentCard p in paymentCards)
            {
                context.PaymentCards.Add(p);
            }
            context.SaveChanges();
        }

        public static void AddCustomers(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
                new Customer()
                {
                    AddressID= 1,
                    PaymentCardID= 8108109342280184,
                    FirstName= "Boris",
                    LastName= "Johnson",
                    Email= "Bojo@gmail.com",
                    PhoneNumber= "09240104731"
                },
                new Customer()
                {
                    AddressID= 2,
                    PaymentCardID= 7369204820760494,
                    FirstName= "James",
                    LastName= "Bond",
                    Email= "Jabo@gmail.com",
                    PhoneNumber= "09460813136"
                },
                new Customer()
                {
                    AddressID= 3,
                    PaymentCardID= 4528898728967346,
                    FirstName= "John",
                    LastName= "Johnson",
                    Email= "Jojo@gmail.com",
                    PhoneNumber= "04500949815"
                },
                new Customer()
                {
                    AddressID= 4,
                    PaymentCardID= 8006414157735322,
                    FirstName= "Tom",
                    LastName= "Jones",
                    Email= "Tojo@gmail.com",
                    PhoneNumber= "07252016143 "
                },
                new Customer()
                {
                    AddressID= 5,
                    PaymentCardID= 6200039714689144,
                    FirstName= "Peter",
                    LastName= "Peterson",
                    Email= "Pepe@gmail.com",
                    PhoneNumber= "06014738258"
                },
                new Customer()
                {
                    AddressID= 6,
                    PaymentCardID= 2975690378139100,
                    FirstName= "Stephan",
                    LastName= "King",
                    Email= "Steking@gmail.com",
                    PhoneNumber= "03989731221"
                },
                new Customer()
                {
                    AddressID= 7,
                    PaymentCardID= 2015616913792017,
                    FirstName= "Lee",
                    LastName= "Evans",
                    Email= "Leev@gmail.com",
                    PhoneNumber= "04807897844"
                },
                new Customer()
                {
                    AddressID= 8,
                    PaymentCardID= 1700783439618400,
                    FirstName= "Jack",
                    LastName= "Jackson",
                    Email= "Jaja@gmail.com",
                    PhoneNumber= "02559749094"
                },
                new Customer()
                {
                    AddressID= 9,
                    PaymentCardID= 5952554349752715,
                    FirstName= "Tom",
                    LastName= "Cruise",
                    Email= "Tocru@gmail.com",
                    PhoneNumber= "06601940401"
                },
                new Customer()
                {
                    AddressID= 10,
                    PaymentCardID= 8804239747397707,
                    FirstName= "Tony",
                    LastName= "Thompson",
                    Email= "ToThom@gmail.com",
                    PhoneNumber= "07973472148"
                },

            };

            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();
        }
    }
}

