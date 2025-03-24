using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_hash
{
    internal class Connection
    {
        private SqlConnection con;
        private string DataBase = "hashcj3022501";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Password = "aluno";
        public Connection()
        {
            string stringConnection =
            @"Data Source = " + Server
            + "; Initial Catalog = " + DataBase
            + "; User Id =" + Username
            + "; Password =" + Password
            + "; Encrypt = false";
            //string stringConnection = @"Data Source=" +
            //Environment.MachineName + @"\SQLEXPRESS;
            //Initial Catalog=" + DataBase +
            //"; Integrated Security=true";

            con = new SqlConnection(stringConnection);
            con.Open();   //Abrir a conexão com o banco de dados
        }

        //Tenta fechar a conexão com o banco
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        //Retorna a conexão que foi aberta
        public SqlConnection ReturnConnection()
        {
            return con;
        }

    }
}
