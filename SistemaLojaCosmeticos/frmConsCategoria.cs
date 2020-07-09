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
    public partial class frmConsCategoria : Form
    {
        public frmConsCategoria()
        {
            InitializeComponent();
        }

        

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar a consulta de Categoria?", "Atenção!",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }

        private void frmConsCategoria_Load(object sender, EventArgs e)
        {
            //Carregar Combo com as opções de Pesquisa de Categoria
            cbOpcoes.Items.Add("Descrição");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.SelectedIndex = 0;
            rbtContem.Checked = true;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //VARIÁVEL PARA GUARDAR A OPÇÃO NA COMBO DE OPÇÕES
            string Consulta = cbOpcoes.SelectedItem.ToString();
            classCategoria cCategoria = new classCategoria();
            switch (Consulta)
            {
                case "Descrição":
                    //VERIFICAR SE TEM CAMPO EM BRANCO NO TEXT PESQUISAR
                    if (textPesquisar.Text != "")
                    {
                        //INÍCIO
                        if (rbtInicio.Checked)
                        {
                            cCategoria.NomeCategoria = textPesquisar.Text;
                            dgvCategoria.DataSource = cCategoria.BuscarCategoriaDescricaoInicial();
                        }
                        //CONTÉM
                        else if (rbtContem.Checked)
                        {
                            cCategoria.NomeCategoria = textPesquisar.Text;
                            dgvCategoria.DataSource = cCategoria.BuscarCategoriaDescricaoContem();
                        }
                    }
                    else
                        MessageBox.Show("Favor informar uma Descrição.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        cCategoria.Status = 1;
                        dgvCategoria.DataSource = cCategoria.BuscarCategoriaStatus();
                    }
                    else
                        cCategoria.Status = 0;
                    dgvCategoria.DataSource = cCategoria.BuscarCategoriaStatus();
                    break;

               
            }
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOpcoes.SelectedIndex == 0) //Descrição
            {
                textPesquisar.Enabled = true;
                gbTipoPesquisa.Enabled = true;
                gbStatus.Enabled = false;
                textPesquisar.Focus();
                

            }

            //if (cbOpcoes.SelectedIndex == 1) //Código
            //{
            //    textPesquisar.Enabled = false;
            //    gbTipoPesquisa.Enabled = false;
            //    gbStatus.Enabled = false;
                


            //}


            if (cbOpcoes.SelectedIndex == 1) //Status
            {
                textPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = true;
                rbAtivo.Checked = true;


            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.SelectedCells.Count > 0)
            {
                classCategoria cCategoria = new classCategoria();
                cCategoria.RetornaCategoria(Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value));
                frmCategoria formCategoria = new frmCategoria();

                //Não esquecer de mudar a propriedade modifiers para Public dos objetos do formulário de Produto
                formCategoria.textCategoria.Text = cCategoria.CodigoCategoria.ToString();
                formCategoria.lbData.Text = cCategoria.DataCadastro.ToShortDateString();
                formCategoria.textNomeCategoria.Text = cCategoria.NomeCategoria;
                formCategoria.textObservacao.Text = cCategoria.Observacao;
             

                if (cCategoria.Status == 1)
                {
                    formCategoria.ckStatus.Checked = true;
                }
                else
                {
                    formCategoria.ckStatus.Checked = false;
                }
                //Mandar a informação de update
                formCategoria.tipo = "Atualização";
                //Não permitir que outro formulário seja aberto e depois de atualizar fecha o formulário
                formCategoria.ShowDialog();
                //Chamar método de pesquisa
                btPesquisar_Click(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Selecione a Categoria a ser atualizado!", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmConsCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //O Código "!E.SHIFT" indica que é para mudar para o próximo campo se pressionado enter, e ir para o campo anterior se pressionados SHIFT e ENTER SIMULTANEAMENTE
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void gbStatus_Enter(object sender, EventArgs e)
        {

        }
    }
}
