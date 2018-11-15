//using NLog;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    /* tem que ser abstrado pra nao ser chamada  */
    public abstract class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        
        public T BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public ICollection<T> BuscarTodos(Expression<Func<T, int>> order)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> BuscarTodos(int inicio, int tamanho)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> BuscarTodos(Expression<Func<T, int>> order, int inicio, int tamanho)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> BuscarTodos(Expression<Func<T, bool>> exprecao)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> BuscarTodos(Expression<Func<T, int>> order, Expression<Func<T, bool>> exprecao)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> BuscarTodos(int inicio, int tamanho, Expression<Func<T, bool>> exprecao)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> BuscarTodos(Expression<Func<T, int>> order, int inicio, int tamanho, Expression<Func<T, bool>> exprecao)
        {
            throw new NotImplementedException();
        }

        public void Deletar(T obj)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Expression<Func<T, bool>> exprecao)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int RetornaQtdRegistros()
        {
            throw new NotImplementedException();
        }

        public int RetornaQtdRegistros(Expression<Func<T, bool>> exprecao)
        {
            throw new NotImplementedException();
        }

        public void Salvar(T obj)
        {
            throw new NotImplementedException();
        }

        public int SalvarMudancas()
        {
            throw new NotImplementedException();
        }
    }
}
