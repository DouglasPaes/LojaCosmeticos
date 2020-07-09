namespace SistemaLojaCosmeticos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.timerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLbData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolstripLbMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cadFuncionarios = new System.Windows.Forms.ToolStripButton();
            this.cadClientes = new System.Windows.Forms.ToolStripButton();
            this.cadVendas = new System.Windows.Forms.ToolStripButton();
            this.cadSair = new System.Windows.Forms.ToolStripButton();
            this.cargoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuConsultas,
            this.menuRelatorios,
            this.menuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadCategoria,
            this.menuCadMarca,
            this.menuCadProduto,
            this.cargoToolStripMenuItem});
            this.menuCadastros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCadastros.Image = ((System.Drawing.Image)(resources.GetObject("menuCadastros.Image")));
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(104, 36);
            this.menuCadastros.Text = "Cadastros";
            // 
            // menuCadCategoria
            // 
            this.menuCadCategoria.Name = "menuCadCategoria";
            this.menuCadCategoria.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuCadCategoria.Size = new System.Drawing.Size(147, 22);
            this.menuCadCategoria.Text = "Categoria";
            this.menuCadCategoria.Click += new System.EventHandler(this.menuCadCategoria_Click);
            // 
            // menuCadMarca
            // 
            this.menuCadMarca.Name = "menuCadMarca";
            this.menuCadMarca.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuCadMarca.Size = new System.Drawing.Size(147, 22);
            this.menuCadMarca.Text = "Marca";
            this.menuCadMarca.Click += new System.EventHandler(this.menuCadMarca_Click);
            // 
            // menuCadProduto
            // 
            this.menuCadProduto.Name = "menuCadProduto";
            this.menuCadProduto.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuCadProduto.Size = new System.Drawing.Size(147, 22);
            this.menuCadProduto.Text = "Produto";
            this.menuCadProduto.Click += new System.EventHandler(this.menuCadProduto_Click);
            // 
            // cargoToolStripMenuItem
            // 
            this.cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            this.cargoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cargoToolStripMenuItem.Text = "Cargo";
            this.cargoToolStripMenuItem.Click += new System.EventHandler(this.cargoToolStripMenuItem_Click);
            // 
            // menuConsultas
            // 
            this.menuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.marcaToolStripMenuItem1,
            this.funcionáriosToolStripMenuItem,
            this.clientesToolStripMenuItem1,
            this.cargoToolStripMenuItem1});
            this.menuConsultas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuConsultas.Image = ((System.Drawing.Image)(resources.GetObject("menuConsultas.Image")));
            this.menuConsultas.Name = "menuConsultas";
            this.menuConsultas.Size = new System.Drawing.Size(103, 36);
            this.menuConsultas.Text = "Consultas";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem1
            // 
            this.marcaToolStripMenuItem1.Name = "marcaToolStripMenuItem1";
            this.marcaToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.marcaToolStripMenuItem1.Text = "Marca";
            this.marcaToolStripMenuItem1.Click += new System.EventHandler(this.marcaToolStripMenuItem1_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // cargoToolStripMenuItem1
            // 
            this.cargoToolStripMenuItem1.Name = "cargoToolStripMenuItem1";
            this.cargoToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.cargoToolStripMenuItem1.Text = "Cargo";
            this.cargoToolStripMenuItem1.Click += new System.EventHandler(this.cargoToolStripMenuItem1_Click);
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem1,
            this.cargoToolStripMenuItem2,
            this.produtoToolStripMenuItem,
            this.categoriaToolStripMenuItem1});
            this.menuRelatorios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("menuRelatorios.Image")));
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(107, 36);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem1
            // 
            this.funcionáriosToolStripMenuItem1.Name = "funcionáriosToolStripMenuItem1";
            this.funcionáriosToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.funcionáriosToolStripMenuItem1.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem1.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem1_Click);
            // 
            // menuSair
            // 
            this.menuSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSair.Image = ((System.Drawing.Image)(resources.GetObject("menuSair.Image")));
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(72, 36);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // timerPrincipal
            // 
            this.timerPrincipal.Enabled = true;
            this.timerPrincipal.Tick += new System.EventHandler(this.timerPrincipal_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbHora,
            this.statusLbData,
            this.toolstripLbMensagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(680, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbHora
            // 
            this.statusLbHora.Name = "statusLbHora";
            this.statusLbHora.Size = new System.Drawing.Size(33, 17);
            this.statusLbHora.Text = "Hora";
            // 
            // statusLbData
            // 
            this.statusLbData.Name = "statusLbData";
            this.statusLbData.Size = new System.Drawing.Size(31, 17);
            this.statusLbData.Text = "Data";
            // 
            // toolstripLbMensagem
            // 
            this.toolstripLbMensagem.Name = "toolstripLbMensagem";
            this.toolstripLbMensagem.Size = new System.Drawing.Size(129, 17);
            this.toolstripLbMensagem.Text = "! Bem vindo ao sistema";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadFuncionarios,
            this.cadClientes,
            this.cadVendas,
            this.cadSair});
            this.toolStrip1.Location = new System.Drawing.Point(599, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 334);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cadFuncionarios
            // 
            this.cadFuncionarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("cadFuncionarios.Image")));
            this.cadFuncionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cadFuncionarios.Name = "cadFuncionarios";
            this.cadFuncionarios.Size = new System.Drawing.Size(78, 67);
            this.cadFuncionarios.Text = "Funcionários";
            this.cadFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cadFuncionarios.Click += new System.EventHandler(this.cadFuncionarios_Click);
            // 
            // cadClientes
            // 
            this.cadClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadClientes.Image = ((System.Drawing.Image)(resources.GetObject("cadClientes.Image")));
            this.cadClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cadClientes.Name = "cadClientes";
            this.cadClientes.Size = new System.Drawing.Size(78, 67);
            this.cadClientes.Text = "Clientes";
            this.cadClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cadClientes.Click += new System.EventHandler(this.cadClientes_Click);
            // 
            // cadVendas
            // 
            this.cadVendas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadVendas.Image = ((System.Drawing.Image)(resources.GetObject("cadVendas.Image")));
            this.cadVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cadVendas.Name = "cadVendas";
            this.cadVendas.Size = new System.Drawing.Size(78, 67);
            this.cadVendas.Text = "Vendas";
            this.cadVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cadVendas.Click += new System.EventHandler(this.cadVendas_Click);
            // 
            // cadSair
            // 
            this.cadSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadSair.Image = ((System.Drawing.Image)(resources.GetObject("cadSair.Image")));
            this.cadSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cadSair.Name = "cadSair";
            this.cadSair.Size = new System.Drawing.Size(78, 67);
            this.cadSair.Text = "Sair";
            this.cadSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cadSair.Click += new System.EventHandler(this.cadSair_Click);
            // 
            // cargoToolStripMenuItem2
            // 
            this.cargoToolStripMenuItem2.Name = "cargoToolStripMenuItem2";
            this.cargoToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.cargoToolStripMenuItem2.Text = "Cargo";
            this.cargoToolStripMenuItem2.Click += new System.EventHandler(this.cargoToolStripMenuItem2_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem1
            // 
            this.categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            this.categoriaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.categoriaToolStripMenuItem1.Text = "Categoria";
            this.categoriaToolStripMenuItem1.Click += new System.EventHandler(this.categoriaToolStripMenuItem1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 396);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem menuCadCategoria;
        private System.Windows.Forms.ToolStripMenuItem menuCadMarca;
        private System.Windows.Forms.ToolStripMenuItem menuCadProduto;
        private System.Windows.Forms.ToolStripMenuItem menuConsultas;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.Timer timerPrincipal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolstripLbMensagem;
        private System.Windows.Forms.ToolStripStatusLabel statusLbData;
        private System.Windows.Forms.ToolStripStatusLabel statusLbHora;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cadFuncionarios;
        private System.Windows.Forms.ToolStripButton cadClientes;
        private System.Windows.Forms.ToolStripButton cadVendas;
        private System.Windows.Forms.ToolStripButton cadSair;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem1;
    }
}

