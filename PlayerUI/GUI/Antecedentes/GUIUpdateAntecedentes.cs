using PlayerUI.ServicioAntecedentesPenalesSWJavita;
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
    public partial class GUIUpdateAntecedentes : Form
    {
        private ControllerAntecedentesPenales controller;

        public GUIUpdateAntecedentes()
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
                String ciudadanoDi = txtNi.Text;
                int codigoDelito = Int32.Parse(txtDelito.Text);
                List<antecedente> antecedentes = controller.darAntecedentesPorCiudadanoYDelito(ciudadanoDi, codigoDelito);
                if (antecedentes.Count > 0)
                {
                    String codigoId = "" + antecedentes.ElementAt(0).id;
                    txtDi.Text = codigoId;
                    txtCiudad.Text = "" + antecedentes.ElementAt(0).ciudad;
                    txtSentencia.Text = "" + antecedentes.ElementAt(0).sentencia;
                    txtEstado.Text = "" + antecedentes.ElementAt(0).estado;
                    dateTimePicker1.Value = antecedentes.ElementAt(0).fechaDelito;
                    
                    txtDi.Enabled = true;
                    txtCiudad.Enabled = true;
                    txtEstado.Enabled = true;
                    txtSentencia.Enabled = true;
                    dateTimePicker1.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtDi.Text);
                String ciudadanoDI = txtNi.Text;
                int delitoCod = Int32.Parse(txtDelito.Text);
                String ciudad = txtCiudad.Text;
                DateTime date = dateTimePicker1.Value;
                int sentencia = Int32.Parse(txtSentencia.Text);
                String estado = txtEstado.Text;

                if(controller.actualizarAntecedente(id, ciudadanoDI, delitoCod, ciudad, date, sentencia, estado))
                { 
                   MessageBox.Show("El antecedente ha sido actualizado correctamente!"); 
                }
                else 
                {
                   MessageBox.Show("No se actualizó correctamente"); 
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
        }
    }
}
