string mensagemDeBoasVindas = "\nSeja bem vindo ao ScreenSound!";
// List<string> bandasCadastradas = new List<string>() {"U2", "The Beatles", "Calpso"}; //LISTA DAS BANDAS CADASTRADAS NA OPÇÃO 01! FICAM ARMAZENADAS NO CÓDIGO.
Dictionary<string, List<int>> dicionarioBandas = new Dictionary<string, List<int>>();
dicionarioBandas.Add("linkin park" , new List<int> {10, 8, 6});
dicionarioBandas.Add("The Beatles", new List<int> ());

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine(mensagemDeBoasVindas);
}

void Menu ()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para regitrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma bandas");
    Console.WriteLine("Digite 5 para sair do MENU");

    Console.WriteLine("Digite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaInt)
    {
        
        case 1:
            RegistrarBandas();
            break;
        case 2: MostraBandasRegistradas();
            break;
        case 3: AvaliarBandas();
            break;
        case 4: MediaBandasAvaliadas();
            break;
        case 5: Console.WriteLine("Obrigada por usar o SoundSreen até a proxima! :D");
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTitulosMenu("Registre uma banda: ");
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    dicionarioBandas.Add(nomeDaBanda, new List<int>());
    // bandasCadastradas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();
    Menu();
}

void MostraBandasRegistradas()
{
    ExibirTitulosMenu("Exibindo todas os registros de bandas");
    foreach (string banda in dicionarioBandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite qualquer tela para retornar ao MENU: ");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void AvaliarBandas()
{
    Console.Clear();
    ExibirTitulosMenu("Avaliar banda");
    Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
    String nomeDaBanda = Console.ReadLine()!;
    if (dicionarioBandas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual sua nota para a {nomeDaBanda} banda? ");
        int notaDaBanda = int.Parse(Console.ReadLine()!);
        dicionarioBandas[nomeDaBanda].Add(notaDaBanda); // <-- Abro o dicionario de bandas adicionadas na opção 01 do menu e uso a função .add para atribuir e armazenar uma nota para ela
        Console.WriteLine($"\nA nota {notaDaBanda} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear(); // <-- limpa a tela e volta para o menu na função MENU();
        Menu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não esta registrada no sistema");
        Console.WriteLine("Digite qualquer tecla para retornar ao Menu");
        Console.ReadKey(); // <-- Usuario digita uma tecla qualquer e é direcionado para o menu principal com a função Menu();
        Console.Clear();
        Menu();
    }
}

// void MediaBandasAvaliadas()
// {
//     // A banda que sera avaliada existe no cadastro? ok
//     // sim >>> Calcule a média de acordo com as notas que o usuario digitou na opção 03
//     // não >>> Mensagem dizendo que a banda não foi registrada.

//     Console.Clear();

//     ExibirTitulosMenu("Media das bandas avaliadas");
//     Console.WriteLine("Qual banda você dejesa calcular a média?");
//     string nomeDaBanda = Console.ReadLine()!;
//     if (dicionarioBandas.ContainsKey(nomeDaBanda))
//     {
//         var notaDaBanda = dicionarioBandas[nomeDaBanda];
//         double mediaCalculada = notaDaBanda.Average();
//         int mediaCalculada = int.Parse(Console.ReadLine()!);
//         Console.WriteLine($"A média da banda {nomeDaBanda} é de {mediaCalculada}");
//         Thread.Sleep(2000);
//         Console.Clear(); // <-- limpa a tela e volta para o menu na função MENU(); 
//         Menu();
//     }
//     else
//     {
//         Console.WriteLine($"A banda {nomeDaBanda} não esta registrada no sistema");
//         Console.WriteLine("Digite qualquer tecla para retornar ao Menu");
//         Console.ReadKey(); // <-- Usuario digita uma tecla qualquer e é direcionado para o menu principal com a função Menu();
//         Console.Clear();
//         Menu();

//     }

// }

void ExibirTitulosMenu(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string qtdAsteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(qtdAsteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(qtdAsteriscos + "\n");
}

Menu();