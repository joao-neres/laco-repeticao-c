/*
Desenvolva um programa em C# que permita ao usuário escolher um número para gerar a sua tabuada.

O programa deve:
-solicitar ao usuário o número desejado;
-calcular e exibir a tabuada desse número;

Regras da atividade
- utilizar estrutura de repetição(while ou do/while) para exibir os cálculos;
- apresentar cada operação de forma organizada;
- mostrar a tabuada completa do número informado pelo usuário.

Observação: Vestigios de uso de IA, atividade zerada, 
ou código copiado de terceiros sem a devida citação, serão penalizados.

*/

public static class Atv04
{
    public static void Executar()
    {
        Console.Clear();
        Console.WriteLine("Digite um numero");
        Console.WriteLine("");
        int numero = int.Parse(Console.ReadLine()!);
        int multiplicação = 0;
        Console.Clear();
        Console.WriteLine("TABUADA ✖️");

        while (multiplicação <= 10)
        {
            Console.WriteLine("");
            Console.WriteLine($"{numero} X {multiplicação} = {numero * multiplicação}");
            Console.WriteLine("");
            multiplicação++;
        }
        Console.WriteLine("");
    }
}