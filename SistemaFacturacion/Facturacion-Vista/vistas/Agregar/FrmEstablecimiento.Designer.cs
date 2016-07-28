namespace Facturacion_Vista.Vistas.Agregar
{
    partial class FrmEstablecimiento
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.group = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rdDesactivo = new System.Windows.Forms.RadioButton();
            this.rdActivo = new System.Windows.Forms.RadioButton();
            this.txtDireccion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btCancelar = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(16, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(167, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Nombre del establecimiento: ";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(16, 70);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(167, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Dirección del establecimiento: ";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(16, 125);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Estado: ";
            // 
            // group
            // 
            this.group.CanvasColor = System.Drawing.SystemColors.Control;
            this.group.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.group.Controls.Add(this.rdDesactivo);
            this.group.Controls.Add(this.rdActivo);
            this.group.Controls.Add(this.txtDireccion);
            this.group.Controls.Add(this.txtNombre);
            this.group.Controls.Add(this.labelX1);
            this.group.Controls.Add(this.labelX3);
            this.group.Controls.Add(this.labelX2);
            this.group.DisabledBackColor = System.Drawing.Color.Empty;
            this.group.Location = new System.Drawing.Point(12, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(429, 185);
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
            this.group.TabIndex = 3;
            this.group.Text = "Datos del nuevo establecimiento";
            // 
            // rdDesactivo
            // 
            this.rdDesactivo.AutoSize = true;
            this.rdDesactivo.BackColor = System.Drawing.Color.Transparent;
            this.rdDesactivo.Location = new System.Drawing.Point(323, 131);
            this.rdDesactivo.Name = "rdDesactivo";
            this.rdDesactivo.Size = new System.Drawing.Size(73, 17);
            this.rdDesactivo.TabIndex = 6;
            this.rdDesactivo.TabStop = true;
            this.rdDesactivo.Text = "Desactivo";
            this.rdDesactivo.UseVisualStyleBackColor = false;
            this.rdDesactivo.CheckedChanged += new System.EventHandler(this.rdDesactivo_CheckedChanged);
            // 
            // rdActivo
            // 
            this.rdActivo.AutoSize = true;
            this.rdActivo.BackColor = System.Drawing.Color.Transparent;
            this.rdActivo.Location = new System.Drawing.Point(178, 130);
            this.rdActivo.Name = "rdActivo";
            this.rdActivo.Size = new System.Drawing.Size(55, 17);
            this.rdActivo.TabIndex = 5;
            this.rdActivo.TabStop = true;
            this.rdActivo.Text = "Activo";
            this.rdActivo.UseVisualStyleBackColor = false;
            this.rdActivo.CheckedChanged += new System.EventHandler(this.rdActivo_CheckedChanged);
            // 
            // txtDireccion
            // 
            // 
            // 
            // 
            this.txtDireccion.Border.Class = "TextBoxBorder";
            this.txtDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDireccion.Location = new System.Drawing.Point(178, 70);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PreventEnterBeep = true;
            this.txtDireccion.Size = new System.Drawing.Size(230, 38);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.Border.Class = "TextBoxBorder";
            this.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombre.Location = new System.Drawing.Point(178, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PreventEnterBeep = true;
            this.txtNombre.Size = new System.Drawing.Size(230, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btGuardar
            // 
            this.btGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btGuardar.Image = global::Facturacion_Vista.Properties.Resources.save_ico;
            this.btGuardar.Location = new System.Drawing.Point(64, 209);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(100, 44);
            this.btGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btGuardar.TabIndex = 4;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCancelar.Image = global::Facturacion_Vista.Properties.Resources.cancel_ico;
            this.btCancelar.Location = new System.Drawing.Point(279, 209);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(96, 44);
            this.btCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEstablecimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 258);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.group);
            this.DoubleBuffered = true;
            this.Name = "FrmEstablecimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmEstablecimiento";
            this.Load += new System.EventHandler(this.FrmEstablecimiento_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.GroupPanel group;
        private System.Windows.Forms.RadioButton rdDesactivo;
        private System.Windows.Forms.RadioButton rdActivo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDireccion;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombre;
        private DevComponents.DotNetBar.ButtonX btGuardar;
        private DevComponents.DotNetBar.ButtonX btCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}