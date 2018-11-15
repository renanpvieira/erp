using System.Collections.Generic;

namespace titanium.erp.dominio
{
    public class Chamado
    {
        /* Lista de usuarios esta relacinado ChamadoStatus */

        public int ChamadoId { get; set; }
        public string Titulo { get; set; }

        public virtual ICollection<ChamadoItem> Itens { get; set; }
        public virtual ICollection<ChamadoStatus> Status { get; set; }


    }
}
