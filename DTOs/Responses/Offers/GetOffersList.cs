namespace OrientHGAPI.DTOs.Responses.Offers
{
    public class GetOffersList
    {
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string OfferPhoto { get; set; }
        public string OfferUrl { get; set; }
        public string OfferName { get; set; }
        public string OfferSubTitle1 { get; set; }
        public string OfferSubTitle2 { get; set; }
        public bool? IsChildAllowed { get; set; }
        public string HotelUrl { get; set; }

    }
}
