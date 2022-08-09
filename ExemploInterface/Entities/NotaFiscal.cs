using System;
using System.Globalization;

namespace ExemploInterface.Entities
{
    public class NotaFiscal
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        public NotaFiscal(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }
        public double PagamentoTotal { get { return PagamentoBasico + Taxa; } }

        public override string ToString()
        {
            return "Pagamento basico: "
                + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento Total: "
                + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
