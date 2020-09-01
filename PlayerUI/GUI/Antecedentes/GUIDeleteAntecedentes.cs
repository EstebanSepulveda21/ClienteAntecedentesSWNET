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
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
