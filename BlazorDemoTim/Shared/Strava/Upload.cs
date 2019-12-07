using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {


  [DataContract]
  public class Upload {
    /// <summary>
    /// The unique identifier of the upload
    /// </summary>
    /// <value>The unique identifier of the upload</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// The external identifier of the upload
    /// </summary>
    /// <value>The external identifier of the upload</value>
    [DataMember(Name="external_id", EmitDefaultValue=false)]
    [JsonPropertyName("external_id")]
    public string ExternalId { get; set; }

    /// <summary>
    /// The error associated with this upload
    /// </summary>
    /// <value>The error associated with this upload</value>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonPropertyName("error")]
    public string Error { get; set; }

    /// <summary>
    /// The status of this upload
    /// </summary>
    /// <value>The status of this upload</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>
    /// The identifier of the activity this upload resulted into
    /// </summary>
    /// <value>The identifier of the activity this upload resulted into</value>
    [DataMember(Name="activity_id", EmitDefaultValue=false)]
    [JsonPropertyName("activity_id")]
    public long? ActivityId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Upload {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
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