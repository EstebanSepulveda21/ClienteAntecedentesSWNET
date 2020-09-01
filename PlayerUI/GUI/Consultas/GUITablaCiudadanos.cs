using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.GUI.Consultas
{
    public partial class GUITablaCiudadanos : Form
    {
        public GUITablaCiudadanos()
        {
            InitializeComponent();
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvCiudadano.Rows.Insert(0, "1", "Rafael", "Fernandez", "AV. Melgar", "56465");
        }
    }
}
