namespace ConsumindiApisComCSharp.Filtro;
using ConsumindiApisComCSharp.Modelos;
internal static class LinqFiltro
{
    public static void FiltrarBrasileiros(List<Usuario> usuarios)
    {
        List<Usuario> brasileiros = usuarios.Where(usuario => usuario?.Localizacao?.Pais == "Brazil").ToList();
        foreach (var brasileiro in brasileiros)
        {
            brasileiro.ExibirInformacaoes();
        }
    }

    public static void OrdenarUsuarioNome(List<Usuario> usuarios)
    {
        List<Usuario> nomeOrdenados = usuarios.OrderBy(usuario => usuario.Nome?.PrimeiroNome).ToList();
        foreach (Usuario nome in nomeOrdenados)
        {
            nome.ExibirInformacaoes();
        }

    }
    public static void BrasileirosOrdenadosNomes(List<Usuario> usuarios)
    {
        List<Usuario> brasileirosOrdenadosNomes = usuarios.Where(usuario => usuario.Localizacao?.Pais == "Brazil")
        .OrderBy(usuario => usuario?.Nome.PrimeiroNome).ToList();
        foreach (var brasileiro in brasileirosOrdenadosNomes)
        {
            brasileiro.ExibirInformacaoes();
        }
    }
    public static void ExibirEmails(List<Usuario> usuarios)
    {
        List<string> emails = usuarios.Where(usuario => usuario.Email != null).Select(usuario => usuario.Email!).Distinct().ToList();
        foreach(string email in emails)
        {
            System.Console.WriteLine(email);
        }
    }
    public static void AgruparUsuariosPais(List<Usuario> usuarios)
    {
        var grupos = usuarios.GroupBy(usuario => usuario.Localizacao?.Pais).ToList();
        foreach(var grupo in grupos)
        {
            System.Console.WriteLine(grupo.Key);
            foreach(Usuario usuario in grupo)
            {
                usuario.ExibirInformacaoes();
            }
        }
    }
    public static void QuantidadeUsuariosPorPais(List<Usuario> usuarios)
    {
        var grupos = usuarios.GroupBy(usuario => usuario.Localizacao?.Pais).ToList();
        foreach (var grupo in grupos)
        {
            Console.Write($"{grupo.Key}: ");
            Console.WriteLine($"{grupo.Count()} usuários");
            

        }
    }
}