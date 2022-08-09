using System;
using System.Globalization;
using ExemploInterface.Entities;
using ExemploInterface.Services;

namespace ExemploInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel ");
            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Data inicio (DD/MM/YYYY HH:MM): ");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data do retorno (DD/MM/YYYY HH:MM): ");
            DateTime termino = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Entre com o preço por hora: ");
            double precoHora = double.Parse(Console.ReadLine());
            Console.Write("Entre com o preço por dia: ");   
            double precoDia = double.Parse(Console.ReadLine());

            AluguelCarro aluguelCarro = new AluguelCarro(inicio, termino, new Veiculo(modelo));
            ServicoAluguel servicoAluguel = new ServicoAluguel(precoHora, precoDia, new TaxaBrasilServices());
            servicoAluguel.ProcessarPagamento(aluguelCarro);

            Console.WriteLine("Nota fiscal: ");
            Console.WriteLine(aluguelCarro.NotaFiscal.ToString());
        }
    }
}
