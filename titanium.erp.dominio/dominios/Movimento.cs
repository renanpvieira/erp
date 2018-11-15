using System;
using System.Collections.Generic;

namespace titanium.erp.dominio
{
    public class Movimento
    {
        public int MovimentoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual Parceiro Parceiro { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<MovimentoStatus> MovimentoEstatus { get; set; }
        public virtual ICollection<MovimentoItem> MovimentoItens { get; set; }
               
    }
}