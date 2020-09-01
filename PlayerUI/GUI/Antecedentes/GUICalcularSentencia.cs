using PlayerUI.Controller;
using PlayerUI.GUI.Consultas;
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
    public partial class GUICalcularSentencia : Form, IBuscarCiudadano
    {
        private ControllerAntecedentesPenales controller;
        public GUICalcularSentencia()
        {
            InitializeComponent();
            controller = ControllerAntecedentesPenales.getInstance();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUITablaCiudadanos gui = new GUITablaCiudadanos(this);
            gui.ShowDialog();
        }

        public void CambiarTxtCiudadano(string ciudadanoDI)
        {
            textBox3.Text = ciudadanoDI;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int sentenciaTotal = controller.
            }
            catch(Exception e)
            {

            }
        }
    }
}
