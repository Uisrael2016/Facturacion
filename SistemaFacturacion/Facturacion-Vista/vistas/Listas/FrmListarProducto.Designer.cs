namespace Facturacion_Vista.Vistas.Listas
{
    partial class FrmListarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtlista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonItem();
            this.textBuscar = new DevComponents.DotNetBar.TextBoxItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtlista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtlista
            // 
            this.dtlista.AllowUserToAddRows = false;
            this.dtlista.AllowUserToDeleteRows = false;
            this.dtlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtlista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtlista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.tipo,
            this.precio,
            this.descuento,
            this.desc_producto});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtlista.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtlista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtlista.Location = new System.Drawing.Point(0, 12);
            this.dtlista.Name = "dtlista";
            this.dtlista.ReadOnly = true;
            this.dtlista.RowHeadersVisible = false;
            this.dtlista.Size = new System.Drawing.Size(504, 324);
            this.dtlista.TabIndex = 0;
            this.dtlista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtlista_CellDoubleClick);
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "Id";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Visible = false;
            this.id_producto.Width = 22;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 53;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 62;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Width = 84;
            // 
            // desc_producto
            // 
            this.desc_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.desc_producto.HeaderText = "Descripcion Producto";
            this.desc_producto.Name = "desc_producto";
            this.desc_producto.ReadOnly = true;
            this.desc_producto.Width = 300;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.btnBuscar,
            this.textBuscar});
            this.bar1.Location = new System.Drawing.Point(2, 342);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(502, 39);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 1;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Image = global::Facturacion_Vista.Properties.Resources.new_ico;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "btnNuevo";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Facturacion_Vista.Properties.Resources.search_ico;
            this.btnBuscar.Name = "btnBuscar";
            // 
            // textBuscar
            // 
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.TextBoxWidth = 200;
            this.textBuscar.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // FrmListarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 380);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.dtlista);
            this.DoubleBuffered = true;
            this.Name = "FrmListarProducto";
            this.Text = "FrmListarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dtlista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtlista;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btnBuscar;
        private DevComponents.DotNetBar.TextBoxItem textBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_producto;
    }
}