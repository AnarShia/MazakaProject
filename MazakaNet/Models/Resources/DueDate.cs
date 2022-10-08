using System.Text.Json.Serialization;

namespace MazakaNet.Models.Resources;

public class DueDate
{
    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("isFullDay")]
    public bool IsFullDay { get; set; }

    [JsonPropertyName("isRecurring")]
    public bool IsRecurring { get; set; }

    [JsonPropertyName("language")]
    public Language Language { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("timezone")]
    public string Timezone { get; set; }
}