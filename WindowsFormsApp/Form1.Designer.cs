namespace WindowsFormsApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonRefrescar = new FontAwesome.Sharp.IconButton();
            this.iconButtonProductos = new FontAwesome.Sharp.IconButton();
            this.iconButtonVentas = new FontAwesome.Sharp.IconButton();
            this.iconButtonNotificaciones = new FontAwesome.Sharp.IconButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelError = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelStockBajo = new System.Windows.Forms.Panel();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelNotificaciones = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panelError.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelStockBajo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelNotificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButtonRefrescar);
            this.panel1.Controls.Add(this.iconButtonProductos);
            this.panel1.Controls.Add(this.iconButtonVentas);
            this.panel1.Controls.Add(this.iconButtonNotificaciones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 35);
            this.panel1.TabIndex = 0;
            // 
            // iconButtonRefrescar
            // 
            this.iconButtonRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonRefrescar.AutoSize = true;
            this.iconButtonRefrescar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButtonRefrescar.FlatAppearance.BorderSize = 0;
            this.iconButtonRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRefrescar.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.iconButtonRefrescar.IconColor = System.Drawing.Color.Black;
            this.iconButtonRefrescar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRefrescar.IconSize = 25;
            this.iconButtonRefrescar.Location = new System.Drawing.Point(745, 9);
            this.iconButtonRefrescar.Name = "iconButtonRefrescar";
            this.iconButtonRefrescar.Size = new System.Drawing.Size(31, 31);
            this.iconButtonRefrescar.TabIndex = 2;
            this.iconButtonRefrescar.UseVisualStyleBackColor = true;
            this.iconButtonRefrescar.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButtonProductos
            // 
            this.iconButtonProductos.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonProductos.FlatAppearance.BorderSize = 0;
            this.iconButtonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonProductos.ForeColor = System.Drawing.Color.Black;
            this.iconButtonProductos.IconChar = FontAwesome.Sharp.IconChar.SprayCan;
            this.iconButtonProductos.IconColor = System.Drawing.Color.DimGray;
            this.iconButtonProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonProductos.IconSize = 30;
            this.iconButtonProductos.Location = new System.Drawing.Point(184, 0);
            this.iconButtonProductos.Name = "iconButtonProductos";
            this.iconButtonProductos.Size = new System.Drawing.Size(133, 35);
            this.iconButtonProductos.TabIndex = 1;
            this.iconButtonProductos.Text = "Productos";
            this.iconButtonProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonProductos.UseVisualStyleBackColor = false;
            this.iconButtonProductos.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButtonVentas
            // 
            this.iconButtonVentas.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonVentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonVentas.FlatAppearance.BorderSize = 0;
            this.iconButtonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonVentas.ForeColor = System.Drawing.Color.Black;
            this.iconButtonVentas.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.iconButtonVentas.IconColor = System.Drawing.Color.DimGray;
            this.iconButtonVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonVentas.IconSize = 30;
            this.iconButtonVentas.Location = new System.Drawing.Point(51, 0);
            this.iconButtonVentas.Name = "iconButtonVentas";
            this.iconButtonVentas.Size = new System.Drawing.Size(133, 35);
            this.iconButtonVentas.TabIndex = 0;
            this.iconButtonVentas.Text = "Ventas";
            this.iconButtonVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonVentas.UseVisualStyleBackColor = false;
            this.iconButtonVentas.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButtonNotificaciones
            // 
            this.iconButtonNotificaciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonNotificaciones.FlatAppearance.BorderSize = 0;
            this.iconButtonNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNotificaciones.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconButtonNotificaciones.IconColor = System.Drawing.Color.Blue;
            this.iconButtonNotificaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNotificaciones.IconSize = 27;
            this.iconButtonNotificaciones.Location = new System.Drawing.Point(0, 0);
            this.iconButtonNotificaciones.Name = "iconButtonNotificaciones";
            this.iconButtonNotificaciones.Size = new System.Drawing.Size(51, 35);
            this.iconButtonNotificaciones.TabIndex = 3;
            this.iconButtonNotificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonNotificaciones.UseVisualStyleBackColor = true;
            this.iconButtonNotificaciones.Click += new System.EventHandler(this.iconButtonNotificaciones_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.panelError);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(178, 35);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(621, 418);
            this.panelChildForm.TabIndex = 1;
            // 
            // panelError
            // 
            this.panelError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelError.Controls.Add(this.label3);
            this.panelError.Controls.Add(this.pictureBox1);
            this.panelError.Location = new System.Drawing.Point(98, 61);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(445, 241);
            this.panelError.TabIndex = 1;
            this.panelError.Visible = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 58);
            this.label3.TabIndex = 1;
            this.label3.Text = "Error al conectar con el servidor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 29);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notificaciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelStockBajo
            // 
            this.panelStockBajo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelStockBajo.Controls.Add(this.panelProductos);
            this.panelStockBajo.Controls.Add(this.panel5);
            this.panelStockBajo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStockBajo.Location = new System.Drawing.Point(0, 29);
            this.panelStockBajo.Name = "panelStockBajo";
            this.panelStockBajo.Size = new System.Drawing.Size(178, 214);
            this.panelStockBajo.TabIndex = 2;
            this.panelStockBajo.Visible = false;
            // 
            // panelProductos
            // 
            this.panelProductos.AutoScroll = true;
            this.panelProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductos.Location = new System.Drawing.Point(0, 64);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(178, 150);
            this.panelProductos.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 64);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "• Stock bajo, realizar pedido de los siguientes productos:\r\n";
            // 
            // panelNotificaciones
            // 
            this.panelNotificaciones.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelNotificaciones.Controls.Add(this.panelStockBajo);
            this.panelNotificaciones.Controls.Add(this.panel3);
            this.panelNotificaciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNotificaciones.Location = new System.Drawing.Point(0, 35);
            this.panelNotificaciones.Name = "panelNotificaciones";
            this.panelNotificaciones.Size = new System.Drawing.Size(178, 418);
            this.panelNotificaciones.TabIndex = 2;
            this.panelNotificaciones.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 453);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelNotificaciones);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(815, 492);
            this.Name = "Form1";
            this.Text = "Información de ventas e inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelError.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelStockBajo.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelNotificaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonVentas;
        private FontAwesome.Sharp.IconButton iconButtonProductos;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton iconButtonRefrescar;
        private FontAwesome.Sharp.IconButton iconButtonNotificaciones;
        private System.Windows.Forms.Panel panelError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelStockBajo;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelNotificaciones;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

