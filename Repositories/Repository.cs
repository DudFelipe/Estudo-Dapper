using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Estudo_Dapper.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection)
           => _connection = connection;

        public IEnumerable<T> Get()
            => _connection.GetAll<T>();

        public T Get(int id)
            => _connection.Get<T>(id);

        public void Create(T entity)
            => _connection.Insert<T>(entity);

        public void Update(T entity)
            => _connection.Update<T>(entity);

        public void Delete(T model)
            => _connection.Delete<T>(model);

        public void Delete(int id)
        {
            if(id == 0)
                return;

            var model = _connection.Get<T>(id);
            _connection.Delete<T>(model);
        }
    }
}