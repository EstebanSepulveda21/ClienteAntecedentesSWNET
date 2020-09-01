﻿using PlayerUI.Controller;
using PlayerUI.GUI.Consultas;
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

namespace PlayerUI.GUI.Otras_Consultas
{
    public partial class GUICalcularSentencia : Form, IBuscarCiudadano
    {
        private ControllerAntecedentesPenales controller;
        public GUICalcularSentencia()
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

        private void button2_Click(object sender, EventArgs e)
        {
            GUITablaCiudadanos gui = new GUITablaCiudadanos(this);
            gui.ShowDialog();
        }

        public void CambiarTxtCiudadano(string ciudadanoDI)
        {
            textBox3.Text = ciudadanoDI;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int sentenciasTotales = controller.darSentenciaTotalPorCiudadano(textBox3.Text);
            ciudadano ciudadano = controller.darCiudadanoPorCedula(textBox3.Text);
            MessageBox.Show(" El total de las sentencias del ciudadano: " + ciudadano.nombre.Trim() + " " + ciudadano.apellido.Trim() + " es de: \n" + sentenciasTotales + " años ");
        }

        private void GUICalcularSentencia_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
