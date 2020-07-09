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
    public partial class frmRelCargo : Form
    {
        public frmRelCargo()
        {
            InitializeComponent();
        }

        private void frmRelCargo_Load(object sender, EventArgs e)
        {
            classCargo cCargo= new classCargo();
            classCargoBindingSource.DataSource = cCargo.RelCargo();
            this.rptCargo.RefreshReport();
        }
    }
}
