using System.Text.Json.Serialization;

namespace MazakaNet.Models.Resources;

public class ItemId
{
    [JsonPropertyName("persistentId")]
    public long PersistentId { get; set; }

    [JsonPropertyName("tempId")]
    public string TempId { get; set; }

    [JsonPropertyName("isEmpty")]
    public bool IsEmpty { get; set; }
}