string mensagemDeBoasVindas = "\nSeja bem vindo ao ScreenSound!";
List<string> bandasCadastradas = new List<string>(); //LISTA DAS BANDAS CADASTRADAS NA OPÇÃO 01! FICAM ARMAZENADAS NO CÓDIGO.



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
    Console.WriteLine("Digite 3 para avaliar uma bandas");
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
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt);
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
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasCadastradas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Menu();
}

void MostraBandasRegistradas()
{
    
}

Menu();