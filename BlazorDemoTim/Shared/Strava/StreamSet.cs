using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {


  [DataContract]
  public class StreamSet {
    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonPropertyName("time")]
    public TimeStream Time { get; set; }

    /// <summary>
    /// Gets or Sets Distance
    /// </summary>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonPropertyName("distance")]
    public DistanceStream Distance { get; set; }

    /// <summary>
    /// Gets or Sets Latlng
    /// </summary>
    [DataMember(Name="latlng", EmitDefaultValue=false)]
    [JsonPropertyName("latlng")]
    public LatLngStream Latlng { get; set; }

    /// <summary>
    /// Gets or Sets Altitude
    /// </summary>
    [DataMember(Name="altitude", EmitDefaultValue=false)]
    [JsonPropertyName("altitude")]
    public AltitudeStream Altitude { get; set; }

    /// <summary>
    /// Gets or Sets VelocitySmooth
    /// </summary>
    [DataMember(Name="velocity_smooth", EmitDefaultValue=false)]
    [JsonPropertyName("velocity_smooth")]
    public SmoothVelocityStream VelocitySmooth { get; set; }

    /// <summary>
    /// Gets or Sets Heartrate
    /// </summary>
    [DataMember(Name="heartrate", EmitDefaultValue=false)]
    [JsonPropertyName("heartrate")]
    public HeartrateStream Heartrate { get; set; }

    /// <summary>
    /// Gets or Sets Cadence
    /// </summary>
    [DataMember(Name="cadence", EmitDefaultValue=false)]
    [JsonPropertyName("cadence")]
    public CadenceStream Cadence { get; set; }

    /// <summary>
    /// Gets or Sets Watts
    /// </summary>
    [DataMember(Name="watts", EmitDefaultValue=false)]
    [JsonPropertyName("watts")]
    public PowerStream Watts { get; set; }

    /// <summary>
    /// Gets or Sets Temp
    /// </summary>
    [DataMember(Name="temp", EmitDefaultValue=false)]
    [JsonPropertyName("temp")]
    public TemperatureStream Temp { get; set; }

    /// <summary>
    /// Gets or Sets Moving
    /// </summary>
    [DataMember(Name="moving", EmitDefaultValue=false)]
    [JsonPropertyName("moving")]
    public MovingStream Moving { get; set; }

    /// <summary>
    /// Gets or Sets GradeSmooth
    /// </summary>
    [DataMember(Name="grade_smooth", EmitDefaultValue=false)]
    [JsonPropertyName("grade_smooth")]
    public SmoothGradeStream GradeSmooth { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StreamSet {\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  Latlng: ").Append(Latlng).Append("\n");
      sb.Append("  Altitude: ").Append(Altitude).Append("\n");
      sb.Append("  VelocitySmooth: ").Append(VelocitySmooth).Append("\n");
      sb.Append("  Heartrate: ").Append(Heartrate).Append("\n");
      sb.Append("  Cadence: ").Append(Cadence).Append("\n");
      sb.Append("  Watts: ").Append(Watts).Append("\n");
      sb.Append("  Temp: ").Append(Temp).Append("\n");
      sb.Append("  Moving: ").Append(Moving).Append("\n");
      sb.Append("  GradeSmooth: ").Append(GradeSmooth).Append("\n");
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
