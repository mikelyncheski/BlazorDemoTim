using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {

  /// <summary>
  /// Encapsulates the errors that may be returned from the API.
  /// </summary>
  [DataContract]
  public class Fault {
    /// <summary>
    /// The set of specific errors associated with this fault, if any.
    /// </summary>
    /// <value>The set of specific errors associated with this fault, if any.</value>
    [DataMember(Name="errors", EmitDefaultValue=false)]
    [JsonPropertyName("errors")]
    public List<Error> Errors { get; set; }

    /// <summary>
    /// The message of the fault.
    /// </summary>
    /// <value>The message of the fault.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonPropertyName("message")]
    public string Message { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Fault {\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
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
