//Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções. A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo. Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.

//Algoritmo 
//1.criar menu com 5 opcoes
//2.informar a bebida 
//3.mensagem de gelo 
//4.a bebida x sera com adicional de gelo
//5. a bebida e sem gelo 

//Entrada 


Console.WriteLine(@$"
--------------------------------------------
| Bem-vindo à lanchonete aqui so tem refri |
|Informe o refigerante desejado:           |
|1 para Citrus                             |
|2 para Fanta Laranja                      |
|3 para Sprite                             |
|4 para Kuat                               |
|5 para Sparkling                          |
--------------------------------------------
");

int refri = int.Parse(Console.ReadLine());

Console.WriteLine($"Gostaria de adicionar gelo (S/N) ?");

string gelo = Console.ReadLine().ToLower();
string sim = "s";

switch (refri)
{
    case 1: 
    Console.WriteLine($"Você solitou uma citrus, aguarde seu pedido !");
    if (gelo == sim)
    {
        Console.WriteLine($"Sua citrus vira com gelo !");  
    }
    else 
    {
        Console.WriteLine($"Sua citrus vira sem gelo !");
    }
    break;

    case 2: 
    Console.WriteLine($"Você solitou uma Fanta Laranja, aguarde seu pedido !");
    if (gelo == sim)
    {
        Console.WriteLine($"Sua Fanta Laranja vira com gelo !");  
    }
    else 
    {
        Console.WriteLine($"Sua Fanta Laranja vira sem gelo !");
    }
    break;

    case 3: 
    Console.WriteLine($"Você solitou uma Sprite, aguarde seu pedido !");
    if (gelo == sim)
    {
        Console.WriteLine($"Sua Sprite vira com gelo !");  
    }
    else 
    {
        Console.WriteLine($"Sua Sprite vira sem gelo !");
    }
    break;

    case 4: 
    Console.WriteLine($"Você solitou uma Kuat, aguarde seu pedido !");
    if (gelo == sim)
    {
        Console.WriteLine($"Sua Kuat vira com gelo !");  
    }
    else 
    {
        Console.WriteLine($"Sua Kuat vira sem gelo !");
    }
    break;

    case 5: 
    Console.WriteLine($"Vocêdot solitou uma Sparkling, aguarde seu pedido !");
    if (gelo == sim)
    {
        Console.WriteLine($"Sua Sparkling vira com gelo !");  
    }
    else 
    {
        Console.WriteLine($"Sua Sparkling vira sem gelo !");
    }
    break;

    default:
        Console.WriteLine($"Digite uma opção valida");
    break;
}
 







