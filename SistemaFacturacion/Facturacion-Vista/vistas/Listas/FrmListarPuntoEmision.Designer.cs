namespace Facturacion_Vista.Vistas.Listas
{
    partial class FrmListarPuntoEmision
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtLista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btAgregar = new DevComponents.DotNetBar.ButtonItem();
            this.btBuscar = new DevComponents.DotNetBar.ButtonItem();
            this.txtbuscar = new DevComponents.DotNetBar.TextBoxItem();
            this.PuntoEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtLista
            // 
            this.dtLista.AllowUserToAddRows = false;
            this.dtLista.AllowUserToDeleteRows = false;
            this.dtLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtLista.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PuntoEmision,
            this.Codigo,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtLista.EnableHeadersVisualStyles = false;
            this.dtLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtLista.Location = new System.Drawing.Point(12, 12);
            this.dtLista.Name = "dtLista";
            this.dtLista.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtLista.Size = new System.Drawing.Size(596, 247);
            this.dtLista.TabIndex = 0;
            this.dtLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtlista_CellDoubleClick);
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btAgregar,
            this.btBuscar,
            this.txtbuscar});
            this.bar1.Location = new System.Drawing.Point(12, 265);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(597, 39);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 8;
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
            // PuntoEmision
            // 
            this.PuntoEmision.HeaderText = "Punto Emisión";
            this.PuntoEmision.Name = "PuntoEmision";
            this.PuntoEmision.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // FrmListarPuntoEmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 309);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.dtLista);
            this.DoubleBuffered = true;
            this.Name = "FrmListarPuntoEmision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listar Punto de Emisión";
           // this.Load += new System.EventHandler(this.FrmListarPuntoEmision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtLista;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btAgregar;
        private DevComponents.DotNetBar.ButtonItem btBuscar;
        private DevComponents.DotNetBar.TextBoxItem txtbuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntoEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}