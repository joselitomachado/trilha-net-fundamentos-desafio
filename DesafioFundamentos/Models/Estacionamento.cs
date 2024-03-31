namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            try
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                string veiculo = Console.ReadLine().ToUpper();
                if (string.IsNullOrEmpty(veiculo)) throw new Exception("Verifique se digitou a placa do veículo corretamente.");

                veiculos.Add(veiculo);
                Console.WriteLine($"Veículo com a placa {veiculo}, adicionado com sucesso.");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }

        public void RemoverVeiculo()
        {
            string placa = "";

            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine().ToUpper();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                try
                {
                    int horas = 0;
                    decimal valorTotal = 0;

                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    horas = Convert.ToInt32(Console.ReadLine());

                    valorTotal = precoInicial + precoPorHora * horas;

                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                catch (Exception erro)
                {
                    Console.WriteLine($"Houve um erro: {erro.Message}");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo.ToString());
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
