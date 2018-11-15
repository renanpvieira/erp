using System.Collections.Generic;

namespace titanium.erp.dominio
{
    public class UF
    {
        public int UFId { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string CodigoUF { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}