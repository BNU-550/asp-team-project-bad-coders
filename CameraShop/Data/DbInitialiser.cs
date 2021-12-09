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
                    AddressId= 1,
                    HouseNumber= "1",
                    Postcode= "PE12 EPG"

                },
                new Address()
                {
                    AddressId = 2,
                    HouseNumber= "122",
                    Postcode= "AC1 3AB"

                },
                new Address()
                {
                    AddressId=3,
                    HouseNumber= "16",
                    Postcode= "EV86 6RE"
                },
                new Address()
                {
                    AddressId=4,
                    HouseNumber= "22",
                    Postcode= "NQ98 2TY"

                },
                new Address()
                {
                    AddressId= 5,
                    HouseNumber= "56",
                    Postcode= "MH46 9JG"

                },
                new Address()
                {
                    AddressId=6,
                    HouseNumber= "234",
                    Postcode= "SA74 6NE"

                },
                new Address()
                {
                    AddressId=7,
                    HouseNumber= "65",
                    Postcode= "YU76 2UK"

                },
                new Address()
                {
                    AddressId=8,
                    HouseNumber= "18",
                    Postcode= "AM17 8KM"

                },
                new Address()
                {
                    AddressId=9,
                    HouseNumber= "82",
                    Postcode= "KR19 AM1"

                },
                new Address()
                {
                    AddressId=10,
                    HouseNumber= "36",
                    Postcode= "G73 98N"

                }
                };

                foreach (Address a in addresses)
                {
                    context.Addresses.Add(a);
                }
                //context.SaveChanges();
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
                    CardID= 8108109342280184,
                    CardName= "B. Johnson",
                    ExpiryMonth= 12,
                    ExpiryYear= 23,
                    CvsNumber= 102
                },
                new PaymentCard()
                {
                    CardID = 7369204820760494,
                    CardName= "J. Bond",
                    ExpiryMonth= 07,
                    ExpiryYear= 24,
                    CvsNumber= 007
                },
                new PaymentCard()
                {
                    CardID= 4528898728967346,
                    CardName= "J Johnson",
                    ExpiryMonth= 01,
                    ExpiryYear= 22,
                    CvsNumber= 122
                },
                new PaymentCard()
                {
                    CardID= 8006414157735322,
                    CardName= "T Jones",
                    ExpiryMonth= 11,
                    ExpiryYear= 22,
                    CvsNumber= 088
                },
                new PaymentCard()
                {
                    CardID= 6200039714689144,
                    CardName= "P Peterson",
                    ExpiryMonth= 05,
                    ExpiryYear= 24,
                    CvsNumber= 503
                },
                new PaymentCard()
                {
                    CardID= 2975690378139100,
                    CardName= "S King",
                    ExpiryMonth= 07,
                    ExpiryYear= 22,
                    CvsNumber= 755
                },
                new PaymentCard()
                {
                    CardID= 2015616913792017,
                    CardName= "L Evans",
                    ExpiryMonth= 12,
                    ExpiryYear= 23,
                    CvsNumber= 123
                },
                new PaymentCard()
                {
                    CardID = 1700783439618400,
                    CardName= "J Jackson",
                    ExpiryMonth= 09,
                    ExpiryYear= 22,
                    CvsNumber= 911
                },
                new PaymentCard()
                {
                    CardID= 5952554349752715,
                    CardName= "T Cruise",
                    ExpiryMonth= 03,
                    ExpiryYear= 23,
                    CvsNumber= 203
                },
                new PaymentCard()
                {
                    CardID= 8804239747397707,
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
            //context.SaveChanges();
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
                    CustomerId= 101,
                    FirstName= "Boris",
                    LastName= "Johnson",
                    Email= "Bojo@gmail.com",
                    PhoneNumber= "09240104731"
                },
                new Customer()
                {
                    CustomerId= 102,
                    FirstName= "James",
                    LastName= "Bond",
                    Email= "Jabo@gmail.com",
                    PhoneNumber= "09460813136"
                },
                new Customer()
                {
                    CustomerId= 103,
                    FirstName= "John",
                    LastName= "Johnson",
                    Email= "Jojo@gmail.com",
                    PhoneNumber= "04500949815"
                },
                new Customer()
                {
                    CustomerId= 104,
                    FirstName= "Tom",
                    LastName= "Jones",
                    Email= "Tojo@gmail.com",
                    PhoneNumber= "07252016143 "
                },
                new Customer()
                {
                    CustomerId= 105,
                    FirstName= "Peter",
                    LastName= "Peterson",
                    Email= "Pepe@gmail.com",
                    PhoneNumber= "06014738258"
                },
                new Customer()
                {
                    CustomerId= 106,
                    FirstName= "Stephan",
                    LastName= "King",
                    Email= "Steking@gmail.com",
                    PhoneNumber= "03989731221"
                },
                new Customer()
                {
                    CustomerId= 107,
                    FirstName= "Lee",
                    LastName= "Evans",
                    Email= "Leev@gmail.com",
                    PhoneNumber= "04807897844"
                },
                new Customer()
                {
                    CustomerId= 108,
                    FirstName= "Jack",
                    LastName= "Jackson",
                    Email= "Jaja@gmail.com",
                    PhoneNumber= "02559749094"
                },
                new Customer()
                {
                    CustomerId= 109,
                    FirstName= "Tom",
                    LastName= "Cruise",
                    Email= "Tocru@gmail.com",
                    PhoneNumber= "06601940401"
                },
                new Customer()
                {
                    CustomerId= 110,
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
            //context.SaveChanges();
        }
    }
}

