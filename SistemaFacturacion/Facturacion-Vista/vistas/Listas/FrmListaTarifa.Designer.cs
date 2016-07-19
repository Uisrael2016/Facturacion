namespace Facturacion_Vista.Vistas.Listas
{
    partial class FrmListaTarifa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxitemTodos = new DevComponents.Editors.ComboItem();
            this.cbxActivos = new DevComponents.Editors.ComboItem();
            this.cbxDesactivos = new DevComponents.Editors.ComboItem();
            this.dtlista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.comboBoxItem1 = new DevComponents.DotNetBar.ComboBoxItem();
            this.buttonBuscar = new DevComponents.DotNetBar.ButtonItem();
            this.btGuardar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtlista)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxitemTodos
            // 
            this.cbxitemTodos.Text = "Todos";
            // 
            // cbxActivos
            // 
            this.cbxActivos.Text = "Activos";
            // 
            // cbxDesactivos
            // 
            this.cbxDesactivos.Text = "Desactivados";
            // 
            // dtlista
            // 
            this.dtlista.AllowUserToAddRows = false;
            this.dtlista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtlista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProveedor,
            this.Valor,
            this.Estado});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtlista.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtlista.EnableHeadersVisualStyles = false;
            this.dtlista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtlista.Location = new System.Drawing.Point(2, 12);
            this.dtlista.Name = "dtlista";
            this.dtlista.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtlista.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtlista.RowHeadersVisible = false;
            this.dtlista.Size = new System.Drawing.Size(254, 180);
            this.dtlista.TabIndex = 4;
            // 
            // idProveedor
            // 
            this.idProveedor.HeaderText = "Id";
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.ReadOnly = true;
            this.idProveedor.Visible = false;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor de Tarifa";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 150;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Image = global::Facturacion_Vista.Properties.Resources.new_ico;
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Text = "Nuevo Material";
            this.buttonNuevo.Tooltip = "Nuevo Material";
            // 
            // comboBoxItem1
            // 
            this.comboBoxItem1.ComboWidth = 150;
            this.comboBoxItem1.DropDownHeight = 106;
            this.comboBoxItem1.ItemHeight = 17;
            this.comboBoxItem1.Items.AddRange(new object[] {
            this.cbxitemTodos,
            this.cbxActivos,
            this.cbxDesactivos});
            this.comboBoxItem1.Name = "comboBoxItem1";
            this.comboBoxItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonBuscar});
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = global::Facturacion_Vista.Properties.Resources.search_ico;
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Text = "Buscar Material";
            this.buttonBuscar.Tooltip = "Buscar Material";
            // 
            // btGuardar
            // 
            this.btGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btGuardar.Image = global::Facturacion_Vista.Properties.Resources.new_ico;
            this.btGuardar.Location = new System.Drawing.Point(2, 198);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(86, 31);
            this.btGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btGuardar.TabIndex = 5;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // FrmListaTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 229);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.dtlista);
            this.DoubleBuffered = true;
            this.Name = "FrmListaTarifa";
            this.Text = "FrmListaTarifa";
            ((System.ComponentModel.ISupportInitialize)(this.dtlista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.Editors.ComboItem cbxitemTodos;
        private DevComponents.Editors.ComboItem cbxActivos;
        private DevComponents.Editors.ComboItem cbxDesactivos;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtlista;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private DevComponents.DotNetBar.ButtonItem buttonNuevo;
        private DevComponents.DotNetBar.ComboBoxItem comboBoxItem1;
        private DevComponents.DotNetBar.ButtonItem buttonBuscar;
        private DevComponents.DotNetBar.ButtonX btGuardar;
    }
}