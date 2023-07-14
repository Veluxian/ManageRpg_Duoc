using ManageRPG.Controlador;
using ManageRPG.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRPG.Vista
{
    public partial class Vista_principal : Form
    {
        public Vista_principal()
        {
            InitializeComponent();
        }

        private void Vista_principal_Load(object sender, EventArgs e)
        {
            DisenoInicial();
            MostrarListaObjetos();
        }

        private void DisenoInicial()
        {
            dataGridObjetos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridObjetos.MultiSelect = false;
            dataGridObjetos.ReadOnly = true;
            dataGridObjetos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridObjetos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridObjetos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void MostrarListaObjetos()
        {
            List<Objeto> tabla = new controladorPrincipal().ObtenerDatos();
            dataGridObjetos.DataSource = null;
            dataGridObjetos.Columns.Clear();
            dataGridObjetos.Rows.Clear();
            dataGridObjetos.Refresh();

            dataGridObjetos.DataSource = tabla;
            dataGridObjetos.Columns["id_objeto"].Visible = false;

        }

        private void dataGridObjetos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Objeto objeto = (Objeto)dataGridObjetos.SelectedRows[0].DataBoundItem;
            Vista_Modificar modificar = new Vista_Modificar(objeto);
            modificar.ShowDialog();
            MostrarListaObjetos();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            Objeto objeto = (Objeto)dataGridObjetos.SelectedRows[0].DataBoundItem;
        }
    }
}
