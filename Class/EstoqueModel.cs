using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneGroup.Class
{
    public class EstoqueModel
    {
        private static int nextId = 1;
        public EstoqueModel(string localizacao, int saida, int entrada, string motivoEntrada, string motivoSaida, int qntDisponivel)
        {
            IdEstoque = nextId++;
            Localizacao = localizacao;
            Saida = saida;
            Entrada = entrada;
            DataAtualizacao = DateTime.Now;
            MotivoEntrada = motivoEntrada;
            MotivoSaida = motivoSaida;
            QtdDisponivel = qntDisponivel;
        }
        public int IdEstoque { get; set; }
        public string Localizacao { get; set; }
        public int Saida { get; set; }
        public int Entrada { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string MotivoEntrada { get; set; }
        public string MotivoSaida { get; set; }
        public int QtdDisponivel{ get; set; }
    }
}
