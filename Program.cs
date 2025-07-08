// Agora que criei a classe musica, posso uar ela como se fosse um tipo de variavel, assim como String, Boolean, Int etc 

Musica musica1 = new Musica(); // <<-- objeto Musica();
musica1.nomeDaMusica = "Roxane";
musica1.artistas = "The police";
musica1.tempoDeDuraçãoDaMusica = 310;
musica1.disponibilidadeNoPlano = true;

Musica musica2 = new Musica();
musica2.nomeDaMusica = "Vertical";
musica2.artistas = "U2";
musica2.tempoDeDuraçãoDaMusica = 311;
musica2.disponibilidadeNoPlano = false;

musica1.FichaTecnicaDaMusica();
musica2.FichaTecnicaDaMusica();