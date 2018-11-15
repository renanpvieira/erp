using System;

namespace titanium.erp.dominio
{
    public class MovimentoStatus
    {
        public int MovimentoEstatusId { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual Movimento Movimento { get; set; }
        public virtual StatusMovimento EstatusMovimento { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}