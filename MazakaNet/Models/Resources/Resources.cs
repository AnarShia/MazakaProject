using System.Text.Json.Serialization;

namespace MazakaNet.Models.Resources
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

    public class Resources
    {
        [JsonPropertyName("filters")]
        public List<Filter> Filters { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }

        [JsonPropertyName("labels")]
        public List<Label> Labels { get; set; }

        [JsonPropertyName("lastReadNotificationId")]
        public int LastReadNotificationId { get; set; }

        [JsonPropertyName("notes")]
        public List<Note> Notes { get; set; }

        [JsonPropertyName("notifications")]
        public List<object> Notifications { get; set; }

        [JsonPropertyName("projectNotes")]
        public List<object> ProjectNotes { get; set; }

        [JsonPropertyName("projects")]
        public List<Project> Projects { get; set; }

        [JsonPropertyName("reminders")]
        public List<object> Reminders { get; set; }

        [JsonPropertyName("sections")]
        public List<Section> Sections { get; set; }

        [JsonPropertyName("userInfo")]
        public UserInfo UserInfo { get; set; }
    }
}
