using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaCosmeticos
{
    class classProduto
    {
        // Variavies
        private int codigoproduto;
        private DateTime datacadastro;
        private string nomeproduto;
        private int qtdeestoque;
        private decimal precovenda;
        private string observacao;
        private int status;
        private int codigocategoria;
        private int codigomarca;
        private string erro;

        // Construtor
        public classProduto()
        {
            codigoproduto = 0;
            datacadastro = DateTime.Now;
            nomeproduto = null;
            qtdeestoque = 0;
            precovenda = 0;
            observacao = null;
            status = 0;
            codigocategoria = 0;
            codigomarca = 0;
            erro = null;
        }

        //Propriedades - Ler e gravar as informações do BD
        //Mesmo nome dos campos do BD para as propriedades

        public int CodigoProduto
        {
            get { return codigoproduto;  }
            set { codigoproduto = value; }
        }

        public DateTime DataCadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        public string NomeProduto
        {
            get { return nomeproduto; }
            set { nomeproduto = value; }
        }

        public int QtdeEstoque
        {
            get { return qtdeestoque; }
            set { qtdeestoque = value; }
        }

        public decimal PrecoVenda
        {
            get { return precovenda; }
            set { precovenda = value; }
        }

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public int CodigoCategoria
        {
            get { return codigocategoria; }
            set { codigocategoria = value; }
        }

        public int CodigoMarca
        {
            get { return codigomarca; }
            set { codigomarca = value; }
        }

        public string Erro
        {
            get { return erro; }
            set { erro = value; }
        }

        //Insert para campos do tipo valor (DECIMAL)
        //variavel.ToString().Replace(",",".") 
        public int CadastrarProduto()
        {
            string query = "insert into Produto values (getdate(), '" + nomeproduto + "','" + qtdeestoque + "','" + precovenda.ToString().Replace(",", ".") + "','" + observacao + "', 1, '" + codigocategoria + "', '" + codigomarca + "')";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        //Verificar se já está cadastrado no banco - Não repetir o nome do produto
        public bool ValidaProduto(string produto)
        {
            classConexao cConexao = new classConexao();
            string query = "Declare @i bit set @i = 0";
            query += " if exists(select NomeProduto from Produto where NomeProduto ='" + produto + "')";
            query += " set @i = 0 else set @i = 1";
            query += " select @i[resp]";

            DataTable dt = cConexao.RetornaDataTable(query);
            int resp = Convert.ToInt32(dt.Rows[0][0]);
            if (resp == 0) //Se já existir alguma Produto com esse nome retrna 0
                return true;
            else
                return false; //Se não existir irá retornar 1
        }

        //Método de Pesquisa de produtos
        //Por descrição, Categoria, marca, status e preço
        //Campos:Código, Produto, Qtde, Preço, Marca, Categoria, Status.

        //Pesquisa de Produto por descrição (INICIAL)
        public DataTable BuscarProdutoDescricaoInicial()
        {
            string query = "select Produto.CodigoProduto[Código], Produto.NomeProduto[Produto], Produto.QtdeEstoque[Estoque],Produto.PrecoVenda[Preço R$], Marca.NomeMarca[Marca], Categoria.NomeCategoria[Categoria], Produto.Status [Ativo] from Produto inner join Marca on Produto.CodigoMarca = Marca.CodigoMarca inner join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.NomeProduto like '" + nomeproduto + "%' and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Produto por descrição (CONTÉM)
        public DataTable BuscarProdutoDescricaoContem()
        {
            string query = "select Produto.CodigoProduto[Código], Produto.NomeProduto[Produto], Produto.QtdeEstoque[Estoque],Produto.PrecoVenda[Preço R$], Marca.NomeMarca[Marca], Categoria.NomeCategoria[Categoria], Produto.Status [Ativo] from Produto inner join Marca on Produto.CodigoMarca = Marca.CodigoMarca inner join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.NomeProduto like '%" + nomeproduto + "%' and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisar de Produto por categoria
        public DataTable BuscarProdutoCategoria()
        {
            string query = "select Produto.CodigoProduto[Código], Produto.NomeProduto[Produto], Produto.QtdeEstoque[Estoque],Produto.PrecoVenda[Preço R$], Marca.NomeMarca[Marca], Categoria.NomeCategoria[Categoria], Produto.Status [Ativo] from Produto inner join Marca on Produto.CodigoMarca = Marca.CodigoMarca inner join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.CodigoCategoria = " + codigocategoria + " and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisar de Produto por Marca
        public DataTable BuscarProdutoMarca()
        {
            string query = "select Produto.CodigoProduto[Código], Produto.NomeProduto[Produto], Produto.QtdeEstoque[Estoque],Produto.PrecoVenda[Preço R$], Marca.NomeMarca[Marca], Categoria.NomeCategoria[Categoria], Produto.Status [Ativo] from Produto inner join Marca on Produto.CodigoMarca = Marca.CodigoMarca inner join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.CodigoMarca = " + codigomarca + " and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisar de Produto por Status
        public DataTable BuscarProdutoStatus()
        {
            string query = "select Produto.CodigoProduto[Código], Produto.NomeProduto[Produto], Produto.QtdeEstoque[Estoque],Produto.PrecoVenda[Preço R$], Marca.NomeMarca[Marca], Categoria.NomeCategoria[Categoria], Produto.Status [Ativo] from Produto inner join Marca on Produto.CodigoMarca = Marca.CodigoMarca inner join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.Status = " + status + " order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisar de Produto por Preço
        public DataTable BuscarProdutoPreco(decimal precoi, decimal precof)
        {
            string query = "select Produto.CodigoProduto[Código], Produto.NomeProduto[Produto], Produto.QtdeEstoque[Estoque],Produto.PrecoVenda[Preço R$], Marca.NomeMarca[Marca], Categoria.NomeCategoria[Categoria], Produto.Status [Ativo] from Produto inner join Marca on Produto.CodigoMarca = Marca.CodigoMarca inner join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.PrecoVenda between '" + precoi.ToString().Replace(",",".") + "' and '" + precof.ToString().Replace(",",".") + "' and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método Para Buscar todos os dados do banco quando o usuário escolher o produto na GRID e Clicar no Botão Editar

        public bool RetornaProduto(int cod)
        {
            string query = "select * from Produto where CodigoProduto = " + cod;
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                codigoproduto = Convert.ToInt32(dt.Rows[0]["CodigoProduto"]);
                datacadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                nomeproduto = Convert.ToString(dt.Rows[0]["NomeProduto"]);
                qtdeestoque = Convert.ToInt32(dt.Rows[0]["QtdeEstoque"]);
                precovenda = Convert.ToDecimal(dt.Rows[0]["PrecoVenda"]);
                observacao = Convert.ToString(dt.Rows[0]["Observacao"]);
                status = Convert.ToInt32(dt.Rows[0]["Status"]);
                codigomarca = Convert.ToInt32(dt.Rows[0]["CodigoMarca"]);
                codigocategoria = Convert.ToInt32(dt.Rows[0]["CodigoCategoria"]);

                return true;
            }
            else
            {
                return false;
            }
        }

         //Método para Atualizar Produto
        public bool AtualizarProduto()
        {
            string query = "update Produto set NomeProduto = '" + nomeproduto + "', QtdeEstoque = " + qtdeestoque + ", PrecoVenda = '" + precovenda.ToString().Replace(",", ".") + "', Observacao ='" + observacao + "', Status = " + status + ", CodigoCategoria = " + codigocategoria + ", CodigoMarca = " + codigomarca + " where CodigoProduto = " + codigoproduto;
            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return true;
        }

        //Método para Excluir Produto
        public bool ExcluirProduto()
        {
            string query = "delete Produto where CodigoProduto = " + codigoproduto;
            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }

        //Método para Pesquisar os produtos no formulário de Vendas

        public DataTable BuscaProduto(string prod)
        {
            string query = "select Produto.CodigoProduto [Código], Produto.NomeProduto [Produto] , Produto.QtdeEstoque [Estoque], Produto.PrecoVenda [Preço], Marca.NomeMarca [Marca] from Produto inner join Marca on Produto.CodigoMarca = Marca.CodigoMarca where Produto.Status = 1 and Produto.NomeProduto like '%" + prod + "%' order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método usado para quando clicar na grid de produtos no formulário de vendas,
        //Carregar as informações do Produto (Nome, Preço, Qtde Estoque) Nos Text Box do Form de Vendas

        public bool BuscaProdutoId(int cod)
        {
            string query = "Select NomeProduto, PrecoVenda, QtdeEstoque from Produto where CodigoProduto = " + cod;
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count >= 0)
            {
                NomeProduto = (string)dt.Rows[0]["NomeProduto"];
                PrecoVenda = (decimal)dt.Rows[0]["PrecoVenda"];
                QtdeEstoque = (int)dt.Rows[0]["QtdeEstoque"];
                return true;
            }
            else
                return false;
        }

        //Levar Nome do Produto para a lista de intens (GRID)

        public string BuscaNomeProd(int cod)
        {
            string query = "select NomeProduto [Produto] from Produto where CodigoProduto = " + cod;
            classConexao cConexao = new classConexao();

            DataTable dt = cConexao.RetornaDataTable(query);
            if (dt.Rows.Count > 0)
            {
                NomeProduto = dt.Rows[0]["Produto"].ToString();

            }
            return NomeProduto;
        }

        //Método para Atualizar estoque

        public bool AtualizaQtde(int qtde, int cod)
        {
            string query = "update Produto set QtdeEstoque = " + qtde + "where CodigoProduto = " + cod;
            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
                return false;
        }

        //Retornar os produtos pelo Preço

        public DataTable RelProdutoPreco(decimal preco)
        {
            string query = " select Produto.CodigoProduto, Produto.NomeProduto, Produto.QtdeEstoque,Produto.PrecoVenda,  Marca.NomeMarca, Categoria.NomeCategoria, Produto.Status from Produto inner join Marca on Produto.CodigoMarca = Marca.CodigoMarca inner join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.PrecoVenda = '" + preco.ToString().Replace(",", ".") + "' and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Retornar os produtos pela quantidade de estoque
        public DataTable RelProdutoQtdeEstoque(int qtde)
        {
            string query = "select Produto.CodigoProduto, Produto.NomeProduto, Produto.QtdeEstoque,Produto.PrecoVenda,  Marca.NomeMarca, Categoria.NomeCategoria, Produto.Status from Produto inner join Marca on Produto.CodigoMarca = Marca.CodigoMarca inner join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.QtdeEstoque = '" + qtde + "' and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Retornar os produtos pelo Status

        public DataTable RelProdutoStatus(int status)
        {
            string query = "select Produto.CodigoProduto, Produto.NomeProduto, Produto.QtdeEstoque,Produto.PrecoVenda,  Marca.NomeMarca, Categoria.NomeCategoria, Produto.Status from Produto inner join Marca on Produto.CodigoMarca = Marca.CodigoMarca inner join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.Status = '" + status + "' order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Retornar os produtos pela Categoria

        public DataTable RelProdutoCategoria(string categoria)
        {
            string query = "select Produto.CodigoProduto, Produto.NomeProduto, Produto.QtdeEstoque,Produto.PrecoVenda,  Marca.NomeMarca, Categoria.NomeCategoria, Produto.Status from Produto inner join Marca on Produto.CodigoMarca = Marca.CodigoMarca inner join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Categoria.NomeCategoria = '" + categoria + "'and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Retornar os produtos pela Marca

        public DataTable RelProdutoMarca(string marca)
        {
            string query = "select Produto.CodigoProduto, Produto.NomeProduto, Produto.QtdeEstoque,Produto.PrecoVenda,  Marca.NomeMarca, Categoria.NomeCategoria, Produto.Status from Produto inner join Marca on Produto.CodigoMarca = Marca.CodigoMarca inner join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Marca.NomeMarca = '" + marca + "'and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //MÉTODO PARA CARREGAR COMBO DE CATEGORIA NO RELATÓRIO DE PRODUTO COMPLETO
        public DataTable BuscarCategoria()
        {
            string query = "select distinct NomeCategoria from Categoria order by NomeCategoria";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //MÉTODO PARA CARREGAR COMBO DE MARCA NO RELATÓRIO DE PRODUTO COMPLETO
        public DataTable BuscarMarca()
        {
            string query = "select distinct NomeMarca from Marca order by NomeMarca";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

    }
}
