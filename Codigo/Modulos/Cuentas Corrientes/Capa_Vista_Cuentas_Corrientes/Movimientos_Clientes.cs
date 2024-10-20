using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Cuentas_Corrientes
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void creacionClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaPago man = new FormaPago();
            man.Show(); 
        }

        private void nuevosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteNuevo man = new ClienteNuevo();///este funciona *****
            man.Show();
        }


        private void tiposDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaPago man = new FormaPago();///este funciona *****
            man.Show();
        }
    }
}
