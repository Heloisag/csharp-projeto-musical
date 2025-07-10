class Podcast
{
    private List<Episodios> episodios = new();
    public Podcast(string? nomeDoPodcast, string? hostDoPodcast)
    {
        NomeDoPodcast = nomeDoPodcast;
        HostDoPodcast = hostDoPodcast;
    }

    public string? NomeDoPodcast { get; }
    public string? HostDoPodcast { get; }
    public int TotalDeEpisodios => episodios.Count;


    public void AdicionarEpisodios(Episodios episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirDestalhesDoPodcast()
    {
        System.Console.WriteLine($"Nome do Podcast é {NomeDoPodcast} e o host é {HostDoPodcast}\n");
        foreach (Episodios episodio in episodios.OrderBy(e => e.OrdemDosEpisodios))
        {
            System.Console.WriteLine(episodio.Resumo);
        }
        System.Console.WriteLine($"Total de episodios desse Podcast: {TotalDeEpisodios}");
    }  
}