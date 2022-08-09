using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploInterface.Entities
{
    public class AluguelCarro
    {
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public Veiculo Veiculo { get; set; }
        public NotaFiscal NotaFiscal { get; set; }

        public AluguelCarro(DateTime inicio, DateTime termino, Veiculo veiculo)
        {
            Inicio = inicio;
            Termino = termino;
            Veiculo = veiculo;
        }
    }
}
