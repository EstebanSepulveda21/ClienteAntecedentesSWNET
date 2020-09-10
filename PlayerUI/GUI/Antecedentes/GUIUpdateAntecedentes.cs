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
using PlayerUI.GUI.Otras_Consultas;
using PlayerUI.GUI.Consultas;
using System.Runtime.InteropServices;

namespace PlayerUI.GUI.Antecedentes
{
    public partial class GUIUpdateAntecedentes : Form, IBuscarDelito, IBuscarCiudadano
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void GUIUpdateAntecedentes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region botones

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //btn buscar
            try
            {
                if (txtNi.Text.Trim() == "" || txtDelito.Text.Trim() == "")
                {
                    if(txtNi.Text.Trim() == "")
                    {
                        MessageBox.Show("El numero de identificación se encuentra vacío, por favor ingresa valores e intentalo de nuevo");
                    }
                    else if(txtDelito.Text.Trim() == "")
                    {
                        MessageBox.Show("El codigo del delito se encuentra vacío, por favor ingresa valores e intentalo de nuevo");
                    }
                    else
                    {
                        MessageBox.Show("Existen valores vacíos, por favor confirme su información e intentelo de nuevo");
                    }
                }
                else
                {
                    String ciudadanoDi = txtNi.Text.Trim();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnEliminar
            try
            {
                int id = Int32.Parse(txtDi.Text);
                String ciudadanoDI = txtNi.Text.Trim();
                int delitoCod = Int32.Parse(txtDelito.Text);
                String ciudad = txtCiudad.Text.Trim();
                DateTime date = dateTimePicker1.Value;
                int sentencia = Int32.Parse(txtSentencia.Text);
                String estado = txtEstado.Text.Trim();

                if(controller.actualizarAntecedente(id, ciudadanoDI, delitoCod, ciudad, date, sentencia, estado))
                { 
                   MessageBox.Show("El antecedente ha sido actualizado correctamente!");
                   limpiar();
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

        private void button2_Click(object sender, EventArgs e)
        {
            GUIDelitos gui = new GUIDelitos(this);
            gui.ShowDialog();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            GUITablaCiudadanos gui = new GUITablaCiudadanos(this);
            gui.ShowDialog();
        }

        #endregion

        #region validaciones
        private void limpiar()
        {
            txtCiudad.Text = "";
            txtSentencia.Text = "";
            txtEstado.Text = "";
            txtSentencia.Text = "";
            txtDelito.Text = "";
            txtDi.Text = "";
            txtNi.Text = "";
        }

        public void CambiarTxtCiudadano(string ciudadanoDI)
        {
            txtNi.Text = ciudadanoDI;
        }

        public void CambiarTxtDelito(int codigoDelito)
        {
            txtDelito.Text = "" + codigoDelito;
        }
        #endregion

    }
}
