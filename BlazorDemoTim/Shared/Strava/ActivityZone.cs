using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {


  [DataContract]
  public class ActivityZone {
    /// <summary>
    /// Gets or Sets Score
    /// </summary>
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonPropertyName("score")]
    public int? Score { get; set; }

    /// <summary>
    /// Gets or Sets DistributionBuckets
    /// </summary>
    [DataMember(Name="distribution_buckets", EmitDefaultValue=false)]
    [JsonPropertyName("distribution_buckets")]
    public TimedZoneDistribution DistributionBuckets { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets SensorBased
    /// </summary>
    [DataMember(Name="sensor_based", EmitDefaultValue=false)]
    [JsonPropertyName("sensor_based")]
    public bool? SensorBased { get; set; }

    /// <summary>
    /// Gets or Sets Points
    /// </summary>
    [DataMember(Name="points", EmitDefaultValue=false)]
    [JsonPropertyName("points")]
    public int? Points { get; set; }

    /// <summary>
    /// Gets or Sets CustomZones
    /// </summary>
    [DataMember(Name="custom_zones", EmitDefaultValue=false)]
    [JsonPropertyName("custom_zones")]
    public bool? CustomZones { get; set; }

    /// <summary>
    /// Gets or Sets Max
    /// </summary>
    [DataMember(Name="max", EmitDefaultValue=false)]
    [JsonPropertyName("max")]
    public int? Max { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActivityZone {\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  DistributionBuckets: ").Append(DistributionBuckets).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  SensorBased: ").Append(SensorBased).Append("\n");
      sb.Append("  Points: ").Append(Points).Append("\n");
      sb.Append("  CustomZones: ").Append(CustomZones).Append("\n");
      sb.Append("  Max: ").Append(Max).Append("\n");
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
