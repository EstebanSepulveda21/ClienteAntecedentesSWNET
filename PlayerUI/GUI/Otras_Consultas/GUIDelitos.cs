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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
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
                dgvCiudadano.Rows.Insert(i, ""+ delito.codigo, delito.nombre.Trim(), ""+delito.penaMinima, ""+delito.penaMaxima);
            }
        }

        private void dgvCiudadano_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (padre != null)
            {
                if (e.ColumnIndex == 0)
                    padre.CambiarTxtDelito(Int32.Parse((string)dgvCiudadano.CurrentRow.Cells[0].Value));
                this.Hide();
            }
        }

        private void dgvCiudadano_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (padre != null)
            {
                padre.CambiarTxtDelito(Int32.Parse((string)dgvCiudadano.CurrentRow.Cells[0].Value));
                this.Hide();
            }
        }

        private void GUIDelitos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
