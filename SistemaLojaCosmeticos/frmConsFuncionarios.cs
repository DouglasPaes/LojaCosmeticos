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
    public partial class frmConsFuncionarios : Form
    {
        public frmConsFuncionarios()
        {
            InitializeComponent();
        }

       

        

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //VARIÁVEL PARA GUARDAR A OPÇÃO NA COMBO DE OPÇÕES
            string Consulta = cbOpcoes.SelectedItem.ToString();
            classFuncionario cFuncionario = new classFuncionario();
            switch (Consulta)
            {
                case "Nome":
                    //VERIFICAR SE ALGUM NOME FOI DIGITADO
                    if (txtPesquisar.Text != "")
                    {
                        //INÍCIO
                        if (rbtInicio.Checked)
                        {
                            cFuncionario.NomeFuncionario = txtPesquisar.Text;
                            dgvFuncionario.DataSource = cFuncionario.BuscarFuncionarioNomeInicial();
                        }

                        //CONTÉM
                        else if (rbtContem.Checked)
                        {
                            cFuncionario.NomeFuncionario = txtPesquisar.Text;
                            dgvFuncionario.DataSource = cFuncionario.BuscarFuncionarioNomeContem();
                        }
                    }
                    else
                        MessageBox.Show("Favor informar um Nome.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Código":
                    if (txtPesquisar.Text != "")
                    {
                        cFuncionario.CodigoFuncionario = Convert.ToInt32(txtPesquisar.Text);
                        dgvFuncionario.DataSource = cFuncionario.BuscarFuncionarioCodigo();
                    }
                    else
                        MessageBox.Show("Favor informar o código do Funcionário.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "CPF":
                    if (mskCpf.Text != "   .   .   -")
                    {
                        cFuncionario.CPF = Convert.ToString(mskCpf.Text);
                        dgvFuncionario.DataSource = cFuncionario.BuscarFuncionarioCPF();
                    }
                    else
                        MessageBox.Show("Favor informar o CPF do Funcionário.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Nascimento":
                    if (mskDataNascimento.Text != "  /  /")
                    {
                        cFuncionario.DataNascimento = Convert.ToDateTime(mskDataNascimento.Text);
                        dgvFuncionario.DataSource = cFuncionario.BuscarFuncionarioDataNascimento();
                    }
                    else
                        MessageBox.Show("Favor informar a Data de Nascimento do Funcionário.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Status":
                    if (rbtAtivo.Checked == true)
                    {
                        cFuncionario.Status = 1;
                        dgvFuncionario.DataSource = cFuncionario.BuscarFuncionarioStatus();
                    }
                    else
                        cFuncionario.Status = 0;
                    dgvFuncionario.DataSource = cFuncionario.BuscarFuncionarioStatus();
                    break;

                case "Cargo":
                    if (cbCargo.Text != "")
                    {
                        cFuncionario.CodigoCargo = Convert.ToInt32(cbCargo.SelectedValue);
                        dgvFuncionario.DataSource = cFuncionario.BuscarFuncionarioCargo();
                    }
                    else
                        MessageBox.Show("Favor escolher um Cargo.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar a consulta de Funcionário?", "Atenção!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
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
                cbCargo.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 1) //Código
            {
                txtPesquisar.Enabled = true;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                mskCpf.Enabled = false;
                mskDataNascimento.Enabled = false;
                txtPesquisar.Focus();
                cbCargo.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 2) //CPF
            {
                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                mskCpf.Enabled = true;
                mskDataNascimento.Enabled = false;
                mskCpf.Focus();
                cbCargo.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 3) //Data de Nascimento
            {
                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                mskCpf.Enabled = false;
                mskDataNascimento.Enabled = true;
                mskDataNascimento.Focus();
                cbCargo.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 4) //STATUS
            {
                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = true;
                mskCpf.Enabled = false;
                mskDataNascimento.Enabled = false;
                rbtAtivo.Checked = true;
                cbCargo.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 5) //Cargo
            {
                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                mskCpf.Enabled = false;
                mskDataNascimento.Enabled = false;
                rbtAtivo.Checked = false;
                cbCargo.Enabled = true;

            }
        }

       

        private void frmConsFuncionarios_Load(object sender, EventArgs e)
        {
            //CARREGAR OPÇÕES DE BUSCA NA COMBO
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("Código");
            cbOpcoes.Items.Add("CPF");
            cbOpcoes.Items.Add("Nascimento");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.Items.Add("Cargo");
            //DEIXAR SELECIONADA A OPÇÃO NOME
            cbOpcoes.SelectedItem = "Nome";

            //Carregar Combo de Cargo
            classCargo cCargo = new classCargo();
            cbCargo.DataSource = cCargo.BuscarCargo(); // executar método de consulta criado na classe de cargo
            cbCargo.DisplayMember = "NomeCargo"; // Exibir na combo (nome)
            cbCargo.ValueMember = "CodigoCargo"; //Guardar no BD (código0
            cbCargo.SelectedIndex = -1; // Limpar a combo (não deixar nada selecionado)
        }

        private void btEditar_Click(object sender, EventArgs e)
        {

            if (dgvFuncionario.SelectedCells.Count > 0)
            {
                classFuncionario cFuncionario = new classFuncionario();
                cFuncionario.RetornaFuncionario(Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells[0].Value));
                frmFuncionarios formFuncionario = new frmFuncionarios();

                //Não esquecer de mudar a propriedade modifiers para Public dos objetos do formulário de Funcionarios
                formFuncionario.txtFuncionario.Text = cFuncionario.CodigoFuncionario.ToString();
                formFuncionario.lbData.Text = Convert.ToDateTime(cFuncionario.DataCadastro).ToString();
                formFuncionario.txtNomeFuncionario.Text = cFuncionario.NomeFuncionario.ToString();
                formFuncionario.mskRg.Text = cFuncionario.RG.ToString();
                formFuncionario.mskCpf.Text = cFuncionario.CPF.ToString();
                formFuncionario.mskDatanasc.Text = cFuncionario.DataNascimento.ToString();
                formFuncionario.mskDataAdmissao.Text = cFuncionario.DataAdmissao.ToString();
                formFuncionario.cargo = cFuncionario.CodigoCargo; // (Combo passar a variável declarada no formulário de funcionario

                if (cFuncionario.Sexo == "Feminino")
                    formFuncionario.rbtFeminino.Checked = true;
                else
                    formFuncionario.rbtMasculino.Checked = true;

                formFuncionario.txtRua.Text = cFuncionario.Rua.ToString();
                formFuncionario.txtNumero.Text = cFuncionario.Numero.ToString();
                formFuncionario.txtComplemento.Text = cFuncionario.Complemento.ToString();
                formFuncionario.txtBairro.Text = cFuncionario.Bairro.ToString();
                formFuncionario.txtCidade.Text = cFuncionario.Cidade.ToString();
                formFuncionario.estado = cFuncionario.Estado.ToString();
                formFuncionario.mskCep.Text = cFuncionario.CEP.ToString();
                formFuncionario.txtEmail.Text = cFuncionario.Email.ToString();
                formFuncionario.mskTelefone.Text = cFuncionario.TelefoneResidencial.ToString();
                formFuncionario.mskCelular.Text = cFuncionario.TelefoneCelular.ToString();

                if (cFuncionario.Status == 1)
                {
                    formFuncionario.ckStatus.Checked = true;
                }
                else
                {
                    formFuncionario.ckStatus.Checked = false;
                }

                // MANDAR A INFORMAÇÃO DE UPDATE
                formFuncionario.tipo = "Atualização";
                //DEPOIS DE ATUALIZAR FECHA O FORMULÁRIO
                formFuncionario.ShowDialog();
                // CHAMAR MÉTODO DE PESQUISA
                btPesquisar_Click(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Selecione um valor a ser atualizado!", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        

        private void frmConsFuncionarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //O Código "!E.SHIFT" indica que é para mudar para o próximo campo se pressionado enter, e ir para o campo anterior se pressionados SHIFT e ENTER SIMULTANEAMENTE
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
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
