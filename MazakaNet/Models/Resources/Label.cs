using System.Text.Json.Serialization;

namespace MazakaNet.Models.Resources;

public class Label
{
    [JsonPropertyName("color")]
    public int Color { get; set; }

    [JsonPropertyName("isDeleted")]
    public bool IsDeleted { get; set; }

    [JsonPropertyName("itemOrder")]
    public int ItemOrder { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public Id Id { get; set; }
}