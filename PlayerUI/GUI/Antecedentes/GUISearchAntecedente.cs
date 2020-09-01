using System;
using PlayerUI.Controller;
using PlayerUI.ServicioAntecedentesPenalesSWJavita;
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
    public partial class GUISearchAntecedente : Form
    {
        private ControllerAntecedentesPenales controller;

        public GUISearchAntecedente()
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
                String ciudadanoDi = textBox1.Text;
                int codigoDelito = Int32.Parse(textBox3.Text);
                List<antecedente> antecedentes = controller.darAntecedentesPorCiudadanoYDelito(ciudadanoDi, codigoDelito);
                if (antecedentes.Count > 0)
                {
                    String codigoId = "" + antecedentes.ElementAt(0).id;
                    txtDi.Text = codigoId;
                    txtSentencia.Text = "" + antecedentes.ElementAt(0).sentencia;
                    txtEstado.Text = "" + antecedentes.ElementAt(0).estado;
                    txtCiudad.Text = "" + antecedentes.ElementAt(0).ciudad;
                    dateTimePicker1.Value = antecedentes.ElementAt(0).fechaDelito;
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

        private void textBox3_Validated(object sender, EventArgs e)
        {
            if(textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Digite los valores");
                textBox3.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox1, "Digite el ID");
                textBox3.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
