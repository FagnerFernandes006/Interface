using System;
using ExemploInterface.Entities;

namespace ExemploInterface.Services
{
    public class ServicoAluguel
    {
        public double PrecoPorHora { get; set; }
        public double PrecoPorDia { get; set; }

        private ITaxaService _taxaService;

        public ServicoAluguel(double precoPorHora, double precoPorDia, ITaxaService taxaServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaService = taxaServico;
        }
        public void ProcessarPagamento(AluguelCarro aluguelCarro) 
        {
            TimeSpan duracao = aluguelCarro.Termino.Subtract(aluguelCarro.Inicio);

            double pagamentoBasico = 0.0;
            if(duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _taxaService.Taxa(pagamentoBasico);

            aluguelCarro.NotaFiscal = new NotaFiscal(pagamentoBasico, taxa);
        }
    }
}
