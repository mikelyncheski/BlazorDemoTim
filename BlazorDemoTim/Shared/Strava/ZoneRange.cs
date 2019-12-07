using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {


  [DataContract]
  public class ZoneRange {
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ZoneRange {\n");
      sb.Append("  Min: ").Append(Min).Append("\n");
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
