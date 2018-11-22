using System;
using System.Data;

namespace titanium.erp.data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private bool _disposed;
        private IDbConnection _connection;
        private IDbTransaction _transaction;

        public UnitOfWork(IDbConnection cnn)
        {
            _connection = cnn;
        }

        public void OpenConnection()
        {
            _connection.Open();
        }

        public void CloseConnection()
        {
            try
            {
                _connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _connection.Dispose();
            }
        }
        
        public void BeginTransaction()
        {
            try
            {
                _transaction = _connection.BeginTransaction();
            }
            catch
            {
                throw;
            }
        }
        
        public void Rollback() {
            try
            {
                _transaction.Rollback();
            }
            catch
            {
                throw;
            }
            finally
            {
                _transaction.Dispose();
            }
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
            }
        }
        
        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }

        ~UnitOfWork()
        {
            dispose(false);
        }
    }

}
