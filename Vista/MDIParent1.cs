using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producto_2.Vista
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
            IsMdiContainer = true;  
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
         
        }

        private void OpenFile(object sender, EventArgs e)
        {
         
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            frmAutenticacion frmAuten   = new frmAutenticacion();
            frmAuten.MdiParent = this;
            frmAuten.ControlBox = false;
            frmAuten.MaximizeBox = false;   
            frmAuten.MinimizeBox = false;
            frmAuten.Show();
        }
    }
}
