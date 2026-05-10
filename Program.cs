using System.Text.Json;
using ConsumindiApisComCSharp.Modelos;
using(HttpClient client = new HttpClient())
{
    try
    {
        string resultado = await client.GetStringAsync("https://randomuser.me/api/?results=5");
        RespostaUsuario? dados = JsonSerializer.Deserialize<RespostaUsuario>(resultado);

        int contador = 1;
        if (dados != null && dados.Resultado != null)
            foreach (Usuario usuario in dados.Resultado)
            {
                Console.WriteLine($"#{contador} Usuário:");
                usuario.ExibirInformacaoes();
                contador ++;
            }
    }
    catch(Exception e)
    {
        Console.WriteLine($"Erro: {e.Message}");
    }
}