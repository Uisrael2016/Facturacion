namespace Facturacion_Vista.Vistas.Agregar
{
    partial class FrmUsuarioPerfil
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
            this.group = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbPerfil = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbUsuario = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbPuntoemision = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btCancelar = new DevComponents.DotNetBar.ButtonX();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.CanvasColor = System.Drawing.SystemColors.Control;
            this.group.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.group.Controls.Add(this.cbPerfil);
            this.group.Controls.Add(this.cbPuntoemision);
            this.group.Controls.Add(this.btCancelar);
            this.group.Controls.Add(this.btGuardar);
            this.group.Controls.Add(this.cbUsuario);
            this.group.Controls.Add(this.labelX3);
            this.group.Controls.Add(this.labelX2);
            this.group.Controls.Add(this.labelX1);
            this.group.DisabledBackColor = System.Drawing.Color.Empty;
            this.group.Location = new System.Drawing.Point(30, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(355, 369);
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
            this.group.Text = "Asignación de perfiles";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(51, 102);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tipo de perfil :";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(51, 172);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Usuario :";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(51, 35);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(104, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Punto de emisión :";
            // 
            // cbPerfil
            // 
            this.cbPerfil.DisplayMember = "Text";
            this.cbPerfil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.ItemHeight = 14;
            this.cbPerfil.Location = new System.Drawing.Point(158, 105);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(178, 20);
            this.cbPerfil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbPerfil.TabIndex = 3;
            this.cbPerfil.SelectedIndexChanged += new System.EventHandler(this.cbTipoPerfil_SelectedIndexChanged);
            // 
            // cbUsuario
            // 
            this.cbUsuario.DisplayMember = "Text";
            this.cbUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.ItemHeight = 14;
            this.cbUsuario.Location = new System.Drawing.Point(158, 172);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(178, 20);
            this.cbUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbUsuario.TabIndex = 4;
            this.cbUsuario.SelectedIndexChanged += new System.EventHandler(this.cbUsuario_SelectedIndexChanged);
            // 
            // cbPuntoemision
            // 
            this.cbPuntoemision.DisplayMember = "Text";
            this.cbPuntoemision.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPuntoemision.FormattingEnabled = true;
            this.cbPuntoemision.ItemHeight = 14;
            this.cbPuntoemision.Location = new System.Drawing.Point(161, 38);
            this.cbPuntoemision.Name = "cbPuntoemision";
            this.cbPuntoemision.Size = new System.Drawing.Size(175, 20);
            this.cbPuntoemision.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbPuntoemision.TabIndex = 5;
            this.cbPuntoemision.SelectedIndexChanged += new System.EventHandler(this.cbTipoPuntoEmision_SelectedIndexChanged);
            // 
            // btGuardar
            // 
            this.btGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btGuardar.Image = global::Facturacion_Vista.Properties.Resources.save_ico;
            this.btGuardar.Location = new System.Drawing.Point(51, 262);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(104, 38);
            this.btGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btGuardar.TabIndex = 6;
            // 
            // btCancelar
            // 
            this.btCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCancelar.Image = global::Facturacion_Vista.Properties.Resources.cancel_ico;
            this.btCancelar.Location = new System.Drawing.Point(189, 262);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(104, 38);
            this.btCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FrmUsuarioPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 410);
            this.Controls.Add(this.group);
            this.DoubleBuffered = true;
            this.Name = "FrmUsuarioPerfil";
            this.Text = "FrmUsuarioPerfil";
            this.Load += new System.EventHandler(this.FrmUsuarioPerfil_Load);
            this.group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel group;
        private DevComponents.DotNetBar.ButtonX btGuardar;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbPuntoemision;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbUsuario;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbPerfil;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btCancelar;
    }
}