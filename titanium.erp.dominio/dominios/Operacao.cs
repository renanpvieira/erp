using System.Collections.Generic;

namespace titanium.erp.dominio
{
    public class Operacao
    {
        public int OperacaoId { get; set; }
        public string CFOP { get; set; }
        public string DescricaoFiscal { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<MovimentoItem> MovimentoItens { get; set; }
    }
}

