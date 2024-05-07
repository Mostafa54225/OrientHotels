using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblOffer
{
    public int Offerid { get; set; }

    public int? HotelId { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsDisplayDates { get; set; }

    public bool? IsChildAllowed { get; set; }

    public bool? OfferStatus { get; set; }

    public DateTime? CreationDate { get; set; }

    public string OfferNameSys { get; set; }

    public string OfferUrl { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public int? OfferPosition { get; set; }

    public string OfferPhoto { get; set; }

    public string OfferBanner { get; set; }

    public string PromoCode { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public int? OfferPhotoWidth { get; set; }

    public int? OfferPhotoHieght { get; set; }

    public int? OfferBannerWidth { get; set; }

    public int? OfferBannerHieght { get; set; }

    public string OfferBannerMobile { get; set; }

    public int? OfferBannerMobileWidth { get; set; }

    public int? OfferBannerMobileHeight { get; set; }

    public string OfferBannerTablet { get; set; }

    public int? OfferBannerTabletWidth { get; set; }

    public int? OfferBannerTabletHeight { get; set; }

    public virtual ICollection<TblOffersContent> TblOffersContents { get; set; } = new List<TblOffersContent>();
}
