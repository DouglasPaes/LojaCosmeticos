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
    public partial class frmCategoria : Form
    {

        //Variável declarada para guardar como o formulário deve ser aberto,
        //para cadastrar ou  atualizar / excluir
        public string tipo;

        public frmCategoria()
        {
            InitializeComponent();
        }

       

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o cadastro de Categoria?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }

       

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Categoria";
                btCadastar.Enabled = false;
                ckStatus.Enabled = true;
                
            }
            else
            {
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
            }
        }

        private void btCadastar_Click(object sender, EventArgs e)
        {
            //Instanciar a class de marca para usar métodos e propriedades
            classCategoria cCategoria = new classCategoria();

            string nomecategoria;
            nomecategoria = textNomeCategoria.Text;

            if (cCategoria.ValidaCategoria(nomecategoria))
            {
                MessageBox.Show(" Categoria: " + nomecategoria + " já está Cadastrada no Sistema.",
                    "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else

            //Verificar campos obrigatórios
            if (textNomeCategoria.Text != "")
            {
                //Passar para as propriedades o conteudo do formulario
                //Todos os campos que o usuário pode preencher
                cCategoria.NomeCategoria = textNomeCategoria.Text;
                cCategoria.Observacao = textObservacao.Text;

                //Método para Cadastrar da classe categoria
                int aux = cCategoria.CadastrarCategoria();

                //Se deu Certo = 1
                if (aux != 0)
                {
                    MessageBox.Show(" Categoria: " + cCategoria.NomeCategoria + " Cadastrada com sucesso.",
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
                textNomeCategoria.BackColor = Color.LemonChiffon;
                textNomeCategoria.Focus();
            }
           
        }

        
        private void btLimpar_Click(object sender, EventArgs e)
        {
            textNomeCategoria.Clear();
            textObservacao.Clear();
        }

       

        private void frmCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //O Código "!E.SHIFT" indica que é para mudar para o próximo campo se pressionado enter, e ir para o campo anterior se pressionados SHIFT e ENTER SIMULTANEAMENTE
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            classCategoria cCategoria = new classCategoria();
            cCategoria.CodigoCategoria = Convert.ToInt32(textCategoria.Text);

            if (MessageBox.Show("Deseja realmente excluir? A operação não poderá ser desfeita após a exclusão.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool aux = cCategoria.ExcluirCategoria();
                if (aux)
                {
                    MessageBox.Show("Categoria:" + cCategoria.NomeCategoria + " excluida com sucesso.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(cCategoria.NomeCategoria + "Erro ao excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            classCategoria cCategoria = new classCategoria();

            //Verificar campos obrigatórios
            if (textNomeCategoria.Text != "")
            {
                //Passar para as propriedades o conteúdo do Conteúdo do Formulário
                cCategoria.NomeCategoria = textNomeCategoria.Text;
                cCategoria.Observacao = textObservacao.Text;
                

                if (ckStatus.Checked == true)
                {
                    cCategoria.Status = 1;
                }
                else
                {
                    cCategoria.Status = 0;
                }
                cCategoria.CodigoCategoria = Convert.ToInt32(textCategoria.Text);
                bool aux = cCategoria.AtualizarCategoria();
                if (aux)
                {
                    MessageBox.Show("Categoria: " + cCategoria.NomeCategoria + " Atualizada com sucesso.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); //Fecha formulário
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar a Categoria" + cCategoria.NomeCategoria, "Sistema Loja de Cosméticos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textNomeCategoria.BackColor = Color.LemonChiffon;
                textNomeCategoria.Focus();
            }
        }
    }
    
}
