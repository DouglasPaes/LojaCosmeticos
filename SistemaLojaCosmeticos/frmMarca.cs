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
    public partial class frmMarca : Form
    {
        //Variável declarada para guardar como o formulário deve ser aberto,
        //para cadastrar ou  atualizar / excluir
        public string tipo;


        public frmMarca()
        {
            InitializeComponent();
        }


        private void btCadastrar_Click(object sender, EventArgs e)
        {
            {
                //Instanciar a class de marca para usar métodos e propriedades
                classMarca cMarca = new classMarca();

                string nomemarca;
                nomemarca = textNomeMarca.Text;

                if (cMarca.ValidaMarca(nomemarca))
                {
                    MessageBox.Show(" Marca: " + nomemarca + " já está Cadastrada no Sistema.",
                        "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else

                    //Verificar campos obrigatórios
                    if (textNomeMarca.Text != "")
                {
                    //Passar para as propriedades o conteudo do formulario
                    //Todos os campos que o usuário pode preencher
                    cMarca.NomeMarca = textNomeMarca.Text;
                    cMarca.Observacao = textNomeMarca.Text;

                    //Método para Cadastrar da classe Marca
                    int aux = cMarca.CadastrarMarca();

                    //Se deu Certo = 1
                    if (aux != 0)
                    {
                        MessageBox.Show(" Marca: " + cMarca.NomeMarca + " Cadastrada com sucesso.",
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
                    textNomeMarca.BackColor = Color.LemonChiffon;
                    textNomeMarca.Focus();
                }

            }

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            textNomeMarca.Clear();
            textObservacao.Clear();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o cadastro de Marca?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }

        private void frmMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //O Código "!E.SHIFT" indica que é para mudar para o próximo campo se pressionado enter, e ir para o campo anterior se pressionados SHIFT e ENTER SIMULTANEAMENTE
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

       

        private void frmMarca_Load(object sender, EventArgs e)
        {
            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Marca";
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
            classMarca cMarca = new classMarca();

            //Verificar campos obrigatórios
            if (textNomeMarca.Text != "")
            {
                //Passar para as propriedades o conteúdo do Conteúdo do Formulário
                cMarca.NomeMarca = textNomeMarca.Text;
                cMarca.Observacao = textObservacao.Text;


                if (ckStatus.Checked == true)
                {
                    cMarca.Status = 1;
                }
                else
                {
                    cMarca.Status = 0;
                }
                cMarca.CodigoMarca = Convert.ToInt32(textMarca.Text);
                bool aux = cMarca.AtualizarMarca();
                if (aux)
                {
                    MessageBox.Show("Marca: " + cMarca.NomeMarca + " Atualizada com sucesso.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); //Fecha formulário
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar a Marca" + cMarca.NomeMarca, "Sistema Loja de Cosméticos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textNomeMarca.BackColor = Color.LemonChiffon;
                textNomeMarca.Focus();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            classMarca cMarca = new classMarca();
            cMarca.CodigoMarca = Convert.ToInt32(textMarca.Text);

            if (MessageBox.Show("Deseja realmente excluir? A operação não poderá ser desfeita após a exclusão.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool aux = cMarca.ExcluirMarca();
                if (aux)
                {
                    MessageBox.Show("Marca:" + cMarca.NomeMarca + " excluida com sucesso.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(cMarca.NomeMarca + "Erro ao excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
