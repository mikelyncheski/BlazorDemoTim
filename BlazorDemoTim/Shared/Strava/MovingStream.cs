using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {


  [DataContract]
  public class MovingStream {
    /// <summary>
    /// The number of data points in this stream
    /// </summary>
    /// <value>The number of data points in this stream</value>
    [DataMember(Name="original_size", EmitDefaultValue=false)]
    [JsonPropertyName("original_size")]
    public int? OriginalSize { get; set; }

    /// <summary>
    /// The level of detail (sampling) in which this stream was returned
    /// </summary>
    /// <value>The level of detail (sampling) in which this stream was returned</value>
    [DataMember(Name="resolution", EmitDefaultValue=false)]
    [JsonPropertyName("resolution")]
    public string Resolution { get; set; }

    /// <summary>
    /// The base series used in the case the stream was downsampled
    /// </summary>
    /// <value>The base series used in the case the stream was downsampled</value>
    [DataMember(Name="series_type", EmitDefaultValue=false)]
    [JsonPropertyName("series_type")]
    public string SeriesType { get; set; }

    /// <summary>
    /// The sequence of moving values for this stream, as boolean values
    /// </summary>
    /// <value>The sequence of moving values for this stream, as boolean values</value>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonPropertyName("data")]
    public List<bool?> Data { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MovingStream {\n");
      sb.Append("  OriginalSize: ").Append(OriginalSize).Append("\n");
      sb.Append("  Resolution: ").Append(Resolution).Append("\n");
      sb.Append("  SeriesType: ").Append(SeriesType).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
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
