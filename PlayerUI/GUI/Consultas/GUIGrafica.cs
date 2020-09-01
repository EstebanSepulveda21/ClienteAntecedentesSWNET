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

namespace PlayerUI.GUI.Consultas
{
    public partial class GUIGrafica : Form
    {
        private ControllerAntecedentesPenales controller;
        public GUIGrafica()
        {
            InitializeComponent();
            controller = ControllerAntecedentesPenales.getInstance();
            hacerGrafica();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hacerGrafica()
        {
            chart1.Titles.Add("Frecuencia de delitos");
            chart1.Series["s1"].IsValueShownAsLabel = true;
            foreach (delito delito in controller.darDelitos())
            {
                double numDelitos = controller.darAntecedentesPorDelito(delito.codigo).Count;
                if (numDelitos > 0)
                {
                    chart1.Series["s1"].Points.AddXY(delito.nombre, ""+numDelitos);
                }
            }
        }
    }
}
