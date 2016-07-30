namespace Facturacion_Vista.Vistas.Listas
{
    partial class FrmListarPedido
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
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btGuardar = new DevComponents.DotNetBar.ButtonItem();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonItem();
            this.textBuscar = new DevComponents.DotNetBar.TextBoxItem();
            this.dtlista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id_cabecera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtsecuencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtfecha_emision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dttotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlista)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btGuardar,
            this.btnBuscar,
            this.textBuscar});
            this.bar1.Location = new System.Drawing.Point(-4, 484);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(974, 39);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 3;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btGuardar
            // 
            this.btGuardar.Image = global::Facturacion_Vista.Properties.Resources.new_ico;
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Text = "btnNuevo";
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
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
            // dtlista
            // 
            this.dtlista.AllowUserToAddRows = false;
            this.dtlista.AllowUserToDeleteRows = false;
            this.dtlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtlista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtlista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtlista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cabecera,
            this.dtsecuencial,
            this.dtcliente,
            this.dtfecha_emision,
            this.dttotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtlista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtlista.EnableHeadersVisualStyles = false;
            this.dtlista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtlista.Location = new System.Drawing.Point(-4, 2);
            this.dtlista.Name = "dtlista";
            this.dtlista.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtlista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtlista.RowHeadersVisible = false;
            this.dtlista.Size = new System.Drawing.Size(766, 476);
            this.dtlista.TabIndex = 2;
            this.dtlista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtlista_CellDoubleClick);
            // 
            // id_cabecera
            // 
            this.id_cabecera.HeaderText = "Id Cabecera";
            this.id_cabecera.Name = "id_cabecera";
            this.id_cabecera.ReadOnly = true;
            this.id_cabecera.Visible = false;
            // 
            // dtsecuencial
            // 
            this.dtsecuencial.HeaderText = "Codigo Factura";
            this.dtsecuencial.Name = "dtsecuencial";
            this.dtsecuencial.ReadOnly = true;
            // 
            // dtcliente
            // 
            this.dtcliente.HeaderText = "Cliente";
            this.dtcliente.Name = "dtcliente";
            this.dtcliente.ReadOnly = true;
            // 
            // dtfecha_emision
            // 
            this.dtfecha_emision.HeaderText = "Fecha de Pedido";
            this.dtfecha_emision.Name = "dtfecha_emision";
            this.dtfecha_emision.ReadOnly = true;
            // 
            // dttotal
            // 
            this.dttotal.HeaderText = "Total";
            this.dttotal.Name = "dttotal";
            this.dttotal.ReadOnly = true;
            // 
            // FrmListarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 517);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.dtlista);
            this.DoubleBuffered = true;
            this.Name = "FrmListarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmListarPedido";
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btGuardar;
        private DevComponents.DotNetBar.ButtonItem btnBuscar;
        private DevComponents.DotNetBar.TextBoxItem textBuscar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtlista;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cabecera;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtsecuencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtfecha_emision;
        private System.Windows.Forms.DataGridViewTextBoxColumn dttotal;
    }
}