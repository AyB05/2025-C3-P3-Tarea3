using System;
using System.Data.SqlClient;


namespace DAL
{
    public class DatabaseHelper : IDisposable
    {
        private readonly string _connectionString;
        private SqlConnection _connection;

        public DatabaseHelper()
        {
            _connectionString = "Server=DESKTOP-MHD477R;Database=BusControlDB;Trusted_Connection=True;";
            _connection = new SqlConnection(_connectionString);
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_connection != null)
                {
                    _connection.Dispose();
                    _connection = null;
                }
            }
        }
    }
}
