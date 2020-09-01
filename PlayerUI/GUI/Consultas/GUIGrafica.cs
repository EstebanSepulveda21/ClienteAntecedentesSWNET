using PlayerUI.Controller;
using PlayerUI.ServicioAntecedentesPenalesSWJavita;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
