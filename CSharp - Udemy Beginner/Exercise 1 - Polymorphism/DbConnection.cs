using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Polymorphism
{
    public abstract class DbConnection
    {
        private string _connectionString { get; set; }

        public TimeSpan _timeOut { get; private set; }

        public DbConnection()
        {
            this._timeOut = new TimeSpan(0, 3, 0);
        }
        public DbConnection(string connectionString) : this()
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("Connection string cannot be null");
            }
            this._connectionString = connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();



    }

}
