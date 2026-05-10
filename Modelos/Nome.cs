using System.Text.Json.Serialization;
namespace ConsumindiApisComCSharp.Modelos;
internal class Nome
{
    [JsonPropertyName("title")]
    public string? Titulo { get; set; }

    [JsonPropertyName("first")]
    public string? PrimeiroNome { get; set; }
    
    [JsonPropertyName("last")]
    public string? UltimoNome { get; set; }   

    public void NomeCompleto()
    {
        if (PrimeiroNome != null && UltimoNome != null)
        {
            System.Console.WriteLine(PrimeiroNome + " " + UltimoNome);
        }
        else if (PrimeiroNome != null)
        {
            System.Console.WriteLine(PrimeiroNome);
        }
        else if (UltimoNome != null)
        {
            System.Console.WriteLine(UltimoNome);
        }
        else System.Console.WriteLine("Nome não encontrado");
    }
}