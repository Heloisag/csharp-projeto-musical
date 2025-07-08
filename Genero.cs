class Genero
{
    private List<Album> listaDeAlbums = new List<Album>();
    public string? GeneroDoAlbum { get; set; }
    
    public void TipoDeGeneroDoAlbum(Album album)
    {
        listaDeAlbums.Add(album);
    }

    public void ExibirGeneroMusicalDOAlbum()
    {
        System.Console.WriteLine($"\nGênero do album {GeneroDoAlbum}");
        foreach (var album in listaDeAlbums)
        {
            System.Console.WriteLine($"Genêro do Album: {album.NomeDoAlbum}");
        }
    }
}