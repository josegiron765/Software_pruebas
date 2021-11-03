﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_prueba.Forms
{
    public partial class FormHistoria : Form
    {
        public FormHistoria()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void historiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.base_proyectoDataSet);

        }

        private void FormHistoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'base_proyectoDataSet.Historia' Puede moverla o quitarla según sea necesario.
            this.historiaTableAdapter.Fill(this.base_proyectoDataSet.Historia);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            historiaBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            historiaBindingSource.EndEdit();
           historiaTableAdapter.Update(base_proyectoDataSet.Historia);
        }
    }
}
