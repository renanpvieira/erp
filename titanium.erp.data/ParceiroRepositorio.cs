﻿using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public  class ParceiroRepositorio : RepositorioBase<Parceiro>, IParceiroRepositorio
    {
        public ParceiroRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }

    }
}
