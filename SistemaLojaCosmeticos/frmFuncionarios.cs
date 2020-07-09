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
    public partial class frmFuncionarios : Form
    {

        //Variável declarada para guardar como o formulário deve ser aberto,
        //para cadastrar ou  atualizar / excluir
        public string tipo, estado;

        //Variáveis declaradas para guardar cargo
        //Castrada no BD, quando vai fazer update
        public int cargo;
        

        public frmFuncionarios()
        {
            InitializeComponent();
        }

        

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();

            //VERIFICAR CAMPOS OBRIGATÓRIOS
            if (txtNomeFuncionario.Text != "" && mskCpf.Text != "   .   .   -" && mskDatanasc.Text != "  /  /" && mskDataAdmissao.Text != "  /  /" && txtRua.Text != "" && cbCargo.Text !="" && txtNumero.Text != ""
                && txtEmail.Text != "")
            {
                //PASSAR PARA AS PROPRIEDADES O CONTEÚDO DO FORMULÁRIO
                //TODOS OS CAMPOS QUE O USUÁRIO VAI PREENCHER
                cFuncionario.NomeFuncionario = txtNomeFuncionario.Text;
                cFuncionario.RG = mskRg.Text;
                cFuncionario.CPF = mskCpf.Text;
                cFuncionario.DataNascimento = Convert.ToDateTime(mskDatanasc.Text);
                cFuncionario.DataAdmissao = Convert.ToDateTime(mskDataAdmissao.Text);
                cFuncionario.CodigoCargo = Convert.ToInt32(cbCargo.SelectedValue); //Manda para o BD o Código do Cargo

                if (rbtFeminino.Checked)
                    cFuncionario.Sexo = "Feminino";
                else
                    cFuncionario.Sexo = "Masculino";

                cFuncionario.Rua = txtRua.Text;
                cFuncionario.Numero = Convert.ToInt32(txtNumero.Text);
                cFuncionario.Complemento = txtComplemento.Text;
                cFuncionario.Bairro = txtBairro.Text;
                cFuncionario.Cidade = txtCidade.Text;
                cFuncionario.Estado = cbEstado.SelectedItem.ToString();
                cFuncionario.CEP = mskCep.Text;
                cFuncionario.Email = txtEmail.Text;

                if (mskTelefone.Text != "(  )     -")
                    cFuncionario.TelefoneResidencial = mskTelefone.Text;
                else
                    cFuncionario.TelefoneResidencial = "";

                if (mskCelular.Text != "(  )      -")
                    cFuncionario.TelefoneCelular = mskCelular.Text;
                else
                    cFuncionario.TelefoneCelular = "";

                if (ckStatus.Checked == true)
                    cFuncionario.Status = 1;
                else
                    cFuncionario.Status = 0;

                cFuncionario.CodigoFuncionario = Convert.ToInt32(txtFuncionario.Text);

                bool aux = cFuncionario.AtualizarFuncionario();

                if (aux)
                {
                    MessageBox.Show(" Funcionário: " + cFuncionario.NomeFuncionario + " Atualizado com Sucesso.",
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
                txtNomeFuncionario.BackColor = Color.LemonChiffon;
                mskCpf.BackColor = Color.LemonChiffon;
                mskDatanasc.BackColor = Color.LemonChiffon;
                txtRua.BackColor = Color.LemonChiffon;
                txtNumero.BackColor = Color.LemonChiffon;
                txtEmail.BackColor = Color.LemonChiffon;
                txtNomeFuncionario.Focus();
                cbCargo.BackColor = Color.LemonChiffon;
                lbCargo.ForeColor = Color.Red;
            }
        }

        private void frmFuncionarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //O Código "!E.SHIFT" indica que é para mudar para o próximo campo se pressionado enter, e ir para o campo anterior se pressionados SHIFT e ENTER SIMULTANEAMENTE
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //Instanciar a classe Funcionario para usar métodos e propriedades
            classFuncionario cFuncionario = new classFuncionario();

            //Verificar campos obrigatórios (Validando pelo menos um telefone)
            if ((mskTelefone.Text != "(  )      -" || mskCelular.Text != "(  )      -")
                && txtNomeFuncionario.Text != "" && cbCargo.Text != "" && mskCpf.Text != "   .   .   -" && mskDatanasc.Text != "  /  /" && mskDataAdmissao.Text != "  /  /" 
                && txtRua.Text != "" && txtNumero.Text != "" && txtEmail.Text != "")
            {
                //Passar para as propriedades o contéudo do Formulário
                //Todos os campos que o usuário pode preencher
                cFuncionario.NomeFuncionario = txtNomeFuncionario.Text;
                cFuncionario.CPF = mskCpf.Text;
                cFuncionario.DataNascimento = Convert.ToDateTime(mskDatanasc.Text);
                cFuncionario.DataAdmissao = Convert.ToDateTime(mskDataAdmissao.Text);
                cFuncionario.Rua = txtRua.Text;
                cFuncionario.Numero = Convert.ToInt32(txtNumero.Text);
                cFuncionario.Complemento = txtComplemento.Text;
                cFuncionario.Bairro = txtBairro.Text;
                cFuncionario.Cidade = txtCidade.Text;
                cFuncionario.Estado = cbEstado.SelectedItem.ToString(); //Combo Box
                cFuncionario.Email = txtEmail.Text;
                cFuncionario.CodigoCargo = Convert.ToInt32(cbCargo.SelectedValue); // Manda BD o código Cargo

                //Radio Button
                if (rbtFeminino.Checked)
                {
                    { cFuncionario.Sexo = "Feminino"; }
                }
                else
                {
                    { cFuncionario.Sexo = "Masculino"; }


                    //Campos que são máscaras e não são obrigatórios
                    if (mskTelefone.Text != "(  )      -")
                    { cFuncionario.TelefoneResidencial = mskTelefone.Text; }
                    else
                    { cFuncionario.TelefoneResidencial = ""; }

                    if (mskCelular.Text != "(  )      -")
                    { cFuncionario.TelefoneCelular = mskCelular.Text; }
                    else
                    { cFuncionario.TelefoneCelular = ""; }

                    if (mskRg.Text != "  .   .   -")
                    { cFuncionario.RG = mskRg.Text; }
                    else
                    { cFuncionario.RG = ""; }

                    if (mskCep.Text != "     -")
                    { cFuncionario.CEP = mskCep.Text; }
                    else
                    { cFuncionario.CEP = ""; }
                }

                //Método para cadastrar da classe Funcionario
                int aux = cFuncionario.CadastrarFuncionario();

                //Se deu certo = 1
                if (aux != 0)
                {
                    MessageBox.Show("Funcionário: " + cFuncionario.NomeFuncionario + " Cadastrado com Sucesso.", "Sistema Loja de Cosméticos",
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
                txtNomeFuncionario.BackColor = Color.LemonChiffon;
                mskCpf.BackColor = Color.LemonChiffon;
                mskDatanasc.BackColor = Color.LemonChiffon;
                mskDataAdmissao.BackColor = Color.LemonChiffon;
                txtRua.BackColor = Color.LemonChiffon;
                txtNumero.BackColor = Color.LemonChiffon;
                txtEmail.BackColor = Color.LemonChiffon;
                mskCelular.BackColor = Color.LemonChiffon;
                mskTelefone.BackColor = Color.LemonChiffon;
                cbCargo.BackColor = Color.LemonChiffon;
                txtNomeFuncionario.Focus();
                lbCargo.ForeColor = Color.Red;
                

            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            //Limpar os campos
            txtNomeFuncionario.Clear();
            txtEmail.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            mskRg.Clear();
            mskCpf.Clear();
            mskCep.Clear();
            mskDatanasc.Clear();
            mskDataAdmissao.Clear();
            mskTelefone.Clear();
            mskCelular.Clear();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o cadastro de Funcionários?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            //Carregar Combo de Cargo
            classCargo cCargo = new classCargo();
            cbCargo.DataSource = cCargo.BuscarCargo();//Executar método
            cbCargo.DataSource = cCargo.BuscarCargo(); //Executar método criado na classe cargo
            cbCargo.DisplayMember = "NomeCargo"; //Exibir na combo (nome)
            cbCargo.ValueMember = "CodigoCargo"; //Guardar no BD
            cbCargo.SelectedIndex = -1; //Limpar a combo (não selecionada nada)



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
            txtNomeFuncionario.Focus();

            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Funcionários";
                btCadastrar.Enabled = false;
                ckStatus.Enabled = true;
                cbEstado.SelectedValue = estado;
                cbCargo.SelectedValue = cargo;

            }
            else
            {
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
            }
        }


        //Validar se a data foi preenchida corretamente
        //Usando o evento validationcompleted da máscara
        private void mskDatanasc_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                MessageBox.Show("Data Inválida.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

       


        //Validar se a data foi preenchida corretamente
        //Usando o evento validationcompleted da máscara
        private void mskDataAdmissao_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                MessageBox.Show("Data Inválida.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, BACKSPAACE(08), ENTER(13) e ESPAÇO(32)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //Se o usuário pressionar uma tecla não numérica no textbox, cancela o evento key press
                e.Handled = true;
                MessageBox.Show("Este Campo permite apenas Números!", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       

        private void btExcluir_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();
            cFuncionario.CodigoFuncionario = Convert.ToInt32(txtFuncionario.Text);

            if (MessageBox.Show("Deseja realmente excluir? A operação não poderá ser desfeita após a exclusão.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool aux = cFuncionario.ExcluirFuncionario();
                if (aux)
                {
                    MessageBox.Show("Funcionário:" + cFuncionario.NomeFuncionario + " excluido com sucesso.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(cFuncionario.NomeFuncionario + "Erro ao excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
