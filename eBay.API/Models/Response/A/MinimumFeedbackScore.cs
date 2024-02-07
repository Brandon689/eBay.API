using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("MinimumFeedbackScore")]
    public class MinimumFeedbackScore
    {
        [XmlElement("FeedbackScore")]
        public List<int> FeedbackScore { get; set; }
    }
}
