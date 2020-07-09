using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaCosmeticos
{
    class classCargo
    {
        // Variáveis
        private int codigocargo;
        private DateTime datacadastro;
        private string nomecargo;
        private string observacao;
        private int status;
        private string erro;

        //Construtor - Iniciar as variaveis

        public classCargo() // Nome igual da Classe
        {
            codigocargo = 0;
            datacadastro = DateTime.Now;
            nomecargo = null;
            observacao = null;
            status = 0;
            erro = null;
        }

        //Propriedades - Ler e gravar as informações do BD
        //Mesmo nome dos campos do BD para as propriedades

        public int CodigoCargo
        {
            get { return codigocargo; } // Leitura
            set { codigocargo = value; } // Gravação
        }

        public DateTime DataCadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        public string NomeCargo
        {
            get { return nomecargo; }
            set { nomecargo = value; }
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

        public int CadastrarCargo()
        {
            string query = "insert into Cargo values (getdate(), '" + nomecargo + "' , '" + observacao + "' , 1)";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        public bool ValidaCargo(string cargo)
        {
            classConexao cConexao = new classConexao();
            string query = "Declare @i bit set @i = 0";
            query += " if exists(select NomeCargo from Cargo where NomeCargo ='" + cargo + "')";
            query += " set @i = 0 else set @i = 1";
            query += " select @i[resp]";

            DataTable dt = cConexao.RetornaDataTable(query);
            int resp = Convert.ToInt32(dt.Rows[0][0]);
            if (resp == 0) //Se já existir algum Cargo com esse nome retorna 0
                return true;
            else
                return false; //Se não existir irá retornar 1
        }

        //Classe Cargo
        //Método para buscar os dados (código e nome da cargo) da Tabela cargo
        //para popular a combo de cargo do formulario de cadastro de Funcionarios
        public DataTable BuscarCargo()
        {
            string query = "select CodigoCargo, NomeCargo from Cargo where Status = 1 order by NomeCargo";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método de Pesquisa de Cargo
        //Por descrição, CodigoCargo, Status
        //Campos:Código, Descrição, Status.

        // Pesquisa de Cargo por Código
        public DataTable BuscarCargoCodigo()
        {
            string query = "select Cargo.CodigoCargo[Código], Cargo.NomeCargo[Cargo], Cargo.Status [Ativo] from Cargo where Cargo.CodigoCargo = '" + codigocargo + "' and Cargo.Status = 1 order by Cargo.NomeCargo";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Cargo por descrição (INICIAL)
        public DataTable BuscarCargoDescricaoInicial()
        {
            string query = "select Cargo.CodigoCargo[Código], Cargo.NomeCargo[Cargo], Cargo.Status [Ativo] from Cargo where Cargo.NomeCargo like '" + nomecargo + "%' and Cargo.Status = 1 order by Cargo.NomeCargo";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Cargo por descrição (CONTÉM)
        public DataTable BuscarCargoDescricaoContem()
        {
            string query = "select Cargo.CodigoCargo[Código], Cargo.NomeCargo[Cargo], Cargo.Status [Ativo] from Cargo where Cargo.NomeCargo like '%" + nomecargo + "%' and Cargo.Status = 1 order by Cargo.NomeCargo";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Cargo por Status
        public DataTable BuscarCargoStatus()
        {
            string query = "select Cargo.CodigoCargo[Código], Cargo.NomeCargo[Cargo], Cargo.Status [Ativo] from Cargo where Cargo.Status = " + status + " order by Cargo.NomeCargo";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método Para Buscar todos os dados do banco quando o usuário escolher o Cargo na GRID e Clicar no Botão Editar

        public bool RetornaCargo(int cod)
        {
            string query = "select * from Cargo where CodigoCargo = " + cod;
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                codigocargo = Convert.ToInt32(dt.Rows[0]["CodigoCargo"]);
                datacadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                nomecargo = Convert.ToString(dt.Rows[0]["NomeCargo"]);
                observacao = Convert.ToString(dt.Rows[0]["Observacao"]);
                status = Convert.ToInt32(dt.Rows[0]["Status"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        //Método para Atualizar Cargo
        public bool AtualizarCargo()
        {
            string query = "update Cargo set NomeCargo = '" + nomecargo + "', Observacao ='" + observacao + "', Status = " + status + " where CodigoCargo = " + codigocargo;
            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return true;
        }

        //Método para Excluir Cargo
        public bool ExcluirCargo()
        {
            string query = "delete Cargo where CodigoCargo = " + codigocargo;
            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }

        //RELATÓRIO RETORNANDO TODAS OS CARGOS
        public DataTable RelCargo()
        {
            string query = "select CodigoCargo, NomeCargo, DataCadastro, Status from Cargo where Status = 1 order by NomeCargo";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }
    }
}
