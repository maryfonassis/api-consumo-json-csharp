using System.Text.Json.Serialization;
namespace ConsumindiApisComCSharp.Modelos;
internal class Login
{
    [JsonPropertyName("username")]
    public string? NomeDeUsuario { get; set; }
    
    [JsonPropertyName("password")]
    public string? Senha { get; set; }
}