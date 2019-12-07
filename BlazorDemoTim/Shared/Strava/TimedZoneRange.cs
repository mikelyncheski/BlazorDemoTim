using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {

  /// <summary>
  /// A union type representing the time spent in a given zone.
  /// </summary>
  [DataContract]
  public class TimedZoneRange {
    /// <summary>
    /// The minimum value in the range.
    /// </summary>
    /// <value>The minimum value in the range.</value>
    [DataMember(Name="min", EmitDefaultValue=false)]
    [JsonPropertyName("min")]
    public int? Min { get; set; }

    /// <summary>
    /// The maximum value in the range.
    /// </summary>
    /// <value>The maximum value in the range.</value>
    [DataMember(Name="max", EmitDefaultValue=false)]
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary>
    /// The number of seconds spent in this zone
    /// </summary>
    /// <value>The number of seconds spent in this zone</value>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonPropertyName("time")]
    public int? Time { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TimedZoneRange {\n");
      sb.Append("  Min: ").Append(Min).Append("\n");
      sb.Append("  Max: ").Append(Max).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
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
