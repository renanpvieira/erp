using System.Collections.Generic;

namespace titanium.erp.dominio
{
    public class MenuAdmin
    {
        public int MenuAdminId { get; set; }
        public string Display { get; set; } /* Modo como será escrito no site */
        public string Sessao { get; set; }
        public string Controle { get; set; }
        public string Acao { get; set; }
        public string Url { get; set; }
        public int Grupo { get; set; } /* Serve para agrupar e ordenar dentro da sessao */
        public virtual ICollection<UsuarioMenuAdmin> UsuarioMenuAdmin { get; set; }

    }
}
