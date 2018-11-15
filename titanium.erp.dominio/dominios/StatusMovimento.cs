using System.Collections.Generic;

namespace titanium.erp.dominio
{
    public class StatusMovimento
    {
        public int EstatusMovimentoId { get; set; }
        public string Nome { get; set; }
        public bool EmiteNota { get; set; }
        public bool AbateEstoque { get; set; }
        public virtual ICollection<MovimentoStatus> MovimentoEstatus { get; set; }

    }
}
