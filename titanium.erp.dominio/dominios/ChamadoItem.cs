using System;

namespace titanium.erp.dominio
{
    public class ChamadoItem
    {
        public int ChamadoItemId { get; set; }
        public DateTime Data { get; set; }
        public string Texto { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Chamado Chamado { get; set; }

    }
}