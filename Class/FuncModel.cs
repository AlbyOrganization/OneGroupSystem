using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneGroup.Class
{
    public class FuncModel
    {
        private static int nextId = 1;
        public FuncModel(string email, string senha)
        {
            IdFunc = nextId++;
            Email = email;
            Senha = senha;
        }

        public int IdFunc { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
