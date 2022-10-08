using System.Text.Json.Serialization;

namespace MazakaNet.Models.Resources;

public class Note
{
    [JsonPropertyName("content")]
    public string Content { get; set; }

    [JsonPropertyName("fileAttachment")]
    public FileAttachment FileAttachment { get; set; }

    [JsonPropertyName("isArchived")]
    public object IsArchived { get; set; }

    [JsonPropertyName("isDeleted")]
    public bool IsDeleted { get; set; }

    [JsonPropertyName("itemId")]
    public ItemId ItemId { get; set; }

    [JsonPropertyName("posted")]
    public DateTime Posted { get; set; }

    [JsonPropertyName("postedUserId")]
    public int PostedUserId { get; set; }

    [JsonPropertyName("projectId")]
    public ProjectId ProjectId { get; set; }

    [JsonPropertyName("userIdsToNotify")]
    public List<object> UserIdsToNotify { get; set; }

    [JsonPropertyName("id")]
    public Id Id { get; set; }
}