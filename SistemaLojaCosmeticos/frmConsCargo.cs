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
    public partial class frmConsCargo : Form
    {
        public frmConsCargo()
        {
            InitializeComponent();
        }

      

        private void frmConsCargo_Load(object sender, EventArgs e)
        {
            //Carregar Combo com as opções de Pesquisa de Cargo
            cbOpcoes.Items.Add("Descrição");
            cbOpcoes.Items.Add("Código");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.SelectedIndex = 0;
            rbtContem.Checked = true;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar a consulta de Cargo?", "Atenção!",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOpcoes.SelectedIndex == 0) //Descrição
            {
                textPesquisar.Enabled = true;
                gbTipoPesquisa.Enabled = true;
                gbStatus.Enabled = false;
                textPesquisar.Focus();
                textCodigoCargo.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 1) //Código
            {
                textPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                textCodigoCargo.Enabled = true;
                textCodigoCargo.Focus();

            }


            if (cbOpcoes.SelectedIndex == 2) //Status
            {
                textPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = true;
                rbAtivo.Checked = true;
                textCodigoCargo.Enabled = false;

            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //VARIÁVEL PARA GUARDAR A OPÇÃO NA COMBO DE OPÇÕES
            string Consulta = cbOpcoes.SelectedItem.ToString();
            classCargo cCargo = new classCargo();
            switch (Consulta)
            {
                case "Descrição":
                    //VERIFICAR SE TEM CAMPO EM BRANCO NO TEXT PESQUISAR
                    if (textPesquisar.Text != "")
                    {
                        //INÍCIO
                        if (rbtInicio.Checked)
                        {
                            cCargo.NomeCargo = textPesquisar.Text;
                            dgvCargo.DataSource = cCargo.BuscarCargoDescricaoInicial();
                        }
                        //CONTÉM
                        else if (rbtContem.Checked)
                        {
                            cCargo.NomeCargo = textPesquisar.Text;
                            dgvCargo.DataSource = cCargo.BuscarCargoDescricaoContem();
                        }
                    }
                    else
                        MessageBox.Show("Favor informar uma Descrição.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        cCargo.Status = 1;
                        dgvCargo.DataSource = cCargo.BuscarCargoStatus();
                    }
                    else
                        cCargo.Status = 0;
                    dgvCargo.DataSource = cCargo.BuscarCargoStatus();
                    break;

                case "Código":
                    if (textCodigoCargo.Text != "")
                    {
                        cCargo.CodigoCargo = Convert.ToInt32(textCodigoCargo.Text);
                        dgvCargo.DataSource = cCargo.BuscarCargoCodigo();
                    }
                    else
                        MessageBox.Show("Favor informar o código do cargo.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dgvCargo.SelectedCells.Count > 0)
            {
                classCargo cCargo = new classCargo();
                cCargo.RetornaCargo(Convert.ToInt32(dgvCargo.SelectedRows[0].Cells[0].Value));
                frmCargo formCargo = new frmCargo();

                //Não esquecer de mudar a propriedade modifiers para Public dos objetos do formulário de Produto
                formCargo.textCargo.Text = cCargo.CodigoCargo.ToString();
                formCargo.lbData.Text = cCargo.DataCadastro.ToShortDateString();
                formCargo.textNomeCargo.Text = cCargo.NomeCargo;
                formCargo.textObservacao.Text = cCargo.Observacao;


                if (cCargo.Status == 1)
                {
                    formCargo.ckStatus.Checked = true;
                }
                else
                {
                    formCargo.ckStatus.Checked = false;
                }
                //Mandar a informação de update
                formCargo.tipo = "Atualização";
                //Não permitir que outro formulário seja aberto e depois de atualizar fecha o formulário
                formCargo.ShowDialog();
                //Chamar método de pesquisa
                btPesquisar_Click(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Selecione o Cargo a ser atualizado!", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmConsCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //O Código "!E.SHIFT" indica que é para mudar para o próximo campo se pressionado enter, e ir para o campo anterior se pressionados SHIFT e ENTER SIMULTANEAMENTE
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
