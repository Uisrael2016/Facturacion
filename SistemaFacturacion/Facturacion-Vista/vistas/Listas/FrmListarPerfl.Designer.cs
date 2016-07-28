namespace Facturacion_Vista.Vistas.Listas
{
    partial class FrmListarPerfl
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
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btAgregar = new DevComponents.DotNetBar.ButtonItem();
            this.btBuscar = new DevComponents.DotNetBar.ButtonItem();
            this.txtbuscar = new DevComponents.DotNetBar.TextBoxItem();
            this.dtLista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLista)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btAgregar,
            this.btBuscar,
            this.txtbuscar});
            this.bar1.Location = new System.Drawing.Point(0, 282);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(541, 39);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 7;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btAgregar
            // 
            this.btAgregar.Image = global::Facturacion_Vista.Properties.Resources.new_ico;
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Text = "Nuevo";
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Image = global::Facturacion_Vista.Properties.Resources.search_ico;
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Text = "Buscar";
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.TextBoxWidth = 200;
            this.txtbuscar.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // dtLista
            // 
            this.dtLista.AllowUserToAddRows = false;
            this.dtLista.AllowUserToDeleteRows = false;
            this.dtLista.AllowUserToResizeColumns = false;
            this.dtLista.AllowUserToResizeRows = false;
            this.dtLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.descripcion,
            this.codigo,
            this.Estado});
            this.dtLista.Location = new System.Drawing.Point(0, 22);
            this.dtLista.Name = "dtLista";
            this.dtLista.ReadOnly = true;
            this.dtLista.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtLista.Size = new System.Drawing.Size(541, 254);
            this.dtLista.TabIndex = 6;
            this.dtLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLista_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmListarPerfl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 321);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.dtLista);
            this.DoubleBuffered = true;
            this.Name = "FrmListarPerfl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmListarPerfl";
            this.Load += new System.EventHandler(this.FrmListarPerfl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btAgregar;
        private DevComponents.DotNetBar.ButtonItem btBuscar;
        private DevComponents.DotNetBar.TextBoxItem txtbuscar;
        private System.Windows.Forms.DataGridView dtLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}