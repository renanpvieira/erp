using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using titanium.erp.data;
using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;
using MySql.Data.MySqlClient;

namespace titanium.erp.teste.console
{
    class Program
    {
        static void Main(string[] args)
        {

            var cnn = new MySqlConnection();

            cnn.Open();
            var transacao = cnn.BeginTransaction();

            IUsuarioRepositorio repo = new UsuarioRepositorio(transacao);

            repo.AddAsync(new Usuario { });


         
        }

        

    }

   
}
