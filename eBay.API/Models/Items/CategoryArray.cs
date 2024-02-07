using eBay.API.Models.Response;
using System.Xml.Serialization;

namespace eBay.API.Models
{
    [XmlRoot("CategoryArray")]
    public class CategoryArray
    {
        [XmlElement("Category")]
        public List<Category> Category { get; set; }
    }
}
