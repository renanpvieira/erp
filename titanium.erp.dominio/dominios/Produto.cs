using System.Collections.Generic;

namespace titanium.erp.dominio
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string EAN { get; set; }
        public string Nome { get; set; }
        public int Valor { get; set; }
        public int Peso { get; set; }

        public Empresa Empresa { get; set; }
        public virtual ICollection<MovimentoItem> MovimentoItens { get; set; }
    }
}

