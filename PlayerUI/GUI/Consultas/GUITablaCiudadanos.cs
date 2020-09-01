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
    public partial class GUITablaCiudadanos : Form
    {
        private ControllerAntecedentesPenales controller;
        public GUITablaCiudadanos()
        {
            InitializeComponent();
            controller = ControllerAntecedentesPenales.getInstance();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            List<ciudadano> ciudadanos = controller.darCiudadanos();

            for(int i = 0; i < ciudadanos.Count ;i++){
                ciudadano ciudadano = ciudadanos.ElementAt(i);
                dgvCiudadano.Rows.Insert(i, ciudadano.cedula, controller.darTipoDocumentoPorCodigo(ciudadano.tipoDocumento).siglas, ciudadano.nombre, ciudadano.apellido, ciudadano.fechaNacimiento);
            }
        }
    }
}
