using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneGroup.Class
{
    public class FornecedorModel
    {
        private static int nextId = 1;
        public FornecedorModel(string nome, string email, string cnpj, string fone)
        {
            Id = nextId++;
            Nome = nome;
            Email = email;
            Cnpj = cnpj;
            Telefone = fone;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
    }
}
