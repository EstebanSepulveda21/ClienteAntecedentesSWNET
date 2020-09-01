using System;
using PlayerUI.Controller;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.GUI.Antecedentes
{
    public partial class GUIDeleteAntecedentes : Form
    {
        private ControllerAntecedentesPenales controller;

        public GUIDeleteAntecedentes()
        {
            InitializeComponent();
            controller = ControllerAntecedentesPenales.getInstance();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //btn buscar
            try
            {
                String cedula = textBox1.Text;
                ServicioAntecedentesPenalesSWJavita.ciudadano ciudadano = controller.darCiudadanoPorCedula(cedula);
                ServicioAntecedentesPenalesSWJavita.antecedente antecedente = controller.darAntecedentePorId();
                if (ciudadano != null)
                {
                    MessageBox.Show("El ciudadano con el DI: " + ciudadano.cedula + " con el nombre: " + ciudadano.nombre.Trim() + "" + ciudadano.apellido.Trim() + "Ha sido seleccionado");

                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
