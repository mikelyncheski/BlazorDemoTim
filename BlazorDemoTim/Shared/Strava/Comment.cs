using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {


  [DataContract]
  public class Comment {
    /// <summary>
    /// The unique identifier of this comment
    /// </summary>
    /// <value>The unique identifier of this comment</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// The identifier of the activity this comment is related to
    /// </summary>
    /// <value>The identifier of the activity this comment is related to</value>
    [DataMember(Name="activity_id", EmitDefaultValue=false)]
    [JsonPropertyName("activity_id")]
    public long? ActivityId { get; set; }

    /// <summary>
    /// The content of the comment
    /// </summary>
    /// <value>The content of the comment</value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonPropertyName("text")]
    public string Text { get; set; }

    /// <summary>
    /// Gets or Sets Athlete
    /// </summary>
    [DataMember(Name="athlete", EmitDefaultValue=false)]
    [JsonPropertyName("athlete")]
    public SummaryAthlete Athlete { get; set; }

    /// <summary>
    /// The time at which this comment was created.
    /// </summary>
    /// <value>The time at which this comment was created.</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Comment {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Athlete: ").Append(Athlete).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
