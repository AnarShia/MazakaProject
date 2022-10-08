using System.Text.Json.Serialization;

namespace MazakaNet.Models.Resources;

public class Item
{
    [JsonPropertyName("assignedByUid")]
    public object AssignedByUid { get; set; }

    [JsonPropertyName("childOrder")]
    public int ChildOrder { get; set; }

    [JsonPropertyName("collapsed")]
    public bool Collapsed { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }

    [JsonPropertyName("dateAdded")]
    public DateTime DateAdded { get; set; }

    [JsonPropertyName("dayOrder")]
    public int DayOrder { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("dueDate")]
    public DueDate DueDate { get; set; }

    [JsonPropertyName("inHistory")]
    public bool InHistory { get; set; }

    [JsonPropertyName("isArchived")]
    public object IsArchived { get; set; }

    [JsonPropertyName("isChecked")]
    public bool IsChecked { get; set; }

    [JsonPropertyName("isDeleted")]
    public bool IsDeleted { get; set; }

    [JsonPropertyName("labels")]
    public List<object> Labels { get; set; }

    [JsonPropertyName("parentId")]
    public object ParentId { get; set; }

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("projectId")]
    public ProjectId ProjectId { get; set; }

    [JsonPropertyName("responsibleUid")]
    public object ResponsibleUid { get; set; }

    [JsonPropertyName("section")]
    public int? Section { get; set; }

    [JsonPropertyName("syncId")]
    public object SyncId { get; set; }

    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    [JsonPropertyName("id")]
    public Id Id { get; set; }
}