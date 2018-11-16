using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace titanium.erp.dominio.interfaces.repositorios
{
    public interface IRepositorioBase<T> : IDisposable where T : class
    {

        ICollection<T> GetAll();
        Task<T> GetByIdAsync(params object[] keyValues);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteAsync(params object[] keyValues);


        //void Salvar(T obj);

        //ICollection<T> BuscarTodos();
        //ICollection<T> BuscarTodos(Expression<Func<T, int>> ordenacao);
        //ICollection<T> BuscarTodos(int inicio, int tamanho);
        //ICollection<T> BuscarTodos(Expression<Func<T, int>> ordenacao, int inicio, int tamanho);
        //ICollection<T> BuscarTodos(Expression<Func<T, bool>> exprecao);
        //ICollection<T> BuscarTodos(Expression<Func<T, int>> ordenacao, Expression<Func<T, bool>> exprecao);
        //ICollection<T> BuscarTodos(int inicio, int tamanho, Expression<Func<T, bool>> exprecao);
        //ICollection<T> BuscarTodos(Expression<Func<T, int>> ordenacao, int inicio, int tamanho, Expression<Func<T, bool>> exprecao);
        //int RetornaQtdRegistros();
        //int RetornaQtdRegistros(Expression<Func<T, bool>> exprecao);

        //T BuscarPorId(int id);
        //void Deletar(T obj);
        //void Deletar(int id);
        //void Deletar(Expression<Func<T, bool>> exprecao);
        //int SalvarMudancas();
    }
}
