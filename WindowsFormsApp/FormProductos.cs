using ServiciosPrueba2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormProductos : Form
    {
        List<Producto> _productosData;
        BindingSource _bindingSourceProductos = new BindingSource();
        public FormProductos(List<Producto> productosData)
        {
            InitializeComponent();
            _productosData = productosData;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LlenarTabla();
        }

        private void LlenarTabla()
        {
            if (_productosData != null)
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("id", typeof(int));
                dataTable.Columns.Add("titulo");
                dataTable.Columns.Add("descripcion");
                dataTable.Columns.Add("precio", typeof(decimal));
                dataTable.Columns.Add("existencias", typeof(int));

                foreach (Producto producto in _productosData)
                {
                    dataTable.Rows.Add(producto.Idproductos, producto.Titulo, producto.Descripcion, producto.PrecioUnitario, producto.Existencias);
                }

                _bindingSourceProductos.DataSource = dataTable;
                dataGridViewProductos.DataSource = _bindingSourceProductos;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string busqueda = textBox.Text;
            _bindingSourceProductos.Filter = $"titulo LIKE '%{busqueda}%'";
        }

    }
}
