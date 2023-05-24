using INTERFACE;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;

IConta conta;
int tipo;
char opcao;

Console.WriteLine("Qual o tipo de conta escolhido? \n" +
    "1 corrente | 2 Poupança | 3 salario");
tipo = int .Parse(Console.ReadLine());
int escolha;

switch (tipo)
{
    case 1://
        conta = new corrente();
        comeco:
        Console.WriteLine("Você deseja realizar qual operação ? \n" +
            "1 depositar | 2 sacar | 3 ver seu saldo");
        escolha = int .Parse(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                Console.WriteLine("Valor do deposito");
                int deposito=int.Parse(Console.ReadLine());
                conta.depositar(deposito);
                Console.WriteLine($"Seu saldo: {conta.calcularSaldo()}");
                Console.WriteLine("você deseja realizar alguma outra opcao?S/N");
                opcao = char.Parse(Console.ReadLine());
                if (opcao == 'S')
                {
                    goto comeco;
                }
                else
                {
                    break;
                }
                break;

            case 2:
                if (conta.saldo<=0)
                {
                    Console.WriteLine("Você não possui valor para sacar");
                    Console.WriteLine($"Seu saldo: {conta.calcularSaldo()}");

                }
                else
                {
                    Console.WriteLine("Qual valor você deseja sacar ? ");
                    int sacar=int.Parse(Console.ReadLine());        
                    conta.sacar(sacar);
                    Console.WriteLine($"Seu saldo: {conta.calcularSaldo()}");
                }
                Console.WriteLine("você deseja realizar alguma outra opcao? S/N");
                opcao = char.Parse(Console.ReadLine());
                if (opcao == 'S')
                {
                    goto comeco;
                }
                else
                {
                    break;
                }
                break;

            case 3:
                if (conta.saldo<=0)
                {
                    Console.WriteLine($"Seu saldo: {conta.calcularSaldo()}");                  
                }
                else
                {
                    Console.WriteLine($"Seu saldo: {conta.calcularSaldo()}");
                    Console.WriteLine($"Seu saldo com a manutenção da conta");
                    conta.unico();
                }
                Console.WriteLine("você deseja realizar alguma outra opcao?S/N");
                opcao = char.Parse(Console.ReadLine());
                if (opcao == 'S')
                {
                    goto comeco;
                }
                else
                {
                    break;
                }
                break;

            default: Console.WriteLine("Valor invalido");
                goto comeco;
        }
        
        break;//


    case 2://
        conta = new poupança();
    comeco2:
        Console.WriteLine("Você deseja realizar qual operação ? \n" +
            "1 depositar | 2 sacar | 3 ver seu saldo| 4 ver meu rendimento");
        escolha = int.Parse(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                Console.WriteLine("Valor do deposito");
                int deposito = int.Parse(Console.ReadLine());
                conta.depositar(deposito);
                Console.WriteLine($"Seu saldo: {conta.calcularSaldo()}");
                Console.WriteLine("você deseja realizar alguma outra opcao?S/N");
                opcao = char.Parse(Console.ReadLine());
                if (opcao == 'S')
                {
                    goto comeco2;
                }
                else
                {
                    break;
                }
                break;

            case 2:
                if (conta.saldo <= 0)
                {
                    Console.WriteLine("Você não possui valor para sacar");
                    Console.WriteLine($"Seu saldo: {conta.calcularSaldo()}");

                }
                else
                {
                    Console.WriteLine("Qual valor você deseja sacar ? ");
                    int sacar = int.Parse(Console.ReadLine());
                    conta.sacar(sacar);
                    Console.WriteLine($"Seu saldo: {conta.calcularSaldo()}");
                }
                Console.WriteLine("você deseja realizar alguma outra opcao?S/N");
                opcao = char.Parse(Console.ReadLine());
                if (opcao == 'S')
                {
                    goto comeco2;
                }
                else
                {
                    break;
                }
                break;

            case 3:
                Console.WriteLine($"Seu saldo: {conta.calcularSaldo()}");
                Console.WriteLine("você deseja realizar alguma outra opcao?S/N");
                opcao = char.Parse(Console.ReadLine());
                if (opcao == 'S')
                {
                    goto comeco;
                }
                else
                {
                    break;
                }
                break;

            case 4:
                
                if (conta.saldo <= 0)
                {
                    Console.WriteLine("Seu rendimento ao mês:");
                    conta.calcularSaldo();
                }
                else
                {
                    Console.WriteLine("Seu rendimento ao mês:");
                    conta.unico();
                }
                Console.WriteLine("você deseja realizar alguma outra opcao?S/N");
                opcao = char.Parse(Console.ReadLine());
                if (opcao == 'S')
                {
                    goto comeco2;
                }
                else
                {
                    break;
                }
                break;

            default:
                Console.WriteLine("Valor invalido");
                goto comeco2;
        }
        
        break;//


    case 3://
        conta = new salario();
        comeco3:
        Console.WriteLine("Você deseja realizar qual operação ? \n" +
            "1 depositar | 2 sacar | 3 ver seu saldo");
        escolha = int.Parse(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                Console.WriteLine("Valor do deposito");
                int deposito = int.Parse(Console.ReadLine());
                conta.depositar(deposito);
                Console.WriteLine($"Seu saldo: {conta.calcularSaldo()}");
                Console.WriteLine("você deseja realizar alguma outra opcao?S/N");
                opcao = char.Parse(Console.ReadLine());
                if (opcao == 'S')
                {
                    goto comeco3;
                }
                else
                {
                    break;
                }
                break;

            case 2:
                if (conta.saldo <= 0)
                {
                    Console.WriteLine("Você não possui valor para sacar");
                    Console.WriteLine($"Seu saldo: {conta.calcularSaldo()}");

                }
                else
                {
                    Console.WriteLine("Qual valor você deseja sacar ? ");
                    int sacar = int.Parse(Console.ReadLine());
                    conta.sacar(sacar);
                    Console.WriteLine($"Seu saldo: {conta.calcularSaldo()}");
                }
                Console.WriteLine("você deseja realizar alguma outra opcao?S/N");
                opcao = char.Parse(Console.ReadLine());
                if (opcao == 'S')
                {
                    goto comeco3;
                }
                else
                {
                    break;
                }
                break;

            case 3:
                if (conta.saldo <= 0)
                {
                    Console.WriteLine($"Seu saldo: {conta.calcularSaldo()}");
                }
                else
                {
                    Console.WriteLine($"Seu saldo: {conta.calcularSaldo()}");
                    conta.unico();
                }
                Console.WriteLine("você deseja realizar alguma outra opcao?S/N");
                opcao = char.Parse(Console.ReadLine());
                if (opcao == 'S')
                {
                    goto comeco3;
                }
                else
                {
                    break;
                }
                break;


            default:
                Console.WriteLine("Valor invalido");
                goto comeco3;
        }

                break;//

    default: //
        Console.WriteLine("Valor invalido");
        break;//
}



Console.ReadLine(); 

