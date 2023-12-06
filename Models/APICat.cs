using System.Text.Json.Serialization;

namespace CatViewer.Models;

public class APICat
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("url")]
    public required string Url { get; set; }
    [JsonPropertyName("width")]
    public required int Width { get; set; }
    [JsonPropertyName("height")]
    public required int Height { get; set; }
}
