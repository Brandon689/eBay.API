using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("PictureSetMember")]
    public class PictureSetMember
    {
        [XmlElement("MemberURL")]
        public string MemberURL { get; set; }

        [XmlElement("PictureHeight")]
        public int PictureHeight { get; set; }

        [XmlElement("PictureWidth")]
        public int PictureWidth { get; set; }
    }
}
