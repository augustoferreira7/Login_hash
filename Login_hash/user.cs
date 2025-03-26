using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_hash
{
    internal class User
    {

        public int CodCliente { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Password { get; private set; }


        public User(int codcliente, string name, string email, string telephone, string password) : this(name, email, telephone, password)
        {
            CodCliente = codcliente;
        }

        public User(string name, string email, string telephone, string password)
        {
            Name = name;
            Email = email;
            Telephone = telephone;
            Password = password;
        }
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
