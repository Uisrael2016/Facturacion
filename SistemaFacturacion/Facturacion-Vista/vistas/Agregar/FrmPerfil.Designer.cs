namespace Facturacion_Vista.Vistas.Agregar
{
    partial class FrmPerfil
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCodigo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rdActivo = new System.Windows.Forms.RadioButton();
            this.rdDesactivo = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btCancelar = new DevComponents.DotNetBar.ButtonX();
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
            this.group.Controls.Add(this.txtDescripcion);
            this.group.Controls.Add(this.labelX3);
            this.group.Controls.Add(this.labelX2);
            this.group.Controls.Add(this.labelX1);
            this.group.DisabledBackColor = System.Drawing.Color.Empty;
            this.group.Location = new System.Drawing.Point(12, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(412, 211);
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
            this.group.TabIndex = 0;
            this.group.Text = "Ingreso de nuevo Perfil";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(29, 40);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(118, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Descripción del perfil";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(29, 86);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(118, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Codigo";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(29, 141);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(118, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Estado";
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.Border.Class = "TextBoxBorder";
            this.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcion.Location = new System.Drawing.Point(153, 42);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PreventEnterBeep = true;
            this.txtDescripcion.Size = new System.Drawing.Size(212, 20);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.Border.Class = "TextBoxBorder";
            this.txtCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(153, 88);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PreventEnterBeep = true;
            this.txtCodigo.Size = new System.Drawing.Size(212, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // rdActivo
            // 
            this.rdActivo.AutoSize = true;
            this.rdActivo.BackColor = System.Drawing.Color.Transparent;
            this.rdActivo.Location = new System.Drawing.Point(153, 141);
            this.rdActivo.Name = "rdActivo";
            this.rdActivo.Size = new System.Drawing.Size(55, 17);
            this.rdActivo.TabIndex = 5;
            this.rdActivo.TabStop = true;
            this.rdActivo.Text = "Activo";
            this.rdActivo.UseVisualStyleBackColor = false;
            this.rdActivo.CheckedChanged += new System.EventHandler(this.rdActivado_CheckedChanged);
            // 
            // rdDesactivo
            // 
            this.rdDesactivo.AutoSize = true;
            this.rdDesactivo.BackColor = System.Drawing.Color.Transparent;
            this.rdDesactivo.Location = new System.Drawing.Point(292, 144);
            this.rdDesactivo.Name = "rdDesactivo";
            this.rdDesactivo.Size = new System.Drawing.Size(73, 17);
            this.rdDesactivo.TabIndex = 6;
            this.rdDesactivo.TabStop = true;
            this.rdDesactivo.Text = "Desactivo";
            this.rdDesactivo.UseVisualStyleBackColor = false;
            this.rdDesactivo.CheckedChanged += new System.EventHandler(this.rdDesactivado_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btGuardar
            // 
            this.btGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btGuardar.Image = global::Facturacion_Vista.Properties.Resources.save_ico;
            this.btGuardar.Location = new System.Drawing.Point(68, 239);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(94, 44);
            this.btGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btGuardar.TabIndex = 1;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCancelar.Image = global::Facturacion_Vista.Properties.Resources.cancel_ico;
            this.btCancelar.Location = new System.Drawing.Point(286, 239);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(94, 44);
            this.btCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 294);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.group);
            this.DoubleBuffered = true;
            this.Name = "FrmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPerfil";
            this.Load += new System.EventHandler(this.FrmPerfil_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel group;
        private System.Windows.Forms.RadioButton rdDesactivo;
        private System.Windows.Forms.RadioButton rdActivo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodigo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.ButtonX btCancelar;
        private DevComponents.DotNetBar.ButtonX btGuardar;
    }
}