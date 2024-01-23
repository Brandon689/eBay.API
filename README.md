# eBay.API

Version 2 of API, completely overhauled

## Example

```csharp
using dotenv.net;
using eBay.API.Facade;
using eBay.API.Models;
using eBay.API.Models.Items;
using eBay.API.Models.Product;
using eBay.API.Models.Product.ProductVariations;
using eBay.API.Models.SellerStore;
using System.Diagnostics;

DotEnv.Load();

XMLS xm = new XMLS(Environment.GetEnvironmentVariable("authNauth"));
ItemService is = new ItemService(xm);

await is.GetItem("81002670");

Item item = new Item()
{
    Country = "CN",
    Currency = "AUD",
    ConditionID = 1000,
    Description = "desc.",
    SKU = "asku",
    ListingDuration = "GTC",
    Title = "a title",
    Quantity = 3,
    Location = "ACity",
    PrimaryCategory = new PrimaryCategory()
    {
        CategoryID = 262324,
    },
    PictureDetails = new PictureDetails()
    {
        PictureURL = new string[]
        {
            "https://i.ebayimg.com/images/someimage.jpg",
            "https://i.ebayimg.com/images/someimage2.jpg"
        }
    },
    SellerProfiles = new SellerProfiles()
    {
        SellerPaymentProfile = new SellerPaymentProfile()
        {
            PaymentProfileID = "187775466031"
        },
        SellerReturnProfile = new SellerReturnProfile()
        {
            ReturnProfileID = "204860900021"
        },
        SellerShippingProfile = new SellerShippingProfile()
        {
            ShippingProfileID = "111131133020"
        }
    },
    ProductListingDetails = new ProductListingDetails()
    {
        BrandMPN = new BrandMPN()
        {
            Brand = "Unbranded",
            MPN = "Does not apply"
        }
    },
    ItemSpecifics = new ItemSpecifics()
    {
        NameValueList = new NameValueList[]
        {
            new NameValueList()
            {
                Name = "Type",
                Value = new string[]
                {
                    "Atype"
                }
            },
            new NameValueList()
            {
                Name = "Brand",
                Value = new string[]
                {
                    "Unbranded"
                }
            }
        }
    }
};

await is.AddFixedPriceItem(item);
