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

namespace PlayerUI.GUI.Ciudadano
{
    public partial class GUISearchCiudadano : Form
    {
        private ControllerAntecedentesPenales controller;

        public GUISearchCiudadano()
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
                if (ciudadano != null)
                {
                    txtName.Text = ciudadano.nombre;
                    txtAp.Text = ciudadano.apellido;
                    txtNi.Text = ciudadano.cedula;
                    comboBox2.SelectedIndex = ciudadano.tipoDocumento;
                    if (ciudadano.genero)
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = false;
                    comboBox1.SelectedIndex = ciudadano.tipoDocumento - 1;
                    dateTimePicker1.Value = ciudadano.fechaNacimiento;
                }
                else
                {
                    MessageBox.Show("El ciudadano con el DI " + cedula + " no existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "")
            {
                errorProv.SetError(textBox1, "Por favor ingrese el ID");
                textBox1.Focus();
            }
            else
            {
                errorProv.Clear();
            }
        }
    }
}
