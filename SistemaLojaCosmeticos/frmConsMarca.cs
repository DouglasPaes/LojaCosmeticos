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
    public partial class frmConsMarca : Form
    {
        public frmConsMarca()
        {
            InitializeComponent();
        }

       

        private void frmConsMarca_Load(object sender, EventArgs e)
        {
            //Carregar Combo com as opções de Pesquisa de Marca
            cbOpcoes.Items.Add("Descrição");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.SelectedIndex = 0;
            rbtContem.Checked = true;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar a consulta de Marca?", "Atenção!",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //VARIÁVEL PARA GUARDAR A OPÇÃO NA COMBO DE OPÇÕES
            string Consulta = cbOpcoes.SelectedItem.ToString();
            classMarca cMarca = new classMarca();
            switch (Consulta)
            {
                case "Descrição":
                    //VERIFICAR SE TEM CAMPO EM BRANCO NO TEXT PESQUISAR
                    if (textPesquisar.Text != "")
                    {
                        //INÍCIO
                        if (rbtInicio.Checked)
                        {
                            cMarca.NomeMarca = textPesquisar.Text;
                            dgvMarca.DataSource = cMarca.BuscarMarcaDescricaoInicial();
                        }
                        //CONTÉM
                        else if (rbtContem.Checked)
                        {
                            cMarca.NomeMarca = textPesquisar.Text;
                            dgvMarca.DataSource = cMarca.BuscarMarcaDescricaoContem();
                        }
                    }
                    else
                        MessageBox.Show("Favor informar uma Descrição.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        cMarca.Status = 1;
                        dgvMarca.DataSource = cMarca.BuscarMarcaStatus();
                    }
                    else
                        cMarca.Status = 0;
                    dgvMarca.DataSource = cMarca.BuscarMarcaStatus();
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
            if (dgvMarca.SelectedCells.Count > 0)
            {
                classMarca cMarca = new classMarca();
                cMarca.RetornaMarca(Convert.ToInt32(dgvMarca.SelectedRows[0].Cells[0].Value));
                frmMarca formMarca = new frmMarca();

                //Não esquecer de mudar a propriedade modifiers para Public dos objetos do formulário de Produto
                formMarca.textMarca.Text = cMarca.CodigoMarca.ToString();
                formMarca.lbData.Text = cMarca.DataCadastro.ToShortDateString();
                formMarca.textNomeMarca.Text = cMarca.NomeMarca;
                formMarca.textObservacao.Text = cMarca.Observacao;


                if (cMarca.Status == 1)
                {
                    formMarca.ckStatus.Checked = true;
                }
                else
                {
                    formMarca.ckStatus.Checked = false;
                }
                //Mandar a informação de update
                formMarca.tipo = "Atualização";
                //Não permitir que outro formulário seja aberto e depois de atualizar fecha o formulário
                formMarca.ShowDialog();
                //Chamar método de pesquisa
                btPesquisar_Click(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Selecione a Marca a ser atualizada!", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmConsMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //O Código "!E.SHIFT" indica que é para mudar para o próximo campo se pressionado enter, e ir para o campo anterior se pressionados SHIFT e ENTER SIMULTANEAMENTE
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
