using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Polymorphism
{
    public class DbCommand
    {
        private string _instruction { get; set; }
        private DbConnection _connection { get; set; }

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null || instruction == null)
            {
                throw new InvalidOperationException("Connection or intruction were null");
            }

            this._connection = connection;
            this._instruction = instruction;
        }

        public void Execute()
        {
            this._connection.OpenConnection();
            Console.WriteLine(this._instruction);
            this._connection.CloseConnection();
        }
    }
}
