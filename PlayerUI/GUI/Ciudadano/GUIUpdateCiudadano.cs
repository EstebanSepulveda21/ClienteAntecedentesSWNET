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

namespace PlayerUI.GUI
{
    public partial class GUIUpdateCiudadano : Form
    {
        private ControllerAntecedentesPenales controller;

        public GUIUpdateCiudadano()
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
                    txtName.Text = ciudadano.nombre.Trim();
                    txtAp.Text = ciudadano.apellido.Trim();
                    if (ciudadano.genero)
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = false;
                    comboBox1.SelectedIndex = ciudadano.tipoDocumento - 1;
                    dateTimePicker1.Value = ciudadano.fechaNacimiento;

                    txtName.Enabled = true;
                    txtAp.Enabled = true;
                    dateTimePicker1.Enabled = true;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String cedula = textBox1.Text;
                String nombre = txtName.Text;
                String apellido = txtAp.Text;
                int tipoDoc = comboBox1.SelectedIndex+1;
                DateTime date = dateTimePicker1.Value;
                bool genero = radioButton1.Checked;

                if (controller.actualizarCiudadano(cedula, tipoDoc, nombre, apellido, date, genero))
                {
                    MessageBox.Show("El ciudadano con el DI " + cedula + " fue actualizado!");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text.Trim() == "")
            {
                errorProv.SetError(txtName, "Ingrese el nombre nuevo o cambielo");
                txtName.Focus();
            }
            else
            {
                errorProv.Clear();
            }
        }
    }
}
