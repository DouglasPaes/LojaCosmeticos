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
    public partial class frmConsProduto : Form
    {
        public frmConsProduto()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            //Carregar combo  com as opções de pesquisa de produtos
            cbConsulta.Items.Add("Descrição");
            cbConsulta.Items.Add("Categoria");
            cbConsulta.Items.Add("Marca");
            cbConsulta.Items.Add("Preço");
            cbConsulta.Items.Add("Status");
            cbConsulta.SelectedIndex = 0;

            rdContem.Checked = true;

            //Carregar combo de marca

            classMarca cMarca = new classMarca();
            cbMarca.DataSource = cMarca.BuscarMarca(); // Executar método de consulta criado na classe de marca
            cbMarca.DisplayMember = "NomeMarca"; // Exibir na combo (NOME)
            cbMarca.ValueMember = "CodigoMarca"; //Guardar no BD (Código)
            cbMarca.SelectedIndex = -1; // Limpar a combo (Não deixar nada selecionado)

            // Carregar combo de categoria

            classCategoria cCategoria = new classCategoria();
            cbCategoria.DataSource = cCategoria.BuscarCategoria(); // Executar método de consulta criado na classe de marca
            cbCategoria.DisplayMember = "NomeCategoria"; // Exibir na combo (NOME)
            cbCategoria.ValueMember = "CodigoCategoria"; //Guardar no BD (Código)
            cbCategoria.SelectedIndex = -1; // Limpar a combo (Não deixar nada selecionado)





        }

        private void cbConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbConsulta.SelectedIndex ==0) //Descrição
            {
                txtPesquisar.Enabled = true;
                gbTipoPesquisa.Enabled = true;
                gbStatus.Enabled = false;
                cbCategoria.Enabled = false;
                cbMarca.Enabled = false;
                gbValores.Enabled = false;
                txtPesquisar.Focus();
              }


            if (cbConsulta.SelectedIndex == 1) //Categoria
            {
                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                cbCategoria.Enabled = true;
                cbMarca.Enabled = false;
                gbValores.Enabled = false;
                
            }


            if (cbConsulta.SelectedIndex == 2) //Marca
            {
                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                cbCategoria.Enabled = false;
                cbMarca.Enabled = true;
                gbValores.Enabled = false;

            }

            if (cbConsulta.SelectedIndex == 3) //Preço
            {
                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                cbCategoria.Enabled = false;
                cbMarca.Enabled = false;
                gbValores.Enabled = true;
                txtPrecoInicial.Focus();

            }

            if (cbConsulta.SelectedIndex == 4) //Status
            {

                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = true;
                rbAtivo.Checked = true;
                cbCategoria.Enabled = false;
                cbMarca.Enabled = false;
                gbValores.Enabled = false;

            }

        }

        // Botão pesquisar

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //Variável para guardar a opção selecionada na combo de opções
            string Consulta = cbConsulta.SelectedItem.ToString();
            classProduto cProduto = new classProduto();
            switch (Consulta)
            {
              case "Descrição":
                    //Verificar se algo foi digitado no text pesquisar
                    if (txtPesquisar.Text != "")
                    {
                        //Inicio
                        if (rdInicio.Checked)
                        {
                            cProduto.NomeProduto = txtPesquisar.Text;
                            dgColunas.DataSource = cProduto.BuscarProdutoDescricaoInicial();

                        }
                        //Contém
                        else if (rdContem.Checked)
                            cProduto.NomeProduto = txtPesquisar.Text;
                        dgColunas.DataSource = cProduto.BuscarProdutoDescricaoContem();

                    }
            
            else
            MessageBox.Show("Favor informar uma descrição", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;

            case "Categoria":
            if (cbCategoria.Text != "")
            {
                cProduto.CodigoCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                dgColunas.DataSource = cProduto.BuscarProdutoCategoria();
            }
            else
                MessageBox.Show("Favor escolher uma categoria.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;

                case "Marca":
                    if (cbMarca.Text != "")
                    {
                        cProduto.CodigoMarca= Convert.ToInt32(cbMarca.SelectedValue);
                        dgColunas.DataSource = cProduto.BuscarProdutoMarca();
                    }
                    else
                        MessageBox.Show("Favor escolher uma Marca.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        cProduto.Status = 1;
                        dgColunas.DataSource = cProduto.BuscarProdutoStatus();
                    }
                    else
                        cProduto.Status = 0;
                    dgColunas.DataSource = cProduto.BuscarProdutoStatus();
                       
                    break;

                case "Preço":

                    if (txtPrecoInicial.Text != "" && txtPrecoFinal.Text != "")
                    {
                        decimal precoi = Convert.ToDecimal(txtPrecoInicial.Text);
                        decimal precof = Convert.ToDecimal(txtPrecoFinal.Text);
                        dgColunas.DataSource = cProduto.BuscarProdutoPreco(precoi, precof);
                    }
                    else
                        MessageBox.Show("Favor informar preço inicial e preço final.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;


            }

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if(dgColunas.SelectedCells.Count >0)
            {
                classProduto cProduto = new classProduto();
                cProduto.RetornaProduto(Convert.ToInt32(dgColunas.SelectedRows[0].Cells[0].Value));
                frmProduto formProduto = new frmProduto();

                //Não esquecer de mudar a propriedade modifiers para public dos objetos do formulário de produto
                formProduto.txtCodigoProduto.Text = cProduto.CodigoProduto.ToString();
                formProduto.lbData.Text = cProduto.DataCadastro.ToShortDateString();
                formProduto.textNomeProduto.Text = cProduto.NomeProduto;
                formProduto.textQtdeEstoque.Text = cProduto.QtdeEstoque.ToString();
                formProduto.txtPrecoVenda.Text = cProduto.PrecoVenda.ToString();
                formProduto.textObservacao.Text = cProduto.Observacao;
                formProduto.marca = cProduto.CodigoMarca; //(Combo) Passar a variável declarada no formulário de produto 
                formProduto.categoria = cProduto.CodigoCategoria;//(Combo) Passar a variável declarada no formulário de produto

                if (cProduto.Status ==1)
                {
                    formProduto.ckStatus.Checked = true;


                }
                else
                {
                    formProduto.ckStatus.Checked = false;
                }

                //Mandar a informação de update
                formProduto.tipo = "Atualização";
                //Não permitir que outro formulário seja aberto e depois de atualizar fecha o formulário
                formProduto.ShowDialog();
                //Chamar método de pesquisa
                btPesquisar_Click(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Selecione o produto a ser atualizado!", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar a consulta de Produto?", "Atenção!",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }
    }
    }

