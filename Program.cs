// Agora que criei a classe musica, posso usar ela como se fosse um tipo de variavel, assim como String, Boolean, Int etc 
Album albumDoQueen = new Album();
albumDoQueen.NomeDoAlbum = "A night at the opera";

Musica musica1 = new Musica();
musica1.NomeDaMusica = "Love of my life";
musica1.TempoDeDuraçãoDaMusica = 213;


Musica musica2 = new Musica();
musica2.NomeDaMusica = "Bohemian Rhapsody";
musica1.TempoDeDuraçãoDaMusica = 354;


albumDoQueen.ColecaoDeMusicas(musica1);
albumDoQueen.ColecaoDeMusicas(musica2);
albumDoQueen.ExibirColecaoDeMusicasDoAlbum();
