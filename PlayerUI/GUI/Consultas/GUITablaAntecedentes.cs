using PlayerUI.Controller;
using PlayerUI.GUI.Otras_Consultas;
using PlayerUI.ServicioAntecedentesPenalesSWJavita;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.GUI.Consultas
{
    public partial class GUITablaAntecedentes : Form, IBuscarCiudadano, IBuscarDelito
    {
        private ControllerAntecedentesPenales controller;
        public GUITablaAntecedentes()
        {
            InitializeComponent();
            controller = ControllerAntecedentesPenales.getInstance();
            timer1.Enabled = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<antecedente> antecedentes = new List<antecedente>();
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                {
                    antecedentes = controller.darAntecedentesPorCiudadanoYDelito(textBox1.Text, Int32.Parse(textBox2.Text));
                }
                else
                {
                    antecedentes = controller.darAntecedentesPorCiudadano(textBox1.Text);
                }
            }
            else if (checkBox2.Checked)
            {
                antecedentes = controller.darAntecedentesPorDelito(Int32.Parse(textBox2.Text));
            }
            else
            {
                antecedentes = controller.darAntecedentes();
            }
            llenarGrilla(antecedentes);
        }

        public void llenarGrilla(List<antecedente> lista)
        {
            List<antecedente> antecedentes = lista;
            dgvCiudadano.Rows.Clear();
            for (int i = 0; i < antecedentes.Count; i++)
            {
                antecedente antecedente = antecedentes.ElementAt(i);
                dgvCiudadano.Rows.Insert(i, antecedente.id, antecedente.ciudadanoDi, antecedente.delitoCodigo, antecedente.fechaDelito, antecedente.sentencia, antecedente.estado);
            }
        }

        private void dgvCiudadano_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUITablaCiudadanos gui = new GUITablaCiudadanos(this);
            gui.ShowDialog();
        }

        public void CambiarTxtCiudadano(string ciudadanoDI)
        {
            textBox1.Text = ciudadanoDI;
        }

        public void CambiarTxtDelito(int codigoDelito)
        {
            textBox2.Text = ""+codigoDelito;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUIDelitos gui = new GUIDelitos(this);
            gui.ShowDialog();
        }

        private void GUITablaAntecedentes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
