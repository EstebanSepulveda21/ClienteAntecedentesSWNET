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
using PlayerUI.ServicioAntecedentesPenalesSWJavita;
using PlayerUI.GUI.Otras_Consultas;
using PlayerUI.GUI.Consultas;
using System.Runtime.InteropServices;

namespace PlayerUI.GUI.Antecedentes
{
    public partial class GUIDeleteAntecedentes : Form, IBuscarDelito, IBuscarCiudadano
    {
        private ControllerAntecedentesPenales controller;

        public GUIDeleteAntecedentes()
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
                String ciudadanoDi = textBox1.Text;
                int codigoDelito = Int32.Parse(textBox2.Text);
                List<antecedente> antecedentes = controller.darAntecedentesPorCiudadanoYDelito(ciudadanoDi, codigoDelito);
                if (antecedentes.Count>0)
                {
                    String codigoId = "" + antecedentes.ElementAt(0).id;
                    txtIDAntecedente.Text=codigoId;
                    txtNombre.Text = "" + antecedentes.ElementAt(0).sentencia;
                    txtApellido.Text = "" + antecedentes.ElementAt(0).estado;
                }
                else
                {
                    MessageBox.Show("No hay resultados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //btn eliminar
            try
            {
                String cedula = textBox1.Text;
                ServicioAntecedentesPenalesSWJavita.ciudadano ciudadano = controller.darCiudadanoPorCedula(cedula);
                int id = Int32.Parse(txtIDAntecedente.Text);
                if (controller.eliminarAntecedente(id))
                {
                    MessageBox.Show("El antecedente del ciudadano identificado con DI: " + ciudadano.cedula + " ha sido eliminado");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se eliminó correctamente el antecedente");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!  " + ex);
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Digite el codigo");
                textBox1.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Digite el ID");
                textBox2.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUIDelitos gui = new GUIDelitos(this);
            gui.ShowDialog();
        }

        public void CambiarTxtCiudadano(string ciudadanoDI)
        {
            textBox1.Text = ciudadanoDI;
        }

        public void CambiarTxtDelito(int codigoDelito)
        {
            textBox2.Text = "" + codigoDelito;
        }

        private void limpiar()
        {
            txtApellido.Text = "";
            txtIDAntecedente.Text = "";
            txtNombre.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            GUITablaCiudadanos gui = new GUITablaCiudadanos(this);
            gui.ShowDialog();
        }

        private void GUIDeleteAntecedentes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
