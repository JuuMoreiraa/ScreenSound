﻿//Projeto Screen Sound ==> PobreFy //void = sem retorno // PascalCase - Funções // CamelCase - Variáveis

string mensagemDeBoasVindas = "Boas vindas ao PobreFy";

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
                        ██████╗░░█████╗░██████╗░██████╗░███████╗███████╗██╗░░░██╗
                        ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝╚██╗░██╔╝
                        ██████╔╝██║░░██║██████╦╝██████╔╝█████╗░░█████╗░░░╚████╔╝░
                        ██╔═══╝░██║░░██║██╔══██╗██╔══██╗██╔══╝░░██╔══╝░░░░╚██╔╝░░
                        ██║░░░░░╚█████╔╝██████╦╝██║░░██║███████╗██║░░░░░░░░██║░░░
                        ╚═╝░░░░░░╚════╝░╚═════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░░░░╚═╝░░░");

    Console.WriteLine(mensagemDeBoasVindas);
}


void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    //Write - escreve sem pular a linha
    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNum)
    {
        case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case -1: Console.WriteLine("Tchau! :)");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}


ExibirMensagemDeBoasVindas();
ExibirOpcoesMenu();
