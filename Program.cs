Episodios ep1 = new(1, "Tecnicas de facilitação", 45);
ep1.ConvidadosDoPodcast("Heloisa");
ep1.ConvidadosDoPodcast("Leon");

Episodios ep2 = new(1, "Tecnicas de aprendizado", 67);
ep2.ConvidadosDoPodcast("Heloisa");
ep2.ConvidadosDoPodcast("Nicolas");

Podcast podcast = new("New Podcast", "Heloisa");
podcast.AdicionarEpisodios(ep1);
podcast.AdicionarEpisodios(ep2);
podcast.ExibirDestalhesDoPodcast();