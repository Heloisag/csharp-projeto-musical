// Agora que criei a classe musica, posso uar ela como se fosse um tipo de variavel, assim como String, Boolean, Int etc 

Musica musica1 = new Musica(); // <<-- objeto Musica();
musica1.EscreveNomeDaMusica(Roxane);
System.Console.WriteLine(musica1.LeNomeDaMusica());
musica1.artistas = "The police";
musica1.tempoDeDuraçãoDaMusica = 310;
musica1.EscreveDisponibilidadeBooleana(true);
System.Console.WriteLine(musica1.LeEscreveDisponibilidadeBooleana());

Musica musica2 = new Musica();
musica2.nomeDaMusica = "Vertical";
musica2.artistas = "U2";
musica2.tempoDeDuraçãoDaMusica = 311;
musica2.EscreveDisponibilidadeBooleana(false);
System.Console.WriteLine(musica2.LeEscreveDisponibilidadeBooleana());

musica1.FichaTecnicaDaMusica();
musica2.FichaTecnicaDaMusica(); 