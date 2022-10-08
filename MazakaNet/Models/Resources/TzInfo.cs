using System.Text.Json.Serialization;

namespace MazakaNet.Models.Resources;

public class TzInfo
{
    [JsonPropertyName("gmtString")]
    public string GmtString { get; set; }

    [JsonPropertyName("hours")]
    public int Hours { get; set; }

    [JsonPropertyName("isDst")]
    public int IsDst { get; set; }

    [JsonPropertyName("minutes")]
    public int Minutes { get; set; }

    [JsonPropertyName("timezone")]
    public string Timezone { get; set; }
}