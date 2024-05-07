namespace OrientHGAPI.DTOs.Responses.Offers
{
    public class GetOffersResponsePage
    {
        public MainResponse PageDetails { get; set; }
        public List<GetOffersList> OffersList { get; set; }
    }
}
