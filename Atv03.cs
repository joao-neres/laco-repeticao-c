/*
Um estacionamento deseja registrar a entrada de veículos durante o dia. 
Para cada veículo que entrar, o atendente deve informar a placa. 
O sistema deve continuar pedindo novas placas enquanto o 
operador desejar continuar o atendimento.

Ao final, o programa deve mostrar:
- a quantidade total de veículos registrados.

Regras da atividade
- o programa deve usar while para repetir o cadastro das placas;
- após cada tentativa de cadastro, o programa deve perguntar se o operador deseja continuar;
- ao final, exibir a quantidade de veículos registrados com sucesso.

Observação: Vestigios de uso de IA, atividade zerada, 
ou código copiado de terceiros sem a devida citação, serão penalizados.

*/
public static class Atv03
{
    public static void Executar()
    {
        string opcao;
        string placaCarro;
        int qntdCarro = 0;

        Console.WriteLine("Deseja adicionar alguma placa s/n");
        opcao = Console.ReadLine()!;
        Console.Clear();

        while (opcao == "s" || opcao == "S")
        {
            Console.WriteLine("Registre a placa");
            Console.WriteLine("");
            Console.Write("Insira a placa do carro: ");
            placaCarro = Console.ReadLine()!;

            qntdCarro++;
            Console.WriteLine("Deseja continuar: s/n");
            opcao = Console.ReadLine()!;
            Console.Clear();
        }
        Console.WriteLine("Voce nao vai registrar mais placas");
        Console.WriteLine($"Quantidade de placas registradas foram: {qntdCarro}");
    }
}
