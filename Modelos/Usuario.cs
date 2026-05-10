using System.Text.Json.Serialization;
namespace ConsumindiApisComCSharp.Modelos;
internal class Usuario
{
    [JsonPropertyName("gender")]
    public string? Genero { get; set; }

    [JsonPropertyName("name")]
    public Nome? Nome { get; set; }

    [JsonPropertyName("location")]
    public Localizacao? Localizacao { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("login")]
    public Login? Login { get; set; }

    public void ExibirInformacaoes()
    {
        if (Nome is null)
        {
            Console.WriteLine("Nome: Nome não encontrado");
        }
        else
        {
            Console.Write("Nome: ");
            Nome.NomeCompleto();
        }

        Console.WriteLine("Cidade: " + (Localizacao?.Cidade ?? "Cidade não encontrada"));
        Console.WriteLine("País: " + (Localizacao?.Pais ?? "País não encontrado"));
        Console.WriteLine("Email: " + (Email ?? "Email não encontrado"));
    }



}