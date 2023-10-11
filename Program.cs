//Projeto Screen Sound

string mensagemDeBoasVindas = "Bem vindo ao Screen Sound!";

//Dicionário de bandas
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Muse", new List<int> { 10, 5, 9});
bandasRegistradas.Add("Led Zeppelin", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
                █████████████████████████████████████████████████████████████████████████
                █─▄▄▄▄█─▄▄▄─█▄─▄▄▀█▄─▄▄─█▄─▄▄─█▄─▀█▄─▄███─▄▄▄▄█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀█
                █▄▄▄▄─█─███▀██─▄─▄██─▄█▀██─▄█▀██─█▄▀─████▄▄▄▄─█─██─██─██─███─█▄▀─███─██─█
                ▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀");

    Console.WriteLine(mensagemDeBoasVindas);
}


void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNum)
    {
        case 1: RegistroDeBandas();
            break;
        case 2: MostrarRegistroDeBandas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirMediaDaBanda();
            break;
        case -1: Console.WriteLine("Tchau! :)");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistroDeBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarRegistroDeBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibição de bandas registradas");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPressione uma tecla para voltar ao menu inicial");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirTituloDaOpcao (string titulo)
{
    int  quantidadeDeLetras = titulo.Length;
    string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliação de banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBandaAvaliada = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBandaAvaliada))
    {
        Console.Write($"Qual a nota que a banda {nomeBandaAvaliada} merece?: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBandaAvaliada].Add(nota);
        Console.WriteLine($"A nota {nota} foi atribuída com sucesso à banda {nomeBandaAvaliada}!");
        Thread.Sleep(5000);
        Console.Clear();
        ExibirOpcoesMenu();

    } else
    {
        Console.WriteLine($"\nA banda {nomeBandaAvaliada} não foi encontrada!");
        Console.WriteLine($"Tente cadastrá-la e retorne novamente. :)");
        Console.WriteLine("Pressione uma tecla para voltar ao menu inicial.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }

}

void ExibirMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Realizar média da banda");
    Console.Write("Digite o nome da banda a qual deseja visualizar a média: ");
    string bandaMediada = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(bandaMediada))
    {
        List<int> notasDaBanda = bandasRegistradas[bandaMediada];
        Console.WriteLine($"\nA média final da banda {bandaMediada} é {notasDaBanda.Average()}.");
        Console.WriteLine("Pressione uma tecla para voltar ao menu inicial.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();

    } else
    {
        Console.WriteLine($"\nA banda {bandaMediada} não foi encontrada!");
        Console.WriteLine($"Tente cadastrá-la e retorne novamente. :)");
        Console.WriteLine("Pressione uma tecla para voltar ao menu inicial.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}

ExibirOpcoesMenu();

