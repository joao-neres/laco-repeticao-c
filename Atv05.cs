/*
Melhore o programa do exercício 4 para que ele possa receber um número inteiro do usuário 
e mostrar a tabuada desse número. O programa deve continuar pedindo um número até que o 
usuário digite um número negativo, momento em que o programa deve ser encerrado.

Regras:
- utilizar do/while em um dos laços de repetição
- utilizar while em um dos laços de repetição
- apresentar cada operação de forma organizada
- mostrar a tabuada completa do número informado pelo usuário
*/

public static class Atv05
{
    public static void Executar()
    {
        Console.Clear();
        int numero = 0;
        string resposta = "";
        do
        {
            Console.WriteLine("Digite um numero: ");
            Console.WriteLine("");
            numero = int.Parse(Console.ReadLine()!);
            int multiplicação = 0;
            if (numero < 0)
            {
                Console.WriteLine("Programa encerrado, numero negativo detectado.");
                break;
            }
            else
            {
                while (multiplicação <= 10)
                {

                    Console.WriteLine("");
                    Console.WriteLine($"{numero} X {multiplicação} = {numero * multiplicação}");
                    Console.WriteLine("");
                    multiplicação++;
                }
            }
            if (numero >= 0)
            {
                Console.WriteLine("Digite um numero: ");
                Console.WriteLine("deseja calcular a tabuada de um numero? (s/n)");
                resposta = Console.ReadLine()!;
            }
        } while (resposta == "s" || resposta == "S");
        if (numero >= 0)
        {
            Console.WriteLine("Programa encerrado.");
        }
    }
}