using System.Text.Json.Serialization;

namespace MazakaNet.Models.Task
{

    public record Task
    {
        [JsonPropertyName("creator_id")]
        public string CreatorId { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("assignee_id")]
        public object AssigneeId { get; set; }

        [JsonPropertyName("assigner_id")]
        public object AssignerId { get; set; }

        [JsonPropertyName("comment_count")]
        public int CommentCount { get; set; }

        [JsonPropertyName("is_completed")]
        public bool IsCompleted { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("due")]
        public Due Due { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("labels")]
        public List<object> Labels { get; set; }

        [JsonPropertyName("order")]
        public int Order { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [JsonPropertyName("project_id")]
        public string ProjectId { get; set; }

        [JsonPropertyName("section_id")]
        public object SectionId { get; set; }

        [JsonPropertyName("parent_id")]
        public object ParentId { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }


}
