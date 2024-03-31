using DesafioFundamentos.Models;

namespace DesafioFundamentos.Layout;
public class Menu
{
    public static void MenuInicial()
    {
        try
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            decimal precoInicial = 0;
            decimal precoPorHora = 0;

            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n");
            Console.WriteLine("Digite o preço inicial:");
            precoInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora digite o preço por hora:");
            precoPorHora = Convert.ToDecimal(Console.ReadLine());

            MenuEstacionamento(precoInicial, precoPorHora);
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Houve um erro: {erro.Message}");
            Thread.Sleep(2000);
            Console.Clear();
            MenuInicial();
        }
    }

    private static void MenuEstacionamento(decimal precoInicial, decimal precoPorHora)
    {
        Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

        string opcao = string.Empty;
        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");

            switch (Console.ReadLine())
            {
                case "1":
                    es.AdicionarVeiculo();
                    break;

                case "2":
                    es.RemoverVeiculo();
                    break;

                case "3":
                    es.ListarVeiculos();
                    break;

                case "4":
                    Console.WriteLine("O programa se encerrou");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("\nPressione uma tecla para continuar");
            Console.ReadLine();
        }
    }
}
