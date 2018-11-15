using System.Collections.Generic;

namespace titanium.erp.dominio
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Autenticado { get; set; } /* mesma coisa que logado */
        
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<UsuarioMenuAdmin> UsuarioMenuAdmin { get; set; }
    }
}
