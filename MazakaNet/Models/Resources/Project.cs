using System.Text.Json.Serialization;

namespace MazakaNet.Models.Resources;

public class Project
{
    [JsonPropertyName("collapsed")]
    public bool Collapsed { get; set; }

    [JsonPropertyName("color")]
    public int Color { get; set; }

    [JsonPropertyName("parentId")]
    public object ParentId { get; set; }

    [JsonPropertyName("isArchived")]
    public bool IsArchived { get; set; }

    [JsonPropertyName("isDeleted")]
    public bool IsDeleted { get; set; }

    [JsonPropertyName("childOrder")]
    public int ChildOrder { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("shared")]
    public bool Shared { get; set; }

    [JsonPropertyName("id")]
    public Id Id { get; set; }
}