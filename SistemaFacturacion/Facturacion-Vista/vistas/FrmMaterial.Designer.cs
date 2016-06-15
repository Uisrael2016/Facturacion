namespace Facturacion_Vista.Vistas
{
    partial class FrmMaterial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterial));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.comboProveedor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboTipoMaterial = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.textDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textCantidad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.buttonGuardar = new DevComponents.DotNetBar.ButtonX();
            this.buttonCancelar = new DevComponents.DotNetBar.ButtonX();
            this.groupMantenimiento = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Silver;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(16, 117);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Proveedor";
            // 
            // comboProveedor
            // 
            this.comboProveedor.DisplayMember = "Text";
            this.comboProveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboProveedor.FormattingEnabled = true;
            this.comboProveedor.ItemHeight = 14;
            this.comboProveedor.Location = new System.Drawing.Point(135, 119);
            this.comboProveedor.Name = "comboProveedor";
            this.comboProveedor.Size = new System.Drawing.Size(163, 20);
            this.comboProveedor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboProveedor.TabIndex = 3;
            this.comboProveedor.Text = "SELECCIONE";
            this.comboProveedor.SelectedIndexChanged += new System.EventHandler(this.comboProveedor_SelectedIndexChanged);
            // 
            // comboTipoMaterial
            // 
            this.comboTipoMaterial.DisplayMember = "Text";
            this.comboTipoMaterial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTipoMaterial.FormattingEnabled = true;
            this.comboTipoMaterial.ItemHeight = 14;
            this.comboTipoMaterial.Location = new System.Drawing.Point(135, 160);
            this.comboTipoMaterial.Name = "comboTipoMaterial";
            this.comboTipoMaterial.Size = new System.Drawing.Size(163, 20);
            this.comboTipoMaterial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboTipoMaterial.TabIndex = 4;
            this.comboTipoMaterial.Text = "SELECCIONE";
            this.comboTipoMaterial.SelectedIndexChanged += new System.EventHandler(this.comboTipoMaterial_SelectedIndexChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(16, 157);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tipo Material";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(16, 29);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Descripcion";
            // 
            // textDescripcion
            // 
            // 
            // 
            // 
            this.textDescripcion.Border.Class = "TextBoxBorder";
            this.textDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textDescripcion.Location = new System.Drawing.Point(135, 32);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.PreventEnterBeep = true;
            this.textDescripcion.Size = new System.Drawing.Size(163, 20);
            this.textDescripcion.TabIndex = 1;
            // 
            // textCantidad
            // 
            // 
            // 
            // 
            this.textCantidad.Border.Class = "TextBoxBorder";
            this.textCantidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textCantidad.Location = new System.Drawing.Point(135, 75);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.PreventEnterBeep = true;
            this.textCantidad.Size = new System.Drawing.Size(163, 20);
            this.textCantidad.TabIndex = 2;
            this.textCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCantidad_KeyPress);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(16, 72);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Cantidad";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonGuardar.Image = global::Facturacion_Vista.Properties.Resources.save_ico;
            this.buttonGuardar.Location = new System.Drawing.Point(97, 261);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(87, 38);
            this.buttonGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCancelar.Image = global::Facturacion_Vista.Properties.Resources.cancel_ico;
            this.buttonCancelar.Location = new System.Drawing.Point(271, 261);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(85, 38);
            this.buttonCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // groupMantenimiento
            // 
            this.groupMantenimiento.Controls.Add(this.textDescripcion);
            this.groupMantenimiento.Controls.Add(this.labelX3);
            this.groupMantenimiento.Controls.Add(this.labelX1);
            this.groupMantenimiento.Controls.Add(this.textCantidad);
            this.groupMantenimiento.Controls.Add(this.labelX2);
            this.groupMantenimiento.Controls.Add(this.comboTipoMaterial);
            this.groupMantenimiento.Controls.Add(this.labelX4);
            this.groupMantenimiento.Controls.Add(this.comboProveedor);
            this.groupMantenimiento.Location = new System.Drawing.Point(58, 28);
            this.groupMantenimiento.Name = "groupMantenimiento";
            this.groupMantenimiento.Size = new System.Drawing.Size(336, 209);
            this.groupMantenimiento.TabIndex = 10;
            this.groupMantenimiento.TabStop = false;
            this.groupMantenimiento.Text = "Ingreso de Información";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // FrmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 332);
            this.Controls.Add(this.groupMantenimiento);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMaterial";
            this.groupMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboProveedor;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboTipoMaterial;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textDescripcion;
        private DevComponents.DotNetBar.Controls.TextBoxX textCantidad;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX buttonGuardar;
        private DevComponents.DotNetBar.ButtonX buttonCancelar;
        private System.Windows.Forms.GroupBox groupMantenimiento;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}