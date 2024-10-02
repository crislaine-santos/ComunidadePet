using System.Collections.Generic;
using System.Net;
using System.Text.Encodings.Web;

string mensagem = "\nBem Vindo a Comunidade Amantes de Pet";
Dictionary<string, List<string>> petsAdicionados = new Dictionary<string, List<string>>(); // serve como se fosse de fato um dicionario cada palavra (chave) tem uma definição correspondente (valor). 

void ExibirLogo()
{
    Console.WriteLine(@"
▄▀█ █▀▄▀█ ▄▀█ █▄░█ ▀█▀ █▀▀ █▀   █▀▄ █▀▀   █▀█ █▀▀ ▀█▀
█▀█ █░▀░█ █▀█ █░▀█ ░█░ ██▄ ▄█   █▄▀ ██▄   █▀▀ ██▄ ░█░");
    Console.WriteLine(mensagem);

}

void OpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um Pet");
    Console.WriteLine("Digite 2 para mostrar os Pets");
    Console.WriteLine("Digite 3 para dar uma caracteristica a um Pet");
    Console.WriteLine("Digite 4 para ver as caracteristicas de um Pet");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("\nDigite a opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


    switch (opcaoEscolhidaNumerica)
    {
        case 1:RegistrarPets();
            break;
        case 2: PetsRegistrados();
            break;
        case 3: AvaliarPet();
            break;
        case 4:
            VerCaracteristicas();
            break;
        case 5: Console.WriteLine("Bye Bye!");
            break;
        default: Console.WriteLine("Opçao Inválida");
            break;
    }
  
}

void RegistrarPets()
{
    Console.Clear();
    Console.WriteLine("****************");
    Console.WriteLine("Registro de Pets");
    Console.WriteLine("****************\n");
    Console.Write("Digite o nome do pet que vc quer registrar: ");
    string pets = Console.ReadLine()!;
    petsAdicionados.Add(pets, new List<string>());
    Console.WriteLine($"O Pet {pets} Registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    OpcoesDoMenu();

}

void PetsRegistrados()
{
    Console.Clear();
    Console.WriteLine("*****************");
    Console.WriteLine("Pets Registrados: ");
    Console.WriteLine("*****************\n");

    foreach(string pet in petsAdicionados.Keys) // Keys é para o foreach saber que precisa pegar a chave dentro do dicionario;
    {
        Console.WriteLine($"Pet: {pet}");
    }

    Console.WriteLine("\nDigite qualquer tecla para valtar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    OpcoesDoMenu();
}

void AvaliarPet()
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("Digite o nome do pet que deseja: ");
    Console.WriteLine("********************************");
    string nomeDoPet =  Console.ReadLine()!;

    if (petsAdicionados.ContainsKey(nomeDoPet))
    {
        Console.Write("Qual caracteristica esse pet tem ?");
        string caracteristica = Console.ReadLine()!;
        petsAdicionados[nomeDoPet].Add(caracteristica);
        Console.WriteLine("Caracteristica registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        OpcoesDoMenu();


    }
    else
    {
        Console.WriteLine($"O pet {nomeDoPet} não foi encontrado!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        OpcoesDoMenu();
    }

    
}

void VerCaracteristicas()
{
   
    Console.Clear();
    Console.WriteLine("**********************");
    Console.WriteLine("Caracteristicas do pet");
    Console.WriteLine("**********************\n");
    Console.Write("Digite o nome do pet que vc quer verificar as caracteristicas: ");
    string nomePet = Console.ReadLine()!;

    if (petsAdicionados.ContainsKey(nomePet))
    {
        List<string> caracteristicas = petsAdicionados[nomePet];
        Console.Write($"O Pet {nomePet} possui as seguintes características:");

        foreach (string caracteristica in caracteristicas)
        {
            Console.WriteLine(caracteristica);
        }
        Console.WriteLine("\nDigite qualquer tecla para valtar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        OpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"Pet {nomePet} não foi encontrado!");
        Console.WriteLine("\nDigite qualquer tecla para valtar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        OpcoesDoMenu();
    }

    
}

OpcoesDoMenu();