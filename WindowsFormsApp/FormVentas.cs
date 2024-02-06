using Newtonsoft.Json;
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
    public partial class FormVentas : Form
    {
        List<VentaProducto> _ventasData;
        List<string> _productosLista = new List<string> { "Todos" };
        BindingSource _bindingSourceVentas = new BindingSource();
        BindingSource _bindingSourceTopVentas = new BindingSource();
        public FormVentas(List<VentaProducto> ventasData, List<string> productos)
        {
            InitializeComponent();
            this._ventasData = ventasData;
            this._productosLista.AddRange(productos);

        }

        private void FormVentas_Load(object sender, System.EventArgs e)
        {
            LlenarTabla();
            LlenarTablaTopProductos();
            SumarVentas();
            LlenarSelector();
        }

        private void LlenarTabla()
        {
            if(_ventasData != null)
            {
                DataTable dataTable = new DataTable( );
                dataTable.Columns.Add("id", typeof(int));
                dataTable.Columns.Add("producto");
                dataTable.Columns.Add("cantidad", typeof(int));
                dataTable.Columns.Add("fecha", typeof(DateTime));
                dataTable.Columns.Add("totalVenta", typeof(decimal));

                foreach (VentaProducto venta in _ventasData)
                {
                    dataTable.Rows.Add(venta.IdVenta, venta.NombreProducto, venta.CantidadVendida, venta.Fecha, venta.TotalVenta);
                }
                
                _bindingSourceVentas.DataSource = dataTable;
                dataGridViewVentas.DataSource = _bindingSourceVentas;
            }
        }

        private void LlenarTablaTopProductos()
        {
            if (_ventasData != null)
            {
                // Agrupar por producto y sumar el monto de la venta para cada producto
                List<VentaProducto> sumasPorProducto = _ventasData
                    .GroupBy(venta => venta.NombreProducto)
                    .Select(grupo => new VentaProducto
                    {
                        NombreProducto = grupo.Key,
                        CantidadVendida = grupo.Sum(venta => venta.CantidadVendida),
                        TotalVenta = grupo.Sum(venta => venta.TotalVenta)
                    }).ToList();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("producto");
                dataTable.Columns.Add("cantidad", typeof(int));

                foreach (VentaProducto venta in sumasPorProducto)
                {
                    dataTable.Rows.Add( venta.NombreProducto, venta.CantidadVendida);
                }

                _bindingSourceTopVentas.DataSource = dataTable;
                dataGridViewTop.DataSource = _bindingSourceTopVentas;
                _bindingSourceTopVentas.Sort = "cantidad DESC";
            }
        }

        private void SumarVentas()
        {
            DataView dataView = (DataView)_bindingSourceVentas.List;

            decimal sumaTotalVenta = 0;

            foreach (DataRowView filaView in dataView)
            {
                sumaTotalVenta += Convert.ToDecimal(filaView["totalVenta"]);
            }
            
            totalVentasTxt.Text = sumaTotalVenta.ToString("C2");
        }

        private void LlenarSelector()
        {
            filtroVentas.DataSource = _productosLista;
            filtroVentas.SelectedIndex = 0;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;
            string producto = (combobox.SelectedItem != null) ? combobox.SelectedItem.ToString() : string.Empty;
            string filtro;
            if (producto == "Todos")
            {
                filtro = "";
            }
            else
            {
                filtro = $"producto = '{producto}'";
            }
             
            _bindingSourceVentas.Filter = filtro;
            SumarVentas();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if(checkBox.Checked)
            {
                panelTopVentas.Visible = true;
            }
            else
            {
                panelTopVentas.Visible = false;
            }
        }

    }
}
