using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {


  [DataContract]
  public class Error {
    /// <summary>
    /// The code associated with this error.
    /// </summary>
    /// <value>The code associated with this error.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonPropertyName("code")]
    public string Code { get; set; }

    /// <summary>
    /// The specific field or aspect of the resource associated with this error.
    /// </summary>
    /// <value>The specific field or aspect of the resource associated with this error.</value>
    [DataMember(Name="field", EmitDefaultValue=false)]
    [JsonPropertyName("field")]
    public string Field { get; set; }

    /// <summary>
    /// The type of resource associated with this error.
    /// </summary>
    /// <value>The type of resource associated with this error.</value>
    [DataMember(Name="resource", EmitDefaultValue=false)]
    [JsonPropertyName("resource")]
    public string Resource { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Error {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Field: ").Append(Field).Append("\n");
      sb.Append("  Resource: ").Append(Resource).Append("\n");
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
