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
    public partial class frmRelProduto : Form
    {
        public frmRelProduto()
        {
            InitializeComponent();
        }

        private void frmRelProduto_Load(object sender, EventArgs e)
        {
            {
                //CARREGAR COMBO TIPO DE RELATÓRIO
                cbTipoRel.Items.Add("Estoque");
                cbTipoRel.Items.Add("Preço");
                cbTipoRel.Items.Add("Categoria");
                cbTipoRel.Items.Add("Marca");
                cbTipoRel.Items.Add("Status");
                cbTipoRel.SelectedIndex = 0;

                //Carregar Combo Categoria
                classProduto cProduto = new classProduto();
                cbCategoria.DataSource = cProduto.BuscarCategoria(); // EXECUTAR MÉTODO DE CONSULTA CRIADO NA CLASSE Produto
                cbCategoria.DisplayMember = "Categoria"; // EXIBIR NA COMBO (Categoria)
                cbCategoria.ValueMember = "NomeCategoria"; // GUARDAR NO BD (Categoria)
                cbCategoria.SelectedIndex = -1;
                this.rptProduto.RefreshReport();
                this.rptProduto.RefreshReport();
                this.rptProduto.RefreshReport();

                //Carregar Combo de Marca
                classMarca cMarca = new classMarca();
                cbMarca.DataSource = cProduto.BuscarMarca(); // EXECUTAR MÉTODO DE CONSULTA CRIADO NA CLASSE DE PRODUTOS
                cbMarca.DisplayMember = "Marca"; // EXIBIR NA COMBO (Marca)
                cbMarca.ValueMember = "NomeMarca"; // GUARDAR NO BD (Marca)
                cbMarca.SelectedIndex = -1;
                this.rptProduto.RefreshReport();
                this.rptProduto.RefreshReport();
                this.rptProduto.RefreshReport();
            }
            this.rptProduto.RefreshReport();
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0) // Estoque
            {
                gbStatus.Enabled = false;
                textQtdeEstoque.Enabled = true;
                textPreco.Enabled = false;
                cbCategoria.Enabled = false;
                cbMarca.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 1) // Preço 
            {
                gbStatus.Enabled = false;
                textQtdeEstoque.Enabled = false;
                textPreco.Enabled = true;
                cbCategoria.Enabled = false;
                cbMarca.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 2) // Categoria
            {
                gbStatus.Enabled = false;
                textQtdeEstoque.Enabled = false;
                textPreco.Enabled = false;
                cbCategoria.Enabled = true;
                cbMarca.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 3) // Marca
            {
                gbStatus.Enabled = false;
                textQtdeEstoque.Enabled = false;
                textPreco.Enabled = false;
                cbCategoria.Enabled = false;
                cbMarca.Enabled = true;
            }

            if (cbTipoRel.SelectedIndex == 4) // Status
            {
                gbStatus.Enabled = true;
                textQtdeEstoque.Enabled = false;
                textPreco.Enabled = false;
                cbCategoria.Enabled = false;
                cbMarca.Enabled = false;
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            //VARIÁVEIS 
            classProduto cProduto = new classProduto();
            string pesquisa = cbTipoRel.SelectedItem.ToString(); //PARA PEGAR A OPÇÃO ESCOLHIDA PELO USUÁRIO
            switch (pesquisa)
            {
                case "Estoque":
                    if (textQtdeEstoque.Text != "")

                    {
                        int qtde = Convert.ToInt32(textQtdeEstoque.Text);
                        classProdutoBindingSource.DataSource = cProduto.RelProdutoQtdeEstoque(qtde);
                        this.rptProduto.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor digitar uma quantidade de estoque.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;

                case "Preço":
                    if (textPreco.Text != "")

                    {
                        decimal preco = Convert.ToDecimal(textPreco.Text);
                        classProdutoBindingSource.DataSource = cProduto.RelProdutoPreco(preco);
                        this.rptProduto.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor digitar um preço.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;

                case "Categoria":

                    if (cbCategoria.Text != "")
                    {
                        string categoria;
                        categoria = Convert.ToString(cbCategoria.Text);

                        classProdutoBindingSource.DataSource = cProduto.RelProdutoCategoria(categoria);

                        this.rptProduto.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher uma Categoria.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Marca":

                    if (cbMarca.Text != "")
                    {
                        string marca;
                        marca = Convert.ToString(cbMarca.Text);

                        classProdutoBindingSource.DataSource = cProduto.RelProdutoMarca(marca);

                        this.rptProduto.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher uma Marca.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Status":
                    if (rbtAtivo.Checked == true)

                    {
                        cProduto.Status = 1;
                        classProdutoBindingSource.DataSource = cProduto.RelProdutoStatus(cProduto.Status);
                        this.rptProduto.RefreshReport();
                    }
                    else
                    {
                        cProduto.Status = 0;
                        classProdutoBindingSource.DataSource = cProduto.RelProdutoStatus(cProduto.Status);
                        this.rptProduto.RefreshReport();
                    }
                    break;
            }
        }

        private void textPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, BACKSPAACE(08), ENTER(13) e ESPAÇO(32)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32 && e.KeyChar != 44)
            {
                //Se o usuário pressionar uma tecla não numérica no textbox, cancela o evento key press
                e.Handled = true;
                MessageBox.Show("Este Campo permite apenas Números e virgula!", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
