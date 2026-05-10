using System.Text.Json;
using ConsumindiApisComCSharp.Filtro;
using ConsumindiApisComCSharp.Modelos;
using(HttpClient client = new HttpClient())
{
    try
    {
        string resultado = await client.GetStringAsync("https://randomuser.me/api/?results=100");
        RespostaUsuario? dados = JsonSerializer.Deserialize<RespostaUsuario>(resultado);

        /*int contador = 1;
        if (dados != null && dados.Resultado != null)
            foreach (Usuario usuario in dados.Resultado)
            {
                Console.WriteLine($"#{contador} Usuário:");
                usuario.ExibirInformacaoes();
                contador ++;
            }

            LinqFiltro.FiltrarBrasileiros(dados.Resultado);
            LinqFiltro.OrdenarUsuarioNome(dados.Resultado);
            LinqFiltro.ExibirEmails(dados.Resultado);*/
            LinqFiltro.QuantidadeUsuariosPorPais(dados.Resultado);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Erro: {e.Message}");
    }
}