using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LendoDadosJson
{
    internal class Usuarios
    {
        public string login { get; set; }
        public int senha { get; set; }

        public Usuarios(string login, int senha)
        {
            this.login = login;
            this.senha = senha;
        }
    }
}
