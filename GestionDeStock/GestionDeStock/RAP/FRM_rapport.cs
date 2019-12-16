using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.RAP
{
    public partial class FRM_rapport : Form
    {
        public FRM_rapport()
        {
            InitializeComponent();
        }

        private void FRM_rapport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
