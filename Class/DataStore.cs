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
            new FuncModel("joao@teste.com", "joao"),
                        new FuncModel("pedro@teste.com", "pedro"),
            new FuncModel("lucas@teste.com", "lucas"),
            new FuncModel("ana@teste.com", "ana"),
            new FuncModel("rafael@teste.com", "rafael"),
            new FuncModel("julia@teste.com", "julia")
        };
        public static List<ProdutoModel> Produtos { get; set; } = new List<ProdutoModel>()
        {
            new ProdutoModel("Camisa Preta", 30.00m, "Camisa preta básica com gola V", "Camisas", "Prada", DateTime.Parse("2024-11-16"), DateTime.Parse("2024-11-17")),
            new ProdutoModel("Boné Preto", 40.00m, "Boné preto básico", "Acessórios", "Channel", DateTime.Parse("2024-11-16"), DateTime.Parse("2024-11-17")),
            new ProdutoModel("Calça Preta", 50.00m, "Calça preta jogger", "Calças", "Bluesteel", DateTime.Parse("2024-11-16"), DateTime.Parse("2024-11-17")),
            new ProdutoModel("Jaqueta Azul", 120.00m, "Jaqueta azul de inverno", "Jaquetas", "Nike", DateTime.Parse("2024-11-16"), DateTime.Parse("2024-11-17")),
            new ProdutoModel("Tênis Branco", 150.00m, "Tênis branco casual", "Calçados", "Adidas", DateTime.Parse("2024-11-16"), DateTime.Parse("2024-11-17")),
            new ProdutoModel("Cinto de Couro", 60.00m, "Cinto de couro legítimo", "Acessórios", "Gucci", DateTime.Parse("2024-11-16"), DateTime.Parse("2024-11-17")),
            new ProdutoModel("Meia Colorida", 10.00m, "Meia colorida divertida", "Meias", "Happy Socks", DateTime.Parse("2024-11-16"), DateTime.Parse("2024-11-17")),
            new ProdutoModel("Camisa Branca", 35.00m, "Camisa branca social", "Camisas", "Lacoste", DateTime.Parse("2024-11-16"), DateTime.Parse("2024-11-17")),
            new ProdutoModel("Saia Preta", 45.00m, "Saia preta midi", "Saia", "Zara", DateTime.Parse("2024-11-16"), DateTime.Parse("2024-11-17")),
            new ProdutoModel("Vestido Vermelho", 85.00m, "Vestido vermelho casual", "Vestidos", "H&M", DateTime.Parse("2024-11-16"), DateTime.Parse("2024-11-17"))
        };
        public static List<FornecedorModel> Fornecedores { get; set; } = new List<FornecedorModel>()
        {
            new FornecedorModel("Claudio", "pecas@gmail.com", "93568412355", "(19) 3663-5614"),
            new FornecedorModel("Sandra", "acessorios@gmail.com", "93571583855", "(45) 9873-1265"),
            new FornecedorModel("Laura", "calcas@gmail.com", "85201479632", "(32) 1469-8521"),
            new FornecedorModel("Carlos", "carlos@gmail.com", "12345678901", "(11) 91234-5678"),
            new FornecedorModel("Fernanda", "fernanda@gmail.com", "23456789012", "(21) 98765-4321"),
            new FornecedorModel("Ricardo", "ricardo@gmail.com", "34567890123", "(31) 97654 3210"),
            new FornecedorModel("Patricia", "patricia@gmail.com", "45678901234", "(41) 87654-3210"),
            new FornecedorModel("Roberto", "roberto@gmail.com", "56789012345", "(51) 76543-2109"),
            new FornecedorModel("Juliana", "juliana@gmail.com", "67890123456", "(61) 65432-1098"),
            new FornecedorModel("Eduardo", "eduardo@gmail.com", "78901234567", "(71) 54321-0987")
        }; 
        public static List<EstoqueModel> Estoques { get; set; } = new List<EstoqueModel>()
        {
            new EstoqueModel("SP", 1, 0, "Compra", "Nota Fiscal 001", 10),
            new EstoqueModel("RJ", 1, 0, "Compra", "Nota Fiscal 002", 10),
            new EstoqueModel("PA", 1, 0, "Compra", "Nota Fiscal 003", 10),
            new EstoqueModel("MG", 2, 0, "Compra", "Nota Fiscal 004", 15),
            new EstoqueModel("RS", 3, 0, "Compra", "Nota Fiscal 005", 20),
            new EstoqueModel("BA", 4, 0, "Compra", "Nota Fiscal 006", 25),
            new EstoqueModel("PR", 5, 0, "Compra", "Nota Fiscal 007", 30),
            new EstoqueModel("CE", 6, 0, "Compra", "Nota Fiscal 008", 35),
            new EstoqueModel("PE", 7, 0, "Compra", "Nota Fiscal 009", 40),
            new EstoqueModel("SC", 8, 0, "Compra", "Nota Fiscal 010", 45)
        };
    }
}