using System.Text.Json.Serialization;
namespace ConsumindiApisComCSharp.Modelos;
internal class RespostaUsuario
{
    [JsonPropertyName("results")]
    public List<Usuario>? Resultado { get; set; }
}