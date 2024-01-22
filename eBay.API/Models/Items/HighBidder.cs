namespace eBay.API.Models.Items
{
    public class HighBidder
    {
        public bool AboutMePage { get; set; }

        public string EIASToken { get; set; }

        public string Email { get; set; }

        public int FeedbackScore { get; set; }

        public double PositiveFeedbackPercent { get; set; }

        public bool EBayGoodStanding { get; set; }

        public bool NewUser { get; set; }

        public DateTime RegistrationDate { get; set; }
        public string Site { get; set; }

        public string UserID { get; set; }

        public string VATStatus { get; set; }

        public bool UserAnonymized { get; set; }
    }
}
