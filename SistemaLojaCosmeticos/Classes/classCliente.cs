﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaCosmeticos
{
    class classCliente
    {
        // Variáveis
        private int codigocliente;
        private DateTime datacadastro;
        private string nomecliente;
        private string rg;
        private string cpf;
        private DateTime datanascimento;
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
        private int status;
        private string erro;

        //Construtor - Iniciar as variaveis

        public classCliente() // Nome igual da Classe
        {
            codigocliente = 0;
            datacadastro = DateTime.Now;
            nomecliente = null;
            rg = null;
            cpf = null;
            datanascimento = DateTime.Now;
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

        public int CodigoCliente
        {
            get { return codigocliente; } // Leitura
            set { codigocliente = value; } // Gravação
        }

        public DateTime DataCadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        public string NomeCliente
        {
            get { return nomecliente; }
            set { nomecliente = value; }
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

        public int CadastrarCliente()          
        {
            string query = "insert into Cliente values (getdate(), '" + nomecliente + "' , '"+ rg + "','" + cpf + "', convert(date,'" + datanascimento + "', 103), '" + sexo + "', '" + rua + "', '" + numero + "', '" + complemento + "', '" + bairro + "', '"+ cidade + "', '" + estado + "','" + cep + "','" + email + "', '" + telefoneresidencial + "','" + telefonecelular +"' , 1)";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        /////////// MÉTODOS DE PESQUISA DE CLIENTES POR NOME, CPF, STATUS, DATA NASCIMENTO E CÓDIGO.
        
        //PESQUISA DE CLIENTE POR NOME (INICIAL)
        public DataTable BuscarClienteNomeInicial()
        {
            string query = "select CodigoCliente [Código], NomeCliente [Cliente], CPF, DataNascimento [Nascimento], Status [Ativo] from Cliente where NomeCliente like '" + nomecliente + "%' and Status = 1 order by NomeCliente"; 
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //PESQUISA DE CLIENTE POR NOME (CONTÉM)
        public DataTable BuscarClienteNomeContem()
        {
            string query = "select CodigoCliente [Código], NomeCliente [Cliente], CPF, DataNascimento [Nascimento], Status [Ativo] from Cliente where NomeCliente like '%" + nomecliente + "%' and Status = 1 order by NomeCliente";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }



        //PESQUISA DE CLIENTE POR CPF 
        public DataTable BuscarClienteCPF()
        {
            string query = "select CodigoCliente [Código], NomeCliente [Cliente], CPF, DataNascimento [Nascimento], Status [Ativo] from Cliente where CPF like '%" + cpf + "%' and Status = 1";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //PESQUISA DE CLIENTE POR STATUS
        public DataTable BuscarClienteStatus()
        {
            string query = "select CodigoCliente [Código], NomeCliente [Cliente], CPF, DataNascimento [Nascimento], Status [Ativo] from Cliente where Status = " + status + " order by NomeCliente";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //PESQUISA DE CLIENTE POR Data de Nascimento 
        public DataTable BuscarClienteDataNascimento()
        {
            string query = "select CodigoCliente [Código], NomeCliente [Cliente], CPF, DataNascimento [Nascimento], Status [Ativo] from Cliente where DataNascimento = convert(date, '" + datanascimento + "', 103) and Status = 1 order by NomeCliente";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //PESQUISA DE CLIENTE POR Código
        public DataTable BuscarClienteCodigo()
        {
            string query = " select CodigoCliente [Código], NomeCliente [Cliente], CPF, DataNascimento [Nascimento], Status [Ativo] from Cliente where  CodigoCliente = '" + codigocliente + "' and Status = 1";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        
        //MÉTODO PARA BUSCAR OS DADOS DO BANCO QUANDO O USUÁRIO ESCOLHE O CLIENTE NA GRID
        public bool RetornaCliente(int cod)
        {
            string query = "select * from Cliente where CodigoCliente =" + cod;
            classConexao obj = new classConexao();
            DataTable dt = obj.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                codigocliente = Convert.ToInt32(dt.Rows[0]["CodigoCliente"]);
                datacadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                nomecliente = dt.Rows[0]["NomeCliente"].ToString();
                rg = dt.Rows[0]["RG"].ToString();
                cpf = dt.Rows[0]["CPF"].ToString();
                datanascimento = Convert.ToDateTime(dt.Rows[0]["DataNascimento"]);
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


        //MÉTODO ATUALIZAR CLIENTE
        public bool AtualizarCliente()
        {
            string query = "update Cliente set NomeCliente = '" + nomecliente + "', RG = '" + rg + "', CPF = '" + cpf + "', DataNascimento = CONVERT(date, '" + datanascimento + "', 103), Sexo = '" + sexo + "',  Rua = '" + rua + "',  Numero = " + numero + ",  Complemento = '" + complemento + "',  Bairro = '" + bairro + "',  Cidade = '" + cidade + "',  Estado = '" + estado + "',  CEP = '" + cep + "',  Email = '" + email + "', TelefoneResidencial = '" + telefoneresidencial + "', TelefoneCelular = '" + telefonecelular + "', Status = " + status + " where CodigoCliente = " + codigocliente;
            classConexao cConexao = new classConexao();

            int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
                return false;
        }

        //MÉTODO EXCLUIR CLIENTE
        public bool ExcluirCliente()
        {
            string query = "delete Cliente where CodigoCliente = " + codigocliente;

            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
                return false;
        }

       
        //RETORNAR OS CLIENTES ANIVERSARIANTES DO MÊS
        public DataTable RelClienteMes(int mes)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status  from Cliente  where MONTH(DataNascimento) = " + mes + " and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES ANIVERSARIANTES DIA E MÊS
        public DataTable RelClienteDiaMes(int dia, int mes)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status from Cliente where DAY(DataNascimento) = " + dia + " and MONTH(DataNascimento) = " + mes + " and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES POR IDADE
        //8766 NÚMERO DE HORAS EM UM ANO(APROXIMADAMENTE, POIS JÁ ANOS BISSEXTOS)
        public DataTable RelClienteIdade(int idadei, int idadef)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status from Cliente where DATEDIFF(hour, DataNascimento, getdate()) / 8766 between " + idadei + "  and " + idadef + " and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES POR IDADE MAIORES DE
        //8766 NÚMERO DE HORAS EM UM ANO(APROXIMADAMENTE, POIS JÁ ANOS BISSEXTOS)
        public DataTable RelClienteIdadeMaior(int idadem)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status from Cliente where DATEDIFF(hour, DataNascimento, getdate()) / 8766 > " + idadem + "  and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES ANIVERSARIANTES DATA COMPLETA
        public DataTable RelClienteDataCompleta(DateTime dinicio, DateTime dfinal)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status from Cliente where DataNascimento between convert (date,'" + dinicio + "',103) and convert (date,'" + dfinal + "',103) and Status = 1 order by NomeCliente";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES DE ACORDO COM A CIDADE
        public DataTable RelClienteCidade(string cidade)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status From Cliente where Cidade = '" + cidade + "' and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES DE ACORDO COM O STATUS
        public DataTable RelClienteStatus(int status)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status from Cliente where Status = " + status + " order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES DE ACORDO COM O SEXO
        public DataTable RelClienteSexo(string sexo)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status from Cliente where Sexo = '" + sexo + "' and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //MÉTODO PARA CARREGAR COMBO DE CIDADES NO RELATÓRIO DE CLIENTES COMPLETO
        public DataTable BuscarCidade()
        {
            string query = "select distinct Cidade from Cliente order by Cidade";

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

