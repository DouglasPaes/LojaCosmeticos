using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaCosmeticos
{
    class classFuncionario
    {

        // Variáveis
        private int codigofuncionario;
        private DateTime datacadastro;
        private string nomefuncionario;
        private string rg;
        private string cpf;
        private DateTime datanascimento;
        private DateTime dataadmissao;
        private string sexo;
        private string rua;
        private int numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
        private string email;
        private string telefoneresidencial;
        private string telefonecelular;
        private int codigocargo;
        private int status;
        private string erro;

        //Construtor - Iniciar as variaveis

        public classFuncionario() // Nome igual da Classe
        {
            codigofuncionario = 0;
            datacadastro = DateTime.Now;
            nomefuncionario = null;
            rg = null;
            cpf = null;
            datanascimento = DateTime.Now;
            dataadmissao = DateTime.Now;
            sexo = null;
            rua = null;
            numero = 0;
            complemento = null;
            bairro = null;
            cidade = null;
            estado = null;
            cep = null;
            email = null;
            telefoneresidencial = null;
            telefonecelular = null;
            status = 0;
            erro = null;
        }

        //Propriedades - Ler e gravar as informações do BD
        //Mesmo nome dos campos do BD para as propriedades

        public int CodigoFuncionario
        {
            get { return codigofuncionario; } // Leitura
            set { codigofuncionario = value; } // Gravação
        }

        public DateTime DataCadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        public string NomeFuncionario
        {
            get { return nomefuncionario; }
            set { nomefuncionario = value; }
        }

        public string RG
        {
            get { return rg; }
            set { rg = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public DateTime DataNascimento
        {
            get { return datanascimento; }
            set { datanascimento = value; }
        }

        public DateTime DataAdmissao
        {
            get { return dataadmissao; }
            set { dataadmissao = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string TelefoneResidencial
        {
            get { return telefoneresidencial; }
            set { telefoneresidencial = value; }
        }

        public string TelefoneCelular
        {
            get { return telefonecelular; }
            set { telefonecelular = value; }
        }

        public int CodigoCargo
        {
            get { return codigocargo; }
            set { codigocargo = value; }
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

        //Insert para Campos do Tipo Data
        //convert(date,'"+ variavel +"',103)

        //Insert para campos do tipo valor (DECIMAL)
        //variavel.ToString().Replace(",",".")

        public int CadastrarFuncionario()
        {
            string query = "insert into Funcionario values (getdate(), '" + nomefuncionario + "' , '" + rg + "','" + cpf + "', convert(date,'" + datanascimento + "', 103), convert(date,'" + dataadmissao + "', 103),'" + sexo + "', '" + rua + "', '" + numero + "', '" + complemento + "', '" + bairro + "', '" + cidade + "', '" + estado + "','" + cep + "','" + email + "', '" + telefoneresidencial + "','" + telefonecelular + "',1,'" + codigocargo + "')";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        /////////// MÉTODOS DE PESQUISA DE FUNCIONARIOS POR NOME, CPF, STATUS, DATA NASCIMENTO, CÓDIGO E CARGO


        // Pesquisa de Funcionario por Código
        public DataTable BuscarFuncionarioCodigo()
        {
            string query = "select Funcionario.CodigoFuncionario[Código], Funcionario.NomeFuncionario[Funcionário], Funcionario.CPF, Funcionario.DataNascimento[Nascimento],Cargo.NomeCargo[Cargo], Funcionario.Status[Ativo] from Funcionario inner join Cargo on Cargo.CodigoCargo = Funcionario.CodigoCargo where Funcionario.CodigoFuncionario = '" + codigofuncionario + "' and Funcionario.Status = 1 order by Funcionario.NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Funcionario por Nome (INICIAL)
        public DataTable BuscarFuncionarioNomeInicial()
        {
            string query = "select Funcionario.CodigoFuncionario[Código], Funcionario.NomeFuncionario[Funcionário], Funcionario.CPF, Funcionario.DataNascimento[Nascimento],Cargo.NomeCargo[Cargo], Funcionario.Status[Ativo] from Funcionario inner join Cargo on Cargo.CodigoCargo = Funcionario.CodigoCargo where Funcionario.NomeFuncionario like '" + nomefuncionario + "%' and Funcionario.Status = 1 order by Funcionario.NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Funcionario por Nome (CONTÉM)
        public DataTable BuscarFuncionarioNomeContem()
        {
            string query = "select Funcionario.CodigoFuncionario[Código], Funcionario.NomeFuncionario[Funcionário], Funcionario.CPF, Funcionario.DataNascimento[Nascimento],Cargo.NomeCargo[Cargo], Funcionario.Status[Ativo] from Funcionario inner join Cargo on Cargo.CodigoCargo = Funcionario.CodigoCargo where Funcionario.NomeFuncionario like '%" + nomefuncionario + "%' and Funcionario.Status = 1 order by Funcionario.NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Funcionario por Status
        public DataTable BuscarFuncionarioStatus()
        {
            string query = "select Funcionario.CodigoFuncionario[Código], Funcionario.NomeFuncionario[Funcionário], Funcionario.CPF, Funcionario.DataNascimento[Nascimento],Cargo.NomeCargo[Cargo], Funcionario.Status[Ativo] from Funcionario inner join Cargo on Cargo.CodigoCargo = Funcionario.CodigoCargo where Funcionario.Status = " + status + " order by Funcionario.NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Funcionario por CPF
        public DataTable BuscarFuncionarioCPF()
        {
            string query = "select Funcionario.CodigoFuncionario[Código], Funcionario.NomeFuncionario[Funcionário], Funcionario.CPF, Funcionario.DataNascimento[Nascimento],Cargo.NomeCargo[Cargo], Funcionario.Status[Ativo] from Funcionario inner join Cargo on Cargo.CodigoCargo = Funcionario.CodigoCargo where Funcionario.CPF = '" + cpf + "' and Funcionario.Status = 1 order by Funcionario.NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

  

        //Pesquisa de Funcionario por Data NASCIMENTO
        public DataTable BuscarFuncionarioDataNascimento()
        {
            string query = "select Funcionario.CodigoFuncionario[Código], Funcionario.NomeFuncionario[Funcionário], Funcionario.CPF, Funcionario.DataNascimento[Nascimento],Cargo.NomeCargo[Cargo], Funcionario.Status[Ativo] from Funcionario inner join Cargo on Cargo.CodigoCargo = Funcionario.CodigoCargo where Funcionario.DataNascimento = convert(date, '" + datanascimento + "', 103) and Funcionario.Status = 1 order by Funcionario.NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Pesquisa de Funcionario por Cargo
        public DataTable BuscarFuncionarioCargo()
        {
            string query = "select Funcionario.CodigoFuncionario[Código], Funcionario.NomeFuncionario[Funcionário], Funcionario.CPF, Funcionario.DataNascimento[Nascimento],Cargo.NomeCargo[Cargo], Funcionario.Status[Ativo] from Funcionario inner join Cargo on Cargo.CodigoCargo = Funcionario.CodigoCargo where Funcionario.CodigoCargo = '" + codigocargo + "' and Funcionario.Status = 1 order by Funcionario.NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método Para Buscar todos os dados do banco quando o usuário escolher a Categoria na GRID e Clicar no Botão Editar

        public bool RetornaFuncionario(int cod)
        {
            string query = "select * from Funcionario where CodigoFuncionario =" + cod;
            classConexao obj = new classConexao();
            DataTable dt = obj.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                codigofuncionario = Convert.ToInt32(dt.Rows[0]["CodigoFuncionario"]);
                codigocargo = Convert.ToInt32(dt.Rows[0]["CodigoCargo"]);
                datacadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                nomefuncionario = dt.Rows[0]["NomeFuncionario"].ToString();
                rg = dt.Rows[0]["RG"].ToString();
                cpf = dt.Rows[0]["CPF"].ToString();
                datanascimento = Convert.ToDateTime(dt.Rows[0]["DataNascimento"]);
                dataadmissao = Convert.ToDateTime(dt.Rows[0]["DataAdmissao"]);
                sexo = dt.Rows[0]["Sexo"].ToString();
                rua = dt.Rows[0]["Rua"].ToString();
                numero = Convert.ToInt32(dt.Rows[0]["Numero"]);
                complemento = dt.Rows[0]["Complemento"].ToString();
                bairro = dt.Rows[0]["Bairro"].ToString();
                cidade = dt.Rows[0]["Cidade"].ToString();
                estado = dt.Rows[0]["Estado"].ToString();
                cep = dt.Rows[0]["CEP"].ToString();
                email = dt.Rows[0]["Email"].ToString();
                telefoneresidencial = dt.Rows[0]["TelefoneResidencial"].ToString();
                telefonecelular = dt.Rows[0]["TelefoneCelular"].ToString();
                status = Convert.ToInt32(dt.Rows[0]["Status"]);

                return true;
            }
            else
                return false;
        }

        //Método para Atualizar Funcionario
        public bool AtualizarFuncionario()
        {
            string query = "update Funcionario set NomeFuncionario = '" + nomefuncionario + "', DataAdmissao = convert(date,'" + dataadmissao + "', 103), DataNascimento = convert(date, '" + datanascimento + "', 103), Email = '" + email + "', Status = " + status + ", CodigoCargo = " + codigocargo + ", RG = '" + rg + "', CPF ='" + cpf + "', TelefoneCelular = '" + telefonecelular + "', TelefoneResidencial = '" + telefoneresidencial + "', Rua ='" + rua + "', Numero = " + numero + ", Cidade ='" + cidade + "', Bairro ='" + bairro + "', Complemento = '" + complemento + "', CEP ='" + cep + "', Sexo = '" + sexo + "' where CodigoFuncionario = " + codigofuncionario;
            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
                return false;
        }

        //Método para Excluir Funcionario
        public bool ExcluirFuncionario()
        {
            string query = "delete Funcionario where CodigoFuncionario = " + codigofuncionario;
            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }

        public DataTable BuscarFuncionario()
        {
            string query = "select CodigoFuncionario, NomeFuncionario from Funcionario where CodigoCargo = 2 and Status = 1 order by NomeFuncionario ";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //RETORNAR OS CLIENTES ANIVERSARIANTES DO MÊS
        public DataTable RelFuncionarioMes(int mes)
        {
            string query = "select CodigoFuncionario, CPF, NomeFuncionario, DataNascimento, Email, TelefoneCelular, Sexo, Status  from Funcionario  where MONTH(DataNascimento) = " + mes + " and Status = 1 order by NomeFuncionario";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES ANIVERSARIANTES DIA E MÊS
        public DataTable RelFuncionarioDiaMes(int dia, int mes)
        {
            string query = "select CodigoFuncionario, CPF, NomeFuncionario, DataNascimento, Email, TelefoneCelular, Sexo, Status from Funcionario where DAY(DataNascimento) = " + dia + " and MONTH(DataNascimento) = " + mes + " and Status = 1 order by NomeFuncionario";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES POR IDADE
        //8766 NÚMERO DE HORAS EM UM ANO(APROXIMADAMENTE, POIS JÁ ANOS BISSEXTOS)
        public DataTable RelFuncionarioIdade(int idadei, int idadef)
        {
            string query = "select CodigoFuncionario, CPF, NomeFuncionario, DataNascimento, Email, TelefoneCelular, Sexo, Status from Funcionario where DATEDIFF(hour, DataNascimento, getdate()) / 8766 between " + idadei + "  and " + idadef + " and Status = 1 order by NomeFuncionario";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES POR IDADE MAIORES DE
        //8766 NÚMERO DE HORAS EM UM ANO(APROXIMADAMENTE, POIS JÁ ANOS BISSEXTOS)
        public DataTable RelFuncionarioIdadeMaior(int idadem)
        {
            string query = "select CodigoFuncionario, CPF, NomeFuncionario, DataNascimento, Email, TelefoneCelular, Sexo, Status from Funcionario where DATEDIFF(hour, DataNascimento, getdate()) / 8766 > " + idadem + "  and Status = 1 order by NomeFuncionario";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES ANIVERSARIANTES DATA COMPLETA
        public DataTable RelFuncionarioDataCompleta(DateTime dinicio, DateTime dfinal)
        {
            string query = "select CodigoFuncionario, CPF, NomeFuncionario, DataNascimento, Email, TelefoneCelular, Sexo, Status from Funcionario where DataNascimento between convert (date,'" + dinicio + "',103) and convert (date,'" + dfinal + "',103) and Status = 1 order by NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES DE ACORDO COM A CIDADE
        public DataTable RelFuncionarioCidade(string cidade)
        {
            string query = "select CodigoFuncionario, CPF, NomeFuncionario, DataNascimento, Email, TelefoneCelular, Sexo, Status From Funcionario where Cidade = '" + cidade + "' and Status = 1 order by NomeFuncionario";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES DE ACORDO COM O STATUS
        public DataTable RelFuncionarioStatus(int status)
        {
            string query = "select CodigoFuncionario, CPF, NomeFuncionario, DataNascimento, Email, TelefoneCelular, Sexo, Status from Funcionario where Status = " + status + " order by NomeFuncionario";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES DE ACORDO COM O SEXO
        public DataTable RelFuncionarioSexo(string sexo)
        {
            string query = "select CodigoFuncionario, CPF, NomeFuncionario, DataNascimento, Email, TelefoneCelular, Sexo, Status from Funcionario where Sexo = '" + sexo + "' and Status = 1 order by NomeFuncionario";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //MÉTODO PARA CARREGAR COMBO DE CIDADES NO RELATÓRIO DE CLIENTES COMPLETO
        public DataTable BuscarCidade()
        {
            string query = "select distinct Cidade from Funcionario order by Cidade";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public DataTable BuscarCliente(string cli)
        {
            string query = "select CodigoCliente, NomeCliente from Cliente where Status = 1 and NomeCliente like '%" + cli + "%' order by NomeCliente";
            classConexao obj = new classConexao();
            return obj.RetornaDataTable(query);
        }


    }




}

