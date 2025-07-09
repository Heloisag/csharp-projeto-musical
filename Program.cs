// Agora que criei a classe musica, posso usar ela como se fosse um tipo de variavel, assim como String, Boolean, Int etc 
Banda queen = new Banda("Queen");
Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    TempoDeDuraçãoDaMusica = 213,
    DisponibilidadeNoPlano = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{ //<-- Iniciadores
    TempoDeDuraçãoDaMusica = 354,
    DisponibilidadeNoPlano = false,
};

albumDoQueen.ColecaoDeMusicas(musica1);
albumDoQueen.ColecaoDeMusicas(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.FichaTecnicaDaMusica();
musica2.FichaTecnicaDaMusica();
albumDoQueen.ExibirColecaoDeMusicasDoAlbum();
queen.ExibirDiscografiaDoAlbum();

 