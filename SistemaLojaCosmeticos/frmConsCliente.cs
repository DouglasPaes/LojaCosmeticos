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
    public partial class frmConsCliente : Form
    {
        public frmConsCliente()
        {
            InitializeComponent();
        }

        private void frmConsCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //O Código "!E.SHIFT" indica que é para mudar para o próximo campo se pressionado enter, e ir para o campo anterior se pressionados SHIFT e ENTER SIMULTANEAMENTE
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        
      

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //VARIÁVEL PARA GUARDAR A OPÇÃO NA COMBO DE OPÇÕES
            string Consulta = cbOpcoes.SelectedItem.ToString();
            classCliente cCliente = new classCliente();
            switch (Consulta)
            {
                case "Nome":
                    //VERIFICAR SE ALGUM NOME FOI DIGITADO
                    if (txtPesquisar.Text != "")
                    {
                        //INÍCIO
                        if (rbtInicio.Checked)
                        {
                            cCliente.NomeCliente = txtPesquisar.Text;
                            dgvCliente.DataSource = cCliente.BuscarClienteNomeInicial();
                        }

                        //CONTÉM
                        else if (rbtContem.Checked)
                        {
                            cCliente.NomeCliente = txtPesquisar.Text;
                            dgvCliente.DataSource = cCliente.BuscarClienteNomeContem();
                        }
                    }
                    else
                        MessageBox.Show("Favor informar um Nome.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Código":
                    if (txtPesquisar.Text != "")
                    {
                        cCliente.CodigoCliente = Convert.ToInt32(txtPesquisar.Text);
                        dgvCliente.DataSource = cCliente.BuscarClienteCodigo();
                    }
                    else
                        MessageBox.Show("Favor informar o código do Cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "CPF":
                    if (mskCpf.Text != "   .   .   -")
                    {
                        cCliente.CPF = Convert.ToString(mskCpf.Text);
                        dgvCliente.DataSource = cCliente.BuscarClienteCPF();
                    }
                    else
                        MessageBox.Show("Favor informar o CPF do Cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Nascimento":
                    if (mskDataNascimento.Text != "  /  /")
                    {
                        cCliente.DataNascimento = Convert.ToDateTime(mskDataNascimento.Text);
                        dgvCliente.DataSource = cCliente.BuscarClienteDataNascimento();
                    }
                    else
                        MessageBox.Show("Favor informar a Data de Nascimento do Cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Status":
                    if (rbtAtivo.Checked == true)
                    {
                        cCliente.Status = 1;
                        dgvCliente.DataSource = cCliente.BuscarClienteStatus();
                    }
                    else
                        cCliente.Status = 0;
                    dgvCliente.DataSource = cCliente.BuscarClienteStatus();
                    break;
            }
        }

        
        private void frmConsCliente_Load(object sender, EventArgs e)
        {
            //CARREGAR OPÇÕES DE BUSCA NA COMBO
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("Código");
            cbOpcoes.Items.Add("CPF");
            cbOpcoes.Items.Add("Nascimento");
            cbOpcoes.Items.Add("Status");
            //DEIXAR SELECIONADA A OPÇÃO NOME
            cbOpcoes.SelectedItem = "Nome";

            
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOpcoes.SelectedIndex == 0) //NOME
            {
                txtPesquisar.Enabled = true;
                gbTipoPesquisa.Enabled = true;
                gbStatus.Enabled = false;
                mskCpf.Enabled = false;
                mskDataNascimento.Enabled = false;
                txtPesquisar.Focus();
                rbtContem.Checked = true;
            }

            if (cbOpcoes.SelectedIndex == 1) //Código
            {
                txtPesquisar.Enabled = true;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                mskCpf.Enabled = false;
                mskDataNascimento.Enabled = false;
                txtPesquisar.Focus();
            }

            if (cbOpcoes.SelectedIndex == 2) //CPF
            {
                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                mskCpf.Enabled = true;
                mskDataNascimento.Enabled = false;
                mskCpf.Focus();
            }

            if (cbOpcoes.SelectedIndex == 3) //Data de Nascimento
            {
                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                mskCpf.Enabled = false;
                mskDataNascimento.Enabled = true;
                mskDataNascimento.Focus();
            }

            if (cbOpcoes.SelectedIndex == 4) //STATUS
            {
                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = true;
                mskCpf.Enabled = false;
                mskDataNascimento.Enabled = false;
                rbtAtivo.Checked = true;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar a consulta de Cliente?", "Atenção!",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            
            if (dgvCliente.SelectedCells.Count > 0)
            {
                classCliente cCliente = new classCliente();
                cCliente.RetornaCliente(Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value));
                frmClientes formCliente = new frmClientes();

                //Não esquecer de mudar a propriedade modifiers para Public dos objetos do formulário de Funcionarios
                formCliente.txtCodigoCliente.Text = cCliente.CodigoCliente.ToString();
                formCliente.lbData.Text = Convert.ToDateTime(cCliente.DataCadastro).ToString();
                formCliente.txtNome.Text = cCliente.NomeCliente.ToString();
                formCliente.mskRg.Text = cCliente.RG.ToString();
                formCliente.mskCpf.Text = cCliente.CPF.ToString();
                formCliente.mskDataNasc.Text = cCliente.DataNascimento.ToString();

                if (cCliente.Sexo == "Feminino")
                    formCliente.rbtFeminino.Checked = true;
                else
                    formCliente.rbtMasculino.Checked = true;

                formCliente.txtRua.Text = cCliente.Rua.ToString();
                formCliente.txtNumero.Text = cCliente.Numero.ToString();
                formCliente.txtComplemento.Text = cCliente.Complemento.ToString();
                formCliente.txtBairro.Text = cCliente.Bairro.ToString();
                formCliente.txtCidade.Text = cCliente.Cidade.ToString();
                formCliente.estado = cCliente.Estado.ToString();
                formCliente.mskCep.Text = cCliente.CEP.ToString();
                formCliente.txtEmail.Text = cCliente.Email.ToString();
                formCliente.mskTelefone.Text = cCliente.TelefoneResidencial.ToString();
                formCliente.mskCelular.Text = cCliente.TelefoneCelular.ToString();

                if (cCliente.Status == 1)
                {
                    formCliente.ckStatus.Checked = true;
                }
                else
                {
                    formCliente.ckStatus.Checked = false;
                }

                // MANDAR A INFORMAÇÃO DE UPDATE
                formCliente.tipo = "Atualização";
                //DEPOIS DE ATUALIZAR FECHA O FORMULÁRIO
                formCliente.ShowDialog();
                // CHAMAR MÉTODO DE PESQUISA
                btPesquisar_Click(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Selecione um valor a ser atualizado!", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

      
        

        //Validar se a data foi preenchida corretamente
        //Usando o evento validationcompleted da máscara
        private void mskDataNascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                MessageBox.Show("Data Inválida.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
