using PlayerUI.GUI;
using PlayerUI.GUI.Antecedentes;
using PlayerUI.GUI.Ciudadano;
using PlayerUI.GUI.Consultas;
using PlayerUI.GUI.Otras_Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class GUIMenuPrincipal : Form
    {
        public GUIMenuPrincipal()
        {
            InitializeComponent();
            hideSubMenu();
            timer1.Enabled = true;
        }

        #region Control_paneles
        private void hideSubMenu()
        {
            panelSubMenuCiudadano.Visible = false;
            panelSubMenuAntecedente.Visible = false;
            panelSubMenuConsultas.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region Principales
        private void btnMedia_Click(object sender, EventArgs e)
        {
            //Boton Ciudadano
            showSubMenu(panelSubMenuCiudadano);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            //Boton Antecedente
            showSubMenu(panelSubMenuAntecedente);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            //Boton Consultas
            showSubMenu(panelSubMenuConsultas);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Boton ayuda/help
            GUIHelp gui = new GUIHelp();
            gui.Show();
            hideSubMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Boton salida/exit
            Application.Exit();
        }
        #endregion

        #region ciudadanos
        private void button2_Click(object sender, EventArgs e)
        {
            //Boton añadir ciudadanos

            GUIAddCiudadano gui = new GUIAddCiudadano();
            gui.Show();

            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Boton eliminar ciudadano
            GUIDeleteCiudadano gui = new GUIDeleteCiudadano();
            gui.Show();
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Boton actualizar ciudadano
            GUIUpdateCiudadano gui = new GUIUpdateCiudadano();
            gui.Show();
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Boton buscar ciudadano
            GUISearchCiudadano gui = new GUISearchCiudadano();
            gui.Show();
            hideSubMenu();
        }
        #endregion

        #region Antecedente
        private void button8_Click(object sender, EventArgs e)
        {
            //Boton añadir antecedente
            GUIAddAntecedente gui = new GUIAddAntecedente();
            gui.Show();
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Boton eliminar antecedente
            GUIDeleteAntecedentes gui = new GUIDeleteAntecedentes();
            gui.Show();
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Boton actualizar antecedente
            GUIUpdateAntecedentes gui = new GUIUpdateAntecedentes();
            gui.Show();
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton buscar antecedente
            GUISearchAntecedente gui = new GUISearchAntecedente();
            gui.Show();
            hideSubMenu();
        }
        #endregion
       
        #region Consulta
        private void button13_Click(object sender, EventArgs e)
        {
            //Boton tabla ciudadano
            GUITablaCiudadanos gui = new GUITablaCiudadanos();
            gui.Show();
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Boton tabla antecedente
            GUITablaAntecedentes gui = new GUITablaAntecedentes();
            gui.Show();
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Boton grafica
            GUIGrafica gui = new GUIGrafica();
            gui.Show();
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void btnSentencias_Click(object sender, EventArgs e)
        {
            GUICalcularSentencia gui = new GUICalcularSentencia();
            gui.Show();
        }
    }
}
