using System;

namespace titanium.erp.dominio
{
    public class MovimentoFiscal
    {
        public int MovimentoFiscalId { get; set; }
        public string Chave { get; set; }
        public string Protocolo { get; set; }
        public string XML { get; set; }

        public DateTime DataNotaFiscal { get; set; }
        public virtual Movimento Movimento { get; set; }
    }
}

