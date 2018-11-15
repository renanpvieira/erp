using System.Collections.Generic;

namespace titanium.erp.dominio
{
    public class Estoque
    {
        public int EstoqueId { get; set; }
        public string Nome { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<MovimentoItem> MovimentoItens { get; set; }
    }
}
