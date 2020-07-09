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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuCadCategoria_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCategoria>().Count() > 0)
            {
                MessageBox.Show("O Formulario Consulta de Categoria já está aberto", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {     // Criar o objeto e instanciar
                frmCategoria CadCategoria = new frmCategoria();
                // Transformar o formulario marca em filho do principal
                CadCategoria.MdiParent = this;
                // Chamar Formulário
                CadCategoria.Show();

            }
        }

        private void menuCadMarca_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmMarca>().Count() > 0)
            {
                MessageBox.Show("O Formulario Consulta de Marca já está aberto", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                // Criar o objeto e instanciar
                frmMarca CadMarca = new frmMarca();
                // Transformar o formulario marca em filho do principal
                CadMarca.MdiParent = this;
                // Chamar Formulário
                CadMarca.Show();
            }
        }

        private void menuCadProduto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulario Consulta de Produto já está aberto", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                // Criar o objeto e instanciar
                frmProduto CadProduto = new frmProduto();
                // Transformar o formulario marca em filho do principal
                CadProduto.MdiParent = this;
                // Chamar Formulário
                CadProduto.Show();
            }
        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            statusLbData.Text = DateTime.Now.ToShortDateString();
            statusLbHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o sistema?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit();
        }



        private void cadFuncionarios_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFuncionarios>().Count() > 0)
            {
                MessageBox.Show("O Formulario cadastro de Funcionários já está aberto", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Criar o objeto e instanciar
                frmFuncionarios CadFuncionarios = new frmFuncionarios();
                // Transformar o formulario marca em filho do principal
                CadFuncionarios.MdiParent = this;
                // Chamar Formulário
                CadFuncionarios.Show();
            }
        }

        private void cadClientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmClientes>().Count() > 0)
            {
                MessageBox.Show("O Formulario cadastro de Clientes já está aberto", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Criar o objeto e instanciar
                frmClientes cadClientes = new frmClientes();
                // Transformar o formulario marca em filho do principal
                cadClientes.MdiParent = this;
                // Chamar Formulário
                cadClientes.Show();
            }
        }

        private void cadVendas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmVendaCliGrid>().Count() > 0)
            {
                MessageBox.Show("O Formulario cadastro de Vendas já está aberto", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Criar o objeto e instanciar
                frmVendaCliGrid cadVendas = new frmVendaCliGrid();
                // Transformar o formulario marca em filho do principal
                cadVendas.MdiParent = this;
                // Chamar Formulário
                cadVendas.Show();
            }
        }

        private void cadSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o sistema?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit();
        }



        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmConsProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulario Consulta de Produtos já está aberto", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {     // Criar o objeto e instanciar
                frmConsProduto ConsProduto = new frmConsProduto();
                // Transformar o formulario marca em filho do principal
                ConsProduto.MdiParent = this;
                // Chamar Formulário
                ConsProduto.Show();

            }
        }



        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (Application.OpenForms.OfType<frmRelMarca>().Count() > 0)
            {
                MessageBox.Show("O Formulario Relatório de marca já está aberto", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {     // Criar o objeto e instanciar
                frmRelMarca RealMarca = new frmRelMarca();
                // Transformar o formulario marca em filho do principal
                RealMarca.MdiParent = this;
                // Chamar Formulário
                RealMarca.Show();

            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelCliente>().Count() > 0)
            {
                MessageBox.Show("O Formulario Relatório de cliente já está aberto", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {     // Criar o objeto e instanciar
                frmRelCliente RelCliente = new frmRelCliente();
                // Transformar o formulario marca em filho do principal
                RelCliente.MdiParent = this;
                // Chamar Formulário
                RelCliente.Show();
            }
        }


        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCargo>().Count() > 0)
            {
                MessageBox.Show("O Formulario Cadastro de Cargo já está aberto.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                // Criar o objeto e instanciar
                frmCargo CadCargo = new frmCargo();
                // Transformar o formulario marca em filho do principal
                CadCargo.MdiParent = this;
                // Chamar Formulário
                CadCargo.Show();
            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmConsCategoria>().Count() > 0)
            {
                MessageBox.Show("O Formulario Consulta de Categorias já está aberto.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {     // Criar o objeto e instanciar
                frmConsCategoria ConsCategoria = new frmConsCategoria();
                // Transformar o formulario marca em filho do principal
                ConsCategoria.MdiParent = this;
                // Chamar Formulário
                ConsCategoria.Show();
            }
        }

        private void marcaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmConsMarca>().Count() > 0)
            {
                MessageBox.Show("O Formulario Consulta de Marcas já está aberto.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {     // Criar o objeto e instanciar
                frmConsMarca ConsMarca = new frmConsMarca();
                // Transformar o formulario marca em filho do principal
                ConsMarca.MdiParent = this;
                // Chamar Formulário
                ConsMarca.Show();
            }
        }

        private void cargoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmConsCargo>().Count() > 0)
            {
                MessageBox.Show("O Formulario Consulta de Cargos já está aberto.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {     // Criar o objeto e instanciar
                frmConsCargo ConsCargo = new frmConsCargo();
                // Transformar o formulario marca em filho do principal
                ConsCargo.MdiParent = this;
                // Chamar Formulário
                ConsCargo.Show();
            }
        }
        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmConsCliente>().Count() > 0)
            {
                MessageBox.Show("O Formulario Consulta de Clientes já está aberto.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {     // Criar o objeto e instanciar
                frmConsCliente ConsCliente = new frmConsCliente();
                // Transformar o formulario marca em filho do principal
                ConsCliente.MdiParent = this;
                // Chamar Formulário
                ConsCliente.Show();
            }
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmConsFuncionarios>().Count() > 0)
            {
                MessageBox.Show("O Formulario Consulta de Funcionários já está aberto.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {     // Criar o objeto e instanciar
                frmConsFuncionarios ConsFuncionario = new frmConsFuncionarios();
                // Transformar o formulario marca em filho do principal
                ConsFuncionario.MdiParent = this;
                // Chamar Formulário
                ConsFuncionario.Show();
            }
        }

        private void funcionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelFuncionarios>().Count() > 0)
            {
                MessageBox.Show("O Formulario Relatório de funcionários já está aberto", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {     // Criar o objeto e instanciar
                frmRelFuncionarios RelFuncionarios = new frmRelFuncionarios();
                // Transformar o formulario marca em filho do principal
                RelFuncionarios.MdiParent = this;
                // Chamar Formulário
                RelFuncionarios.Show();
            }
        }

        private void cargoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelCargo>().Count() > 0)
            {
                MessageBox.Show("O Formulario relatório de Cargo já está aberto.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {     // Criar o objeto e instanciar
                frmRelCargo RealCargo = new frmRelCargo();
                // Transformar o formulario marca em filho do principal
                RealCargo.MdiParent = this;
                // Chamar Formulário
                RealCargo.Show();
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulario Relátório de Produto já está aberto.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {     // Criar o objeto e instanciar
                frmRelProduto RelProduto = new frmRelProduto();
                // Transformar o formulario marca em filho do principal
                RelProduto.MdiParent = this;
                // Chamar Formulário
                RelProduto.Show();
            }
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelCategoria>().Count() > 0)
            {
                MessageBox.Show("O Formulario relatório de Categoria já está aberto.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {     // Criar o objeto e instanciar
                frmRelCategoria RealCategoria = new frmRelCategoria();
                // Transformar o formulario marca em filho do principal
                RealCategoria.MdiParent = this;
                // Chamar Formulário
                RealCategoria.Show();
            }
        }
    }
}