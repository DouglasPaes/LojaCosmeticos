using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaCosmeticos
{
    class classMarca
    {
        // Variaveis
        private int codigomarca;
        private DateTime datacadastro;
        private string nomemarca;
        private string observacao;
        private int status;
        private string erro;

        //Construtor
        public classMarca()
        {
            codigomarca = 0;
            datacadastro = DateTime.Now;
            nomemarca = null;
            observacao = null;
            status = 0;
            erro = null;
        }

        //Propriedades - Ler e gravar as informações do BD
        //Mesmo nome dos campos do BD para as propriedades
        public int CodigoMarca
        {
            get { return codigomarca;  }
            set { codigomarca = value; }
        }

        public DateTime DataCadastro
        {
            get { return datacadastro;  }
            set { datacadastro = value; }
        }

        public string NomeMarca
        {
            get { return nomemarca;  }
            set { nomemarca = value; }
        }

        public string Observacao
        {
            get { return observacao;  }
            set { observacao = value; }
        }

        public int Status
        {
            get { return status;  }
            set { status = value; }
        }

        public string Erro
        {
            get { return erro;  }
            set { erro = value; }
        }

        public int CadastrarMarca()
        {
            string query = "insert into Marca values (getdate(), '" + nomemarca + "' , '" + observacao + "' , 1)";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        public bool ValidaMarca(string marca)
        {
            classConexao cConexao = new classConexao();
            string query = "Declare @i bit set @i = 0";
            query += " if exists(select NomeMarca from Marca where NomeMarca ='" + marca + "')";
            query += " set @i = 0 else set @i = 1";
            query += " select @i[resp]";

            DataTable dt = cConexao.RetornaDataTable(query);
            int resp = Convert.ToInt32(dt.Rows[0][0]);
            if (resp == 0) //Se já existir alguma Marca com esse nome retorna 0
                return true;
            else
                return false; //Se não existir irá retornar 1
        }

        //Classe Marca
        //Método para buscar os dados (código e nome da marca) da Tabela marca
        //para popular a combo de categoria do formulario de cadastro de produtos
        public DataTable BuscarMarca()
        {
            string query = "select CodigoMarca, NomeMarca from Marca where Status = 1 order by NomeMarca";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método de Pesquisa de Marcas
        //Por descrição, CodigoMarca, Status
        //Campos:Código, Descrição, Status.

        // Pesquisa de Marca por Código
        public DataTable BuscarMarcaCodigo()
        {
            string query = "select Marca.CodigoMarca[Código], Marca.NomeMarca[Marca], Marca.Status [Ativo] from Marca where Marca.CodigoMarca = '" + codigomarca + "' and Marca.Status = 1 order by Marca.NomeMarca";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Marca por descrição (INICIAL)
        public DataTable BuscarMarcaDescricaoInicial()
        {
            string query = "select Marca.CodigoMarca[Código], Marca.NomeMarca[Marca], Marca.Status [Ativo] from Marca where Marca.NomeMarca like '" + nomemarca + "%' and Marca.Status = 1 order by Marca.NomeMarca";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Marca por descrição (CONTÉM)
        public DataTable BuscarMarcaDescricaoContem()
        {
            string query = "select Marca.CodigoMarca[Código], Marca.NomeMarca[Marca], Marca.Status [Ativo] from Marca where Marca.NomeMarca like '%" + nomemarca + "%' and Marca.Status = 1 order by Marca.NomeMarca";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Marca por Status
        public DataTable BuscarMarcaStatus()
        {
            string query = "select Marca.CodigoMarca[Código], Marca.NomeMarca[Marca], Marca.Status [Ativo] from Marca where Marca.Status = " + status + " order by Marca.NomeMarca";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método Para Buscar todos os dados do banco quando o usuário escolher a Marca na GRID e Clicar no Botão Editar

        public bool RetornaMarca(int cod)
        {
            string query = "select * from Marca where CodigoMarca = " + cod;
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                codigomarca = Convert.ToInt32(dt.Rows[0]["CodigoMarca"]);
                datacadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                nomemarca = Convert.ToString(dt.Rows[0]["NomeMarca"]);
                observacao = Convert.ToString(dt.Rows[0]["Observacao"]);
                status = Convert.ToInt32(dt.Rows[0]["Status"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        //Método para Atualizar Marca
        public bool AtualizarMarca()
        {
            string query = "update Marca set NomeMarca = '" + nomemarca + "', Observacao ='" + observacao + "', Status = " + status + " where CodigoMarca = " + codigomarca;
            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return true;
        }

        //Método para Excluir Marca
        public bool ExcluirMarca()
        {
            string query = "delete Marca where CodigoMarca = " + codigomarca;
            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }

        //RELATÓRIO RETORNANDO TODAS A MARCAS
        public DataTable RelMarca()
        {
            string query = "select CodigoMarca, NomeMarca, DataCadastro, Status from Marca where Status = 1 order by NomeMarca";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }
    }
}
