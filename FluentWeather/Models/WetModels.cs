﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FluentWeather.Models
{
    //list of units
    public enum WetUnits
    {
        m = 0, //metric
        e = 1, //imperial
        h = 2, //hybrid
        s = 3 //metric SI
    }

    public class Locale
    {
        public string locale1 { get; set; }
        public string locale2 { get; set; }
        public object locale3 { get; set; }
        public object locale4 { get; set; }
    }

    public class SearchedLocation
    {
        public string address { get; set; }
        public Locale locale { get; set; }
        public string displayName { get; set; }
        public string ianaTimeZone { get; set; }
        public string adminDistrict { get; set; }
        public object adminDistrictCode { get; set; }
        public string city { get; set; }
        public double longitude { get; set; }
        public string postalCode { get; set; }
        public double latitude { get; set; }
        public string placeId { get; set; }
        public object neighborhood { get; set; }
        public string country { get; set; }
        public string postalKey { get; set; }
        public string countryCode { get; set; }
        public bool disputedArea { get; set; }
        public object disputedCountries { get; set; }
        public object disputedCountryCodes { get; set; }
        public object disputedCustomers { get; set; }
        public List<bool> disputedShowCountry { get; set; }
        public string iataCode { get; set; }
        public string icaoCode { get; set; }
        public string locId { get; set; }
        public object locationCategory { get; set; }
        public string pwsId { get; set; }
        public string type { get; set; }
    }

    public class SearchLocationResponse
    {
        public List<SearchedLocation> location { get; set; }
    }


    public class Daypart
    {
        public List<int?> cloudCover { get; set; }
        public List<string> dayOrNight { get; set; }
        public List<string> daypartName { get; set; }
        public List<int?> iconCode { get; set; }
        public List<int?> iconCodeExtend { get; set; }
        public List<string> narrative { get; set; }
        public List<int?> precipChance { get; set; }
        public List<string> precipType { get; set; }
        public List<double?> qpf { get; set; }
        public List<double?> qpfSnow { get; set; }
        public List<string> qualifierCode { get; set; }
        public List<string> qualifierPhrase { get; set; }
        public List<int?> relativeHumidity { get; set; }
        public List<string> snowRange { get; set; }
        public List<int?> temperature { get; set; }
        public List<int?> temperatureHeatIndex { get; set; }
        public List<int?> temperatureWindChill { get; set; }
        public List<string> thunderCategory { get; set; }
        public List<int?> thunderIndex { get; set; }
        public List<string> uvDescription { get; set; }
        public List<int?> uvIndex { get; set; }
        public List<int?> windDirection { get; set; }
        public List<string> windDirectionCardinal { get; set; }
        public List<string> windPhrase { get; set; }
        public List<int?> windSpeed { get; set; }
        public List<string> wxPhraseLong { get; set; }
        public List<string> wxPhraseShort { get; set; }
    }


    public class LocationV3
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string city { get; set; }
        public Locale locale { get; set; }
        public string neighborhood { get; set; }
        public string adminDistrict { get; set; }
        public string adminDistrictCode { get; set; }
        public string postalCode { get; set; }
        public string postalKey { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string ianaTimeZone { get; set; }
        public string displayName { get; set; }
        public DateTimeOffset? dstEnd { get; set; }
        public DateTimeOffset? dstStart { get; set; }
        public string dmaCd { get; set; }
        public string placeId { get; set; }
        public bool disputedArea { get; set; }
        public object disputedCountries { get; set; }
        public object disputedCountryCodes { get; set; }
        public object disputedCustomers { get; set; }
        public List<bool> disputedShowCountry { get; set; }
        public string canonicalCityId { get; set; }
        public string countyId { get; set; }
        public string locId { get; set; }
        public object locationCategory { get; set; }
        public string pollenId { get; set; }
        public string pwsId { get; set; }
        public string regionalSatellite { get; set; }
        public object tideId { get; set; }
        public string type { get; set; }
        public string zoneId { get; set; }
    }

    public class RootV3Response
    {
        public string id { get; set; }

        [JsonProperty("v3-wx-observations-current")]
        public V3WxObservationsCurrent v3wxobservationscurrent { get; set; }

        [JsonProperty("v3-wx-forecast-daily-15day")]
        public V3WxForecastDaily v3wxforecastdaily15day { get; set; }

        [JsonProperty("v3-wx-forecast-daily-10day")]
        public V3WxForecastDaily v3wxforecastdaily10day { get; set; }

        [JsonProperty("v3-wx-forecast-hourly-10day")]
        public V3WxForecastHourly v3wxforecasthourly10day { get; set; }

        public object v3alertsHeadlines { get; set; }

        [JsonProperty("v3-location-point")] public V3LocationPoint v3locationpoint { get; set; }

        [JsonProperty("v2idxDriveDaypart10")] public V2idxDriveDaypartResult v2idxDriveDaypart10days { get; set; }

        [JsonProperty("v2idxRunDaypart10")] public V2idxRunDaypartResult v2idxRunDaypart10days { get; set; }

        [JsonProperty("v2idxPollenDaypart10")] public V2idxPollenDaypartResult v2idxPollenDaypart10days { get; set; }

        [JsonProperty("v2idxWateringDaypart10")]
        public V2idxWateringDaypartResult V2IdxWateringDaypart10days { get; set; }

        [JsonProperty("v2idxDrySkinDaypart10")]
        public V2idxDrySkinDaypartResult V2IdxDrySkinDaypart10days { get; set; }
    }


    public class V3WxForecastHourly
    {
        public List<int> cloudCover { get; set; }
        public List<string> dayOfWeek { get; set; }
        public List<string> dayOrNight { get; set; }
        public List<int> expirationTimeUtc { get; set; }
        public List<int> iconCode { get; set; }
        public List<int> iconCodeExtend { get; set; }
        public List<int> precipChance { get; set; }
        public List<string> precipType { get; set; }
        public List<double> pressureMeanSeaLevel { get; set; }
        public List<double> qpf { get; set; }
        public List<double> qpfSnow { get; set; }
        public List<int> relativeHumidity { get; set; }
        public List<int> temperature { get; set; }
        public List<int> temperatureDewPoint { get; set; }
        public List<int?> temperatureFeelsLike { get; set; }
        public List<int> temperatureHeatIndex { get; set; }
        public List<int> temperatureWindChill { get; set; }
        public List<string> uvDescription { get; set; }
        public List<int> uvIndex { get; set; }
        public List<DateTimeOffset> validTimeLocal { get; set; }
        public List<int> validTimeUtc { get; set; }
        public List<double> visibility { get; set; }
        public List<int> windDirection { get; set; }
        public List<string> windDirectionCardinal { get; set; }
        public List<int?> windGust { get; set; }
        public List<int> windSpeed { get; set; }
        public List<string> wxPhraseLong { get; set; }
        public List<string> wxPhraseShort { get; set; }
        public List<int> wxSeverity { get; set; }
    }


    public class RootStandaloneHourlyResponse
    {
        [JsonProperty("v3-wx-forecast-hourly-10day")]
        public V3WxForecastHourly v3wxforecasthourly10day { get; set; }
    }

    public class V3LocationPoint
    {
        [JsonProperty("location")] public LocationV3 LocationV3 { get; set; }
    }

    public class V3WxForecastDaily
    {
        public List<int?> calendarDayTemperatureMax { get; set; }
        public List<int> calendarDayTemperatureMin { get; set; }
        public List<string> dayOfWeek { get; set; }
        public List<int> expirationTimeUtc { get; set; }
        public List<string> moonPhase { get; set; }
        public List<string> moonPhaseCode { get; set; }
        public List<int> moonPhaseDay { get; set; }
        public List<DateTimeOffset?> moonriseTimeLocal { get; set; }
        public List<int?> moonriseTimeUtc { get; set; }
        public List<DateTimeOffset?> moonsetTimeLocal { get; set; }
        public List<int?> moonsetTimeUtc { get; set; }
        public List<string> narrative { get; set; }
        public List<double?> qpf { get; set; }
        public List<double> qpfSnow { get; set; }
        public List<DateTimeOffset?> sunriseTimeLocal { get; set; }
        public List<int?> sunriseTimeUtc { get; set; }
        public List<DateTimeOffset?> sunsetTimeLocal { get; set; }
        public List<int?> sunsetTimeUtc { get; set; }
        public List<int?> temperatureMax { get; set; }
        public List<int> temperatureMin { get; set; }
        public List<DateTimeOffset> validTimeLocal { get; set; }
        public List<int> validTimeUtc { get; set; }
        public List<Daypart> daypart { get; set; }
    }


    public class V3WxObservationsCurrent
    {
        public object cloudCeiling { get; set; }
        public string cloudCoverPhrase { get; set; }
        public string dayOfWeek { get; set; }
        public string dayOrNight { get; set; }
        public int expirationTimeUtc { get; set; }
        public int iconCode { get; set; }
        public int iconCodeExtend { get; set; }
        public object obsQualifierCode { get; set; }
        public object obsQualifierSeverity { get; set; }
        public double precip1Hour { get; set; }
        public double precip6Hour { get; set; }
        public double precip24Hour { get; set; }
        public double pressureAltimeter { get; set; }
        public double pressureChange { get; set; }
        public double pressureMeanSeaLevel { get; set; }
        public int pressureTendencyCode { get; set; }
        public string pressureTendencyTrend { get; set; }
        public int relativeHumidity { get; set; }
        public double snow1Hour { get; set; }
        public double snow6Hour { get; set; }
        public double snow24Hour { get; set; }
        public DateTimeOffset sunriseTimeLocal { get; set; }
        public int sunriseTimeUtc { get; set; }
        public DateTimeOffset sunsetTimeLocal { get; set; }
        public int sunsetTimeUtc { get; set; }
        public int temperature { get; set; }
        public int temperatureChange24Hour { get; set; }
        public int temperatureDewPoint { get; set; }
        public int temperatureFeelsLike { get; set; }
        public int temperatureHeatIndex { get; set; }
        public int temperatureMax24Hour { get; set; }
        public int temperatureMaxSince7Am { get; set; }
        public int temperatureMin24Hour { get; set; }
        public int temperatureWindChill { get; set; }
        public string uvDescription { get; set; }
        public int uvIndex { get; set; }
        public DateTimeOffset validTimeLocal { get; set; }
        public int validTimeUtc { get; set; }
        public double visibility { get; set; }
        public int windDirection { get; set; }
        public string windDirectionCardinal { get; set; }
        public int? windGust { get; set; }
        public int windSpeed { get; set; }
        public string wxPhraseLong { get; set; }
        public object wxPhraseMedium { get; set; }
        public object wxPhraseShort { get; set; }
    }


    //driving difficulty index

    public class DrivingDifficultyIndexDaypart
    {
        public List<int> fcstValid { get; set; }
        public List<DateTimeOffset> fcstValidLocal { get; set; }
        public List<string> dayInd { get; set; }
        public List<int> num { get; set; }
        public List<string> daypartName { get; set; }
        public List<int> drivingDifficultyIndex { get; set; }
        public List<string> drivingDifficultyCategory { get; set; }
    }

    public class Metadata
    {
        public string language { get; set; }
        public string transactionId { get; set; }
        public string version { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int expireTimeGmt { get; set; }
        public int statusCode { get; set; }
    }

    public class V2idxDriveDaypartResult
    {
        public Metadata metadata { get; set; }

        [JsonProperty("drivingDifficultyIndex12hour")]
        public DrivingDifficultyIndexDaypart drivingDifficultyIndex12hour { get; set; }
    }


    //running index

    public class RunWeatherIndexDaypart
    {
        public List<int> fcstValid { get; set; }
        public List<DateTimeOffset> fcstValidLocal { get; set; }
        public List<string> dayInd { get; set; }
        public List<int> num { get; set; }
        public List<string> daypartName { get; set; }
        public List<int> longRunWeatherIndex { get; set; }
        public List<string> longRunWeatherCategory { get; set; }
        public List<int> shortRunWeatherIndex { get; set; }
        public List<string> shortRunWeatherCategory { get; set; }
    }

    public class V2idxRunDaypartResult
    {
        public Metadata metadata { get; set; }

        [JsonProperty("runWeatherIndex12hour")]
        public RunWeatherIndexDaypart RunWeatherIndexDaypart { get; set; }
    }


    //pollen index

    public class PollenForecastDaypart
    {
        public List<int> fcstValid { get; set; }
        public List<DateTime> fcstValidLocal { get; set; }
        public List<string> dayInd { get; set; }
        public List<int> num { get; set; }
        public List<string> daypartName { get; set; }
        public List<int> grassPollenIndex { get; set; }
        public List<string> grassPollenCategory { get; set; }
        public List<int> treePollenIndex { get; set; }
        public List<string> treePollenCategory { get; set; }
        public List<int> ragweedPollenIndex { get; set; }
        public List<string> ragweedPollenCategory { get; set; }
    }


    public class V2idxPollenDaypartResult
    {
        public Metadata metadata { get; set; }

        [JsonProperty("pollenForecast12hour")] public PollenForecastDaypart PollenForecastDaypart { get; set; }
    }


    //watering needs index

    public class V2idxWateringDaypartResult
    {
        public Metadata metadata { get; set; }

        [JsonProperty("wateringNeedsIndex12hour")]
        public WateringNeedsIndexDaypart WateringNeedsIndexDaypart { get; set; }
    }

    public class WateringNeedsIndexDaypart
    {
        public List<int> fcstValid { get; set; }
        public List<DateTime> fcstValidLocal { get; set; }
        public List<string> dayInd { get; set; }
        public List<int> num { get; set; }
        public List<string> daypartName { get; set; }
        public List<int> wateringNeedsIndex { get; set; }
        public List<string> wateringNeedsCategory { get; set; }
    }


    //dry skin index

    public class DrySkinIndexDaypart
    {
        public List<int> fcstValid { get; set; }
        public List<DateTime> fcstValidLocal { get; set; }
        public List<string> dayInd { get; set; }
        public List<int> num { get; set; }
        public List<string> daypartName { get; set; }
        public List<int> drySkinIndex { get; set; }
        public List<string> drySkinCategory { get; set; }
    }

    public class V2idxDrySkinDaypartResult
    {
        public Metadata metadata { get; set; }

        [JsonProperty("drySkinIndex12hour")] public DrySkinIndexDaypart DrySkinIndexDaypart { get; set; }
    }
}
