using PlayerUI.Controller;
using PlayerUI.ServicioAntecedentesPenalesSWJavita;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.GUI.Consultas
{
    public partial class GUITablaAntecedentes : Form
    {
        private ControllerAntecedentesPenales controller;
        public GUITablaAntecedentes()
        {
            InitializeComponent();
            controller = ControllerAntecedentesPenales.getInstance();
            timer1.Enabled = true;
        }

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
            List<antecedente> antecedentes = controller.darAntecedentes();
            dgvCiudadano.DataSource=null;
            for (int i = 0; i < antecedentes.Count; i++)
            {
                antecedente antecedente = antecedentes.ElementAt(i);
                dgvCiudadano.Rows.Insert(i, antecedente.id, antecedente.ciudadanoDi, antecedente.delitoCodigo, antecedente.fechaDelito, antecedente.sentencia, antecedente.estado);
            }
        }

        private void dgvCiudadano_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
