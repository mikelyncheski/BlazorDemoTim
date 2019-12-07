using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {


  [DataContract]
  public class UpdatableActivity {
    /// <summary>
    /// Whether this activity is a commute
    /// </summary>
    /// <value>Whether this activity is a commute</value>
    [DataMember(Name="commute", EmitDefaultValue=false)]
    [JsonPropertyName("commute")]
    public bool? Commute { get; set; }

    /// <summary>
    /// Whether this activity was recorded on a training machine
    /// </summary>
    /// <value>Whether this activity was recorded on a training machine</value>
    [DataMember(Name="trainer", EmitDefaultValue=false)]
    [JsonPropertyName("trainer")]
    public bool? Trainer { get; set; }

    /// <summary>
    /// The description of the activity
    /// </summary>
    /// <value>The description of the activity</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The name of the activity
    /// </summary>
    /// <value>The name of the activity</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonPropertyName("type")]
    public ActivityType Type { get; set; }

    /// <summary>
    /// Identifier for the gear associated with the activity. ‘none’ clears gear from activity
    /// </summary>
    /// <value>Identifier for the gear associated with the activity. ‘none’ clears gear from activity</value>
    [DataMember(Name="gear_id", EmitDefaultValue=false)]
    [JsonPropertyName("gear_id")]
    public string GearId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdatableActivity {\n");
      sb.Append("  Commute: ").Append(Commute).Append("\n");
      sb.Append("  Trainer: ").Append(Trainer).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  GearId: ").Append(GearId).Append("\n");
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
