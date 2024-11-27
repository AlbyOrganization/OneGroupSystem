using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneGroup.Class
{
    public static class DataStore
    {
        public static List<FuncModel> Funcs { get; set; } = new List<FuncModel>
        {
            new FuncModel("clara@teste.com", "clara"),
            new FuncModel("bia@teste.com", "bia"),
            new FuncModel("alby@teste.com", "alby"),
            new FuncModel("joao@teste.com", "joao")
        };
        public static List<ProdutoModel> Produtos { get; set; } = new List<ProdutoModel>()
        {
            new ProdutoModel("Camisa Preta", 30.00m, "Camisa preta básica com gola V", "Camisas", "Prada", DateTime.Parse("2024-11-16"), DateTime.Parse("2024-11-17")), 
            new ProdutoModel("Boné Preto", 40.00m, "Boné preto básico", "Acessórios", "Channel", DateTime.Parse("2024-11-16"), DateTime.Parse("2024-11-17")), 
            new ProdutoModel("Calça Preta", 50.00m, "Calça preta jogger","Calças", "Bluesteel", DateTime.Parse("2024-11-16"), DateTime.Parse("2024-11-17")) 
        };
        public static List<FornecedorModel> Fornecedores { get; set; } = new List<FornecedorModel>()
        {
            new FornecedorModel("Claudio", "pecas@gmail.com", "93568412355", "19366356148246"),
            new FornecedorModel("Sandra", "acessorios@gmail.com", "93571583855", "45987312654752"),
            new FornecedorModel("Laura", "calcas@gmail.com", "85201479632", "32146985214785")
        };
        public static List<EstoqueModel> Estoques { get; set; } = new List<EstoqueModel>()
        {
            new EstoqueModel("SP", 1, 0, "Compra", "", 10),
            new EstoqueModel("RJ", 1, 0, "Compra", "", 10),
            new EstoqueModel("PA", 1, 0, "Compra", "", 10)
        };
    }
}