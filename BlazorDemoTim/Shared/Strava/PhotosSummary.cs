using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {


  [DataContract]
  public class PhotosSummary {
    /// <summary>
    /// The number of photos
    /// </summary>
    /// <value>The number of photos</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// Gets or Sets Primary
    /// </summary>
    [DataMember(Name="primary", EmitDefaultValue=false)]
    [JsonPropertyName("primary")]
    public PhotosSummaryPrimary Primary { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PhotosSummary {\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Primary: ").Append(Primary).Append("\n");
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
