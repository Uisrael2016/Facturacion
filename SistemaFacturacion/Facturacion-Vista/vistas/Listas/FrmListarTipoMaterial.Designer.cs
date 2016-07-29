namespace Facturacion_Vista.Vistas.Listas
{
    partial class FrmListarTipoMaterial
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
            this.id_tipo_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.buttonNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.buttonBuscar = new DevComponents.DotNetBar.ButtonItem();
            this.txtBuscar = new DevComponents.DotNetBar.TextBoxItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtLista
            // 
            this.dtLista.AllowUserToAddRows = false;
            this.dtLista.AllowUserToDeleteRows = false;
            this.dtLista.AllowUserToResizeColumns = false;
            this.dtLista.AllowUserToResizeRows = false;
            this.dtLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.id_tipo_material,
            this.tipo});
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
            this.dtLista.Location = new System.Drawing.Point(22, 12);
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
            this.dtLista.RowHeadersVisible = false;
            this.dtLista.Size = new System.Drawing.Size(445, 217);
            this.dtLista.TabIndex = 0;
            this.dtLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLista_CellDoubleClick);
            this.dtLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtLista_KeyPress);
            // 
            // id_tipo_material
            // 
            this.id_tipo_material.HeaderText = "ID";
            this.id_tipo_material.Name = "id_tipo_material";
            this.id_tipo_material.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo de Material";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonNuevo,
            this.buttonBuscar,
            this.txtBuscar});
            this.bar1.Location = new System.Drawing.Point(22, 235);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(445, 39);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 2;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Image = global::Facturacion_Vista.Properties.Resources.new_ico;
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Text = "Nuevo Material";
            this.buttonNuevo.Tooltip = "Nuevo Material";
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = global::Facturacion_Vista.Properties.Resources.search_ico;
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Text = "Buscar Material";
            this.buttonBuscar.Tooltip = "Buscar Material";
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.TextBoxWidth = 175;
            this.txtBuscar.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // FrmListarTipoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 284);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.dtLista);
            this.DoubleBuffered = true;
            this.Name = "FrmListarTipoMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmListarTipoMaterial";
            this.Load += new System.EventHandler(this.FrmListarTipoMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtLista;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem buttonNuevo;
        private DevComponents.DotNetBar.ButtonItem buttonBuscar;
        private DevComponents.DotNetBar.TextBoxItem txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
    }
}