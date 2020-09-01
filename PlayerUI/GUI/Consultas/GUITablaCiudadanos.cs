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
    public partial class GUITablaCiudadanos : Form
    {
        private ControllerAntecedentesPenales controller;
        private IBuscarCiudadano padre;
        public GUITablaCiudadanos()
        {
            InitializeComponent();
            controller = ControllerAntecedentesPenales.getInstance();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public GUITablaCiudadanos(IBuscarCiudadano pPadre)
        {
            InitializeComponent();
            controller = ControllerAntecedentesPenales.getInstance();
            padre = pPadre;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            List<ciudadano> ciudadanos = controller.darCiudadanos();
            dgvCiudadano.Rows.Clear();
            for(int i = 0; i < ciudadanos.Count ;i++){
                ciudadano ciudadano = ciudadanos.ElementAt(i);
                dgvCiudadano.Rows.Insert(i, ciudadano.cedula, controller.darTipoDocumentoPorCodigo(ciudadano.tipoDocumento).siglas, ciudadano.nombre, ciudadano.apellido, ciudadano.fechaNacimiento);
            }
        }

        private void dgvCiudadano_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(padre!=null)
            {
                if (e.ColumnIndex == 0)
                    padre.CambiarTxtCiudadano((string)dgvCiudadano.CurrentRow.Cells[0].Value);
                this.Hide();
            }
        }

        private void GUITablaCiudadanos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
