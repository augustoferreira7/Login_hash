using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_hash
{
    internal class userDAO
    {
        internal class UserDAO
        {
            private Connection Connect { get; set; }
            private SqlCommand Command { get; set; }
            //Sempre o nome da classe
            public UserDAO()
            {
                Connect = new Connection();
                Command = new SqlCommand();
            }
            public bool Insert(User prop)
            {
                Command.Connection = Connect.ReturnConnection();
                Command.CommandText = @"INSERT INTO Customer VALUES 
            (@name, @email, @telephone, @password)";

                Command.Parameters.AddWithValue("@Name", prop.Name);
                Command.Parameters.AddWithValue("@email", prop.Email);
                Command.Parameters.AddWithValue("@telephone", prop.Telephone);
                Command.Parameters.AddWithValue("@password", prop.Password);


                try
                {
                    //Executa query definida acima.
                    return Command.ExecuteNonQuery() == 0 ? false : true;
                }
                catch (Exception err)
                {
                    throw new Exception("Erro: Problemas ao inserir " +
                        "usuario no banco.\n" + err.Message);
                }
                finally
                {
                    Connect.CloseConnection();

                }


            }
            
        }
    }
}

