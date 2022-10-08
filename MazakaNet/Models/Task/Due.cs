using System.Text.Json.Serialization;

namespace MazakaNet.Models.Task;

public class Due
{
    [JsonPropertyName("date")]
    public string Date { get; set; }

    [JsonPropertyName("is_recurring")]
    public bool IsRecurring { get; set; }

    [JsonPropertyName("datetime")]
    public DateTime Datetime { get; set; }

    [JsonPropertyName("string")]
    public string String { get; set; }

    [JsonPropertyName("timezone")]
    public string Timezone { get; set; }
}