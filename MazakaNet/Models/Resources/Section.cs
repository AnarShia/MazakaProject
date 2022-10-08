using System.Text.Json.Serialization;

namespace MazakaNet.Models.Resources;

public class Section
{
    [JsonPropertyName("dateAdded")]
    public DateTime DateAdded { get; set; }

    [JsonPropertyName("dateArchived")]
    public object DateArchived { get; set; }

    [JsonPropertyName("isArchived")]
    public bool IsArchived { get; set; }

    [JsonPropertyName("isCollapsed")]
    public bool IsCollapsed { get; set; }

    [JsonPropertyName("isDeleted")]
    public bool IsDeleted { get; set; }

    [JsonPropertyName("legacyProjectId")]
    public object LegacyProjectId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("projectId")]
    public ProjectId ProjectId { get; set; }

    [JsonPropertyName("sectionOrder")]
    public int SectionOrder { get; set; }

    [JsonPropertyName("id")]
    public Id Id { get; set; }
}