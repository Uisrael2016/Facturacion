namespace Facturacion_Vista.Vistas.Agregar
{
    partial class FrmPuntoEmision
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
            this.rdDesactivo = new System.Windows.Forms.RadioButton();
            this.rdActivo = new System.Windows.Forms.RadioButton();
            this.txtCodigo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lbCodigo = new DevComponents.DotNetBar.LabelX();
            this.lbEstablecimiento = new DevComponents.DotNetBar.LabelX();
            this.cbEstablecimiento = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btCancelar = new DevComponents.DotNetBar.ButtonX();
            this.btGuardar = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.CanvasColor = System.Drawing.SystemColors.Control;
            this.group.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.group.Controls.Add(this.rdDesactivo);
            this.group.Controls.Add(this.rdActivo);
            this.group.Controls.Add(this.txtCodigo);
            this.group.Controls.Add(this.labelX3);
            this.group.Controls.Add(this.lbCodigo);
            this.group.Controls.Add(this.lbEstablecimiento);
            this.group.Controls.Add(this.cbEstablecimiento);
            this.group.DisabledBackColor = System.Drawing.Color.Empty;
            this.group.Location = new System.Drawing.Point(12, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(421, 172);
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
            this.group.Text = "Información del nuevo punto de emisión";
            // 
            // rdDesactivo
            // 
            this.rdDesactivo.AutoSize = true;
            this.rdDesactivo.BackColor = System.Drawing.Color.Transparent;
            this.rdDesactivo.Location = new System.Drawing.Point(293, 113);
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
            this.rdActivo.Location = new System.Drawing.Point(202, 113);
            this.rdActivo.Name = "rdActivo";
            this.rdActivo.Size = new System.Drawing.Size(55, 17);
            this.rdActivo.TabIndex = 5;
            this.rdActivo.TabStop = true;
            this.rdActivo.Text = "Activo";
            this.rdActivo.UseVisualStyleBackColor = false;
            this.rdActivo.CheckedChanged += new System.EventHandler(this.rdActivo_CheckedChanged);
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.Border.Class = "TextBoxBorder";
            this.txtCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodigo.Location = new System.Drawing.Point(202, 63);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PreventEnterBeep = true;
            this.txtCodigo.Size = new System.Drawing.Size(176, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.WatermarkText = "MTR1 , SCR1";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(33, 114);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(146, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Estado";
            // 
            // lbCodigo
            // 
            this.lbCodigo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbCodigo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbCodigo.Location = new System.Drawing.Point(33, 64);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(146, 23);
            this.lbCodigo.TabIndex = 2;
            this.lbCodigo.Text = "Codigo del punto de emisión";
            // 
            // lbEstablecimiento
            // 
            this.lbEstablecimiento.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbEstablecimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbEstablecimiento.Location = new System.Drawing.Point(33, 21);
            this.lbEstablecimiento.Name = "lbEstablecimiento";
            this.lbEstablecimiento.Size = new System.Drawing.Size(146, 23);
            this.lbEstablecimiento.TabIndex = 1;
            this.lbEstablecimiento.Text = "Establecimiento";
            // 
            // cbEstablecimiento
            // 
            this.cbEstablecimiento.DisplayMember = "Text";
            this.cbEstablecimiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstablecimiento.FormattingEnabled = true;
            this.cbEstablecimiento.ItemHeight = 14;
            this.cbEstablecimiento.Location = new System.Drawing.Point(202, 24);
            this.cbEstablecimiento.Name = "cbEstablecimiento";
            this.cbEstablecimiento.Size = new System.Drawing.Size(176, 20);
            this.cbEstablecimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEstablecimiento.TabIndex = 0;
            this.cbEstablecimiento.SelectedIndexChanged += new System.EventHandler(this.cbEstablecimiento_SelectedIndexChanged);
            // 
            // btCancelar
            // 
            this.btCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCancelar.Image = global::Facturacion_Vista.Properties.Resources.cancel_ico;
            this.btCancelar.Location = new System.Drawing.Point(272, 199);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(111, 44);
            this.btCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btGuardar.Image = global::Facturacion_Vista.Properties.Resources.save_ico;
            this.btGuardar.Location = new System.Drawing.Point(83, 199);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(111, 44);
            this.btGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btGuardar.TabIndex = 4;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmPuntoEmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 253);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.group);
            this.DoubleBuffered = true;
            this.Name = "FrmPuntoEmision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPuntoEmision";
            this.Load += new System.EventHandler(this.FrmPuntoEmision_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btCancelar;
        private DevComponents.DotNetBar.ButtonX btGuardar;
        private DevComponents.DotNetBar.Controls.GroupPanel group;
        private System.Windows.Forms.RadioButton rdDesactivo;
        private System.Windows.Forms.RadioButton rdActivo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodigo;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lbCodigo;
        private DevComponents.DotNetBar.LabelX lbEstablecimiento;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbEstablecimiento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}