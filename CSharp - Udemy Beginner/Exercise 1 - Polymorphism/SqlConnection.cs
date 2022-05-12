﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Polymorphism
{
    public class SqlConnection : DbConnection
    {

        public SqlConnection(string connectionString) : base(connectionString)
        {
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Cerrando una conexión de tipo SQL");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Abriendo una conexión de tipo SQL");
        }
    }
}
