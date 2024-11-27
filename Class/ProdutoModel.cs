using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneGroup.Class
{
    public class ProdutoModel
    {
        private static int nextId = 1;
        private static int nextIdEstoque = 1;
        public ProdutoModel(string nome, decimal preco, string descricao, string categoria, string marca, DateTime dtEntrada, DateTime dtVenda)
        {
            Id = nextId++;
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Categoria = categoria;
            Marca = marca;
            IdEstoque = nextIdEstoque++;
            DtEntrada = dtEntrada;
            DtVenda = dtVenda;
        }
        public int Id { get; set; }
        public decimal Preco { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public int IdEstoque { get; set; }
        public DateTime DtEntrada { get; set; }
        public DateTime DtVenda { get; set; }
    public int QntVenda => GetQntVendidaFromEstoque(Id);

        public int GetQntVendidaFromEstoque(int idProduto)
        {
            var produto = DataStore.Produtos.FirstOrDefault(p => p.Id == idProduto);
            if (produto != null)
            {
                var estoque = DataStore.Estoques.FirstOrDefault(e => e.IdEstoque == produto.IdEstoque);
                return estoque != null ? estoque.Saida : 0;
            }
            return 0;
        }
        public void AtualizarQntVenda(int qtdVendida)
        {
            var estoque = DataStore.Estoques.FirstOrDefault(e => e.IdEstoque == this.IdEstoque);

            if (estoque != null)
            {
                estoque.Saida += qtdVendida;
                estoque.QtdDisponivel -= qtdVendida;  
                estoque.DataAtualizacao = DateTime.Now;  
                estoque.MotivoSaida = "Venda - " + this.Nome;  

                this.DtVenda = DateTime.Now;
            }
        }
    }
}