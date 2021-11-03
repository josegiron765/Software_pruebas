
namespace Software_prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.Boton_Afiliaciones = new System.Windows.Forms.Button();
            this.Boton_Reportes = new System.Windows.Forms.Button();
            this.Boton_Historias_clinicas = new System.Windows.Forms.Button();
            this.Boton_Pacientes = new System.Windows.Forms.Button();
            this.Panel_Logo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelDeskopt = new System.Windows.Forms.Panel();
            this.Panel_Menu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.Panel_Menu.Controls.Add(this.Boton_Salir);
            this.Panel_Menu.Controls.Add(this.Boton_Afiliaciones);
            this.Panel_Menu.Controls.Add(this.Boton_Reportes);
            this.Panel_Menu.Controls.Add(this.Boton_Historias_clinicas);
            this.Panel_Menu.Controls.Add(this.Boton_Pacientes);
            this.Panel_Menu.Controls.Add(this.Panel_Logo);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(216, 559);
            this.Panel_Menu.TabIndex = 0;
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.Dock = System.Windows.Forms.DockStyle.Top;
            this.Boton_Salir.FlatAppearance.BorderSize = 0;
            this.Boton_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Salir.ForeColor = System.Drawing.Color.White;
            this.Boton_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Salir.Image")));
            this.Boton_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Salir.Location = new System.Drawing.Point(0, 312);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Boton_Salir.Size = new System.Drawing.Size(216, 59);
            this.Boton_Salir.TabIndex = 6;
            this.Boton_Salir.Text = "      Configuracion";
            this.Boton_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Boton_Salir.UseVisualStyleBackColor = true;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // Boton_Afiliaciones
            // 
            this.Boton_Afiliaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.Boton_Afiliaciones.FlatAppearance.BorderSize = 0;
            this.Boton_Afiliaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Afiliaciones.ForeColor = System.Drawing.Color.White;
            this.Boton_Afiliaciones.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Afiliaciones.Image")));
            this.Boton_Afiliaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Afiliaciones.Location = new System.Drawing.Point(0, 253);
            this.Boton_Afiliaciones.Name = "Boton_Afiliaciones";
            this.Boton_Afiliaciones.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Boton_Afiliaciones.Size = new System.Drawing.Size(216, 59);
            this.Boton_Afiliaciones.TabIndex = 5;
            this.Boton_Afiliaciones.Text = "      Afiliacion";
            this.Boton_Afiliaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Afiliaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Boton_Afiliaciones.UseVisualStyleBackColor = true;
            this.Boton_Afiliaciones.Click += new System.EventHandler(this.Boton_Afiliaciones_Click);
            // 
            // Boton_Reportes
            // 
            this.Boton_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Boton_Reportes.FlatAppearance.BorderSize = 0;
            this.Boton_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Reportes.ForeColor = System.Drawing.Color.White;
            this.Boton_Reportes.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Reportes.Image")));
            this.Boton_Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Reportes.Location = new System.Drawing.Point(0, 194);
            this.Boton_Reportes.Name = "Boton_Reportes";
            this.Boton_Reportes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Boton_Reportes.Size = new System.Drawing.Size(216, 59);
            this.Boton_Reportes.TabIndex = 4;
            this.Boton_Reportes.Text = "      Reportes";
            this.Boton_Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Boton_Reportes.UseVisualStyleBackColor = true;
            this.Boton_Reportes.Click += new System.EventHandler(this.Boton_Reportes_Click);
            // 
            // Boton_Historias_clinicas
            // 
            this.Boton_Historias_clinicas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Boton_Historias_clinicas.FlatAppearance.BorderSize = 0;
            this.Boton_Historias_clinicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Historias_clinicas.ForeColor = System.Drawing.Color.White;
            this.Boton_Historias_clinicas.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Historias_clinicas.Image")));
            this.Boton_Historias_clinicas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Historias_clinicas.Location = new System.Drawing.Point(0, 135);
            this.Boton_Historias_clinicas.Name = "Boton_Historias_clinicas";
            this.Boton_Historias_clinicas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Boton_Historias_clinicas.Size = new System.Drawing.Size(216, 59);
            this.Boton_Historias_clinicas.TabIndex = 3;
            this.Boton_Historias_clinicas.Text = "      Historia clinica";
            this.Boton_Historias_clinicas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Historias_clinicas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Boton_Historias_clinicas.UseVisualStyleBackColor = true;
            this.Boton_Historias_clinicas.Click += new System.EventHandler(this.Boton_Historias_clinicas_Click);
            // 
            // Boton_Pacientes
            // 
            this.Boton_Pacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Boton_Pacientes.FlatAppearance.BorderSize = 0;
            this.Boton_Pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Pacientes.ForeColor = System.Drawing.Color.White;
            this.Boton_Pacientes.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Pacientes.Image")));
            this.Boton_Pacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Pacientes.Location = new System.Drawing.Point(0, 76);
            this.Boton_Pacientes.Name = "Boton_Pacientes";
            this.Boton_Pacientes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Boton_Pacientes.Size = new System.Drawing.Size(216, 59);
            this.Boton_Pacientes.TabIndex = 2;
            this.Boton_Pacientes.Text = "      Paciente";
            this.Boton_Pacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Pacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Boton_Pacientes.UseVisualStyleBackColor = true;
            this.Boton_Pacientes.Click += new System.EventHandler(this.Boton_Pacientes_Click);
            // 
            // Panel_Logo
            // 
            this.Panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Panel_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Logo.BackgroundImage")));
            this.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Logo.Name = "Panel_Logo";
            this.Panel_Logo.Size = new System.Drawing.Size(216, 76);
            this.Panel_Logo.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(216, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(994, 76);
            this.panelTitleBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(444, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOME";
            // 
            // PanelDeskopt
            // 
            this.PanelDeskopt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.PanelDeskopt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDeskopt.Location = new System.Drawing.Point(216, 76);
            this.PanelDeskopt.MinimumSize = new System.Drawing.Size(500, 400);
            this.PanelDeskopt.Name = "PanelDeskopt";
            this.PanelDeskopt.Size = new System.Drawing.Size(994, 483);
            this.PanelDeskopt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 559);
            this.Controls.Add(this.PanelDeskopt);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.Panel_Menu);
            this.Name = "Form1";
            this.Text = "Home ";
            this.Panel_Menu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.Button Boton_Afiliaciones;
        private System.Windows.Forms.Button Boton_Reportes;
        private System.Windows.Forms.Button Boton_Historias_clinicas;
        private System.Windows.Forms.Button Boton_Pacientes;
        private System.Windows.Forms.Panel Panel_Logo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelDeskopt;
    }
}

