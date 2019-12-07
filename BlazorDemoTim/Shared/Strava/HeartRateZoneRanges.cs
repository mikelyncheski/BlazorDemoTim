using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {


  [DataContract]
  public class HeartRateZoneRanges {
    /// <summary>
    /// Whether the athlete has set their own custom heart rate zones
    /// </summary>
    /// <value>Whether the athlete has set their own custom heart rate zones</value>
    [DataMember(Name="custom_zones", EmitDefaultValue=false)]
    [JsonPropertyName("custom_zones")]
    public bool? CustomZones { get; set; }

    /// <summary>
    /// Gets or Sets Zones
    /// </summary>
    [DataMember(Name="zones", EmitDefaultValue=false)]
    [JsonPropertyName("zones")]
    public ZoneRanges Zones { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HeartRateZoneRanges {\n");
      sb.Append("  CustomZones: ").Append(CustomZones).Append("\n");
      sb.Append("  Zones: ").Append(Zones).Append("\n");
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
