using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_circulares
{
    public partial class Form1 : Form
    {
        private Ruta ruta = new Ruta();
        public Form1()
        {
            InitializeComponent();
            ruta.agregar(new Base("A", 8));
            ruta.agregar(new Base("B", 15));
            ruta.agregar(new Base("C", 11));
            ruta.agregar(new Base("D", 18));
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            ruta.agregar(new Base(txtNombre.Text, int.Parse(txtTiempo.Text)));

            txtNombre.Clear();
            txtTiempo.Clear();
            txtNombre.Focus();
        }

        private void cmdAgregar_Inicio_Click(object sender, EventArgs e)
        {
            ruta.agregarInicio(new Base(txtNombre.Text, int.Parse(txtTiempo.Text)));

            txtNombre.Clear();
            txtTiempo.Clear();
            txtNombre.Focus();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            ruta.eliminar(txtBuscar.Text);
        }

        private void cmdEliminar_Inicio_Click(object sender, EventArgs e)
        {
            ruta.eliminarInicio();
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            txtLista.Text = ruta.ToString();
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            ruta.insertar(txtRuta.Text, new Base(txtNombre.Text, int.Parse(txtTiempo.Text)));

            txtNombre.Clear();
            txtTiempo.Clear();
            txtRuta.Clear();
            txtNombre.Focus();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Base resultado = ruta.buscar(txtBuscar.Text);

            if (resultado != null)
            {
                txtNombre.Text = resultado.nombre;
                txtTiempo.Text = resultado.minutos.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el resultado.");
            }
        }

        private void cmdRecorrido_Click(object sender, EventArgs e)
        {
            txtLista.Text = ruta.recorrido(txtRecorrido.Text, dtpInicio.Value, dtpFin.Value);
        }
    }
}
