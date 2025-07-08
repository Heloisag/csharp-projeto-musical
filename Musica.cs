class Musica
{
    private string? nomeDaMusica;
    private string? artistas;
    private int tempoDeDuraçãoDaMusica;
    private bool disponibilidadeNoPlano; // <<-- bool é a variavel de Boolean // private - acesso é feito apenas dentro dessa "chave" 

    public void EscreveNomeDaMusica(string value)
    {
        nomeDaMusica = value;
    }
    public string LeNomeDaMusica()
    {
        return nomeDaMusica;
    }

    public void EscreveArtista(string value)
    {
        artistas = value;
    }




    public void EscreveDisponibilidadeBooleana(bool value)
    {
        disponibilidadeNoPlano = value;
    }
    public bool LeEscreveDisponibilidadeBooleana()
    {
        return disponibilidadeNoPlano;
    }
    public void FichaTecnicaDaMusica()
    {
        Console.WriteLine($"Nome: {nomeDaMusica}");
        Console.WriteLine($"Artista: {artistas}");
        System.Console.WriteLine($"Duração da musica: {tempoDeDuraçãoDaMusica}");
        if (disponibilidadeNoPlano)
        {
            System.Console.WriteLine("Está musica esta disponivel no plano atual! XD\n");
        }
        else
        {
            System.Console.WriteLine("Esta musica só pode ser escutada dentro do plano plus! Adquira agora mesmo, não fique forá!\n");
        }
    }
}

