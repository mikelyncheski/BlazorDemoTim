using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {


  [DataContract]
  public class RunningRace {
    /// <summary>
    /// The unique identifier of this race.
    /// </summary>
    /// <value>The unique identifier of this race.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of this race.
    /// </summary>
    /// <value>The name of this race.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The type of this race.
    /// </summary>
    /// <value>The type of this race.</value>
    [DataMember(Name="running_race_type", EmitDefaultValue=false)]
    [JsonPropertyName("running_race_type")]
    public int? RunningRaceType { get; set; }

    /// <summary>
    /// The race's distance, in meters.
    /// </summary>
    /// <value>The race's distance, in meters.</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonPropertyName("distance")]
    public float? Distance { get; set; }

    /// <summary>
    /// The time at which the race begins started in the local timezone.
    /// </summary>
    /// <value>The time at which the race begins started in the local timezone.</value>
    [DataMember(Name="start_date_local", EmitDefaultValue=false)]
    [JsonPropertyName("start_date_local")]
    public DateTime? StartDateLocal { get; set; }

    /// <summary>
    /// The name of the city in which the race is taking place.
    /// </summary>
    /// <value>The name of the city in which the race is taking place.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonPropertyName("city")]
    public string City { get; set; }

    /// <summary>
    /// The name of the state or geographical region in which the race is taking place.
    /// </summary>
    /// <value>The name of the state or geographical region in which the race is taking place.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonPropertyName("state")]
    public string State { get; set; }

    /// <summary>
    /// The name of the country in which the race is taking place.
    /// </summary>
    /// <value>The name of the country in which the race is taking place.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonPropertyName("country")]
    public string Country { get; set; }

    /// <summary>
    /// The set of routes that cover this race's course.
    /// </summary>
    /// <value>The set of routes that cover this race's course.</value>
    [DataMember(Name="route_ids", EmitDefaultValue=false)]
    [JsonPropertyName("route_ids")]
    public List<int?> RouteIds { get; set; }

    /// <summary>
    /// The unit system in which the race should be displayed.
    /// </summary>
    /// <value>The unit system in which the race should be displayed.</value>
    [DataMember(Name="measurement_preference", EmitDefaultValue=false)]
    [JsonPropertyName("measurement_preference")]
    public string MeasurementPreference { get; set; }

    /// <summary>
    /// The vanity URL of this race on Strava.
    /// </summary>
    /// <value>The vanity URL of this race on Strava.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>
    /// The URL of this race's website.
    /// </summary>
    /// <value>The URL of this race's website.</value>
    [DataMember(Name="website_url", EmitDefaultValue=false)]
    [JsonPropertyName("website_url")]
    public string WebsiteUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RunningRace {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RunningRaceType: ").Append(RunningRaceType).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  StartDateLocal: ").Append(StartDateLocal).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  RouteIds: ").Append(RouteIds).Append("\n");
      sb.Append("  MeasurementPreference: ").Append(MeasurementPreference).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
        return System.Text.Json.JsonSerializer.Serialize(this, BlazorDemoTim.Shared.JsonOptions.Default);
    }

}
}
