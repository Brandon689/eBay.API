namespace eBay.API.Models.Customer.Ship
{
    public class ShippingAddress
    {
        public string Name { get; set; }

        public string Street1 { get; set; }

        public string Street2 { get; set; }

        public string CityName { get; set; }

        public string StateOrProvince { get; set; }

        public string Country { get; set; }

        public string CountryName { get; set; }

        public string Phone { get; set; }

        public string PostalCode { get; set; }

        public double AddressID { get; set; }

        public string AddressOwner { get; set; }
    }
}
