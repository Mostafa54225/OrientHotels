﻿using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class VwHotel
{
    public int HotelId { get; set; }

    public string HotelAccommodationTitle { get; set; }

    public string HotelAccommodationMetatagTitle { get; set; }

    public string HotelAccommodationMetatagDescription { get; set; }

    public string HotelNameSys { get; set; }

    public string HotelPhoto { get; set; }

    public bool? HotelStatus { get; set; }

    public int? CountryId { get; set; }

    public int? DestinationId { get; set; }

    public string HotelEmail { get; set; }

    public string ReservationEmail { get; set; }

    public string HotelPmscode { get; set; }

    public string HotelPhone { get; set; }

    public string HotelFax { get; set; }

    public string HotelMobile { get; set; }

    public string HotelUrl { get; set; }

    public int HotelContentId { get; set; }

    public int? LangId { get; set; }

    public string HotelName { get; set; }

    public string HotelSummery { get; set; }

    public string HotelOverview { get; set; }

    public string HotelFactsheet { get; set; }

    public string HotelAddress { get; set; }

    public string HotelBookingUrl { get; set; }

    public string DestinationPhoto { get; set; }

    public string DestinationBanner { get; set; }

    public bool? DestinationStatus { get; set; }

    public string DestinationUrl { get; set; }

    public int? DestinationContentId { get; set; }

    public string DestinationName { get; set; }

    public string DestinationIntro { get; set; }

    public string DestinationDetails { get; set; }

    public string LanguageAbbreviation { get; set; }

    public string LanguageName { get; set; }

    public string HotelYouTube { get; set; }

    public string TripAdvisorKey { get; set; }

    public string TripAdvisorUrl { get; set; }

    public string HotelGoogleMap { get; set; }

    public bool? EnableOnlineCheckIn { get; set; }

    public string HotelWhatsAppNumber { get; set; }

    public string HotelLogo { get; set; }

    public int? HotelPhotoWidth { get; set; }

    public int? HotelPhotoHieght { get; set; }

    public int? HotelTypeId { get; set; }

    public string HotelTypeNameSys { get; set; }

    public int? HotelTypeContentId { get; set; }

    public string HotelTypeName { get; set; }

    public bool? EnableOnlineBooking { get; set; }

    public string HotelAccommodation { get; set; }

    public string HotelDining { get; set; }

    public string HotelFacilities { get; set; }

    public string HotelMeeting { get; set; }

    public string HotelAccommodationBanner { get; set; }

    public int? HotelAccommodationBannerPhotoWidth { get; set; }

    public int? HotelAccommodationBannerPhotoHieght { get; set; }

    public string HotelDiningTitle { get; set; }

    public string HotelDiningMetatagTitle { get; set; }

    public string HotelFacilitiesTitle { get; set; }

    public string HotelDiningMetatagDescription { get; set; }

    public string HotelFacilitiesMetatagTitle { get; set; }

    public string HotelFacilitiesMetatagDescription { get; set; }

    public string HotelMeetingTitle { get; set; }

    public string HotelMeetingMetatagTitle { get; set; }

    public string HotelMeetingMetatagDescription { get; set; }

    public string HotelDiningBanner { get; set; }

    public int? HotelDiningBannerHieght { get; set; }

    public int? HotelDiningBannerWidth { get; set; }

    public string HotelFacilitiesBanner { get; set; }

    public int? HotelFacilitiesBannerWidth { get; set; }

    public int? HotelFacilitiesBannerHieght { get; set; }

    public string HotelMeetingBanner { get; set; }

    public int? HotelMeetingBannerWidth { get; set; }

    public int? HotelMeetingBannerHieght { get; set; }

    public string HotelOfferBanner { get; set; }

    public int? HotelOfferBannerWidth { get; set; }

    public int? HotelOfferBannerHieght { get; set; }

    public string HotelOffers { get; set; }

    public string HotelOffersTitle { get; set; }

    public string HotelOffersMetatagTitle { get; set; }

    public string HotelOffersMetatagDescription { get; set; }

    public string HotelAwardBanner { get; set; }

    public int? HotelAwardBannerWidth { get; set; }

    public int? HotelAwardBannerHieght { get; set; }

    public string HotelGalleryBanner { get; set; }

    public int? HotelGalleryBannerWidth { get; set; }

    public int? HotelGalleryBannerHieght { get; set; }

    public string HotelAwards { get; set; }

    public string HotelAwardsTitle { get; set; }

    public string HotelAwardsMetatagTitle { get; set; }

    public string HotelAwardsMetatagDescription { get; set; }

    public string HotelGallery { get; set; }

    public string HotelGalleryTitle { get; set; }

    public string HotelGalleryMetatagTitle { get; set; }

    public string HotelGalleryMetatagDescription { get; set; }

    public string HotelSocialBanner { get; set; }

    public int? HotelSocialBannerWidth { get; set; }

    public int? HotelSocialBannerHieght { get; set; }

    public string HotelSocial { get; set; }

    public string HotelSocialTitle { get; set; }

    public string HotelSocialMetatagTitle { get; set; }

    public string HotelSocialMetatagDescription { get; set; }

    public string HotelNearBanner { get; set; }

    public int? HotelNearBannerWidth { get; set; }

    public int? HotelNearBannerHieght { get; set; }

    public string HotelNear { get; set; }

    public string HotelNearTitle { get; set; }

    public string HotelNearMetatagTitle { get; set; }

    public string HotelNearMetatagDescription { get; set; }

    public string HotelTeamBanner { get; set; }

    public int? HotelTeamBannerWidth { get; set; }

    public int? HotelTeamBannerHieght { get; set; }

    public string HotelTeam { get; set; }

    public string HotelTeamTitle { get; set; }

    public string HotelTeamMetatagTitle { get; set; }

    public string HotelTeamMetatagDescription { get; set; }

    public string HotelContactBanner { get; set; }

    public int? HotelContactBannerWidth { get; set; }

    public int? HotelContactBannerHieght { get; set; }

    public string HotelContact { get; set; }

    public string HotelContactTitle { get; set; }

    public string HotelContactMetaTagTitle { get; set; }

    public string HotelContactMetatagDescription { get; set; }

    public string HotelContactThanks { get; set; }

    public string HotelContactThanksTitle { get; set; }

    public string HotelContactThanksMetaTagTitle { get; set; }

    public string HotelContactThanksMetatagDescription { get; set; }

    public string HotelContactThanksBanner { get; set; }

    public int? HotelContactThanksBannerWidth { get; set; }

    public int? HotelContactThanksBannerHight { get; set; }

    public string HotelNewsletterThanks { get; set; }

    public string HotelNewsletterThanksTitle { get; set; }

    public string HotelNewsletterThanksMetaTagTitle { get; set; }

    public string HotelNewsletterThanksMetatagDescription { get; set; }

    public string HotelNewsletterThanksBanner { get; set; }

    public int? HotelNewsletterThanksBannerWidth { get; set; }

    public int? HotelNewsletterThanksBannerHight { get; set; }

    public string HotelMeetingThanks { get; set; }

    public string HotelMeetingThanksTitle { get; set; }

    public string HotelMeetingThanksMetaTagTitle { get; set; }

    public string HotelMeeitngThanksMetatagDescription { get; set; }

    public string HotelMeetingThanksBanner { get; set; }

    public int? HotelMeetingThanksBannerWidth { get; set; }

    public int? HotelMeetingThanksBannerHieght { get; set; }

    public string HotelAccommodationBannerColorOverlayFrom { get; set; }

    public string HotelAccommodationBannerColorOverlayTo { get; set; }

    public string HotelAccommodationBannerTablet { get; set; }

    public int? HotelAccommodationBannerTabletWidth { get; set; }

    public int? HotelAccommodationBannerTabletHieght { get; set; }

    public string HotelAccommodationBannerTabletColorOverlayFrom { get; set; }

    public string HotelAccommodationBannerTabletColorOverlayTo { get; set; }

    public string HotelAccommodationBannerMobile { get; set; }

    public int? HotelAccommodationBannerMobileWidth { get; set; }

    public int? HotelAccommodationBannerMobileHieght { get; set; }

    public string HotelAccommodationBannerMobileColorOverlayFrom { get; set; }

    public string HotelAccommodationBannerMobileColorOverlayTo { get; set; }

    public string HotelDiningBannerColorOverlayFrom { get; set; }

    public string HotelDiningBannerColorOverlayTo { get; set; }

    public string HotelDiningBannerTablet { get; set; }

    public int? HotelDiningBannerTabletWidth { get; set; }

    public int? HotelDiningBannerTabletHieght { get; set; }

    public string HotelDiningBannerTabletColorOverlayFrom { get; set; }

    public string HotelDiningBannerTabletColorOverlayTo { get; set; }

    public string HotelDiningBannerMobile { get; set; }

    public int? HotelDiningBannerMobileWidth { get; set; }

    public int? HotelDiningBannerMobileHieght { get; set; }

    public string HotelDiningBannerMobileColorOverlayFrom { get; set; }

    public string HotelDiningBannerMobileColorOverlayTo { get; set; }

    public string HotelFacilitiesBannerColorOverlayFrom { get; set; }

    public string HotelFacilitiesBannerColorOverlayTo { get; set; }

    public string HotelFacilitiesBannerTablet { get; set; }

    public int? HotelFacilitiesBannerTabletWidth { get; set; }

    public int? HotelFacilitiesBannerTabletHieght { get; set; }

    public string HotelFacilitiesBannerTabletColorOverlayFrom { get; set; }

    public string HotelFacilitiesBannerTabletColorOverlayTo { get; set; }

    public string HotelFacilitiesBannerMobile { get; set; }

    public int? HotelFacilitiesBannerMobileWidth { get; set; }

    public int? HotelFacilitiesBannerMobileHieght { get; set; }

    public string HotelFacilitiesBannerMobileColorOverlayFrom { get; set; }

    public string HotelFacilitiesBannerMobileColorOverlayTo { get; set; }

    public string HotelMeetingBannerColorOverlayFrom { get; set; }

    public string HotelMeetingBannerColorOverlayTo { get; set; }

    public string HotelMeetingBannerTablet { get; set; }

    public int? HotelMeetingBannerTabletWidth { get; set; }

    public int? HotelMeetingBannerTabletHieght { get; set; }

    public string HotelMeetingBannerTabletColorOverlayFrom { get; set; }

    public string HotelMeetingBannerTabletColorOverlayTo { get; set; }

    public string HotelMeetingBannerMobile { get; set; }

    public int? HotelMeetingBannerMobileWidth { get; set; }

    public int? HotelMeetingBannerMobileHieght { get; set; }

    public string HotelMeetingBannerMobileColorOverlayFrom { get; set; }

    public string HotelMeetingBannerMobileColorOverlayTo { get; set; }

    public string HotelOfferBannerColorOverlayFrom { get; set; }

    public string HotelOfferBannerColorOverlayTo { get; set; }

    public string HotelOfferBannerTablet { get; set; }

    public int? HotelOfferBannerTabletWidth { get; set; }

    public int? HotelOfferBannerTabletHieght { get; set; }

    public string HotelOfferBannerTabletColorOverlayFrom { get; set; }

    public string HotelOfferBannerTabletColorOverlayTo { get; set; }

    public string HotelOfferBannerMobile { get; set; }

    public int? HotelOfferBannerMobileWidth { get; set; }

    public int? HotelOfferBannerMobileHieght { get; set; }

    public string HotelOfferBannerMobileColorOverlayFrom { get; set; }

    public string HotelOfferBannerMobileColorOverlayTo { get; set; }

    public string HotelAwardBannerColorOverlayFrom { get; set; }

    public string HotelAwardBannerColorOverlayTo { get; set; }

    public string HotelAwardBannerTablet { get; set; }

    public int? HotelAwardBannerTabletWidth { get; set; }

    public int? HotelAwardBannerTabletHieght { get; set; }

    public string HotelAwardBannerTabletColorOverlayFrom { get; set; }

    public string HotelAwardBannerTabletColorOverlayTo { get; set; }

    public string HotelAwardBannerMobile { get; set; }

    public int? HotelAwardBannerMobileWidth { get; set; }

    public int? HotelAwardBannerMobileHieght { get; set; }

    public string HotelAwardBannerMobileColorOverlayFrom { get; set; }

    public string HotelAwardBannerMobileColorOverlayTo { get; set; }

    public string HotelGalleryBannerColorOverlayFrom { get; set; }

    public string HotelGalleryBannerColorOverlayTo { get; set; }

    public int? HotelGalleryBannerTabletWidth { get; set; }

    public string HotelGalleryBannerTablet { get; set; }

    public int? HotelGalleryBannerTabletHieght { get; set; }

    public string HotelGalleryBannerTabletColorOverlayFrom { get; set; }

    public string HotelGalleryBannerTabletColorOverlayTo { get; set; }

    public string HotelGalleryBannerMobile { get; set; }

    public int? HotelGalleryBannerMobileWidth { get; set; }

    public int? HotelGalleryBannerMobileHieght { get; set; }

    public string HotelGalleryBannerMobileColorOverlayFrom { get; set; }

    public string HotelGalleryBannerMobileColorOverlayTo { get; set; }

    public string HotelTeamBannerColorOverlayFrom { get; set; }

    public string HotelTeamBannerColorOverlayTo { get; set; }

    public string HotelTeamBannerTablet { get; set; }

    public int? HotelTeamBannerTabletWidth { get; set; }

    public int? HotelTeamBannerTabletHieght { get; set; }

    public string HotelTeamBannerTabletColorOverlayFrom { get; set; }

    public string HotelTeamBannerTabletColorOverlayTo { get; set; }

    public string HotelTeamBannerMobile { get; set; }

    public int? HotelTeamBannerMobileWidth { get; set; }

    public int? HotelTeamBannerMobileHieght { get; set; }

    public string HotelTeamBannerMobileColorOverlayFrom { get; set; }

    public string HotelTeamBannerMobileColorOverlayTo { get; set; }

    public string HotelContactBannerColorOverlayFrom { get; set; }

    public string HotelContactBannerColorOverlayTo { get; set; }

    public string HotelContactBannerTablet { get; set; }

    public int? HotelContactBannerTabletWidth { get; set; }

    public int? HotelContactBannerTabletHieght { get; set; }

    public string HotelContactBannerTabletColorOverlayFrom { get; set; }

    public string HotelContactBannerTabletColorOverlayTo { get; set; }

    public string HotelContactBannerMobile { get; set; }

    public int? HotelContactBannerMobileWidth { get; set; }

    public int? HotelContactBannerMobileHieght { get; set; }

    public string HotelContactBannerMobileColorOverlayFrom { get; set; }

    public string HotelContactBannerMobileColorOverlayTo { get; set; }

    public string HotelContactThanksBannerColorOverlayFrom { get; set; }

    public string HotelContactThanksBannerColorOverlayTo { get; set; }

    public string HotelContactThanksBannerTablet { get; set; }

    public int? HotelContactThanksBannerTabletWidth { get; set; }

    public int? HotelContactThanksBannerTabletHight { get; set; }

    public string HotelContactThanksBannerTabletColorOverlayFrom { get; set; }

    public string HotelContactThanksBannerTabletColorOverlayTo { get; set; }

    public string HotelContactThanksBannerMobile { get; set; }

    public int? HotelContactThanksBannerMobileWidth { get; set; }

    public int? HotelContactThanksBannerMobileHight { get; set; }

    public string HotelContactThanksBannerMobileColorOverlayFrom { get; set; }

    public string HotelContactThanksBannerMobileColorOverlayTo { get; set; }

    public string HotelNewsletterThanksBannerColorOverlayFrom { get; set; }

    public string HotelNewsletterThanksBannerColorOverlayTo { get; set; }

    public string HotelNewsletterThanksBannerTablet { get; set; }

    public int? HotelNewsletterThanksBannerTabletWidth { get; set; }

    public int? HotelNewsletterThanksBannerTabletHight { get; set; }

    public string HotelNewsletterThanksBannerTabletColorOverlayFrom { get; set; }

    public string HotelNewsletterThanksBannerTabletColorOverlayTo { get; set; }

    public string HotelNewsletterThanksBannerMobile { get; set; }

    public int? HotelNewsletterThanksBannerMobileWidth { get; set; }

    public int? HotelNewsletterThanksBannerMobileHight { get; set; }

    public string HotelNewsletterThanksBannerMobileColorOverlayFrom { get; set; }

    public string HotelNewsletterThanksBannerMobileColorOverlayTo { get; set; }

    public string HotelMeetingThanksBannerColorOverlayFrom { get; set; }

    public string HotelMeetingThanksBannerColorOverlayTo { get; set; }

    public string HotelMeetingThanksBannerTablet { get; set; }

    public int? HotelMeetingThanksBannerTabletWidth { get; set; }

    public int? HotelMeetingThanksBannerTabletHieght { get; set; }

    public string HotelMeetingThanksBannerTabletColorOverlayFrom { get; set; }

    public string HotelMeetingThanksBannerTabletColorOverlayTo { get; set; }

    public string HotelMeetingThanksBannerMobile { get; set; }

    public int? HotelMeetingThanksBannerMobileWidth { get; set; }

    public int? HotelMeetingThanksBannerMobileHieght { get; set; }

    public string HotelMeetingThanksBannerMobileColorOverlayFrom { get; set; }

    public string HotelMeetingThanksBannerMobileColorOverlayTo { get; set; }

    public int? LangIdmasterHotelTypes { get; set; }

    public string HotelFaqBanner { get; set; }

    public string HotelFaqBannerTablet { get; set; }

    public string HotelFaqBannerMobile { get; set; }

    public string HotelFaqThanksBanner { get; set; }

    public string HotelFaqThanksBannerTablet { get; set; }

    public string HotelFaqThanksBannerMobile { get; set; }

    public string HotelFaqBannerColorOverlayFrom { get; set; }

    public string HotelFaqBannerTabletColorOverlayFrom { get; set; }

    public string HotelFaqBannerMobileColorOverlayFrom { get; set; }

    public string HotelFaqBannerColorOverlayTo { get; set; }

    public string HotelFaqBannerTabletColorOverlayTo { get; set; }

    public string HotelFaqBannerMobileColorOverlayTo { get; set; }

    public string HotelFaqThanksBannerColorOverlayFrom { get; set; }

    public string HotelFaqThanksBannerTabletColorOverlayFrom { get; set; }

    public string HotelFaqThanksBannerMobileColorOverlayFrom { get; set; }

    public string HotelFaqThanksBannerColorOverlayTo { get; set; }

    public string HotelFaqThanksBannerTabletColorOverlayTo { get; set; }

    public string HotelFaqThanksBannerMobileColorOverlayTo { get; set; }

    public int? HotelFaqBannerPhotoHieght { get; set; }

    public int? HotelFaqBannerPhotoWidth { get; set; }

    public int? HotelFaqBannerTabletWidth { get; set; }

    public int? HotelFaqBannerTabletHieght { get; set; }

    public int? HotelFaqBannerMobileWidth { get; set; }

    public int? HotelFaqBannerMobileHieght { get; set; }

    public int? HotelFaqThanksBannerPhotoWidth { get; set; }

    public int? HotelFaqThanksBannerPhotoHieght { get; set; }

    public int? HotelFaqThanksBannerTabletWidth { get; set; }

    public int? HotelFaqThanksBannerTabletHieght { get; set; }

    public int? HotelFaqThanksBannerMobileWidth { get; set; }

    public int? HotelFaqThanksBannerMobileHieght { get; set; }

    public string HotelNewsBanner { get; set; }

    public string HotelNewsBannerTablet { get; set; }

    public string HotelNewsBannerMobile { get; set; }

    public string HotelCovidBanner { get; set; }

    public string HotelCovidBannerTablet { get; set; }

    public string HotelCovidBannerMobile { get; set; }

    public string HotelCareerBanner { get; set; }

    public string HotelCareerBannerTablet { get; set; }

    public string HotelCareerBannerMobile { get; set; }

    public string HotelAboutUsBanner { get; set; }

    public string HotelAboutUsBannerTablet { get; set; }

    public string HotelAboutUsBannerMobile { get; set; }

    public string HotelPrivacyBanner { get; set; }

    public string HotelPrivacyBannerTablet { get; set; }

    public string HotelPrivacyBannerMobile { get; set; }

    public string HotelBlogBanner { get; set; }

    public string HotelBlogBannerTablet { get; set; }

    public string HotelBlogBannerMobile { get; set; }

    public string HotelTermsConditionsBanner { get; set; }

    public string HotelTermsConditionsBannerTablet { get; set; }

    public string HotelTermsConditionsBannerMobile { get; set; }

    public string HotelNewsBannerColorOverlayFrom { get; set; }

    public string HotelNewsBannerTabletColorOverlayFrom { get; set; }

    public string HotelNewsBannerMobileColorOverlayFrom { get; set; }

    public string HotelNewsBannerColorOverlayTo { get; set; }

    public string HotelNewsBannerTabletColorOverlayTo { get; set; }

    public string HotelNewsBannerMobileColorOverlayTo { get; set; }

    public string HotelCovidBannerColorOverlayFrom { get; set; }

    public string HotelCovidBannerTabletColorOverlayFrom { get; set; }

    public string HotelCovidBannerMobileColorOverlayFrom { get; set; }

    public string HotelCovidBannerColorOverlayTo { get; set; }

    public string HotelCovidBannerTabletColorOverlayTo { get; set; }

    public string HotelCovidBannerMobileColorOverlayTo { get; set; }

    public string HotelCareerBannerColorOverlayFrom { get; set; }

    public string HotelCareerBannerTabletColorOverlayFrom { get; set; }

    public string HotelCareerBannerMobileColorOverlayFrom { get; set; }

    public string HotelCareerBannerColorOverlayTo { get; set; }

    public string HotelCareerBannerTabletColorOverlayTo { get; set; }

    public string HotelCareerBannerMobileColorOverlayTo { get; set; }

    public string HotelAboutUsBannerColorOverlayFrom { get; set; }

    public string HotelAboutUsBannerTabletColorOverlayFrom { get; set; }

    public string HotelAboutUsBannerMobileColorOverlayFrom { get; set; }

    public string HotelAboutUsBannerColorOverlayTo { get; set; }

    public string HotelAboutUsBannerTabletColorOverlayTo { get; set; }

    public string HotelAboutUsBannerMobileColorOverlayTo { get; set; }

    public string HotelPrivacyBannerColorOverlayFrom { get; set; }

    public string HotelPrivacyBannerTabletColorOverlayFrom { get; set; }

    public string HotelPrivacyBannerMobileColorOverlayFrom { get; set; }

    public string HotelPrivacyBannerColorOverlayTo { get; set; }

    public string HotelPrivacyBannerTabletColorOverlayTo { get; set; }

    public string HotelPrivacyBannerMobileColorOverlayTo { get; set; }

    public string HotelBlogBannerColorOverlayFrom { get; set; }

    public string HotelBlogBannerTabletColorOverlayFrom { get; set; }

    public string HotelBlogBannerMobileColorOverlayFrom { get; set; }

    public string HotelBlogBannerColorOverlayTo { get; set; }

    public string HotelBlogBannerTabletColorOverlayTo { get; set; }

    public string HotelBlogBannerMobileColorOverlayTo { get; set; }

    public string HotelTermsConditionsBannerColorOverlayFrom { get; set; }

    public string HotelTermsConditionsBannerTabletColorOverlayFrom { get; set; }

    public string HotelTermsConditionsBannerMobileColorOverlayFrom { get; set; }

    public string HotelTermsConditionsBannerColorOverlayTo { get; set; }

    public string HotelTermsConditionsBannerTabletColorOverlayTo { get; set; }

    public string HotelTermsConditionsBannerMobileColorOverlayTo { get; set; }

    public int? HotelNewsBannerPhotoWidth { get; set; }

    public int? HotelNewsBannerPhotoHieght { get; set; }

    public int? HotelNewsBannerTabletWidth { get; set; }

    public int? HotelNewsBannerTabletHieght { get; set; }

    public int? HotelNewsBannerMobileWidth { get; set; }

    public int? HotelNewsBannerMobileHieght { get; set; }

    public int? HotelCovidBannerPhotoWidth { get; set; }

    public int? HotelCovidBannerPhotoHieght { get; set; }

    public int? HotelCovidBannerTabletWidth { get; set; }

    public int? HotelCovidBannerTabletHieght { get; set; }

    public int? HotelCovidBannerMobileWidth { get; set; }

    public int? HotelCovidBannerMobileHieght { get; set; }

    public int? HotelCareerBannerPhotoWidth { get; set; }

    public int? HotelCareerBannerPhotoHieght { get; set; }

    public int? HotelCareerBannerTabletWidth { get; set; }

    public int? HotelCareerBannerTabletHieght { get; set; }

    public int? HotelCareerBannerMobileWidth { get; set; }

    public int? HotelCareerBannerMobileHieght { get; set; }

    public int? HotelAboutUsBannerPhotoWidth { get; set; }

    public int? HotelAboutUsBannerPhotoHieght { get; set; }

    public int? HotelAboutUsBannerTabletWidth { get; set; }

    public int? HotelAboutUsBannerTabletHieght { get; set; }

    public int? HotelAboutUsBannerMobileWidth { get; set; }

    public int? HotelAboutUsBannerMobileHieght { get; set; }

    public int? HotelPrivacyBannerPhotoWidth { get; set; }

    public int? HotelPrivacyBannerPhotoHieght { get; set; }

    public int? HotelPrivacyBannerTabletWidth { get; set; }

    public int? HotelPrivacyBannerTabletHieght { get; set; }

    public int? HotelPrivacyBannerMobileWidth { get; set; }

    public int? HotelPrivacyBannerMobileHieght { get; set; }

    public int? HotelBlogBannerPhotoWidth { get; set; }

    public int? HotelBlogBannerPhotoHieght { get; set; }

    public int? HotelBlogBannerTabletWidth { get; set; }

    public int? HotelBlogBannerTabletHieght { get; set; }

    public int? HotelBlogBannerMobileWidth { get; set; }

    public int? HotelBlogBannerMobileHieght { get; set; }

    public int? HotelTermsConditionsBannerPhotoHieght { get; set; }

    public int? HotelTermsConditionsBannerPhotoWidth { get; set; }

    public int? HotelTermsConditionsBannerTabletWidth { get; set; }

    public int? HotelTermsConditionsBannerMobileWidth { get; set; }

    public int? HotelTermsConditionsBannerTabletHieght { get; set; }

    public int? HotelTermsConditionsBannerMobileHieght { get; set; }

    public string HotelFaq { get; set; }

    public string HotelFaqTitle { get; set; }

    public string HotelFaqMetaTagTitle { get; set; }

    public string HotelFaqMetatagDescription { get; set; }

    public string HotelFaqThanks { get; set; }

    public string HotelFaqThanksTitle { get; set; }

    public string HotelFaqThanksMetaTagTitle { get; set; }

    public string HotelFaqThanksMetatagDescription { get; set; }

    public string HotelNews { get; set; }

    public string HotelNewsTitle { get; set; }

    public string HotelNewsMetaTagTitle { get; set; }

    public string HotelNewsMetatagDescription { get; set; }

    public string HotelCovid { get; set; }

    public string HotelCovidTitle { get; set; }

    public string HotelCovidMetaTagTitle { get; set; }

    public string HotelCovidMetatagDescription { get; set; }

    public string HotelCareer { get; set; }

    public string HotelCareerTitle { get; set; }

    public string HotelCareerMetaTagTitle { get; set; }

    public string HotelCareerMetatagDescription { get; set; }

    public string HotelAboutUs { get; set; }

    public string HotelAboutUsTitle { get; set; }

    public string HotelAboutUsMetaTagTitle { get; set; }

    public string HotelAboutUsMetatagDescription { get; set; }

    public string HotelPrivacy { get; set; }

    public string HotelPrivacyTitle { get; set; }

    public string HotelPrivacyMetaTagTitle { get; set; }

    public string HotelBlog { get; set; }

    public string HotelBlogTitle { get; set; }

    public string HotelBlogMetaTagTitle { get; set; }

    public string HotelBlogMetatagDescription { get; set; }

    public string HotelTermsConditions { get; set; }

    public string HotelTermsConditionsTitle { get; set; }

    public string HotelTermsConditionsMetaTagTitle { get; set; }

    public string HotelTermsConditionsMetatagDescription { get; set; }

    public string HotelPrivacyMetatagDescription { get; set; }

    public string HotelLocationBanner { get; set; }

    public string HotelLocationBannerTablet { get; set; }

    public string HotelLocationBannerMobile { get; set; }

    public string HotelLocationBannerColorOverlayFrom { get; set; }

    public string HotelLocationBannerTabletColorOverlayFrom { get; set; }

    public string HotelLocationBannerMobileColorOverlayFrom { get; set; }

    public string HotelLocationBannerColorOverlayTo { get; set; }

    public string HotelLocationBannerTabletColorOverlayTo { get; set; }

    public string HotelLocationBannerMobileColorOverlayTo { get; set; }

    public int? HotelLocationBannerPhotoWidth { get; set; }

    public int? HotelLocationBannerPhotoHieght { get; set; }

    public int? HotelLocationBannerTabletWidth { get; set; }

    public int? HotelLocationBannerTabletHieght { get; set; }

    public int? HotelLocationBannerMobileWidth { get; set; }

    public int? HotelLocationBannerMobileHieght { get; set; }

    public string HotelAllInclusiveBanner { get; set; }

    public string HotelAllInclusiveBannerTablet { get; set; }

    public string HotelAllInclusiveBannerMobile { get; set; }

    public string HotelAllInclusiveBannerColorOverlayFrom { get; set; }

    public string HotelAllInclusiveBannerTabletColorOverlayFrom { get; set; }

    public string HotelAllInclusiveBannerMobileColorOverlayFrom { get; set; }

    public string HotelAllInclusiveBannerColorOverlayTo { get; set; }

    public string HotelAllInclusiveBannerTabletColorOverlayTo { get; set; }

    public string HotelAllInclusiveBannerMobileColorOverlayTo { get; set; }

    public int? HotelAllInclusiveBannerPhotoWidth { get; set; }

    public int? HotelAllInclusiveBannerPhotoHieght { get; set; }

    public int? HotelAllInclusiveBannerTabletWidth { get; set; }

    public int? HotelAllInclusiveBannerTabletHieght { get; set; }

    public int? HotelAllInclusiveBannerMobileWidth { get; set; }

    public int? HotelAllInclusiveBannerMobileHieght { get; set; }

    public string HotelLocation { get; set; }

    public string HotelLocationTitle { get; set; }

    public string HotelLocationMetatagTitle { get; set; }

    public string HotelLocationMetatagDescription { get; set; }

    public string HotelAllInclusive { get; set; }

    public string HotelAllInclusiveTitle { get; set; }

    public string HotelAllInclusiveMetatagTitle { get; set; }

    public string HotelAllInclusiveMetatagDescription { get; set; }

    public string HotelWellnessBanner { get; set; }

    public string HotelWellnessBannerTablet { get; set; }

    public string HotelWellnessBannerMobile { get; set; }

    public string HotelWellnessBannerColorOverlayFrom { get; set; }

    public string HotelWellnessBannerTabletColorOverlayFrom { get; set; }

    public string HotelWellnessBannerColorOverlayTo { get; set; }

    public string HotelWellnessBannerMobileColorOverlayFrom { get; set; }

    public string HotelWellnessBannerMobileColorOverlayTo { get; set; }

    public string HotelWellnessBannerTabletColorOverlayTo { get; set; }

    public string HotelWellness { get; set; }

    public string HotelWellnessTitle { get; set; }

    public string HotelWellnessMetatagTitle { get; set; }

    public string HotelWellnessMetatagDescription { get; set; }

    public int? HotelWellnessBannerPhotoWidth { get; set; }

    public int? HotelWellnessBannerPhotoHieght { get; set; }

    public int? HotelWellnessBannerTabletWidth { get; set; }

    public int? HotelWellnessBannerTabletHieght { get; set; }

    public int? HotelWellnessBannerMobileWidth { get; set; }

    public int? HotelWellnessBannerMobileHieght { get; set; }

    public bool? LangStatus { get; set; }

    public string HotelLogoColored { get; set; }

    public string HotelGetDirectionLink { get; set; }

    public string HotelContactUsIcon { get; set; }

    public string HotelContactUsTitleTop { get; set; }

    public string HotelContactUsTitle { get; set; }

    public string HotelContactUsSummery { get; set; }

    public string HotelPhotoGroup { get; set; }

    public int? HotelPhotoGroupWidth { get; set; }

    public int? HotelPhotoGroupHeight { get; set; }

    public string MetatagTitle { get; set; }

    public string MetatagDescription { get; set; }

    public string HotelPhoto2 { get; set; }

    public int? HotelPhoto2Width { get; set; }

    public int? HotelPhoto2Height { get; set; }
}
