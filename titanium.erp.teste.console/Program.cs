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

            var cnn = new MySqlConnection("server=mysql22.redehost.com.br;port=41890;database=teste01;uid=teste01;password=@#Titanium18!@Prod20;SSL Mode=None");

            cnn.Open();
            var transacao = cnn.BeginTransaction();

            IUsuarioRepositorio repo = new UsuarioRepositorio(transacao);

            var x = repo.GetAll();

            transacao.Dispose();

            cnn.Close();

            repo.AddAsync(new Usuario { });


         
        }

        

    }

   
}
