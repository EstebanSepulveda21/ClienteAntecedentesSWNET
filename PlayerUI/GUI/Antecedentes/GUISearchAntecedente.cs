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
using PlayerUI.GUI.Otras_Consultas;
using PlayerUI.GUI.Consultas;
using System.Runtime.InteropServices;

namespace PlayerUI.GUI.Antecedentes
{
    public partial class GUISearchAntecedente : Form, IBuscarDelito, IBuscarCiudadano
    {
        private ControllerAntecedentesPenales controller;

        public GUISearchAntecedente()
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
                List<antecedente> antecedentes = new List<antecedente>();
                int caso = -1;
                if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox3.Text))
                {
                    String ciudadanoDi = textBox1.Text;
                    int codigoDelito = Int32.Parse(textBox3.Text);
                    antecedentes = controller.darAntecedentesPorCiudadanoYDelito(ciudadanoDi, codigoDelito);
                    caso = 1;
                }
                else if(!String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox3.Text))
                {
                    antecedentes = controller.darAntecedentesPorCiudadano(textBox1.Text);
                    caso = 2;
                }
                else if(String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox3.Text))
                {
                    antecedentes = controller.darAntecedentesPorDelito(Int32.Parse(textBox3.Text));
                    caso = 3;
                }
                else
                {
                    antecedente anteced = controller.darAntecedentePorId(Int32.Parse(txtDi.Text));
                    antecedentes.Add(anteced);
                    caso = 4;
                }
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
                    switch (caso)
                    {
                        case 1:
                            MessageBox.Show( "El ciudadano no tiene dicho antecedente");
                            break;
                        case 2:
                            MessageBox.Show("El ciudadano no tiene antecedentes");
                            break;
                        case 3:
                            MessageBox.Show("Ningun ciudadano tiene ese antecedente");
                            break;
                        case 4:
                            MessageBox.Show("No hay antecedente con el id especificado");
                            break;
                        default:
                            MessageBox.Show("Ha ocurrido un error en el servidor contacte con el servicio de soporte técnico");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
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
            textBox3.Text = codigoDelito + "";
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            GUITablaCiudadanos gui = new GUITablaCiudadanos(this);
            gui.ShowDialog();
        }

        private void GUISearchAntecedente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
