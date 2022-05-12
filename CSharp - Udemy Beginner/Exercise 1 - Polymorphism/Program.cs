using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primer ejercicio
            List<DbConnection> connections = new List<DbConnection>();
            connections.Add(new SqlConnection("cadena sql"));
            connections.Add(new OracleConnection("cadena oracle"));

            foreach (var connection in connections)
            {
                connection.OpenConnection();
                connection.CloseConnection();
            }
            Console.WriteLine("--------------SEGUNDO EJERCICIO----------------");
            //Segundo ejercicio
            SqlConnection sqlConnection = new SqlConnection("cadena de conexcion sql");
            DbCommand dbCommand = new DbCommand(sqlConnection, "select * from customers");
            dbCommand.Execute();


            OracleConnection oracleConnection = new OracleConnection("cadena de conexcion oracle");
            DbCommand dbCommandOracle = new DbCommand(oracleConnection, "select * from customers");
            dbCommandOracle.Execute();

        }
    }
}
