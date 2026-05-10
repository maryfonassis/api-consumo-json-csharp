using System.Text.Json.Serialization;
namespace ConsumindiApisComCSharp.Modelos;
internal class Localizacao
{
    [JsonPropertyName("location")]
    public Rua? Rua { get; set; }
    
    [JsonPropertyName("city")]
    public string? Cidade { get; set; }

    [JsonPropertyName("state")]
    public string? Estado { get; set; }

    [JsonPropertyName("country")]
    public string? Pais { get; set; }
}