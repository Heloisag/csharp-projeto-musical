class Album
{
    public Album(string nomeDoAlbum)
    {
        NomeDoAlbum = nomeDoAlbum;
    }

    private List<Musica> listaDeMusicas = new List<Musica>();
    public string? NomeDoAlbum { get; set; }
    
    // public Genero? GeneroDoAlbum { get; set; }
    public int TempoDeDuracao => listaDeMusicas.Sum(tempoDeDuracaoTotalDasMusicasDoAlbum => tempoDeDuracaoTotalDasMusicasDoAlbum.TempoDeDuraçãoDaMusica);

    public void ColecaoDeMusicas(Musica musica)
    {
        listaDeMusicas.Add(musica);
    }

    public void ExibirColecaoDeMusicasDoAlbum()
    {
        System.Console.WriteLine($"\nColeção de musicas do album {NomeDoAlbum}");
        foreach (var musica in listaDeMusicas)
        {
            System.Console.WriteLine($"Música: {musica.NomeDaMusica}");
        }
        System.Console.WriteLine($"\nPara ouvir esse album completo você precisa de {TempoDeDuracao} segundos livres\n");
    }
}