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
    public partial class frmCargo : Form
    {

        //Variável declarada para guardar como o formulário deve ser aberto,
        //para cadastrar ou  atualizar / excluir
        public string tipo;

        public frmCargo()
        {
            InitializeComponent();
        }

        

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //Instanciar a class de marca para usar métodos e propriedades
            classCargo cCargo = new classCargo();

            string nomecargo;
            nomecargo = textNomeCargo.Text;

            if (cCargo.ValidaCargo(nomecargo))
            {
                MessageBox.Show(" Cargo: " + nomecargo + " já está Cadastrado no Sistema.",
                    "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else

            //Verificar campos obrigatórios
            if (textNomeCargo.Text != "")
            {
                //Passar para as propriedades o conteudo do formulario
                //Todos os campos que o usuário pode preencher
                cCargo.NomeCargo = textNomeCargo.Text;
                cCargo.Observacao = textObservacao.Text;

                //Método para Cadastrar da classe categoria
                int aux = cCargo.CadastrarCargo();

                //Se deu Certo = 1
                if (aux != 0)
                {
                    MessageBox.Show(" Cargo: " + cCargo.NomeCargo + " Cadastrado com sucesso.",
                    "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar campos campos do Formulário, chamado botão limpar
                    btLimpar_Click(this, new EventArgs());
                }
                //Se deu errado = 0
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro.", "Sistema Loja de cosméticos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textNomeCargo.BackColor = Color.LemonChiffon;
                textNomeCargo.Focus();
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            //Limpar campos
            textNomeCargo.Clear();
            textObservacao.Clear();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o cadastro de Cargo?", "Atenção!",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }

        private void frmCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //O Código "!E.SHIFT" indica que é para mudar para o próximo campo se pressionado enter, e ir para o campo anterior se pressionados SHIFT e ENTER SIMULTANEAMENTE
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Cargos";
                btCadastrar.Enabled = false;
                ckStatus.Enabled = true;

            }
            else
            {
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            classCargo cCargo = new classCargo();

            //Verificar campos obrigatórios
            if (textNomeCargo.Text != "")
            {
                //Passar para as propriedades o conteúdo do Conteúdo do Formulário
                cCargo.NomeCargo = textNomeCargo.Text;
                cCargo.Observacao = textObservacao.Text;


                if (ckStatus.Checked == true)
                {
                    cCargo.Status = 1;
                }
                else
                {
                    cCargo.Status = 0;
                }
                cCargo.CodigoCargo = Convert.ToInt32(textCargo.Text);
                bool aux = cCargo.AtualizarCargo();
                if (aux)
                {
                    MessageBox.Show("Cargo: " + cCargo.NomeCargo + " Atualizado com sucesso.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); //Fecha formulário
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar o Cargo" + cCargo.NomeCargo, "Sistema Loja de Cosméticos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textNomeCargo.BackColor = Color.LemonChiffon;
                textNomeCargo.Focus();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            classCargo cCargo = new classCargo();
            cCargo.CodigoCargo = Convert.ToInt32(textCargo.Text);

            if (MessageBox.Show("Deseja realmente excluir? A operação não poderá ser desfeita após a exclusão.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool aux = cCargo.ExcluirCargo();
                if (aux)
                {
                    MessageBox.Show("Cargo:" + cCargo.NomeCargo + " excluido com sucesso.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(cCargo.NomeCargo + "Erro ao excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
