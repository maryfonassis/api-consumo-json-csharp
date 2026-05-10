using System.Text.Json.Serialization;
namespace ConsumindiApisComCSharp.Modelos;
internal class Rua
{
    [JsonPropertyName("number")]
    public int? Numero { get; set; }
    
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
}