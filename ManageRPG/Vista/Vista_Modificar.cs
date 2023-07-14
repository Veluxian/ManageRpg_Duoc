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
    public partial class Vista_Modificar : Form
    {
        bool modificacion = false;
        public Vista_Modificar(Objeto parametroObjeto)
        {
            InitializeComponent();

            if (parametroObjeto != null)
            {
                modificacion = true;
                id_objeto.Text = parametroObjeto.id_objeto.ToString();
                nombreObjeto.Text = parametroObjeto.nombre_objeto;
                descripcionObjeto.Text = parametroObjeto.descripcion_objeto;
                pesoObjeto.Text = parametroObjeto.peso_objeto.ToString();
                precioObjeto.Text = parametroObjeto.valor_objeto.ToString();
                cantidadObjeto.Text = parametroObjeto.cantidad_objeto.ToString();
            }
        }

        private void Vista_Modificar_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (modificacion)
            {
                int id = int.Parse(id_objeto.Text);
                string nombre = nombreObjeto.Text;
                string descripcion = descripcionObjeto.Text;
                int peso = int.Parse(pesoObjeto.Text);
                int precio = int.Parse(precioObjeto.Text);
                int cantidad = int.Parse(cantidadObjeto.Text);
                controladorObjetos.ModificarObjeto(id, nombre, descripcion, peso, precio, cantidad);
            }
            else
            {
                string nombre = nombreObjeto.Text;
                string descripcion = descripcionObjeto.Text;
                int peso = int.Parse(pesoObjeto.Text);
                int precio = int.Parse(precioObjeto.Text);
                int cantidad = int.Parse(cantidadObjeto.Text);
                controladorObjetos.AgregarObjeto(nombre, descripcion, peso, precio, cantidad);
            }

        }
    }
}
