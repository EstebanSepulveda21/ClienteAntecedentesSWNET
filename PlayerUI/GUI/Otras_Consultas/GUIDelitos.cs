using PlayerUI.Controller;
using PlayerUI.ServicioAntecedentesPenalesSWJavita;
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
        ControllerAntecedentesPenales controller;
        IBuscarDelito padre;
        public GUIDelitos()
        {
            InitializeComponent();
            controller = ControllerAntecedentesPenales.getInstance();
            padre = null;
            llenarGrilla();
        }

        public GUIDelitos(IBuscarDelito pPadre)
        {
            InitializeComponent();
            controller = ControllerAntecedentesPenales.getInstance();
            padre = pPadre;
            llenarGrilla();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarGrilla()
        {
            List<delito> delitos = controller.darDelitos();
            dgvCiudadano.Rows.Clear();
            for (int i = 0; i < delitos.Count; i++)
            {
                delito delito = delitos.ElementAt(i);
                dgvCiudadano.Rows.Insert(i, delito.codigo, delito.nombre.Trim(), delito.penaMinima, delito.penaMaxima);
            }
        }
    }
}
