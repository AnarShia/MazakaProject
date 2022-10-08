
using System.Text.Json.Serialization;

namespace MazakaNet.Models.Resources;

public class Filter
{
    [JsonPropertyName("color")]
    public int Color { get; set; }

    [JsonPropertyName("isDeleted")]
    public bool IsDeleted { get; set; }

    [JsonPropertyName("itemOrder")]
    public int ItemOrder { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("query")]
    public string Query { get; set; }

    [JsonPropertyName("id")]
    public Id Id { get; set; }
}