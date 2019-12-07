using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {

  /// <summary>
  /// A
  /// </summary>
  [DataContract]
  public class SegmentLeaderboard {
    /// <summary>
    /// The total number of entries for this leaderboard
    /// </summary>
    /// <value>The total number of entries for this leaderboard</value>
    [DataMember(Name="entry_count", EmitDefaultValue=false)]
    [JsonPropertyName("entry_count")]
    public int? EntryCount { get; set; }

    /// <summary>
    /// Deprecated, use entry_count
    /// </summary>
    /// <value>Deprecated, use entry_count</value>
    [DataMember(Name="effort_count", EmitDefaultValue=false)]
    [JsonPropertyName("effort_count")]
    public int? EffortCount { get; set; }

    /// <summary>
    /// Gets or Sets KomType
    /// </summary>
    [DataMember(Name="kom_type", EmitDefaultValue=false)]
    [JsonPropertyName("kom_type")]
    public string KomType { get; set; }

    /// <summary>
    /// Gets or Sets Entries
    /// </summary>
    [DataMember(Name="entries", EmitDefaultValue=false)]
    [JsonPropertyName("entries")]
    public List<SegmentLeaderboardEntry> Entries { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SegmentLeaderboard {\n");
      sb.Append("  EntryCount: ").Append(EntryCount).Append("\n");
      sb.Append("  EffortCount: ").Append(EffortCount).Append("\n");
      sb.Append("  KomType: ").Append(KomType).Append("\n");
      sb.Append("  Entries: ").Append(Entries).Append("\n");
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
