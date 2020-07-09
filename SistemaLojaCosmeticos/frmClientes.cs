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
    public partial class frmClientes : Form
    {
        public string tipo;
        public string estado;

        public frmClientes()
        {
            InitializeComponent();
        }

      

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //Instanciar a classe de clientes para usar métodos e propriedades
            classCliente cCliente = new classCliente();

            //Verificar campos obrigatórios (Validando pelo menos um telefone)
            if ((mskTelefone.Text != "(  )      -" || mskCelular.Text != "(  )      -")
                && txtNome.Text != "" && mskCpf.Text != "   .   .   -" && mskDataNasc.Text != "  /  /"
                && txtRua.Text != "" && txtNumero.Text != "" && txtEmail.Text != "")
            {
                //Passar para as propriedades o contéudo do Formulário
                //Todos os campos que o usuário pode preencher
                cCliente.NomeCliente = txtNome.Text;
                cCliente.CPF = mskCpf.Text;
                cCliente.DataNascimento = Convert.ToDateTime(mskDataNasc.Text);
                cCliente.Rua = txtRua.Text;
                cCliente.Numero = Convert.ToInt32(txtNumero.Text);
                cCliente.Complemento = txtComplemento.Text;
                cCliente.Bairro = txtBairro.Text;
                cCliente.Cidade = txtCidade.Text;
                cCliente.Estado = cbEstado.SelectedItem.ToString(); //Combo Box
                cCliente.Email = txtEmail.Text;

                //Radio Button
                if (rbtFeminino.Checked)
                {
                    { cCliente.Sexo = "Feminino"; }
                }
                else
                {
                    { cCliente.Sexo = "Masculino"; }


                    //Campos que são máscaras e não são obrigatórios
                    if (mskTelefone.Text != "(  )      -")
                    { cCliente.TelefoneResidencial = mskTelefone.Text; }
                    else
                    { cCliente.TelefoneResidencial = ""; }

                    if (mskCelular.Text != "(  )      -")
                    { cCliente.TelefoneCelular = mskCelular.Text; }
                    else
                    { cCliente.TelefoneCelular = ""; }

                    if (mskRg.Text != "  .   .   -")
                    { cCliente.RG = mskRg.Text; }
                    else
                    { cCliente.RG = ""; }

                    if (mskCep.Text != "     -")
                    { cCliente.CEP = mskCep.Text; }
                    else
                    { cCliente.CEP = ""; }
                }

                //Método para cadastrar da classe Cliente
                int aux = cCliente.CadastrarCliente();

                //Se deu certo = 1
                if (aux != 0)
                {
                    MessageBox.Show("Cliente: " + cCliente.NomeCliente + " Cadastrado com Sucesso.", "Sistema Loja de Cosméticos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btLimpar_Click(this, new EventArgs());
                }
                //Se deu Errado = 0
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro.", "Sistema Loja de Cosméticos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.BackColor = Color.LemonChiffon;
                mskCpf.BackColor = Color.LemonChiffon;
                mskDataNasc.BackColor = Color.LemonChiffon;
                txtRua.BackColor = Color.LemonChiffon;
                txtNumero.BackColor = Color.LemonChiffon;
                txtEmail.BackColor = Color.LemonChiffon;
                mskCelular.BackColor = Color.LemonChiffon;
                mskTelefone.BackColor = Color.LemonChiffon;
                txtNome.Focus();

            }

        }




        private void btLimpar_Click(object sender, EventArgs e)
        {
            //Limpar os campos
            txtNome.Clear();
            txtEmail.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            mskRg.Clear();
            mskCpf.Clear();
            mskCep.Clear();
            mskDataNasc.Clear();
            mskTelefone.Clear();
            mskCelular.Clear();
            
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            //Carregar combo de Estado
            cbEstado.Items.Add("AC");
            cbEstado.Items.Add("AL");
            cbEstado.Items.Add("AP");
            cbEstado.Items.Add("AM");
            cbEstado.Items.Add("BA");
            cbEstado.Items.Add("CE");
            cbEstado.Items.Add("DF");
            cbEstado.Items.Add("ES");
            cbEstado.Items.Add("GO");
            cbEstado.Items.Add("MA");
            cbEstado.Items.Add("MT");
            cbEstado.Items.Add("MS");
            cbEstado.Items.Add("MG");
            cbEstado.Items.Add("PA");
            cbEstado.Items.Add("PB");
            cbEstado.Items.Add("PR");
            cbEstado.Items.Add("PE");
            cbEstado.Items.Add("PI");
            cbEstado.Items.Add("RJ");
            cbEstado.Items.Add("RN");
            cbEstado.Items.Add("RS");
            cbEstado.Items.Add("RO");
            cbEstado.Items.Add("RR");
            cbEstado.Items.Add("SC");
            cbEstado.Items.Add("SP");
            cbEstado.Items.Add("SE");
            cbEstado.Items.Add("TO");

            //Colocar os itens em ordem alfabética
            cbEstado.Sorted = true;

            //Deixar a opção SP selecionada
            cbEstado.SelectedItem = "SP";

            //Nenhuma opção selecionada
            //cbEstado.SelectedIndex = -1;

            //Cursor no campo nome do cliente
            txtNome.Focus();

            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Cliente";
                btCadastrar.Enabled = false;
                ckStatus.Enabled = true;
                cbEstado.SelectedItem = estado;

            }
            else
            {
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o cadastro de Cliente?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }


        private void btAtualizar_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

            //VERIFICAR CAMPOS OBRIGATÓRIOS
            if (txtNome.Text != "" && mskCpf.Text != "   .   .   -" && mskDataNasc.Text != "  /  /" && txtRua.Text != "" && txtNumero.Text != ""
                && txtEmail.Text != "")
            {
                //PASSAR PARA AS PROPRIEDADES O CONTEÚDO DO FORMULÁRIO
                //TODOS OS CAMPOS QUE O USUÁRIO VAI PREENCHER
                cCliente.NomeCliente = txtNome.Text;
                cCliente.RG = mskRg.Text;
                cCliente.CPF = mskCpf.Text;
                cCliente.DataNascimento = Convert.ToDateTime(mskDataNasc.Text);

                if (rbtFeminino.Checked)
                    cCliente.Sexo = "Feminino";
                else
                    cCliente.Sexo = "Masculino";

                cCliente.Rua = txtRua.Text;
                cCliente.Numero = Convert.ToInt32(txtNumero.Text);
                cCliente.Complemento = txtComplemento.Text;
                cCliente.Bairro = txtBairro.Text;
                cCliente.Cidade = txtCidade.Text;
                cCliente.Estado = cbEstado.SelectedItem.ToString();
                cCliente.CEP = mskCep.Text;
                cCliente.Email = txtEmail.Text;

                if (mskTelefone.Text != "(  )     -")
                    cCliente.TelefoneResidencial = mskTelefone.Text;
                else
                    cCliente.TelefoneResidencial = "";

                if (mskCelular.Text != "(  )      -")
                    cCliente.TelefoneCelular = mskCelular.Text;
                else
                    cCliente.TelefoneCelular = "";

                if (ckStatus.Checked == true)
                    cCliente.Status = 1;
                else
                    cCliente.Status = 0;

                cCliente.CodigoCliente = Convert.ToInt32(txtCodigoCliente.Text);

                bool aux = cCliente.AtualizarCliente();

                if (aux)
                {
                    MessageBox.Show(" Cliente: " + cCliente.NomeCliente + " Atualizado com Sucesso.",
                    "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();


                }
                else
                    MessageBox.Show("Erro ao atualizar.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.BackColor = Color.LemonChiffon;
                mskCpf.BackColor = Color.LemonChiffon;
                mskDataNasc.BackColor = Color.LemonChiffon;
                txtRua.BackColor = Color.LemonChiffon;
                txtNumero.BackColor = Color.LemonChiffon;
                txtEmail.BackColor = Color.LemonChiffon;
                txtNome.Focus();
            }
        }

  

        //Validar se a data foi preenchida corretamente
        //Usando o evento validationcompleted da máscara
        private void mskDataNasc_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                MessageBox.Show("Data Inválida.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //Não permitir que digite Letras
        //Usando o evento Keypress do text
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, BACKSPAACE(08), ENTER(13) e ESPAÇO(32)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar !=08 && e.KeyChar !=13 && e.KeyChar !=32)
            {
                //Se o usuário pressionar uma tecla não numérica no textbox, cancela o evento key press
                e.Handled = true;
                MessageBox.Show("Este Campo permite apenas Números!", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //O Código "!E.SHIFT" indica que é para mudar para o próximo campo se pressionado enter, e ir para o campo anterior se pressionados SHIFT e ENTER SIMULTANEAMENTE
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();
            cCliente.CodigoCliente = Convert.ToInt32(txtCodigoCliente.Text);

            if (MessageBox.Show("Deseja realmente excluir? A operação não poderá ser desfeita após a exclusão.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool aux = cCliente.ExcluirCliente();
                if (aux)
                {
                    MessageBox.Show("Cliente:" + cCliente.NomeCliente + " excluido com sucesso.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(cCliente.NomeCliente + "Erro ao excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
