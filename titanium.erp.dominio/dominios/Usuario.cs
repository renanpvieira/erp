using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace titanium.erp.dominio
{
    [Table("usuario")]
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Autenticado { get; set; } /* mesma coisa que logado */
        
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<UsuarioMenuAdmin> UsuarioMenuAdmin { get; set; }
    }
}
