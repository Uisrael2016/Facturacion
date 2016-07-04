namespace Facturacion_Vista.Vistas
{
    partial class FrmProveedores
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
            this.group = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtreprlegal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.radioD = new System.Windows.Forms.RadioButton();
            this.radioH = new System.Windows.Forms.RadioButton();
            this.estdoLbl = new System.Windows.Forms.Label();
            this.cbxTipoDocumento = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtTelefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDireccion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRazonSocial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btguardar = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.CanvasColor = System.Drawing.SystemColors.Control;
            this.group.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.group.Controls.Add(this.txtreprlegal);
            this.group.Controls.Add(this.labelX4);
            this.group.Controls.Add(this.radioD);
            this.group.Controls.Add(this.radioH);
            this.group.Controls.Add(this.estdoLbl);
            this.group.Controls.Add(this.cbxTipoDocumento);
            this.group.Controls.Add(this.txtTelefono);
            this.group.Controls.Add(this.txtDireccion);
            this.group.Controls.Add(this.txtEmail);
            this.group.Controls.Add(this.txtRazonSocial);
            this.group.Controls.Add(this.txtDocumento);
            this.group.Controls.Add(this.labelX7);
            this.group.Controls.Add(this.labelX6);
            this.group.Controls.Add(this.labelX5);
            this.group.Controls.Add(this.labelX3);
            this.group.Controls.Add(this.labelX2);
            this.group.Controls.Add(this.labelX1);
            this.group.DisabledBackColor = System.Drawing.Color.Empty;
            this.group.Location = new System.Drawing.Point(12, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(556, 526);
            // 
            // 
            // 
            this.group.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.group.Style.BackColorGradientAngle = 90;
            this.group.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.group.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.group.Style.BorderBottomWidth = 1;
            this.group.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.group.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.group.Style.BorderLeftWidth = 1;
            this.group.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.group.Style.BorderRightWidth = 1;
            this.group.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.group.Style.BorderTopWidth = 1;
            this.group.Style.CornerDiameter = 4;
            this.group.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.group.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.group.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.group.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.group.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.group.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.group.TabIndex = 1;
            this.group.Text = "Datos Proveedor";
            this.group.Click += new System.EventHandler(this.groupMantenimiento_Click);
            // 
            // txtreprlegal
            // 
            // 
            // 
            // 
            this.txtreprlegal.Border.Class = "TextBoxBorder";
            this.txtreprlegal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtreprlegal.Location = new System.Drawing.Point(166, 197);
            this.txtreprlegal.Name = "txtreprlegal";
            this.txtreprlegal.PreventEnterBeep = true;
            this.txtreprlegal.Size = new System.Drawing.Size(247, 20);
            this.txtreprlegal.TabIndex = 19;
            this.txtreprlegal.WatermarkText = "Representante Legal";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(37, 188);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(110, 29);
            this.labelX4.TabIndex = 18;
            this.labelX4.Text = "Representante Legal";
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.BackColor = System.Drawing.Color.Transparent;
            this.radioD.Location = new System.Drawing.Point(303, 310);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(95, 17);
            this.radioD.TabIndex = 17;
            this.radioD.TabStop = true;
            this.radioD.Text = "Desahabilitado";
            this.radioD.UseVisualStyleBackColor = false;
            this.radioD.CheckedChanged += new System.EventHandler(this.radioD_CheckedChanged);
            // 
            // radioH
            // 
            this.radioH.AutoSize = true;
            this.radioH.BackColor = System.Drawing.Color.Transparent;
            this.radioH.Location = new System.Drawing.Point(166, 308);
            this.radioH.Name = "radioH";
            this.radioH.Size = new System.Drawing.Size(72, 17);
            this.radioH.TabIndex = 16;
            this.radioH.TabStop = true;
            this.radioH.Text = "Habilitado";
            this.radioH.UseVisualStyleBackColor = false;
            this.radioH.CheckedChanged += new System.EventHandler(this.radioH_CheckedChanged);
            // 
            // estdoLbl
            // 
            this.estdoLbl.AutoSize = true;
            this.estdoLbl.BackColor = System.Drawing.Color.Transparent;
            this.estdoLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estdoLbl.Location = new System.Drawing.Point(33, 308);
            this.estdoLbl.Name = "estdoLbl";
            this.estdoLbl.Size = new System.Drawing.Size(50, 19);
            this.estdoLbl.TabIndex = 15;
            this.estdoLbl.Text = "Estado";
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.DisplayMember = "Text";
            this.cbxTipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.ItemHeight = 14;
            this.cbxTipoDocumento.Location = new System.Drawing.Point(166, 34);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(247, 20);
            this.cbxTipoDocumento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxTipoDocumento.TabIndex = 14;
            this.cbxTipoDocumento.WatermarkText = "SELECCIONE";
            this.cbxTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cbxTipoDocumento_SelectedIndexChanged);
            this.cbxTipoDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTipoDocumento_KeyPress);
            // 
            // txtTelefono
            // 
            // 
            // 
            // 
            this.txtTelefono.Border.Class = "TextBoxBorder";
            this.txtTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTelefono.Location = new System.Drawing.Point(166, 424);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PreventEnterBeep = true;
            this.txtTelefono.Size = new System.Drawing.Size(247, 20);
            this.txtTelefono.TabIndex = 13;
            this.txtTelefono.WatermarkText = "593(__)(_______)";
            // 
            // txtDireccion
            // 
            // 
            // 
            // 
            this.txtDireccion.Border.Class = "TextBoxBorder";
            this.txtDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDireccion.Location = new System.Drawing.Point(166, 364);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PreventEnterBeep = true;
            this.txtDireccion.Size = new System.Drawing.Size(247, 20);
            this.txtDireccion.TabIndex = 12;
            this.txtDireccion.WatermarkText = "Su direccion Domiciliario";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.Location = new System.Drawing.Point(166, 246);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PreventEnterBeep = true;
            this.txtEmail.Size = new System.Drawing.Size(247, 20);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.WatermarkText = "ejemplo@hotmail.com";
            // 
            // txtRazonSocial
            // 
            // 
            // 
            // 
            this.txtRazonSocial.Border.Class = "TextBoxBorder";
            this.txtRazonSocial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRazonSocial.Location = new System.Drawing.Point(166, 144);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PreventEnterBeep = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(247, 20);
            this.txtRazonSocial.TabIndex = 9;
            this.txtRazonSocial.WatermarkText = "Razon Social";
            // 
            // txtDocumento
            // 
            // 
            // 
            // 
            this.txtDocumento.Border.Class = "TextBoxBorder";
            this.txtDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocumento.Location = new System.Drawing.Point(166, 85);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PreventEnterBeep = true;
            this.txtDocumento.Size = new System.Drawing.Size(247, 20);
            this.txtDocumento.TabIndex = 8;
            this.txtDocumento.WatermarkText = "Ingrese su Identificacion";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(37, 415);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(87, 29);
            this.labelX7.TabIndex = 6;
            this.labelX7.Text = "Telefono";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(37, 355);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(123, 29);
            this.labelX6.TabIndex = 5;
            this.labelX6.Text = "Direccion de Domicilio";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(37, 240);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(87, 29);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Email";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(37, 135);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(110, 29);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Razon Social";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(37, 85);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(87, 29);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Nro. Cedula";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(37, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(110, 29);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tipo de Documento";
            // 
            // btguardar
            // 
            this.btguardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btguardar.BackColor = System.Drawing.Color.Transparent;
            this.btguardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btguardar.Image = global::Facturacion_Vista.Properties.Resources.save_ico;
            this.btguardar.Location = new System.Drawing.Point(90, 555);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(85, 41);
            this.btguardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btguardar.TabIndex = 6;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.Color.Transparent;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::Facturacion_Vista.Properties.Resources.cancel_ico;
            this.buttonX2.Location = new System.Drawing.Point(332, 555);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(95, 41);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 5;
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 608);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.group);
            this.DoubleBuffered = true;
            this.Name = "FrmProveedores";
            this.Text = "FrmProveedores";
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel group;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cbxTipoDocumento;
        public DevComponents.DotNetBar.Controls.TextBoxX txtTelefono;
        public DevComponents.DotNetBar.Controls.TextBoxX txtDireccion;
        public DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        public DevComponents.DotNetBar.Controls.TextBoxX txtRazonSocial;
        public DevComponents.DotNetBar.Controls.TextBoxX txtDocumento;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btguardar;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.RadioButton radioH;
        private System.Windows.Forms.Label estdoLbl;
        public DevComponents.DotNetBar.Controls.TextBoxX txtreprlegal;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.ErrorProvider erroricono;
    }
}