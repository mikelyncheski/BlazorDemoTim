using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {


  [DataContract]
  public class SummarySegmentEffort {
    /// <summary>
    /// The unique identifier of this effort
    /// </summary>
    /// <value>The unique identifier of this effort</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// The effort's elapsed time
    /// </summary>
    /// <value>The effort's elapsed time</value>
    [DataMember(Name="elapsed_time", EmitDefaultValue=false)]
    [JsonPropertyName("elapsed_time")]
    public int? ElapsedTime { get; set; }

    /// <summary>
    /// The time at which the effort was started.
    /// </summary>
    /// <value>The time at which the effort was started.</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// The time at which the effort was started in the local timezone.
    /// </summary>
    /// <value>The time at which the effort was started in the local timezone.</value>
    [DataMember(Name="start_date_local", EmitDefaultValue=false)]
    [JsonPropertyName("start_date_local")]
    public DateTime? StartDateLocal { get; set; }

    /// <summary>
    /// The effort's distance in meters
    /// </summary>
    /// <value>The effort's distance in meters</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonPropertyName("distance")]
    public float? Distance { get; set; }

    /// <summary>
    /// Whether this effort is the current best on the leaderboard
    /// </summary>
    /// <value>Whether this effort is the current best on the leaderboard</value>
    [DataMember(Name="is_kom", EmitDefaultValue=false)]
    [JsonPropertyName("is_kom")]
    public bool? IsKom { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SummarySegmentEffort {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ElapsedTime: ").Append(ElapsedTime).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  StartDateLocal: ").Append(StartDateLocal).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  IsKom: ").Append(IsKom).Append("\n");
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
