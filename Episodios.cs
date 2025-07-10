using System.Runtime.InteropServices.Marshalling;

class Episodios
{
    private List<string> convidados = new();
    public Episodios(int ordemDosEpisodios, string? nomeDoEpisodio, int duracao)
    {
        OrdemDosEpisodios = ordemDosEpisodios;
        NomeDoEpisodio = nomeDoEpisodio;
        Duracao = duracao;
    }

    public int OrdemDosEpisodios { get; set; }
    public string? NomeDoEpisodio { get; set; }
    public int Duracao { get; set; }
    public string? Resumo => $"{OrdemDosEpisodios}. {NomeDoEpisodio} ({Duracao} min) - {string.Join(", ", convidados)}";

    public void ConvidadosDoPodcast(string convidado)
    {
        convidados.Add(convidado);
    }
}