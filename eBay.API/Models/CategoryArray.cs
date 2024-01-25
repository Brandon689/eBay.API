using eBay.API.Models.Response;
using System.Xml.Serialization;

namespace eBay.API.Models
{
    [XmlRoot(ElementName = "CategoryArray")]
    public class CategoryArray
    {
        [XmlElement(ElementName = "Category")]
        public List<Category> Category { get; set; }
    }
}
