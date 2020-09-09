namespace PlayerUI
{
    partial class GUIMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIMenuPrincipal));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelSubMenuConsultas = new System.Windows.Forms.Panel();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnTablaAntecedente = new System.Windows.Forms.Button();
            this.btnTablaCiudadano = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panelSubMenuAntecedente = new System.Windows.Forms.Panel();
            this.btnSentencias = new System.Windows.Forms.Button();
            this.btnSearchAntecedente = new System.Windows.Forms.Button();
            this.btnUpdateAntecedente = new System.Windows.Forms.Button();
            this.btnDeleteAntecedente = new System.Windows.Forms.Button();
            this.btnAddAntecedente = new System.Windows.Forms.Button();
            this.btnAntecedente = new System.Windows.Forms.Button();
            this.panelSubMenuCiudadano = new System.Windows.Forms.Panel();
            this.btnSearchCiudadano = new System.Windows.Forms.Button();
            this.btnUpdateCiudadano = new System.Windows.Forms.Button();
            this.btnDeleteCiudadano = new System.Windows.Forms.Button();
            this.btnAddCiudadano = new System.Windows.Forms.Button();
            this.btnCiudadano = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenuConsultas.SuspendLayout();
            this.panelSubMenuAntecedente.SuspendLayout();
            this.panelSubMenuCiudadano.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.label1);
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.panelSubMenuConsultas);
            this.panelSideMenu.Controls.Add(this.btnConsulta);
            this.panelSideMenu.Controls.Add(this.panelSubMenuAntecedente);
            this.panelSideMenu.Controls.Add(this.btnAntecedente);
            this.panelSideMenu.Controls.Add(this.panelSubMenuCiudadano);
            this.panelSideMenu.Controls.Add(this.btnCiudadano);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 749);
            this.panelSideMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 771);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Label1";
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 788);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(233, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Silver;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 726);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(233, 45);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "  Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelSubMenuConsultas
            // 
            this.panelSubMenuConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuConsultas.Controls.Add(this.btnGrafica);
            this.panelSubMenuConsultas.Controls.Add(this.btnTablaAntecedente);
            this.panelSubMenuConsultas.Controls.Add(this.btnTablaCiudadano);
            this.panelSubMenuConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuConsultas.Location = new System.Drawing.Point(0, 596);
            this.panelSubMenuConsultas.Name = "panelSubMenuConsultas";
            this.panelSubMenuConsultas.Size = new System.Drawing.Size(233, 130);
            this.panelSubMenuConsultas.TabIndex = 7;
            // 
            // btnGrafica
            // 
            this.btnGrafica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrafica.FlatAppearance.BorderSize = 0;
            this.btnGrafica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnGrafica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnGrafica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafica.ForeColor = System.Drawing.Color.Silver;
            this.btnGrafica.Location = new System.Drawing.Point(0, 80);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGrafica.Size = new System.Drawing.Size(233, 40);
            this.btnGrafica.TabIndex = 2;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnTablaAntecedente
            // 
            this.btnTablaAntecedente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTablaAntecedente.FlatAppearance.BorderSize = 0;
            this.btnTablaAntecedente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnTablaAntecedente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnTablaAntecedente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablaAntecedente.ForeColor = System.Drawing.Color.Silver;
            this.btnTablaAntecedente.Location = new System.Drawing.Point(0, 40);
            this.btnTablaAntecedente.Name = "btnTablaAntecedente";
            this.btnTablaAntecedente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTablaAntecedente.Size = new System.Drawing.Size(233, 40);
            this.btnTablaAntecedente.TabIndex = 1;
            this.btnTablaAntecedente.Text = "Tabla antecedentes";
            this.btnTablaAntecedente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTablaAntecedente.UseVisualStyleBackColor = true;
            this.btnTablaAntecedente.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnTablaCiudadano
            // 
            this.btnTablaCiudadano.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTablaCiudadano.FlatAppearance.BorderSize = 0;
            this.btnTablaCiudadano.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnTablaCiudadano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnTablaCiudadano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablaCiudadano.ForeColor = System.Drawing.Color.Silver;
            this.btnTablaCiudadano.Location = new System.Drawing.Point(0, 0);
            this.btnTablaCiudadano.Name = "btnTablaCiudadano";
            this.btnTablaCiudadano.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTablaCiudadano.Size = new System.Drawing.Size(233, 40);
            this.btnTablaCiudadano.TabIndex = 0;
            this.btnTablaCiudadano.Text = "Tabla ciudadanos";
            this.btnTablaCiudadano.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTablaCiudadano.UseVisualStyleBackColor = true;
            this.btnTablaCiudadano.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.ForeColor = System.Drawing.Color.Silver;
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(0, 551);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConsulta.Size = new System.Drawing.Size(233, 45);
            this.btnConsulta.TabIndex = 6;
            this.btnConsulta.Text = " Consultas";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // panelSubMenuAntecedente
            // 
            this.panelSubMenuAntecedente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuAntecedente.Controls.Add(this.btnSentencias);
            this.panelSubMenuAntecedente.Controls.Add(this.btnSearchAntecedente);
            this.panelSubMenuAntecedente.Controls.Add(this.btnUpdateAntecedente);
            this.panelSubMenuAntecedente.Controls.Add(this.btnDeleteAntecedente);
            this.panelSubMenuAntecedente.Controls.Add(this.btnAddAntecedente);
            this.panelSubMenuAntecedente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuAntecedente.Location = new System.Drawing.Point(0, 347);
            this.panelSubMenuAntecedente.Name = "panelSubMenuAntecedente";
            this.panelSubMenuAntecedente.Size = new System.Drawing.Size(233, 204);
            this.panelSubMenuAntecedente.TabIndex = 4;
            // 
            // btnSentencias
            // 
            this.btnSentencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSentencias.FlatAppearance.BorderSize = 0;
            this.btnSentencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSentencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSentencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentencias.ForeColor = System.Drawing.Color.Silver;
            this.btnSentencias.Location = new System.Drawing.Point(0, 160);
            this.btnSentencias.Name = "btnSentencias";
            this.btnSentencias.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSentencias.Size = new System.Drawing.Size(233, 40);
            this.btnSentencias.TabIndex = 4;
            this.btnSentencias.Text = "Calcular sentencias";
            this.btnSentencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSentencias.UseVisualStyleBackColor = true;
            this.btnSentencias.Click += new System.EventHandler(this.btnSentencias_Click);
            // 
            // btnSearchAntecedente
            // 
            this.btnSearchAntecedente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchAntecedente.FlatAppearance.BorderSize = 0;
            this.btnSearchAntecedente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSearchAntecedente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSearchAntecedente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAntecedente.ForeColor = System.Drawing.Color.Silver;
            this.btnSearchAntecedente.Location = new System.Drawing.Point(0, 120);
            this.btnSearchAntecedente.Name = "btnSearchAntecedente";
            this.btnSearchAntecedente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSearchAntecedente.Size = new System.Drawing.Size(233, 40);
            this.btnSearchAntecedente.TabIndex = 3;
            this.btnSearchAntecedente.Text = "Buscar";
            this.btnSearchAntecedente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchAntecedente.UseVisualStyleBackColor = true;
            this.btnSearchAntecedente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdateAntecedente
            // 
            this.btnUpdateAntecedente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateAntecedente.FlatAppearance.BorderSize = 0;
            this.btnUpdateAntecedente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnUpdateAntecedente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnUpdateAntecedente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAntecedente.ForeColor = System.Drawing.Color.Silver;
            this.btnUpdateAntecedente.Location = new System.Drawing.Point(0, 80);
            this.btnUpdateAntecedente.Name = "btnUpdateAntecedente";
            this.btnUpdateAntecedente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUpdateAntecedente.Size = new System.Drawing.Size(233, 40);
            this.btnUpdateAntecedente.TabIndex = 2;
            this.btnUpdateAntecedente.Text = "Actualizar";
            this.btnUpdateAntecedente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAntecedente.UseVisualStyleBackColor = true;
            this.btnUpdateAntecedente.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDeleteAntecedente
            // 
            this.btnDeleteAntecedente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteAntecedente.FlatAppearance.BorderSize = 0;
            this.btnDeleteAntecedente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnDeleteAntecedente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnDeleteAntecedente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAntecedente.ForeColor = System.Drawing.Color.Silver;
            this.btnDeleteAntecedente.Location = new System.Drawing.Point(0, 40);
            this.btnDeleteAntecedente.Name = "btnDeleteAntecedente";
            this.btnDeleteAntecedente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDeleteAntecedente.Size = new System.Drawing.Size(233, 40);
            this.btnDeleteAntecedente.TabIndex = 1;
            this.btnDeleteAntecedente.Text = "Eliminar";
            this.btnDeleteAntecedente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAntecedente.UseVisualStyleBackColor = true;
            this.btnDeleteAntecedente.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnAddAntecedente
            // 
            this.btnAddAntecedente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAntecedente.FlatAppearance.BorderSize = 0;
            this.btnAddAntecedente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAddAntecedente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAddAntecedente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAntecedente.ForeColor = System.Drawing.Color.Silver;
            this.btnAddAntecedente.Location = new System.Drawing.Point(0, 0);
            this.btnAddAntecedente.Name = "btnAddAntecedente";
            this.btnAddAntecedente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddAntecedente.Size = new System.Drawing.Size(233, 40);
            this.btnAddAntecedente.TabIndex = 0;
            this.btnAddAntecedente.Text = "Añadir";
            this.btnAddAntecedente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAntecedente.UseVisualStyleBackColor = true;
            this.btnAddAntecedente.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnAntecedente
            // 
            this.btnAntecedente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAntecedente.FlatAppearance.BorderSize = 0;
            this.btnAntecedente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnAntecedente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAntecedente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntecedente.ForeColor = System.Drawing.Color.Silver;
            this.btnAntecedente.Image = ((System.Drawing.Image)(resources.GetObject("btnAntecedente.Image")));
            this.btnAntecedente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAntecedente.Location = new System.Drawing.Point(0, 302);
            this.btnAntecedente.Name = "btnAntecedente";
            this.btnAntecedente.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAntecedente.Size = new System.Drawing.Size(233, 45);
            this.btnAntecedente.TabIndex = 3;
            this.btnAntecedente.Text = "Antecedentes";
            this.btnAntecedente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAntecedente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAntecedente.UseVisualStyleBackColor = true;
            this.btnAntecedente.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // panelSubMenuCiudadano
            // 
            this.panelSubMenuCiudadano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuCiudadano.Controls.Add(this.btnSearchCiudadano);
            this.panelSubMenuCiudadano.Controls.Add(this.btnUpdateCiudadano);
            this.panelSubMenuCiudadano.Controls.Add(this.btnDeleteCiudadano);
            this.panelSubMenuCiudadano.Controls.Add(this.btnAddCiudadano);
            this.panelSubMenuCiudadano.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCiudadano.Location = new System.Drawing.Point(0, 137);
            this.panelSubMenuCiudadano.Name = "panelSubMenuCiudadano";
            this.panelSubMenuCiudadano.Size = new System.Drawing.Size(233, 165);
            this.panelSubMenuCiudadano.TabIndex = 2;
            // 
            // btnSearchCiudadano
            // 
            this.btnSearchCiudadano.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchCiudadano.FlatAppearance.BorderSize = 0;
            this.btnSearchCiudadano.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSearchCiudadano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSearchCiudadano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCiudadano.ForeColor = System.Drawing.Color.Silver;
            this.btnSearchCiudadano.Location = new System.Drawing.Point(0, 120);
            this.btnSearchCiudadano.Name = "btnSearchCiudadano";
            this.btnSearchCiudadano.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSearchCiudadano.Size = new System.Drawing.Size(233, 40);
            this.btnSearchCiudadano.TabIndex = 3;
            this.btnSearchCiudadano.Text = "Buscar";
            this.btnSearchCiudadano.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCiudadano.UseVisualStyleBackColor = true;
            this.btnSearchCiudadano.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnUpdateCiudadano
            // 
            this.btnUpdateCiudadano.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateCiudadano.FlatAppearance.BorderSize = 0;
            this.btnUpdateCiudadano.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnUpdateCiudadano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnUpdateCiudadano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCiudadano.ForeColor = System.Drawing.Color.Silver;
            this.btnUpdateCiudadano.Location = new System.Drawing.Point(0, 80);
            this.btnUpdateCiudadano.Name = "btnUpdateCiudadano";
            this.btnUpdateCiudadano.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUpdateCiudadano.Size = new System.Drawing.Size(233, 40);
            this.btnUpdateCiudadano.TabIndex = 2;
            this.btnUpdateCiudadano.Text = "Actualizar";
            this.btnUpdateCiudadano.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCiudadano.UseVisualStyleBackColor = true;
            this.btnUpdateCiudadano.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDeleteCiudadano
            // 
            this.btnDeleteCiudadano.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteCiudadano.FlatAppearance.BorderSize = 0;
            this.btnDeleteCiudadano.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnDeleteCiudadano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnDeleteCiudadano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCiudadano.ForeColor = System.Drawing.Color.Silver;
            this.btnDeleteCiudadano.Location = new System.Drawing.Point(0, 40);
            this.btnDeleteCiudadano.Name = "btnDeleteCiudadano";
            this.btnDeleteCiudadano.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDeleteCiudadano.Size = new System.Drawing.Size(233, 40);
            this.btnDeleteCiudadano.TabIndex = 1;
            this.btnDeleteCiudadano.Text = "Eliminar";
            this.btnDeleteCiudadano.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCiudadano.UseVisualStyleBackColor = true;
            this.btnDeleteCiudadano.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddCiudadano
            // 
            this.btnAddCiudadano.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCiudadano.FlatAppearance.BorderSize = 0;
            this.btnAddCiudadano.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAddCiudadano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAddCiudadano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCiudadano.ForeColor = System.Drawing.Color.Silver;
            this.btnAddCiudadano.Location = new System.Drawing.Point(0, 0);
            this.btnAddCiudadano.Name = "btnAddCiudadano";
            this.btnAddCiudadano.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddCiudadano.Size = new System.Drawing.Size(233, 40);
            this.btnAddCiudadano.TabIndex = 0;
            this.btnAddCiudadano.Text = "Añadir ";
            this.btnAddCiudadano.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCiudadano.UseVisualStyleBackColor = true;
            this.btnAddCiudadano.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCiudadano
            // 
            this.btnCiudadano.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCiudadano.FlatAppearance.BorderSize = 0;
            this.btnCiudadano.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnCiudadano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCiudadano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiudadano.ForeColor = System.Drawing.Color.Silver;
            this.btnCiudadano.Image = ((System.Drawing.Image)(resources.GetObject("btnCiudadano.Image")));
            this.btnCiudadano.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCiudadano.Location = new System.Drawing.Point(0, 92);
            this.btnCiudadano.Name = "btnCiudadano";
            this.btnCiudadano.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCiudadano.Size = new System.Drawing.Size(233, 45);
            this.btnCiudadano.TabIndex = 1;
            this.btnCiudadano.Text = "Ciudadano";
            this.btnCiudadano.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCiudadano.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCiudadano.UseVisualStyleBackColor = true;
            this.btnCiudadano.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 92);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.pictureBox9);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 749);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(155, 144);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(374, 374);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // GUIMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(934, 749);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "GUIMenuPrincipal";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelSubMenuConsultas.ResumeLayout(false);
            this.panelSubMenuAntecedente.ResumeLayout(false);
            this.panelSubMenuCiudadano.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubMenuCiudadano;
        private System.Windows.Forms.Button btnSearchCiudadano;
        private System.Windows.Forms.Button btnUpdateCiudadano;
        private System.Windows.Forms.Button btnDeleteCiudadano;
        private System.Windows.Forms.Button btnAddCiudadano;
        private System.Windows.Forms.Button btnCiudadano;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelSubMenuConsultas;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnTablaAntecedente;
        private System.Windows.Forms.Button btnTablaCiudadano;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Panel panelSubMenuAntecedente;
        private System.Windows.Forms.Button btnSearchAntecedente;
        private System.Windows.Forms.Button btnUpdateAntecedente;
        private System.Windows.Forms.Button btnDeleteAntecedente;
        private System.Windows.Forms.Button btnAddAntecedente;
        private System.Windows.Forms.Button btnAntecedente;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSentencias;
    }
}

