using System.Xml.Serialization;

namespace eBay.API.Models.Requests.Order
{
    [XmlRoot("FeedbackInfo")]
    public class FeedbackInfo
    {
        [XmlElement("CommentText")]
        public string CommentText { get; set; }

        [XmlElement("CommentType")]
        public string CommentType { get; set; }

        [XmlElement("TargetUser")]
        public string TargetUser { get; set; }
    }
}
