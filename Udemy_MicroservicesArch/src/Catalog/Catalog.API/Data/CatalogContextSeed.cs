using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product() 
                { 
                    Name = "IPhone X", 
                    Summary = "The iPhone X is a smartphone designed, developed, and marketed by Apple Inc. The eleventh generation of the iPhone, it was available to pre-order on October 27, 2017 and was released on November 3, 2017.", 
                    Description = "The iPhone X used a glass and stainless-steel form factor and \"bezel-less\" design, shrinking the bezels while not having a \"chin\", unlike many Android phones. It was the first iPhone to use an OLED screen.",
                    ImageFile = "product-1.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Name = "Samsung Galaxy S10",
                    Summary = "The Samsung Galaxy S10 is a line of Android-based smartphones manufactured, released and marketed by Samsung Electronics as part of the Samsung Galaxy S series.",
                    Description = "The Galaxy S10 series is a celebratory series of the 10th anniversary of the Samsung Galaxy S flagship line, its top line of phones next to the Note models.",
                    ImageFile = "product-2.png",
                    Price = 840.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Name = "Huawei P10",
                    Summary = "The Huawei P10 is an Android phablet smartphone manufactured by Huawei. Announced at Mobile World Congress 2017 on 26 February 2017, the P10 is the successor to the Huawei P9.",
                    Description = "The P10 is constructed with a metal chassis, available in various color finishes. Two color options, \"Dazzling Blue\" and \"Dazzling Gold\", feature a patterned \"Hyper Diamond Cut\" finish which reduces its susceptibility to fingerprints.",
                    ImageFile = "product-3.png",
                    Price = 650.00M,
                    Category = "White Appliances"
                },
                new Product()
                {
                    Name = "Xiaomi Mi 9",
                    Summary = "The Xiaomi Mi 9 is a flagship Android smartphone developed by Xiaomi Inc. It was announced in February 2019.",
                    Description = "The Xiaomi Mi 9 is powered by the Qualcomm Snapdragon 855 processor, with 6 GB or 8 GB LPDDR4X RAM and the Adreno 640 GPU. It has a 6.39-inch (162 mm) FHD+ AMOLED display.",
                    ImageFile = "product-4.png",
                    Price = 470.00M,
                    Category = "White Appliances"
                },
                new Product()
                {
                    Name = "Poco X3",
                    Summary = "The POCO X3 and POCO X3 NFC are Android-based smartphones developed by Xiaomi, announced on 7 and 22 September 2020.",
                    Description = "The POCO X3 NFC runs on Qualcomm Snapdragon 732G (8 nm) processor with Adreno 618 to handle graphics. It is equipped with Liquid Cool Technology 1.0 Plus for heat dissipation.",
                    ImageFile = "product-5.png",
                    Price = 380.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Name = "LG G7 ThinQ",
                    Summary = "The LG G7 ThinQ, commonly referred to as just LG G7, is an Android smartphone developed by LG Electronics as part of the LG G series.",
                    Description = "The LG G7 ThinQ utilizes a metal chassis with a glass backing, and is IP68-rated for water and dust-resistance. It is available in black, blue, rose and silver-color finishes.",
                    ImageFile = "product-6.png",
                    Price = 240.00M,
                    Category = "Home Kitchen"
                }
            };
        }
    }
}