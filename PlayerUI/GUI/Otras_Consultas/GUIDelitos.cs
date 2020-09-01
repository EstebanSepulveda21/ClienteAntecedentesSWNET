using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.GUI.Otras_Consultas
{
    public partial class GUIDelitos : Form
    {
        IBuscarDelito padre;
        public GUIDelitos()
        {
            InitializeComponent();
            padre = null;
        }

        GUIDelitos(IBuscarDelito pPadre)
        {
            InitializeComponent();
            padre = pPadre;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
