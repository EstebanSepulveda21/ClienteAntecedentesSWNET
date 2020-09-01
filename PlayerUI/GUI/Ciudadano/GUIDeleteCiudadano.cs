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
using System.Runtime.InteropServices;

namespace PlayerUI.GUI
{
    public partial class GUIDeleteCiudadano : Form
    {
        private ControllerAntecedentesPenales controller;

        public GUIDeleteCiudadano()
        {
            InitializeComponent();
            controller = ControllerAntecedentesPenales.getInstance();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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
            }catch(Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String cedula = textBox1.Text;
                if (controller.eliminarCiudadano(cedula))
                {
                    MessageBox.Show("Ciudadano eliminado correctamente!");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al eliminar al ciudadano");
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
                errorProv.SetError(textBox1, "Por favor ingrese el DI ");
                textBox1.Focus();
            }
            else
            {
                errorProv.Clear();
            }
        }

        private void limpiar()
        {
            textBox1.Text = "";
            txtName.Text = "";
            txtAp.Text = "";
        }

        private void GUIDeleteCiudadano_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
