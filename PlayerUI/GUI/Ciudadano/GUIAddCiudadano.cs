﻿using PlayerUI.Controller;
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

namespace PlayerUI.GUI
{
    public partial class GUIAddCiudadano : Form
    {
        private ControllerAntecedentesPenales controller;
        public GUIAddCiudadano()
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
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Btn Añadir
            try
            {
                String cedula = txtDi.Text;
                int tipoDoc = comboBox1.SelectedIndex + 1;
                String nombre = txtNombre.Text;
                String apellido = txtApellido.Text;
                DateTime fecha = dateTimePicker1.Value;
                bool genero = radioButton1.Checked;

                if (controller.agregarCiudadano(cedula, tipoDoc, nombre, apellido, fecha, genero))
                {
                    MessageBox.Show("El ciudadano fue agregado exitosamente!");
                    limpiar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo realizar esta acción");
            }
        }

        #region validaciones
        private void txtDi_Validated(object sender, EventArgs e)
        {
            if(txtDi.Text.Trim() == "")
            {
                errorProv.SetError(txtDi, "Introduce el documento de identidad");
                txtDi.Focus();
            }
            else
            {
                errorProv.Clear();
            }
        }

        private void comboBox1_Validated(object sender, EventArgs e)
        {
           
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim() == "")
            {
                errorProv.SetError(txtNombre, "Introduce el nombre del ciudadadano");
                txtNombre.Focus();
            }
            else
            {
                errorProv.Clear();
            }
        }

        private void txtApellido_Validated(object sender, EventArgs e)
        {
            if(txtApellido.Text.Trim() == "")
            {
                errorProv.SetError(txtApellido, "Introduce el apellido del ciudadano");
                txtApellido.Focus();
            }
            else
            {
                errorProv.Clear();
            }
        }

        private void limpiar()
        {
            txtDi.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
        }
        #endregion
    }
}
