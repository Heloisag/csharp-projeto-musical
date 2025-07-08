class Musica
{
    public string? NomeDaMusica { get; set; }
    public string? Artistas { get; set; }
    public int TempoDeDuraçãoDaMusica { get; set; }
    public bool DisponibilidadeNoPlano { get; set; } // <<-- bool é a variavel de Boolean // private - acesso é feito apenas dentro dessa "chave" 
    public string? ResumoDaMusica => $"A música {NomeDaMusica} pertence ao artista {Artistas}"; // Arrow function or lambda
    // ResumoDaMusica é uma propriedade que retorna uma string formatada com o nome da música e o artista.    


    public void FichaTecnicaDaMusica()
    {
        Console.WriteLine($"Nome: {NomeDaMusica}");
        Console.WriteLine($"Artista: {Artistas}");
        System.Console.WriteLine($"Duração da musica: {TempoDeDuraçãoDaMusica}");
        if (DisponibilidadeNoPlano)
        {
            System.Console.WriteLine("Está musica esta disponivel no plano atual! XD\n");
        }
        else
        {
            System.Console.WriteLine("Esta musica só pode ser escutada dentro do plano plus! Adquira agora mesmo, não fique forá!\n");
        }
    }
}