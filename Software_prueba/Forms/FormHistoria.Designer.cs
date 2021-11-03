
namespace Software_prueba.Forms
{
    partial class FormHistoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoria));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label _HistoriaLabel;
            System.Windows.Forms.Label nombre_pacienteLabel;
            System.Windows.Forms.Label apellido_PacienteLabel;
            System.Windows.Forms.Label ePSLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.base_proyectoDataSet = new Software_prueba.base_proyectoDataSet();
            this.historiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historiaTableAdapter = new Software_prueba.base_proyectoDataSetTableAdapters.HistoriaTableAdapter();
            this.tableAdapterManager = new Software_prueba.base_proyectoDataSetTableAdapters.TableAdapterManager();
            this.historiaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.historiaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this._HistoriaTextBox = new System.Windows.Forms.TextBox();
            this.nombre_pacienteTextBox = new System.Windows.Forms.TextBox();
            this.apellido_PacienteTextBox = new System.Windows.Forms.TextBox();
            this.ePSTextBox = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrepacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            _HistoriaLabel = new System.Windows.Forms.Label();
            nombre_pacienteLabel = new System.Windows.Forms.Label();
            apellido_PacienteLabel = new System.Windows.Forms.Label();
            ePSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_proyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaBindingNavigator)).BeginInit();
            this.historiaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historia clinica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione paciente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.historiaDataGridViewTextBoxColumn,
            this.nombrepacienteDataGridViewTextBoxColumn,
            this.apellidoPacienteDataGridViewTextBoxColumn,
            this.ePSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.historiaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 180);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(333, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(142, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // base_proyectoDataSet
            // 
            this.base_proyectoDataSet.DataSetName = "base_proyectoDataSet";
            this.base_proyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historiaBindingSource
            // 
            this.historiaBindingSource.DataMember = "Historia";
            this.historiaBindingSource.DataSource = this.base_proyectoDataSet;
            // 
            // historiaTableAdapter
            // 
            this.historiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HistoriaTableAdapter = this.historiaTableAdapter;
            this.tableAdapterManager.PacientesTableAdapter = null;
            this.tableAdapterManager.ReportesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Software_prueba.base_proyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // historiaBindingNavigator
            // 
            this.historiaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.historiaBindingNavigator.BindingSource = this.historiaBindingSource;
            this.historiaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.historiaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.historiaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.historiaBindingNavigatorSaveItem});
            this.historiaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.historiaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.historiaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.historiaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.historiaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.historiaBindingNavigator.Name = "historiaBindingNavigator";
            this.historiaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.historiaBindingNavigator.Size = new System.Drawing.Size(852, 25);
            this.historiaBindingNavigator.TabIndex = 10;
            this.historiaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // historiaBindingNavigatorSaveItem
            // 
            this.historiaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.historiaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("historiaBindingNavigatorSaveItem.Image")));
            this.historiaBindingNavigatorSaveItem.Name = "historiaBindingNavigatorSaveItem";
            this.historiaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.historiaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.historiaBindingNavigatorSaveItem.Click += new System.EventHandler(this.historiaBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.ForeColor = System.Drawing.Color.White;
            idLabel.Location = new System.Drawing.Point(602, 69);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 10;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historiaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(679, 66);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 11;
            // 
            // _HistoriaLabel
            // 
            _HistoriaLabel.AutoSize = true;
            _HistoriaLabel.ForeColor = System.Drawing.Color.White;
            _HistoriaLabel.Location = new System.Drawing.Point(581, 106);
            _HistoriaLabel.Name = "_HistoriaLabel";
            _HistoriaLabel.Size = new System.Drawing.Size(52, 13);
            _HistoriaLabel.TabIndex = 12;
            _HistoriaLabel.Text = "#Historia:";
            // 
            // _HistoriaTextBox
            // 
            this._HistoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historiaBindingSource, "#Historia", true));
            this._HistoriaTextBox.Location = new System.Drawing.Point(679, 106);
            this._HistoriaTextBox.Name = "_HistoriaTextBox";
            this._HistoriaTextBox.Size = new System.Drawing.Size(100, 20);
            this._HistoriaTextBox.TabIndex = 13;
            // 
            // nombre_pacienteLabel
            // 
            nombre_pacienteLabel.AutoSize = true;
            nombre_pacienteLabel.ForeColor = System.Drawing.Color.White;
            nombre_pacienteLabel.Location = new System.Drawing.Point(567, 145);
            nombre_pacienteLabel.Name = "nombre_pacienteLabel";
            nombre_pacienteLabel.Size = new System.Drawing.Size(91, 13);
            nombre_pacienteLabel.TabIndex = 14;
            nombre_pacienteLabel.Text = "Nombre paciente:";
            // 
            // nombre_pacienteTextBox
            // 
            this.nombre_pacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historiaBindingSource, "Nombre_paciente", true));
            this.nombre_pacienteTextBox.Location = new System.Drawing.Point(679, 142);
            this.nombre_pacienteTextBox.Name = "nombre_pacienteTextBox";
            this.nombre_pacienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_pacienteTextBox.TabIndex = 15;
            // 
            // apellido_PacienteLabel
            // 
            apellido_PacienteLabel.AutoSize = true;
            apellido_PacienteLabel.ForeColor = System.Drawing.Color.White;
            apellido_PacienteLabel.Location = new System.Drawing.Point(567, 182);
            apellido_PacienteLabel.Name = "apellido_PacienteLabel";
            apellido_PacienteLabel.Size = new System.Drawing.Size(92, 13);
            apellido_PacienteLabel.TabIndex = 16;
            apellido_PacienteLabel.Text = "Apellido Paciente:";
            // 
            // apellido_PacienteTextBox
            // 
            this.apellido_PacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historiaBindingSource, "Apellido_Paciente", true));
            this.apellido_PacienteTextBox.Location = new System.Drawing.Point(679, 179);
            this.apellido_PacienteTextBox.Name = "apellido_PacienteTextBox";
            this.apellido_PacienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellido_PacienteTextBox.TabIndex = 17;
            // 
            // ePSLabel
            // 
            ePSLabel.AutoSize = true;
            ePSLabel.ForeColor = System.Drawing.Color.White;
            ePSLabel.Location = new System.Drawing.Point(581, 228);
            ePSLabel.Name = "ePSLabel";
            ePSLabel.Size = new System.Drawing.Size(31, 13);
            ePSLabel.TabIndex = 18;
            ePSLabel.Text = "EPS:";
            // 
            // ePSTextBox
            // 
            this.ePSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historiaBindingSource, "EPS", true));
            this.ePSTextBox.Location = new System.Drawing.Point(679, 225);
            this.ePSTextBox.Name = "ePSTextBox";
            this.ePSTextBox.Size = new System.Drawing.Size(100, 20);
            this.ePSTextBox.TabIndex = 19;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // historiaDataGridViewTextBoxColumn
            // 
            this.historiaDataGridViewTextBoxColumn.DataPropertyName = "#Historia";
            this.historiaDataGridViewTextBoxColumn.HeaderText = "#Historia";
            this.historiaDataGridViewTextBoxColumn.Name = "historiaDataGridViewTextBoxColumn";
            // 
            // nombrepacienteDataGridViewTextBoxColumn
            // 
            this.nombrepacienteDataGridViewTextBoxColumn.DataPropertyName = "Nombre_paciente";
            this.nombrepacienteDataGridViewTextBoxColumn.HeaderText = "Nombre_paciente";
            this.nombrepacienteDataGridViewTextBoxColumn.Name = "nombrepacienteDataGridViewTextBoxColumn";
            // 
            // apellidoPacienteDataGridViewTextBoxColumn
            // 
            this.apellidoPacienteDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Paciente";
            this.apellidoPacienteDataGridViewTextBoxColumn.HeaderText = "Apellido_Paciente";
            this.apellidoPacienteDataGridViewTextBoxColumn.Name = "apellidoPacienteDataGridViewTextBoxColumn";
            // 
            // ePSDataGridViewTextBoxColumn
            // 
            this.ePSDataGridViewTextBoxColumn.DataPropertyName = "EPS";
            this.ePSDataGridViewTextBoxColumn.HeaderText = "EPS";
            this.ePSDataGridViewTextBoxColumn.Name = "ePSDataGridViewTextBoxColumn";
            // 
            // FormHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(852, 426);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(_HistoriaLabel);
            this.Controls.Add(this._HistoriaTextBox);
            this.Controls.Add(nombre_pacienteLabel);
            this.Controls.Add(this.nombre_pacienteTextBox);
            this.Controls.Add(apellido_PacienteLabel);
            this.Controls.Add(this.apellido_PacienteTextBox);
            this.Controls.Add(ePSLabel);
            this.Controls.Add(this.ePSTextBox);
            this.Controls.Add(this.historiaBindingNavigator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHistoria";
            this.Text = "FormHistoria";
            this.Load += new System.EventHandler(this.FormHistoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_proyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaBindingNavigator)).EndInit();
            this.historiaBindingNavigator.ResumeLayout(false);
            this.historiaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private base_proyectoDataSet base_proyectoDataSet;
        private System.Windows.Forms.BindingSource historiaBindingSource;
        private base_proyectoDataSetTableAdapters.HistoriaTableAdapter historiaTableAdapter;
        private base_proyectoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator historiaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton historiaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrepacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePSDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox _HistoriaTextBox;
        private System.Windows.Forms.TextBox nombre_pacienteTextBox;
        private System.Windows.Forms.TextBox apellido_PacienteTextBox;
        private System.Windows.Forms.TextBox ePSTextBox;
    }
}