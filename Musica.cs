class Musica
{
    public string? nomeDaMusica;
    public string? artistas;
    public int tempoDeDuraçãoDaMusica;
    public bool disponibilidadeNoPlano; // <<-- bool é a variavel de Boolean

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

