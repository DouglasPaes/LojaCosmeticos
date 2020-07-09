using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLojaCosmeticos
{
    public partial class frmRelCliente : Form
    {
        public frmRelCliente()
        {
            InitializeComponent();
        }

        private void frmRelCliente_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Aniversariantes por Dia e Mês");
            cbTipoRel.Items.Add("Aniversariantes do Mês");
            cbTipoRel.Items.Add("Aniversariantes Data Completa");
            cbTipoRel.Items.Add("Aniversariantes Idade");
            cbTipoRel.Items.Add("Aniversariantes Maiores de");
            cbTipoRel.Items.Add("Cidade");
            cbTipoRel.Items.Add("Sexo");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.SelectedIndex = 4;

            //CARREGAR COMBO MÊS
            cbMes.Items.Add("Escolha um Mês");
            cbMes.Items.Add("Janeiro");
            cbMes.Items.Add("Fevereiro");
            cbMes.Items.Add("Março");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Maio");
            cbMes.Items.Add("Junho");
            cbMes.Items.Add("Julho");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Setembro");
            cbMes.Items.Add("Outubro");
            cbMes.Items.Add("Novembro");
            cbMes.Items.Add("Dezembro");
            cbMes.SelectedIndex = 0;

            //CARREGAR COMBO DIA
            cbDia.Items.Add("Escolha um Dia");
            cbDia.Items.Add("01");
            cbDia.Items.Add("02");
            cbDia.Items.Add("03");
            cbDia.Items.Add("04");
            cbDia.Items.Add("05");
            cbDia.Items.Add("06");
            cbDia.Items.Add("07");
            cbDia.Items.Add("08");
            cbDia.Items.Add("09");
            cbDia.Items.Add("10");
            cbDia.Items.Add("11");
            cbDia.Items.Add("12");
            cbDia.Items.Add("13");
            cbDia.Items.Add("14");
            cbDia.Items.Add("15");
            cbDia.Items.Add("16");
            cbDia.Items.Add("17");
            cbDia.Items.Add("18");
            cbDia.Items.Add("19");
            cbDia.Items.Add("20");
            cbDia.Items.Add("21");
            cbDia.Items.Add("22");
            cbDia.Items.Add("23");
            cbDia.Items.Add("24");
            cbDia.Items.Add("25");
            cbDia.Items.Add("26");
            cbDia.Items.Add("27");
            cbDia.Items.Add("28");
            cbDia.Items.Add("29");
            cbDia.Items.Add("30");
            cbDia.Items.Add("31");
            cbDia.SelectedIndex = 0;

            //CARREGAR COMBO SEXO
            cbSexo.Items.Add("Escolha um Sexo");
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Masculino");
            cbSexo.SelectedIndex = 0;

            //CARREGAR COMBO DE CIDADE DO BANCO DE DADOS - TABELA CLIENTE
            classCliente cCliente = new classCliente();
            cbCidade.DataSource = cCliente.BuscarCidade(); // EXECUTAR MÉTODO DE CONSULTA CRIADO NA CLASSE CLIENTE
            cbCidade.DisplayMember = "Cidade"; // EXIBIR NA COMBO (CIDADE)
            cbCidade.ValueMember = "Cidade"; // GUARDAR NO BD (CIDADE)
            cbCidade.SelectedIndex = -1;
            this.rptClientes.RefreshReport();
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0) //Aniversariantes por Dia e Mês
            {
                gbIdadeMaior.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
                gbStatus.Enabled = false;
                gbAniversariantes.Enabled = true;
                gbIdade.Enabled = false;
                dtpInicial.Enabled = false;
                dtpFinal.Enabled = false;
                cbDia.Enabled = true;
                cbMes.Enabled = true;
            }

            if (cbTipoRel.SelectedIndex == 1) //Aniversariantes do Mês
            {
                gbIdadeMaior.Enabled = false;
                gbIdade.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
                gbStatus.Enabled = false;
                gbAniversariantes.Enabled = true;
                dtpInicial.Enabled = false;
                dtpFinal.Enabled = false;
                cbDia.Enabled = false;
                cbMes.Enabled = true;
            }

            if (cbTipoRel.SelectedIndex == 2) //Aniversariantes Data Completa
            {
                gbIdadeMaior.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
                gbStatus.Enabled = false;
                gbAniversariantes.Enabled = true;
                gbIdade.Enabled = false;
                dtpInicial.Enabled = true;
                dtpFinal.Enabled = true;
                cbDia.Enabled = false;
                cbMes.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 3) //Aniversariantes Idade
            {
                gbIdadeMaior.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
                gbStatus.Enabled = false;
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = true;
                cbDia.Enabled = false;
                cbMes.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 4) //Aniversariantes Maiores de 
            {
                gbIdadeMaior.Enabled = true;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
                gbStatus.Enabled = false;
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                cbDia.Enabled = false;
                cbMes.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 5) //Cidade
            {
                gbIdadeMaior.Enabled = false;
                cbCidade.Enabled = true;
                cbSexo.Enabled = false;
                gbStatus.Enabled = false;
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 6) //Sexo
            {
                gbIdadeMaior.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = true;
                gbStatus.Enabled = false;
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 7) //Status
            {
                gbIdadeMaior.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
                gbStatus.Enabled = true;
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            //BOTÃO GERAR RELATÓRIO - CASE ANIVERSARIANTES DO MÊS

            //VARIÁVEIS 
            classCliente cCliente = new classCliente();
            string pesquisa = cbTipoRel.SelectedItem.ToString(); //PARA PEGAR A OPÇÃO ESCOLHIDA PELO USUÁRIO
            switch (pesquisa)
            {
                case "Aniversariantes do Mês":
                    if (cbMes.Text != "Escolha um Mês")
                    {
                        int mes = Convert.ToInt32(cbMes.SelectedIndex);
                        classClientesBindingSource.DataSource = cCliente.RelClienteMes(mes);
                        this.rptClientes.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um Mês.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;


                case "Aniversariantes por Dia e Mês":
                    if (cbMes.Text != "Escolha um Mês" && cbDia.Text != "Escolha um Dia")

                    {
                        int mes = Convert.ToInt32(cbMes.SelectedIndex);
                        int dia = Convert.ToInt32(cbDia.SelectedIndex);
                        classClientesBindingSource.DataSource = cCliente.RelClienteDiaMes(mes, dia);
                        this.rptClientes.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher  Dia e Mês.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;

                case "Aniversariantes Data Completa":
                    if (dtpInicial.Text != "Escolha uma Data Inicial " && dtpFinal.Text != "Escolha uma Data Final ")

                    {
                        DateTime dinicio = Convert.ToDateTime(dtpInicial.Text);
                        DateTime dfinal = Convert.ToDateTime(dtpFinal.Text);
                        classClientesBindingSource.DataSource = cCliente.RelClienteDataCompleta(dinicio, dfinal);
                        this.rptClientes.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher  Data Inicial e Data Final.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;



                case "Aniversariantes Idade":
                    if (txtDe.Text != "Escolha uma Idade Inicial" && txtAte.Text != "Escolha uma Idade Final")

                    {
                        int idinicio = Convert.ToInt32(txtDe.Text);
                        int idfinal = Convert.ToInt32(txtAte.Text);
                        classClientesBindingSource.DataSource = cCliente.RelClienteIdade(idinicio, idfinal);
                        this.rptClientes.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher  Data Inicial e Data Final.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;


                //===============================================================================================================================================================


                case "Aniversariantes Maiores de":
                    if (txtMaiores.Text != "Escolha um Idade")

                    {
                        int maior = Convert.ToInt32(txtMaiores.Text);
                        classClientesBindingSource.DataSource = cCliente.RelClienteIdadeMaior(maior);
                        this.rptClientes.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher Um Idade .", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;
                //==================================================================================================================================================================
                case "Cidade":
                    if (cbCidade.Text != "")

                    {
                        string cidade = cbCidade.Text;
                        classClientesBindingSource.DataSource = cCliente.RelClienteCidade(cidade);
                        this.rptClientes.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher Uma Cidade .", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;

                case "Sexo":
                    if (cbSexo.Text != "Escolha um Sexo")

                    {
                        string sexo = cbSexo.Text;
                        classClientesBindingSource.DataSource = cCliente.RelClienteSexo(sexo);
                        this.rptClientes.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher Uma Sexo .", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;
                case "Status":
                    if (rbdAtivo.Checked == true)

                    {
                        cCliente.Status = 1;
                        classClientesBindingSource.DataSource = cCliente.RelClienteStatus(cCliente.Status);
                        this.rptClientes.RefreshReport();
                    }
                    else
                    {
                        cCliente.Status = 0;
                        classClientesBindingSource.DataSource = cCliente.RelClienteStatus(cCliente.Status);
                        this.rptClientes.RefreshReport();
                    }
                    break;
            }


        }
    }
}
