//using NLog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using titanium.erp.dominio.interfaces.repositorios;
using System.Data;
using Dapper;
using Dapper.Contrib.Extensions;

namespace titanium.erp.data
{
    /* tem que ser abstrado pra nao ser chamada  */
    public abstract class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        private readonly IDbTransaction _transaction;

        public RepositorioBase(IDbTransaction transaction)
        {
            _transaction = transaction;
        }

        public virtual Task AddAsync(T entity)
        {
            return _transaction.Connection.InsertAsync(entity, _transaction);
        }
        
        public virtual Task UpdateAsync(T entity)
        {
            return _transaction.Connection.UpdateAsync(entity, _transaction);
        }

        public virtual Task DeleteAsync(T entity)
        {
            return _transaction.Connection.DeleteAsync(entity, _transaction);
        }

        public virtual Task DeleteAsync(params object[] keyValues)
        {
            throw new NotImplementedException();
        }
        
        public virtual ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> GetByIdAsync(params object[] keyValues)
        {
            throw new NotImplementedException();
        }
        
        public virtual void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
