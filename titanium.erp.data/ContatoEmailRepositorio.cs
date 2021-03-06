﻿using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class ContatoEmailRepositorio : RepositorioBase<ContatoEmail>, IContatoEmailRepositorio
    {
        public ContatoEmailRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
