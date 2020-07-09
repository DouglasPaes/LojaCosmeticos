namespace SistemaLojaCosmeticos
{
    partial class frmConsulta
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
            this.groupBoxConsulta = new System.Windows.Forms.GroupBox();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.groupBoxValores = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPrecoInicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPrecoFinal = new System.Windows.Forms.TextBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.groupBoxConsulta.SuspendLayout();
            this.groupBoxPesquisa.SuspendLayout();
            this.groupBoxValores.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConsulta
            // 
            this.groupBoxConsulta.Controls.Add(this.btSair);
            this.groupBoxConsulta.Controls.Add(this.btEditar);
            this.groupBoxConsulta.Controls.Add(this.label5);
            this.groupBoxConsulta.Controls.Add(this.dataGrid);
            this.groupBoxConsulta.Controls.Add(this.btPesquisar);
            this.groupBoxConsulta.Controls.Add(this.cbCategoria);
            this.groupBoxConsulta.Controls.Add(this.label4);
            this.groupBoxConsulta.Controls.Add(this.cbMarca);
            this.groupBoxConsulta.Controls.Add(this.label3);
            this.groupBoxConsulta.Controls.Add(this.groupBoxStatus);
            this.groupBoxConsulta.Controls.Add(this.groupBoxValores);
            this.groupBoxConsulta.Controls.Add(this.groupBoxPesquisa);
            this.groupBoxConsulta.Controls.Add(this.textPesquisa);
            this.groupBoxConsulta.Controls.Add(this.cbOpcoes);
            this.groupBoxConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConsulta.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConsulta.Name = "groupBoxConsulta";
            this.groupBoxConsulta.Size = new System.Drawing.Size(534, 439);
            this.groupBoxConsulta.TabIndex = 0;
            this.groupBoxConsulta.TabStop = false;
            this.groupBoxConsulta.Text = "Selecione um Tipo de Consulta:";
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Location = new System.Drawing.Point(6, 33);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(121, 24);
            this.cbOpcoes.TabIndex = 0;
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(143, 33);
            this.textPesquisa.Multiline = true;
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(193, 24);
            this.textPesquisa.TabIndex = 1;
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Controls.Add(this.rbContem);
            this.groupBoxPesquisa.Controls.Add(this.rbInicio);
            this.groupBoxPesquisa.Location = new System.Drawing.Point(355, 12);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Size = new System.Drawing.Size(151, 60);
            this.groupBoxPesquisa.TabIndex = 2;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Tipo de Pesquisa:";
            // 
            // rbInicio
            // 
            this.rbInicio.AutoSize = true;
            this.rbInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInicio.Location = new System.Drawing.Point(6, 22);
            this.rbInicio.Name = "rbInicio";
            this.rbInicio.Size = new System.Drawing.Size(54, 19);
            this.rbInicio.TabIndex = 0;
            this.rbInicio.TabStop = true;
            this.rbInicio.Text = "Início";
            this.rbInicio.UseVisualStyleBackColor = true;
            // 
            // rbContem
            // 
            this.rbContem.AutoSize = true;
            this.rbContem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContem.Location = new System.Drawing.Point(69, 22);
            this.rbContem.Name = "rbContem";
            this.rbContem.Size = new System.Drawing.Size(68, 19);
            this.rbContem.TabIndex = 1;
            this.rbContem.TabStop = true;
            this.rbContem.Text = "Contém";
            this.rbContem.UseVisualStyleBackColor = true;
            // 
            // groupBoxValores
            // 
            this.groupBoxValores.Controls.Add(this.textPrecoFinal);
            this.groupBoxValores.Controls.Add(this.label2);
            this.groupBoxValores.Controls.Add(this.textPrecoInicial);
            this.groupBoxValores.Controls.Add(this.label1);
            this.groupBoxValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxValores.Location = new System.Drawing.Point(6, 78);
            this.groupBoxValores.Name = "groupBoxValores";
            this.groupBoxValores.Size = new System.Drawing.Size(330, 63);
            this.groupBoxValores.TabIndex = 3;
            this.groupBoxValores.TabStop = false;
            this.groupBoxValores.Text = "Valores:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preço inicial:";
            // 
            // textPrecoInicial
            // 
            this.textPrecoInicial.Location = new System.Drawing.Point(89, 24);
            this.textPrecoInicial.Name = "textPrecoInicial";
            this.textPrecoInicial.Size = new System.Drawing.Size(71, 22);
            this.textPrecoInicial.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço Final:";
            // 
            // textPrecoFinal
            // 
            this.textPrecoFinal.Location = new System.Drawing.Point(244, 24);
            this.textPrecoFinal.Name = "textPrecoFinal";
            this.textPrecoFinal.Size = new System.Drawing.Size(71, 22);
            this.textPrecoFinal.TabIndex = 3;

            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.rbInativo);
            this.groupBoxStatus.Controls.Add(this.rbAtivo);
            this.groupBoxStatus.Location = new System.Drawing.Point(355, 78);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(151, 63);
            this.groupBoxStatus.TabIndex = 4;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(72, 22);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(65, 20);
            this.rbInativo.TabIndex = 4;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(7, 22);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(56, 20);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marca:";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(61, 157);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 24);
            this.cbMarca.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(257, 157);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cbCategoria.TabIndex = 8;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Location = new System.Drawing.Point(397, 151);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(109, 34);
            this.btPesquisar.TabIndex = 9;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(9, 225);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(497, 150);
            this.dataGrid.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(482, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Para Atualizar ou excluir um Produto selecione o Produto e clique no botão Editar" +
    " !!";
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(15, 381);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(88, 28);
            this.btEditar.TabIndex = 12;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(416, 379);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(90, 32);
            this.btSair.TabIndex = 13;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 463);
            this.Controls.Add(this.groupBoxConsulta);
            this.Name = "frmConsulta";
            this.Text = "Consulta de Produtos";
            this.groupBoxConsulta.ResumeLayout(false);
            this.groupBoxConsulta.PerformLayout();
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            this.groupBoxValores.ResumeLayout(false);
            this.groupBoxValores.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.GroupBox groupBoxValores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.TextBox textPrecoFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPrecoInicial;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}