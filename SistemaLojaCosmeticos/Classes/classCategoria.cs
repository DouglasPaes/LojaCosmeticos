using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaCosmeticos
{
    class classCategoria
    {
        // Variáveis
        private int codigocategoria;
        private DateTime datacadastro;
        private string nomecategoria;
        private string observacao;
        private int status;
        private string erro;

        //Construtor - Iniciar as variaveis

        public classCategoria() // Nome igual da Classe
        {
            codigocategoria = 0;
            datacadastro = DateTime.Now;
            nomecategoria = null;
            observacao = null;
            status = 0;
            erro = null;
        }

        //Propriedades - Ler e gravar as informações do BD
        //Mesmo nome dos campos do BD para as propriedades

        public int CodigoCategoria
        {
            get { return codigocategoria; } // Leitura
            set { codigocategoria = value; } // Gravação
        }

        public DateTime DataCadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        public string NomeCategoria
        {
            get { return nomecategoria; }
            set { nomecategoria = value; }
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

        public string Erro
        {
            get { return erro; }
            set { erro = value; }
        }

        public int CadastrarCategoria()
        {
            string query = "insert into Categoria values (getdate(), '" + nomecategoria + "' , '" + observacao + "' , 1)";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        //Verificar se já está cadastrado no banco - Não repetir o nome da categoria
        public bool ValidaCategoria(string categoria)
        {
            classConexao cConexao = new classConexao();
            string query = "Declare @i bit set @i = 0";
            query += " if exists(select NomeCategoria from Categoria where NomeCategoria ='" + categoria + "')";
            query += " set @i = 0 else set @i = 1";
            query += " select @i[resp]";

            DataTable dt = cConexao.RetornaDataTable(query);
            int resp = Convert.ToInt32(dt.Rows[0][0]);
            if (resp == 0) //Se já existir alguma Categoria com esse nome retorna 0
                return true;
            else
                return false; //Se não existir irá retornar 1
        }

        //Classe Categoria
        //Método para buscar os dados (código e nome da cateogria) da Tabela categoria
        //para popular a combo de categoria do formulario de cadastro de produtos

        public DataTable BuscarCategoria()
        {
            string query = "select CodigoCategoria, NomeCategoria from Categoria where Status = 1 order by NomeCategoria";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método de Pesquisa de Categorias
        //Por descrição, CodigoCategoria, Status
        //Campos:Código, Descrição, Status.

        // Pesquisa de Categoria por Código
        public DataTable BuscarCategoriaCodigo()
        {
            string query = "select Categoria.CodigoCategoria[Código], Categoria.NomeCategoria[Categoria], Categoria.Status [Ativo] from Categoria where Categoria.CodigoCategoria = '" + codigocategoria + "' and Categoria.Status = 1 order by Categoria.NomeCategoria";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Categoria por descrição (INICIAL)
        public DataTable BuscarCategoriaDescricaoInicial()
        {
            string query = "select Categoria.CodigoCategoria[Código], Categoria.NomeCategoria[Categoria], Categoria.Status [Ativo] from Categoria where Categoria.NomeCategoria like '" + nomecategoria + "%' and Categoria.Status = 1 order by Categoria.NomeCategoria";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Categoria por descrição (CONTÉM)
        public DataTable BuscarCategoriaDescricaoContem()
        {
            string query = "select Categoria.CodigoCategoria[Código], Categoria.NomeCategoria[Categoria], Categoria.Status [Ativo] from Categoria where Categoria.NomeCategoria like '%" + nomecategoria + "%' and Categoria.Status = 1 order by Categoria.NomeCategoria";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Categoria por Status
        public DataTable BuscarCategoriaStatus()
        {
            string query = "select Categoria.CodigoCategoria[Código], Categoria.NomeCategoria[Categoria], Categoria.Status [Ativo] from Categoria where Categoria.Status = " + status + " order by Categoria.NomeCategoria";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método Para Buscar todos os dados do banco quando o usuário escolher a Categoria na GRID e Clicar no Botão Editar

        public bool RetornaCategoria(int cod)
        {
            string query = "select * from Categoria where CodigoCategoria = " + cod;
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                codigocategoria = Convert.ToInt32(dt.Rows[0]["CodigoCategoria"]);
                datacadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                nomecategoria = Convert.ToString(dt.Rows[0]["NomeCategoria"]);
                observacao = Convert.ToString(dt.Rows[0]["Observacao"]);
                status = Convert.ToInt32(dt.Rows[0]["Status"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        //Método para Atualizar Categoria
        public bool AtualizarCategoria()
        {
            string query = "update Categoria set NomeCategoria = '" + nomecategoria + "', Observacao ='" + observacao + "', Status = " + status + " where CodigoCategoria = " + codigocategoria;
            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return true;
        }

        //Método para Excluir Categoria
        public bool ExcluirCategoria()
        {
            string query = "delete Categoria where CodigoCategoria = " + codigocategoria;
            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }

        //RELATÓRIO RETORNANDO TODAS As CATEGORIAS
        public DataTable RelCategoria()
        {
            string query = "select CodigoCategoria, NomeCategoria, DataCadastro, Status from Categoria where Status = 1 order by NomeCategoria";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }
    }
}
