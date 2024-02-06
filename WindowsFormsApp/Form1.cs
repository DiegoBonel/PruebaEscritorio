using FontAwesome.Sharp;
using Newtonsoft.Json;
using ServiciosPrueba2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {

        List<VentaProducto> _ventas;
        List<Producto> _productos;
        Form _formActivo;
        IconButton _btnActivo;
        Panel _bordeInferior;
        List<string> _nombresProductos = new List<string>();


        public Form1()
        {
            InitializeComponent();
            _bordeInferior = new Panel();
            _bordeInferior.Size = new Size(133, 2);
            panel1.Controls.Add(_bordeInferior);
            ActivarBoton(iconButtonVentas);
        }

        private async void Form1_Load(object sender, System.EventArgs e)
        {
            await GetAllVentasProductos();
            await GetAllProductos();

            if (_ventas != null && _productos != null)
            {
                _nombresProductos = _productos.Select(producto => producto.Titulo).ToList();
                AbrirFormulario(new FormVentas(_ventas, _nombresProductos));
                CrearNotificacionesStockBajo();
                panelError.Visible = false;
            }
            else
            {
                panelError.Visible = true;
            }


        }

        public async Task<string> GetAllVentasProductos()
        {
            string apiUrl = "https://localhost:7003/api/VentaProducto/getAll";

            try
            {
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string contenido = await response.Content.ReadAsStringAsync();
                    _ventas = JsonConvert.DeserializeObject<List<VentaProducto>>(contenido);
                    return contenido;
                }
                else
                {
                    _ventas = null;
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }

            }
            catch (Exception ex)
            {
                _ventas = null;
                MessageBox.Show($"Error en la solicitud de Ventas: {ex.Message}");
            }
            return null;
        }

        public async Task<string> GetAllProductos()
        {
            string apiUrl = "https://localhost:7003/api/Producto/getAll";

            try
            {
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string contenido = await response.Content.ReadAsStringAsync();
                    _productos = JsonConvert.DeserializeObject<List<Producto>>(contenido);
                    return contenido;
                }
                else
                {
                    _productos = null;
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }

            }
            catch (Exception ex)
            {
                _productos = null;
                MessageBox.Show($"Error en la solicitud de Productos: {ex.Message}");
            }
            return null;
        }

        private void AbrirFormulario(Form formHijo)
        {
            if(_ventas != null && _productos != null)
            {
                if (_formActivo != null)
                    _formActivo.Close();

                _formActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(formHijo);
                panelChildForm.Tag = formHijo;
                formHijo.Show();
            }
        }

        private void ActivarBoton(object boton)
        {
            if(boton != null)
            {
                DeshabilitarBoton();
                _btnActivo = (IconButton)boton;
                _btnActivo.ForeColor = Color.Blue;
                _btnActivo.IconColor = Color.Blue;

                _bordeInferior.BackColor = Color.Blue;
                _bordeInferior.Location = new Point(_btnActivo.Location.X, 34);
                _bordeInferior.Visible = true;
                _bordeInferior.BringToFront();
            }
        }

        private void DeshabilitarBoton()
        {
            if (_btnActivo != null)
            {
                _btnActivo.ForeColor = Color.Black;
                _btnActivo.IconColor = Color.DimGray;
            }
        }

        private void CrearNotificacionesStockBajo()
        {
            panelProductos.Controls.Clear();
            List<Producto> productosStockBajo = _productos.Where(producto => producto.Existencias < 100).ToList();
            if(productosStockBajo.Count > 0)
            {
                foreach (Producto producto in productosStockBajo)
                {
                    Label labelProducto = new Label();
                    labelProducto.Text = producto.Titulo;
                    labelProducto.Dock = DockStyle.Top;
                    labelProducto.ForeColor = Color.White;

                    
                    panelProductos.Controls.Add(labelProducto);
                }

                iconButtonNotificaciones.Text = "1";
                panelStockBajo.Visible = true;
            }
            else
            {
                panelStockBajo.Visible = false;
                iconButtonNotificaciones.Text = String.Empty;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            if(_ventas != null)
            {
                AbrirFormulario(new FormVentas(_ventas, _nombresProductos));
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            if(_productos != null)
            {
                AbrirFormulario(new FormProductos(_productos));
            }
        }


        private async void iconButton3_Click(object sender, EventArgs e)
        {
            await GetAllVentasProductos();
            await GetAllProductos();

            if (_ventas != null && _productos != null)
            {
                panelError.Visible = false;
                if (_btnActivo.Name == "iconButtonVentas"){
                    _nombresProductos = _productos.Select(producto => producto.Titulo).ToList();
                    AbrirFormulario(new FormVentas(_ventas, _nombresProductos));
                }
                else if (_btnActivo.Name == "iconButtonProductos")
                {
                    AbrirFormulario(new FormProductos(_productos));
                }
                CrearNotificacionesStockBajo();
            }
            else
            {
                _formActivo.Close();
                panelError.Visible = true;
            }
        }

        private void iconButtonNotificaciones_Click(object sender, EventArgs e)
        {
            if(panelNotificaciones.Visible)
            {
                panelNotificaciones.Visible = false;
            }
            else
            {
                panelNotificaciones.Visible = true;
            }
            
        }

    }
}
