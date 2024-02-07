using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("MaximumItemRequirements")]
    public class MaximumItemRequirements
    {
        [XmlElement("MaximumItemCount")]
        public List<int> MaximumItemCount { get; set; }

        [XmlElement("MinimumFeedbackScore")]
        public List<int> MinimumFeedbackScore { get; set; }
    }
}
