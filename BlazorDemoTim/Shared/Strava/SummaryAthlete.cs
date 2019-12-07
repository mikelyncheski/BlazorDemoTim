using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace Strava.NET.Model {


  [DataContract]
  public class SummaryAthlete {
    /// <summary>
    /// The unique identifier of the athlete
    /// </summary>
    /// <value>The unique identifier of the athlete</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>
    /// Resource state, indicates level of detail. Possible values: 1 -> \"meta\", 2 -> \"summary\", 3 -> \"detail\"
    /// </summary>
    /// <value>Resource state, indicates level of detail. Possible values: 1 -> \"meta\", 2 -> \"summary\", 3 -> \"detail\"</value>
    [DataMember(Name="resource_state", EmitDefaultValue=false)]
    [JsonPropertyName("resource_state")]
    public int? ResourceState { get; set; }

    /// <summary>
    /// The athlete's first name.
    /// </summary>
    /// <value>The athlete's first name.</value>
    [DataMember(Name="firstname", EmitDefaultValue=false)]
    [JsonPropertyName("firstname")]
    public string Firstname { get; set; }

    /// <summary>
    /// The athlete's last name.
    /// </summary>
    /// <value>The athlete's last name.</value>
    [DataMember(Name="lastname", EmitDefaultValue=false)]
    [JsonPropertyName("lastname")]
    public string Lastname { get; set; }

    /// <summary>
    /// URL to a 62x62 pixel profile picture.
    /// </summary>
    /// <value>URL to a 62x62 pixel profile picture.</value>
    [DataMember(Name="profile_medium", EmitDefaultValue=false)]
    [JsonPropertyName("profile_medium")]
    public string ProfileMedium { get; set; }

    /// <summary>
    /// URL to a 124x124 pixel profile picture.
    /// </summary>
    /// <value>URL to a 124x124 pixel profile picture.</value>
    [DataMember(Name="profile", EmitDefaultValue=false)]
    [JsonPropertyName("profile")]
    public string Profile { get; set; }

    /// <summary>
    /// The athlete's city.
    /// </summary>
    /// <value>The athlete's city.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonPropertyName("city")]
    public string City { get; set; }

    /// <summary>
    /// The athlete's state or geographical region.
    /// </summary>
    /// <value>The athlete's state or geographical region.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonPropertyName("state")]
    public string State { get; set; }

    /// <summary>
    /// The athlete's country.
    /// </summary>
    /// <value>The athlete's country.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonPropertyName("country")]
    public string Country { get; set; }

    /// <summary>
    /// The athlete's sex.
    /// </summary>
    /// <value>The athlete's sex.</value>
    [DataMember(Name="sex", EmitDefaultValue=false)]
    [JsonPropertyName("sex")]
    public string Sex { get; set; }

    /// <summary>
    /// Whether the currently logged-in athlete follows this athlete.
    /// </summary>
    /// <value>Whether the currently logged-in athlete follows this athlete.</value>
    [DataMember(Name="friend", EmitDefaultValue=false)]
    [JsonPropertyName("friend")]
    public string Friend { get; set; }

    /// <summary>
    /// Whether this athlete follows the currently logged-in athlete.
    /// </summary>
    /// <value>Whether this athlete follows the currently logged-in athlete.</value>
    [DataMember(Name="follower", EmitDefaultValue=false)]
    [JsonPropertyName("follower")]
    public string Follower { get; set; }

    /// <summary>
    /// Deprecated.  Use summit field instead. Whether the athlete has any Summit subscription.
    /// </summary>
    /// <value>Deprecated.  Use summit field instead. Whether the athlete has any Summit subscription.</value>
    [DataMember(Name="premium", EmitDefaultValue=false)]
    [JsonPropertyName("premium")]
    public bool? Premium { get; set; }

    /// <summary>
    /// Whether the athlete has any Summit subscription.
    /// </summary>
    /// <value>Whether the athlete has any Summit subscription.</value>
    [DataMember(Name="summit", EmitDefaultValue=false)]
    [JsonPropertyName("summit")]
    public bool? Summit { get; set; }

    /// <summary>
    /// The time at which the athlete was created.
    /// </summary>
    /// <value>The time at which the athlete was created.</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The time at which the athlete was last updated.
    /// </summary>
    /// <value>The time at which the athlete was last updated.</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SummaryAthlete {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ResourceState: ").Append(ResourceState).Append("\n");
      sb.Append("  Firstname: ").Append(Firstname).Append("\n");
      sb.Append("  Lastname: ").Append(Lastname).Append("\n");
      sb.Append("  ProfileMedium: ").Append(ProfileMedium).Append("\n");
      sb.Append("  Profile: ").Append(Profile).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Sex: ").Append(Sex).Append("\n");
      sb.Append("  Friend: ").Append(Friend).Append("\n");
      sb.Append("  Follower: ").Append(Follower).Append("\n");
      sb.Append("  Premium: ").Append(Premium).Append("\n");
      sb.Append("  Summit: ").Append(Summit).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
