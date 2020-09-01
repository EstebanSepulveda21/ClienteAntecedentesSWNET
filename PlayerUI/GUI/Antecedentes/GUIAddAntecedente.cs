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
using PlayerUI.GUI.Consultas;
using PlayerUI.GUI.Otras_Consultas;

namespace PlayerUI.GUI.Antecedentes
{
    public partial class GUIAddAntecedente : Form, IBuscarCiudadano, IBuscarDelito
    {
        private ControllerAntecedentesPenales controller;

        public GUIAddAntecedente()
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
                if(ciudadano != null)
                {
                    MessageBox.Show("El ciudadano con el DI: " + ciudadano.cedula + " con el nombre: " + ciudadano.nombre.Trim() + "" + ciudadano.apellido.Trim() + "Ha sido seleccionado");
                    txtCiudad.Enabled = true;
                    txtCod.Enabled = true;
                    txtEstado.Enabled = true;
                    txtSentencia.Enabled = true;
                    dateTimePicker1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El ciudadano con el DI: " + cedula + " No existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btn Añadir antecedente
            try
            {
                String ciudadanoDI = textBox1.Text;
                int delitoCod = Int32.Parse(txtCod.Text);
                String ciudad = txtCiudad.Text;
                DateTime date = dateTimePicker1.Value;
                int sentencia = Int32.Parse(txtSentencia.Text);
                String estado = txtEstado.Text;
                if (controller.agregarAntecedente(ciudadanoDI, delitoCod, ciudad, date, sentencia, estado))
                {
                    MessageBox.Show("El ciudadano con el DI: " + ciudadanoDI + " se le añadió correctamente el antecedente");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("El ciudadano con el DI: " + ciudadanoDI + " no se le añadió el antecedente");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            GUITablaCiudadanos gui = new GUITablaCiudadanos(this);
            gui.ShowDialog();
        }

        public void CambiarTxtDelito(int codigoDelito)
        {
            txtCod.Text = "" + codigoDelito;
        }

        public void CambiarTxtCiudadano(string ciudadanoDI)
        {
            textBox1.Text = ciudadanoDI;
        }

        private void limpiar()
        {
            txtCiudad.Text = "";
            txtCod.Text = "";
            txtEstado.Text = "";
            txtSentencia.Text = "";
            textBox1.Text = "";
        }
    }
}
