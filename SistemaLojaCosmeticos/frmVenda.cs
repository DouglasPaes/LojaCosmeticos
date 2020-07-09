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
    public partial class frmVendaCliGrid : Form
    {
        public frmVendaCliGrid()
        {
            InitializeComponent();
        }
        //Lista Itens da Venda
        private List<classItensVenda> ListaItensVenda = new List<classItensVenda>();

        //Variável para calcular valor Total da venda
        private decimal VendaTotal = 0;

        //Variável para contar quantos produtos foram adicionados na lista
        private int itensVenda = 0;

        private void frmVendaCliGrid_Load(object sender, EventArgs e)
        {

            //Combo Funcionario
            classFuncionario cFuncionario = new classFuncionario();
            cbFuncionario.DataSource = cFuncionario.BuscarFuncionario();//Executar método
            cbFuncionario.DataSource = cFuncionario.BuscarFuncionario(); //Executar método criado na classe funcionario
            cbFuncionario.DisplayMember = "NomeFuncionario"; //Exibir na combo (nome)
            cbFuncionario.ValueMember = "CodigoFuncionario"; //Guardar no BD
            cbFuncionario.SelectedIndex = -1; //Limpar a combo (não selecionada nada)


            //Combo forma de Pagamento
            cbFormaPagamento.Items.Add("Dinheiro");
            cbFormaPagamento.Items.Add("Cartão de Crédito");
            cbFormaPagamento.Items.Add("Cartão de Débito");
            cbFormaPagamento.Items.Add("Crediário");
            cbFormaPagamento.SelectedIndex = 0;



        }

        private void txtValorDesconto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValorDesconto.Text))
            {
                decimal valor = Convert.ToDecimal(txtValorTotal.Text);
                decimal desc = 0;
                txtTotalVenda.Text = (valor * (1 - (desc / 100))).ToString("n2");
                txtTotalDesconto.Text = (valor - (valor * (1 - (desc / 100)))).ToString("n2");

            }
            else
            {
                decimal valor = Convert.ToDecimal(txtValorTotal.Text);
                decimal desc = Convert.ToDecimal(txtValorDesconto.Text);
                txtTotalVenda.Text = (valor * (1 - (desc / 100))).ToString("n2");
                txtTotalDesconto.Text = (valor - (valor * (1 - (desc / 100)))).ToString("n2");

            }
        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            if (txtQtde.Text != "")
            {
                int qtde = Convert.ToInt32(txtQtde.Text);
                decimal valor = Convert.ToDecimal(txtValor.Text);
                txtTotal.Text = (qtde * valor).ToString();

            }
            else
            {
                MessageBox.Show("Favor infrmar uma quantidade", "Sistema Loja de Cosméticos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }



        private void AtualizaGrid()
        {
            //Adiciona na grid a partir da lista
            classProduto cProduto = new classProduto();
            DataTable dt = new DataTable();

            //Criar as colunas da grid
            dt.Columns.Add(new DataColumn("Código"));
            dt.Columns.Add(new DataColumn("Produto"));
            dt.Columns.Add(new DataColumn("Quantidade"));
            dt.Columns.Add(new DataColumn("Preço"));

            //Adicionar as linhas da grid
            foreach (classItensVenda Item in ListaItensVenda)
            {
                dt.Rows.Add(Item.CodigoProduto, cProduto.BuscaNomeProd(Item.CodigoProduto), Item.Qtde, Item.Preco);
                dt.AcceptChanges();
            }
            dgvItens.DataSource = dt;
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classProduto cProduto = new classProduto();
            bool aux = cProduto.BuscaProdutoId((int)dgvProduto.SelectedRows[0].Cells[0].Value);

            if (aux)
            {
                txtProduto.Text = cProduto.NomeProduto;
                txtQtdeEstoque.Text = cProduto.QtdeEstoque.ToString();
                txtValor.Text = cProduto.PrecoVenda.ToString("n2");
                txtQtde.Text = "01";
                txtQtde_TextChanged(this, new EventArgs());
                txtQtde.Select();

            }
        }

        private void btAddProduto_Click(object sender, EventArgs e)
        {
            classItensVenda cItensVenda = new classItensVenda();
            decimal vTotal = 0;

            if (string.IsNullOrEmpty(txtProduto.Text))
            {
                MessageBox.Show("Não há produto para ser inserido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                // Verificar se a quantidade vendida é maior que a quantidade em estoque
                int qtdevendida = Convert.ToInt32(txtQtde.Text);
                int qtdeestoque = Convert.ToInt32(txtQtdeEstoque.Text);

                if (qtdevendida > qtdeestoque)
                {
                    MessageBox.Show("A quantidade disponível no estoque é de " + qtdeestoque + "unidades!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQtde.Text = "01";
                    txtQtde.Select();

                }
            }
        }

        private void btRemoveProduto_Click(object sender, EventArgs e)
        {
            if (dgvItens.Rows.Count > 0)
            {
                //Subtrair o valor total de acordo com o item excluído
                decimal valor = Convert.ToDecimal(dgvItens.SelectedRows[0].Cells[3].Value);
                VendaTotal = VendaTotal - valor;
                txtValorTotal.Text = VendaTotal.ToString("n2");
                txtTotalVenda.Text = VendaTotal.ToString("n2");

                //Remover da lista e atualiza grid
                ListaItensVenda.RemoveAt(dgvItens.CurrentRow.Index);
                AtualizaGrid();
                txtQtdeItens.Text = ListaItensVenda.Count.ToString();
                txtValorDesconto_TextChanged(this, new EventArgs());

            }
            else
                MessageBox.Show("Não há itens para ser removido", "Sistema Loja de Cosmeticos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btFechaVenda_Click(object sender, EventArgs e)
        {
            if (cbFuncionario.Text != "" && dgvCliente.DataSource != null && txtPesqProduto.Text != "" && dgvItens.DataSource != null && cbFormaPagamento.Text != "")
            {
                classVenda cVenda = new classVenda();
                cVenda.CodigoCliente = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value);
                cVenda.CodigoFuncionario = (int)(cbFuncionario.SelectedValue);
                cVenda.QtdeItens = Convert.ToInt32(txtQtdeItens.Text);
                cVenda.ValorTotal = Convert.ToDecimal(txtTotalVenda.Text);
                cVenda.Observacao = txtObservacao.Text;
                cVenda.FormaPagamento = cbFormaPagamento.SelectedItem.ToString();
                cVenda.Desconto = Convert.ToDecimal(txtTotalDesconto.Text);

                bool aux = cVenda.CadastraVenda();

                if (aux)
                {
                    aux = false;

                    foreach (classItensVenda item in ListaItensVenda)
                    {
                        item.CodigoVenda = cVenda.CodigoVenda; //Fk item - Pk venda
                        aux = item.CadastraItemVenda();

                        //Baixa estoque
                        AtualizaEstoque(item.Qtde, item.CodigoProduto);
                    }
                }
            }
        }

        private void btBuscaProduto_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtPesqProduto.Text))
                MessageBox.Show("Favor informar um produto", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                classProduto cProduto = new classProduto();
                dgvProduto.DataSource = cProduto.BuscaProduto(txtPesqProduto.Text);

            }
        }
        private void btBuscaCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesqCliente.Text))
                MessageBox.Show("Favor informar um cliente", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                classCliente cCliente = new classCliente();
                dgvCliente.DataSource = cCliente.BuscarCliente(txtPesqCliente.Text);

            }
        }

            //Atualizar Estoque
        private void AtualizaEstoque(int qtde, int cod)
        {
            classProduto cProduto = new classProduto();
            cProduto.BuscaProdutoId(cod);
            int estoque = cProduto.QtdeEstoque;
            cProduto.AtualizaQtde(estoque - qtde, cod);
        }


    }

       
    }


     
    
