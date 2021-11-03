
namespace Software_prueba.Forms
{
    partial class FormPacientes
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label tipo_identificacionLabel;
            System.Windows.Forms.Label identificacionLabel;
            System.Windows.Forms.Label ePSLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.base_proyectoDataSet = new Software_prueba.base_proyectoDataSet();
            this.baseproyectoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new Software_prueba.base_proyectoDataSetTableAdapters.PacientesTableAdapter();
            this.tableAdapterManager = new Software_prueba.base_proyectoDataSetTableAdapters.TableAdapterManager();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoidentificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.tipo_identificacionTextBox = new System.Windows.Forms.TextBox();
            this.identificacionTextBox = new System.Windows.Forms.TextBox();
            this.ePSTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            tipo_identificacionLabel = new System.Windows.Forms.Label();
            identificacionLabel = new System.Windows.Forms.Label();
            ePSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_proyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseproyectoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Nuevo paciente ";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(780, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(504, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.tipoidentificacionDataGridViewTextBoxColumn,
            this.identificacionDataGridViewTextBoxColumn,
            this.ePSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pacientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 227);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // base_proyectoDataSet
            // 
            this.base_proyectoDataSet.DataSetName = "base_proyectoDataSet";
            this.base_proyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baseproyectoDataSetBindingSource
            // 
            this.baseproyectoDataSetBindingSource.DataSource = this.base_proyectoDataSet;
            this.baseproyectoDataSetBindingSource.Position = 0;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.base_proyectoDataSet;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HistoriaTableAdapter = null;
            this.tableAdapterManager.PacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.ReportesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Software_prueba.base_proyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // tipoidentificacionDataGridViewTextBoxColumn
            // 
            this.tipoidentificacionDataGridViewTextBoxColumn.DataPropertyName = "Tipo_identificacion";
            this.tipoidentificacionDataGridViewTextBoxColumn.HeaderText = "Tipo_identificacion";
            this.tipoidentificacionDataGridViewTextBoxColumn.Name = "tipoidentificacionDataGridViewTextBoxColumn";
            // 
            // identificacionDataGridViewTextBoxColumn
            // 
            this.identificacionDataGridViewTextBoxColumn.DataPropertyName = "identificacion";
            this.identificacionDataGridViewTextBoxColumn.HeaderText = "identificacion";
            this.identificacionDataGridViewTextBoxColumn.Name = "identificacionDataGridViewTextBoxColumn";
            // 
            // ePSDataGridViewTextBoxColumn
            // 
            this.ePSDataGridViewTextBoxColumn.DataPropertyName = "EPS";
            this.ePSDataGridViewTextBoxColumn.HeaderText = "EPS";
            this.ePSDataGridViewTextBoxColumn.Name = "ePSDataGridViewTextBoxColumn";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.ForeColor = System.Drawing.Color.White;
            idLabel.Location = new System.Drawing.Point(735, 93);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 14;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(837, 90);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 15;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.ForeColor = System.Drawing.Color.White;
            nombreLabel.Location = new System.Drawing.Point(735, 119);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 16;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(837, 116);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 17;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.ForeColor = System.Drawing.Color.White;
            apellidoLabel.Location = new System.Drawing.Point(735, 145);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 18;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(837, 142);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 19;
            // 
            // tipo_identificacionLabel
            // 
            tipo_identificacionLabel.AutoSize = true;
            tipo_identificacionLabel.ForeColor = System.Drawing.Color.White;
            tipo_identificacionLabel.Location = new System.Drawing.Point(735, 171);
            tipo_identificacionLabel.Name = "tipo_identificacionLabel";
            tipo_identificacionLabel.Size = new System.Drawing.Size(96, 13);
            tipo_identificacionLabel.TabIndex = 20;
            tipo_identificacionLabel.Text = "Tipo identificacion:";
            // 
            // tipo_identificacionTextBox
            // 
            this.tipo_identificacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Tipo_identificacion", true));
            this.tipo_identificacionTextBox.Location = new System.Drawing.Point(837, 168);
            this.tipo_identificacionTextBox.Name = "tipo_identificacionTextBox";
            this.tipo_identificacionTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipo_identificacionTextBox.TabIndex = 21;
            // 
            // identificacionLabel
            // 
            identificacionLabel.AutoSize = true;
            identificacionLabel.ForeColor = System.Drawing.Color.White;
            identificacionLabel.Location = new System.Drawing.Point(735, 197);
            identificacionLabel.Name = "identificacionLabel";
            identificacionLabel.Size = new System.Drawing.Size(72, 13);
            identificacionLabel.TabIndex = 22;
            identificacionLabel.Text = "identificacion:";
            // 
            // identificacionTextBox
            // 
            this.identificacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "identificacion", true));
            this.identificacionTextBox.Location = new System.Drawing.Point(837, 194);
            this.identificacionTextBox.Name = "identificacionTextBox";
            this.identificacionTextBox.Size = new System.Drawing.Size(100, 20);
            this.identificacionTextBox.TabIndex = 23;
            // 
            // ePSLabel
            // 
            ePSLabel.AutoSize = true;
            ePSLabel.ForeColor = System.Drawing.Color.White;
            ePSLabel.Location = new System.Drawing.Point(735, 223);
            ePSLabel.Name = "ePSLabel";
            ePSLabel.Size = new System.Drawing.Size(31, 13);
            ePSLabel.TabIndex = 24;
            ePSLabel.Text = "EPS:";
            // 
            // ePSTextBox
            // 
            this.ePSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "EPS", true));
            this.ePSTextBox.Location = new System.Drawing.Point(837, 220);
            this.ePSTextBox.Name = "ePSTextBox";
            this.ePSTextBox.Size = new System.Drawing.Size(100, 20);
            this.ePSTextBox.TabIndex = 25;
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1031, 420);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(tipo_identificacionLabel);
            this.Controls.Add(this.tipo_identificacionTextBox);
            this.Controls.Add(identificacionLabel);
            this.Controls.Add(this.identificacionTextBox);
            this.Controls.Add(ePSLabel);
            this.Controls.Add(this.ePSTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormPacientes";
            this.Text = "FormPacientes";
            this.Load += new System.EventHandler(this.FormPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_proyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseproyectoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource baseproyectoDataSetBindingSource;
        private base_proyectoDataSet base_proyectoDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private base_proyectoDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private base_proyectoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoidentificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePSDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox tipo_identificacionTextBox;
        private System.Windows.Forms.TextBox identificacionTextBox;
        private System.Windows.Forms.TextBox ePSTextBox;
    }
}