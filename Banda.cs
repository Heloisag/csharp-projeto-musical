class Banda
{
    public Banda(string nomeDaBanda)
    {
        NomeDaBanda = nomeDaBanda;
    }
    private List<Album> listaDeAlbums = new List<Album>();
    public string NomeDaBanda { get; }

    public void AdicionarAlbum(Album album)
    {
        listaDeAlbums.Add(album);
    }

    public void ExibirDiscografiaDoAlbum()
    {
        System.Console.WriteLine($"Discografia da banda {NomeDaBanda}");
        foreach (var Album in listaDeAlbums)
        {
            System.Console.WriteLine($"Album:{Album.NomeDoAlbum} ({Album.TempoDeDuracao})");
        }
    }
}