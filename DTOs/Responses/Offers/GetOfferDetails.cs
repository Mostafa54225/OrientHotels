namespace OrientHGAPI.DTOs.Responses.Offers
{
    public class GetOfferDetails
    {

       
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string OfferPhoto { get; set; }
        public string OfferBanner { get; set; }
        public string OfferBannerMobile { get; set; }
        public string OfferBannerTablet { get; set; }
        public string OfferUrl { get; set; }
        public string OfferName { get; set; }
        public string OfferDescription { get; set; }
        public string OfferSubTitle1 { get; set; }
        public string OfferSubTitle2 { get; set; }
        public string OfferInclude { get; set; }
        public string OfferExclude { get; set; }
        public string OfferTerms { get; set; }
        public string OfferBookingUrl { get; set; }
        public string ValidityText { get; set; }
        public bool? IsChildAllowed { get; set; }
        public string HotelUrl { get; set; }
        public string OfferMetatagTitle { get; set; }
        public string OfferMetatagDescription { get; set; }

    }
}
