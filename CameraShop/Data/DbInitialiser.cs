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
                    Make = "Sony",
                    Model = "a7 IV Mirrorless Camera Body",
                    CameraType = "Mirrorless",
                    Summary = "New 33MP Exmor R back-illuminated sensor, Bionz XR processing power, New 3 inch variangle touchscreen, Shoot 4K 60p video",
                    Description = "The Sony a7 IV full-frame mirrorless camera merges outstanding 33 megapixel image quality, 4K 60p video recording, refined handling and fast sharing abilities making it the perfect hybrid camera. With top of the line real-time autofocus in photo and video, the a7 IV gives the power of Sony’s best technology into the hands of creators and professionals:",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 2399,
                    CarouselNumber = 8,
                    Discount = 30
                },

                new Camera()
                {

                    CameraId = 2,
                    Make = "Fujifilm",
                    Model = "Fujifilm X-T30 II",
                    CameraType = "Mirrorless",
                    Summary = "26.1MP X-Trans CMOS 4 sensor,High speed X-Processor 4 processing engine,4K/30P and full-HD/240P video, High definition 1.62-million-dot LCD monitor,Upgraded AUTO shooting mode",
                    Description = "The Fujifilm X-T30 II is a compact and lightweight (only 378g) mirrorless camera body featuring a 26.1MP X-Trans CMOS 4 sensor and high-speed X-Processor 4 image processing engine for super-fast AF performance and image quality equivalent to the X-T4. The X-T30 II upgrades from the previous model (X-T30) with a new high-resolution 1.62-million-dot LCD monitor and updated AUTO shooting mode.",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 769,
                    CarouselNumber = 3,
                    Discount = 15
                },

                new Camera()
                {

                    CameraId = 3,
                    Make = "Nikon",
                    Model = "Nikon Coolpix P1000",
                    CameraType = "Compact",
                    Summary = "125x optical zoom, 16 megapixel CMOS sensor, 4k video, vari-angle TFT LCD, Wifi and Bluetooth",
                    Description = "The Nikon P1000 features an incredible 125x optical zoom which is a focal length range of 24-3000mm (35mm equivalent). You can zoom even further with 250x Dynamic Fine digital zoom, which gives you an equivalent focal length of 6000mm. To help keep your images sharp using this extreme zoom range, the P1000 includes Nikon's Dual Detect Optical Vibration Reduction, which provides 5 stops of optical image stabilisation.",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 899,
                    CarouselNumber = 10,
                    Discount = 30
                },

                new Camera()
                {

                    CameraId = 4,
                    Make = "Canon",
                    Model = "Canon EOS 90D",
                    CameraType = "DSLR",
                    Summary = "32.5 megapixel APS-C CMOS sensor,4K video and Dual Pixel CMOS AF,Intelligent optical viewfinder,45 cross type AF points with multi-controller,Vari-Angle touchscreen",
                    Description = "The Canon EOS 90D is a compact & stylish DSLR featuring a high-resolution 32.5MP APS-C CMOS sensor for superb image quality This updated sensor design gives you enhanced image clarity and dynamic range, along with sensitivity to ISO 25600 and low noise. Combined with the DIGIC 8 image processor, the sensor powers UHD 4K30p and Full HD 120p video, as well as supporting continuous still image shooting rates up to 10fps. The 45-point all cross-type AF system gives fast AF performance in a range of lighting conditions for tracking moving subjects and working in low light. When shooting in Live View mode, or when capturing video, Canon’s Dual Pixel CMOS AF system delivers superb sharpness and wide-area coverage, plus low light performance. A vari-angle touchscreen LCD is included for intuitive control along with an optical pentaprism viewfinder. Built-in Wi-Fi and Bluetooth connectivity lets you pair your devices with the 90D and easily share your images and movies online.",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 1629,
                    CarouselNumber = 9,
                    Discount = 25
                },

                new Camera()
                {

                    CameraId = 5,
                    Make = "Nikon",
                    Model = "D5600",
                    CameraType = "DSLR",
                    Summary = "24.2 megapixels,Lightweight and tough construction,Vari-angle touchscreen,Low-pass filter removed,SnapBridge connectivity",
                    Description = "The Nikon D5600 is a tough and versatile DSLR camera and a great upgrade or investment for beginner photographers.Featuring a 24.2-megapixel DX sensor and fast 39-point autofocus the D5600 is suitable for a range of photographic pursuits such as landscape photography, portraits, wildlife photography and action. The D5600 can be used to produce detailed high-resolution stills even in challenging lighting conditions, thanks to its native ISO sensitivity range of ISO 100-25600",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 619,
                    CarouselNumber = 5,
                    Discount = 10
                },

                new Camera()
                {

                    CameraId = 6,
                    Make = "Sony",
                    Model = "A6000",
                    CameraType = "Mirrorless",
                    Summary = "Great value mirrorless camera,24.3-megapixel APS-C sensor, World's fastest AF,Wi-Fi/NFC functions, OLED Tru-Finder",
                    Description = "The Sony Alpha a6000 is a great entry-level camera to get you started in creative photography. Features include a 24.3-megapixel sensor with the world's fastest AF (0.06 sec) for cameras of this class. Also included is super-fast 11 fps shooting, DSLR-style operation, a high resolution OLED Tru-Finder and Wi-Fi/NFC connectivity. We love this camera because it gives you creative control in a compact sized body.",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 499,
                    CarouselNumber = 4,
                    Discount = 40
                },

                new Camera()
                {

                    CameraId = 7,
                    Make = "Nikon",
                    Model = "D780",
                    CameraType = "DSLR",
                    Summary = "24.5 MP full frame CMOS sensor,Expeed 6 image processor,Up to 12 fps in Silent Live View Photography mode,51-point Phase-Detection AF system,Full frame 4K movies",
                    Description = "The Nikon D780 is a high-performance full-frame DSLR aimed at both creative photographers and videographers. The tough D780 features a 24.5 MP full-frame CMOS sensor, EXPEED 6 image processor and the same 180K-pixel RGB sensor & Advanced Scene Recognition system as the D850. Also featured is a fast, dedicated Hybrid-AF system for Live View shooting and a fast, powerful 51-point Phase-Detection AF system for viewfinder shooting. When shooting in Live View, photographers and movie makers benefit from the same AF system as found in the Nikon Z 6 mirrorless camera. Users can lock onto expressions with Eye-Detection AF and take advantage of low-light AF, which powers reliable subject acquisition all the way down to -6 EV. Photographers shooting through the viewfinder benefit from flagship tracking performance, and quick switching between advanced AF modes.",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 1999,
                    CarouselNumber = 6,
                    Discount = 40
                },

                new Camera()
                {

                    CameraId = 8,
                    Make = "Fujifilm",
                    Model = "X-T200",
                    CameraType = "Mirrorless",
                    Summary = "24.2MP APS-C CMOS image sensor,4K 30p video recording,Large 3.5-inch vari-angle LCD touchscreen,Continuous shooting up to 8fps,Electronic Stabilisation and HDR Video modes",
                    Description = "The Fujifilm X-T200 in dark silver is a stylish, compact & lightweight (only 370g) mirrorless camera aimed at photographers who want to create high-quality videos and images easily. The X-T200 features a new APS-C 24.2 Megapixel CMOS sensor and processor giving high image quality & super-fast performance. Also featured is a bright, large widescreen LCD vari-angle touchscreen, a newly designed EVF, quick face detection AF and 4K video recording with a new electronic stabilization mode to give you smooth, shake-free movies.",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 749,
                    CarouselNumber = 1,
                    Discount = 15
                },

                new Camera()
                {

                    CameraId = 9,
                    Make = "Sony",
                    Model = "a7R IV",
                    CameraType = "Mirrorless",
                    Summary = "24.2MP APS-C CMOS image sensor, 4K 30p video recording, Large 3.5-inch vari-angle LCD touchscreen,Continuous shooting up to 8fps,Electronic Stabilisation and HDR Video modes",
                    Description = "The Fujifilm X-T200 in dark silver is a stylish, compact & lightweight (only 370g) mirrorless camera aimed at photographers who want to create high-quality videos and images easily. The X-T200 features a new APS-C 24.2 Megapixel CMOS sensor and processor giving high image quality & super-fast performance. Also featured is a bright, large widescreen LCD vari-angle touchscreen, a newly designed EVF, quick face detection AF and 4K video recording with a new electronic stabilization mode to give you smooth, shake-free movies.",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 3199,
                    CarouselNumber = 2,
                    Discount = 25
                },

                new Camera()
                {

                    CameraId = 10,
                    Make = "Nikon",
                    Model = "Coolpix P950",
                    CameraType = "Compact",
                    Summary = "83x optical zoom, f/2.8 bright nikkor lens, 4k movies, 16 megapixel backlit CMOS sensor, Full-size Hot Shoe",
                    Description = "The Coolpix P950 is a versatile superzoom bridge camera offering a mix of still photography and video shooting capabilities. At the heart of the P950 is back-illuminated 16 megapixel CMOS sensor and EXPEED Image Processor which combine to produce high quality images and super-fast shooting, even in low light. You can also record 4K video at up to 30 fps, Full HD video at up to 60 fps and in-camera time-lapse recording. The star of the show however, is the massive 83x optical zoom which covers an amazing 24-2000mm equivalent focal length range. This huge reach is supported by Dual Detect Vibration Reduction, which compensates for the effects of camera shake in order to realize sharper results when shooting handheld. The P950 also features a bright 2.36m-dot OLED Electronic Viewfinder, a large 3.2-inch 921k-dot vari-angle touchscreen monitor and has built-in Wi-Fi and Bluetooth for wireless sharing and remote camera control.",
                    Image = "1",
                    VideoUrl = "1",
                    CurrentPrice = 799,
                    CarouselNumber = 7,
                    Discount = 0
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

