using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {


  [DataContract]
  public class PolylineMap {
    /// <summary>
    /// The identifier of the map
    /// </summary>
    /// <value>The identifier of the map</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// The polyline of the map
    /// </summary>
    /// <value>The polyline of the map</value>
    [DataMember(Name="polyline", EmitDefaultValue=false)]
    [JsonPropertyName("polyline")]
    public string Polyline { get; set; }

    /// <summary>
    /// The summary polyline of the map
    /// </summary>
    /// <value>The summary polyline of the map</value>
    [DataMember(Name="summary_polyline", EmitDefaultValue=false)]
    [JsonPropertyName("summary_polyline")]
    public string SummaryPolyline { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PolylineMap {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Polyline: ").Append(Polyline).Append("\n");
      sb.Append("  SummaryPolyline: ").Append(SummaryPolyline).Append("\n");
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
