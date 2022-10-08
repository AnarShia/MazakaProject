using System.Text.Json.Serialization;

namespace MazakaNet.Models.Resources;

public class FileAttachment
{
    [JsonPropertyName("fileSize")]
    public int FileSize { get; set; }

    [JsonPropertyName("fileType")]
    public object FileType { get; set; }

    [JsonPropertyName("uploadState")]
    public object UploadState { get; set; }

    [JsonPropertyName("fileName")]
    public object FileName { get; set; }

    [JsonPropertyName("fileUrl")]
    public object FileUrl { get; set; }
}