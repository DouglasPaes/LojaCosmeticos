﻿using System;
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
    public partial class frmRelMarca : Form
    {
        public frmRelMarca()
        {
            InitializeComponent();
        }

        private void frmRelMarca_Load(object sender, EventArgs e)
        {
            classMarca cMarca = new classMarca();
            classMarcaBindingSource.DataSource = cMarca.RelMarca();
            this.rptMarca.RefreshReport();
        }
    }
}
