using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TravelServices.Logic.Models
{

    #region Session
  
    [DataContract]
    public class SessionInputs
    {
        [DataMember(Name = "type")]
        public int? Type { get; set; }

        [DataMember(Name = "connection")]
        public Connection Connection { get; set; }

        [DataMember(Name = "application")]
        public Application Application { get; set; }
        [DataMember(Name = "browser")]
        public Browser Browser { get; set; }


    }
    [DataContract]
    public class Connection
    {
        [DataMember(Name = "ip-address")]
        public string IpAddress { get; set; }

        [DataMember(Name = "port")]
        public string Port { get; set; }
    }
    [DataContract]
    public class Application
    {
        [DataMember(Name = "version")]
        public string Version { get; set; }

        [DataMember(Name = "equipment-id")]
        public string EquipmentId { get; set; }
    }

    [DataContract]
    public class Browser
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "version")]
        public string Version { get; set; }
    }

    public class SessionOutput
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("user-message")]
        public string UserMessage { get; set; }
        [JsonProperty("api-request-id")]
        public string ApiRequestId { get; set; }
        [JsonProperty("controller")]
        public string Controller { get; set; }
        [JsonProperty("client-request-id")]
        public string ClientRequestId { get; set; }
        [JsonProperty("data")]
        public SessionData Data { get; set; }
    }
    public class SessionData
    {
        [JsonProperty("session-id")]
        public string SessionId { get; set; }
        [JsonProperty("device-id")]
        public string DeviceId { get; set; }
        [JsonProperty("affiliate")]
        public string Affiliate { get; set; }
        [JsonProperty("device-type")]
        public int? DeviceType { get; set; }
        [JsonProperty("device")]
        public string Device { get; set; }
    }
    #endregion

    #region Location

    [DataContract]
    public class LocationInputs
    {
        [DataMember(Name = "data")]
        public string Data { get; set; }

        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "language")]
        public string Language { get; set; }
        [DataMember(Name = "device-session")]
        public DeviceSession DeviceSession { get; set; }


    }
    [DataContract]
    public class DeviceSession
    {
        [DataMember(Name = "session-id")]
        public string SessionId { get; set; }
        [DataMember(Name = "device-id")]
        public string DeviceId { get; set; }
    }
    public class LocationOutput
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("user-message")]
        public string UserMessage { get; set; }
        [JsonProperty("api-request-id")]
        public string ApiRequestId { get; set; }
        [JsonProperty("controller")]
        public string Controller { get; set; }
        [JsonProperty("client-request-id")]
        public string ClientRequestId { get; set; }
        [JsonProperty("data")]
        public List<LocationData> Data { get; set; }
    }
    public class LocationData
    {
        [JsonProperty("id")]
        public int? Id { get; set; }
        [JsonProperty("parent-id")]
        public int? ParentId { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("zoom")]
        public int? Zoom { get; set; }
        [JsonProperty("tz-code")]
        public string TzCode { get; set; }
        [JsonProperty("weather-code")]
        public string WeatherCode { get; set; }
        [JsonProperty("rank")]
        public int? Rank { get; set; }
        [JsonProperty("reference-code")]
        public string ReferenceCode { get; set; }
        [JsonProperty("keywords")]
        public string Keywords { get; set; }
        [JsonProperty("geo-location")]
        public GeoLocation GeoLocation { get; set; }
    }

    public class GeoLocation
    {
        [JsonProperty("latitude")]
        public double? Latitude { get; set; }
        [JsonProperty("longitude")]
        public double? Longitude { get; set; }
        [JsonProperty("zoom")]
        public int? Zoom { get; set; }
    }
    #endregion

    #region Journey
    [DataContract]
    public class JourneyInputs
    {
        [DataMember(Name = "date")]
        public string Date { get; set; }
        [DataMember(Name = "language")]
        public string Language { get; set; }
        [DataMember(Name = "device-session")]
        public DeviceSession DeviceSession { get; set; }
        [DataMember(Name = "data")]
        public JourneyInputData Data { get; set; }

    }
    [DataContract]
    public class JourneyInputData
    {
        [DataMember(Name = "origin-id")]
        public int? OriginId { get; set; }
        [DataMember(Name = "destination-id")]
        public int? DestinationId { get; set; }
        [DataMember(Name = "departure-date")]
        public string DepartureDate { get; set; }
    }
    public class JourneyOutput
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("user-message")]
        public string UserMessage { get; set; }
        [JsonProperty("api-request-id")]
        public string ApiRequestId { get; set; }
        [JsonProperty("controller")]
        public string Controller { get; set; }
        [JsonProperty("client-request-id")]
        public string ClientRequestId { get; set; }
        [JsonProperty("data")]
        public List<JourneyData> Data { get; set; }
    }
    public class JourneyData
    {
        [JsonProperty("id")]
        public int? Id { get; set; }
        [JsonProperty("parent-id")]
        public int? ParentId { get; set; }
        [JsonProperty("partner-name")]
        public string PartnerName { get; set; }
        [JsonProperty("route-id")]
        public string RouteId { get; set; }
        [JsonProperty("rank")]
        public int? Rank { get; set; }
        [JsonProperty("bus-type")]
        public string BusType { get; set; }
        [JsonProperty("bus-type-name")]
        public string BusTypeName { get; set; }
        [JsonProperty("total-seats")]
        public int? TotalSeats { get; set; }
        [JsonProperty("available-seats")]
        public int? AvailableSeats { get; set; }
        [JsonProperty("origin-location")]
        public string OriginLocation { get; set; }
        [JsonProperty("destination-location")]
        public string DestinationLocation { get; set; }
        [JsonProperty("is-active")]
        public bool IsActive { get; set; }
        [JsonProperty("origin-location-id")]
        public int? OriginLocationId { get; set; }
        [JsonProperty("destination-location-id")]
        public int? DestinationLocationId { get; set; }
        [JsonProperty("is-promoted")]
        public bool IsPromoted { get; set; }
        [JsonProperty("cancellation-offset")]
        public int? CancellationOffset { get; set; }
        [JsonProperty("has-bus-shuttle")]
        public bool HasBusShuttle { get; set; }
        [JsonProperty("disable-sales-without-gov-id")]
        public bool DisableSalesWithoutGovId { get; set; }
        [JsonProperty("display-offset")]
        public string DisplayOffset { get; set; }
        [JsonProperty("partner-rating")]
        public double? PartnerRating { get; set; }
        [JsonProperty("has-dynamic-pricing")]
        public bool HasDynamicPricing { get; set; }
        [JsonProperty("disable-sales-without-hes-code")]
        public bool DisableSalesWithoutHesCode { get; set; }
        [JsonProperty("disable-single-seat-selection")]
        public bool DisableSingleSeatSelection { get; set; }
        [JsonProperty("change-offset")]
        public int? ChangeOffset { get; set; }
        [JsonProperty("display-coupon-code-input")]
        public bool DisplayCouponCodeInput { get; set; }
        [JsonProperty("disable-sales-without-date-of-birth")]
        public bool DisableSalesWithoutDateOfBirth { get; set; }

        [JsonProperty("journey")]
        public Journey Journey { get; set; }

        [JsonProperty("features")]
        public List<Features> Features { get; set; }
    }
    public class Journey
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("departure")]
        public string Departure { get; set; }

        [JsonProperty("arrival")]
        public string Arrival { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("duration")]
        public string Duration { get; set; }
        [JsonProperty("original-price")]
        public double? OriginalPrice { get; set; }
        [JsonProperty("internet-price")]
        public double? InternetPrice { get; set; }
        [JsonProperty("provider-internet-price")]
        public string ProviderInternetPrice { get; set; }
        [JsonProperty("booking")]
        public string Booking { get; set; }
        [JsonProperty("bus-name")]
        public string BusName { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("available")]
        public string Available { get; set; }
        [JsonProperty("features")]
        public List<string> features { get; set; }

        [JsonProperty("stops")]
        public List<Stops> Stops { get; set; }

        [JsonProperty("policy")]
        public Policy Policy { get; set; }
    }
    public class Stops
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("station")]
        public string Station { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("is-origin")]
        public bool IsOrigin { get; set; }

        [JsonProperty("is-destination")]
        public bool IsDestination { get; set; }
    }
    public class Policy
    {
        [JsonProperty("max-seats")]
        public string MaxSeats { get; set; }

        [JsonProperty("max-single")]
        public string MaxSingle { get; set; }

        [JsonProperty("max-single-males")]
        public string MaxSingleMales { get; set; }

        [JsonProperty("max-single-females")]
        public string MaxSingleFemales { get; set; }
        [JsonProperty("mixed-genders")]
        public string MixedGenders { get; set; }
        [JsonProperty("gov-id")]
        public bool GovId { get; set; }
        [JsonProperty("lht")]
        public bool Lht { get; set; }
    }
    public class Features
    {
        [JsonProperty("id")]
        public int? Id { get; set; }
        [JsonProperty("priority")]
        public int? Priority { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("is-promoted")]
        public bool IsPromoted { get; set; }
        [JsonProperty("back-color")]
        public string BackColor { get; set; }
        [JsonProperty("fore-color")]
        public string ForeColor { get; set; }
    }
    public class TravelInput
    {
        public int OriginId { get; set; }
        public int DestinationId { get; set; }
        public string DepartureDate { get; set; }
    }
    #endregion
}
