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
    public partial class frmProduto : Form
    {
        //Variável declarada para guardar como o formulário deve ser aberto,
        //para cadastrar ou  atualizar / excluir
        public string tipo;

        //Variáveis declaradas para guardar marca e categoria
        //Castrada no BD, quando vai fazer update
        public int marca, categoria;


        public frmProduto()
        {
            InitializeComponent();
        }

        

        private void frmProduto_Load(object sender, EventArgs e)
        {
            //Cursor no campo nome do cliente
            textNomeProduto.Focus();

            //Carregar Combo de Categoria
            classCategoria cCategoria = new classCategoria();
            cbCategoria.DataSource = cCategoria.BuscarCategoria();//Executar método
            cbCategoria.DataSource = cCategoria.BuscarCategoria(); //Executar método criado na classe categoria
            cbCategoria.DisplayMember = "NomeCategoria"; //Exibir na combo (nome)
            cbCategoria.ValueMember = "CodigoCategoria"; //Guardar no BD
            cbCategoria.SelectedIndex = -1; //Limpar a combo (não selecionada nada)

            //Carregar Combo de Marca
            classMarca cMarca = new classMarca();
            cbMarca.DataSource = cMarca.BuscarMarca();//Executar método
            cbMarca.DataSource = cMarca.BuscarMarca(); //Executar método criado na classe Marca
            cbMarca.DisplayMember = "NomeMarca"; //Exibir na combo (nome)
            cbMarca.ValueMember = "CodigoMarca"; //Guardar no BD
            cbMarca.SelectedIndex = -1; //Limpar a combo (não selecionada nada)

            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Produto";
                btCadastrar.Enabled = false;
                ckStatus.Enabled = true;
                cbCategoria.SelectedValue = categoria;
                cbMarca.SelectedValue = marca;
            }
            else
            {
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
            }
        }


       

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //Instanciar a class de produto para usar métodos e propriedades
            classProduto cProduto = new classProduto();

            string nomeproduto;
            nomeproduto = textNomeProduto.Text;

            if (cProduto.ValidaProduto(nomeproduto))
            {
                MessageBox.Show(" Produto: " + nomeproduto + " já está Cadastrado no Sistema.",
                    "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else

            //Verificar campos obrigatórios
            if (textNomeProduto.Text != "" && txtPrecoVenda.Text != "" && textQtdeEstoque.Text != "" && cbCategoria.Text != "" && cbMarca.Text !="")
            {
                //Passar para as propriedades o conteudo do formulario
                //Todos os campos que o usuário pode preencher
                cProduto.NomeProduto = textNomeProduto.Text;
                cProduto.Observacao = textObservacao.Text;
                cProduto.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text);
                cProduto.QtdeEstoque = Convert.ToInt32(textQtdeEstoque.Text);
                cProduto.CodigoCategoria = Convert.ToInt32(cbCategoria.SelectedValue); // Manda BD o código da Categoria
                cProduto.CodigoMarca = Convert.ToInt32(cbMarca.SelectedValue); //Manda BD o código da Marca

                
                //Método para Cadastrar da classe produto
                int aux = cProduto.CadastrarProduto();

                //Se deu Certo = 1
                if (aux != 0)
                {
                    MessageBox.Show(" Produto: " + cProduto.NomeProduto + " Cadastrado com sucesso.",
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
                textNomeProduto.BackColor = Color.LemonChiffon;
                textNomeProduto.Focus();
                textQtdeEstoque.BackColor = Color.LemonChiffon;
                txtPrecoVenda.BackColor = Color.LemonChiffon;
                cbCategoria.BackColor = Color.LemonChiffon;
                cbMarca.BackColor = Color.LemonChiffon;
                lbCategoria.ForeColor = Color.Red;
                lbMarca.ForeColor = Color.Red;


            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();

            //Verificar campos obrigatórios
            if (textNomeProduto.Text !="" && txtPrecoVenda.Text != "" && textQtdeEstoque.Text != "" && cbCategoria.Text !="" && cbMarca.Text !="")
            {
                //Passar para as propriedades o conteúdo do Conteúdo do Formulário
                cProduto.NomeProduto = textNomeProduto.Text;
                cProduto.QtdeEstoque = Convert.ToInt32(textQtdeEstoque.Text);
                cProduto.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text);
                cProduto.Observacao = textObservacao.Text;
                cProduto.CodigoCategoria = Convert.ToInt32(cbCategoria.SelectedValue); //Manda para o BD o código Categoria
                cProduto.CodigoMarca = Convert.ToInt32(cbMarca.SelectedValue); //Manda para o BD o Código da Marca

                if (ckStatus.Checked == true)
                {
                    cProduto.Status = 1;
                }
                else
                {
                    cProduto.Status = 0;
                }
                cProduto.CodigoProduto = Convert.ToInt32(txtCodigoProduto.Text);
                bool aux = cProduto.AtualizarProduto();
                if (aux)
                {
                    MessageBox.Show("Produto: " + cProduto.NomeProduto + " Atualizado com sucesso.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); //Fecha formulário
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar o Produto" + cProduto.NomeProduto, "Sistema Loja de Cosméticos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textNomeProduto.BackColor = Color.LemonChiffon;
                txtPrecoVenda.BackColor = Color.LemonChiffon;
                textQtdeEstoque.BackColor = Color.LemonChiffon;
                cbMarca.BackColor = Color.LemonChiffon;
                cbCategoria.BackColor = Color.LemonChiffon;
                textNomeProduto.Focus();
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {   //Limpar campos
            textNomeProduto.Clear();
            textObservacao.Clear();
            txtPrecoVenda.Clear();
            textQtdeEstoque.Clear();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o cadastro de Produto?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }

        

        private void frmProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //O Código "!E.SHIFT" indica que é para mudar para o próximo campo se pressionado enter, e ir para o campo anterior se pressionados SHIFT e ENTER SIMULTANEAMENTE
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }


        private void textQtdeEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, BACKSPAACE(08), ENTER(13) e ESPAÇO(32)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //Se o usuário pressionar uma tecla não numérica no textbox, cancela o evento key press
                e.Handled = true;
                MessageBox.Show("Este Campo permite apenas Números!", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

      

        private void textPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, BACKSPAACE(08), ENTER(13) e ESPAÇO(32)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32 && e.KeyChar != 44 && e.KeyChar !=46)
            {
                //Se o usuário pressionar uma tecla não numérica no textbox, cancela o evento key press
                e.Handled = true;
                MessageBox.Show("Este Campo permite apenas Números!", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       

        private void btExcluir_Click(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();
            cProduto.CodigoProduto = Convert.ToInt32(txtCodigoProduto.Text);

            if (MessageBox.Show("Deseja realmente excluir? A operação não poderá ser desfeita após a exclusão.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                bool aux = cProduto.ExcluirProduto();
                if (aux)
                {
                    MessageBox.Show("Produto:" + cProduto.NomeProduto + " excluido com sucesso.", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(cProduto.NomeProduto + "Erro ao excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             }
         }

      
    }
}
