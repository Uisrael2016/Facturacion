namespace Facturacion_Vista.Vistas.Agregar
{
    partial class FrmCodigo_Documento
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
            this.txtdocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtcodigo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btguardar = new DevComponents.DotNetBar.ButtonX();
            this.btcancelar = new DevComponents.DotNetBar.ButtonX();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.CanvasColor = System.Drawing.SystemColors.Control;
            this.group.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.group.Controls.Add(this.txtdocumento);
            this.group.Controls.Add(this.txtcodigo);
            this.group.Controls.Add(this.labelX2);
            this.group.Controls.Add(this.labelX1);
            this.group.DisabledBackColor = System.Drawing.Color.Empty;
            this.group.Location = new System.Drawing.Point(12, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(371, 143);
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
            this.group.TabIndex = 10;
            this.group.Text = "groupPanel1";
            // 
            // txtdocumento
            // 
            // 
            // 
            // 
            this.txtdocumento.Border.Class = "TextBoxBorder";
            this.txtdocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdocumento.Location = new System.Drawing.Point(151, 75);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.PreventEnterBeep = true;
            this.txtdocumento.Size = new System.Drawing.Size(170, 20);
            this.txtdocumento.TabIndex = 3;
            // 
            // txtcodigo
            // 
            // 
            // 
            // 
            this.txtcodigo.Border.Class = "TextBoxBorder";
            this.txtcodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcodigo.Location = new System.Drawing.Point(151, 18);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PreventEnterBeep = true;
            this.txtcodigo.Size = new System.Drawing.Size(170, 20);
            this.txtcodigo.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(34, 75);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Documento";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(34, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Codigo";
            // 
            // btguardar
            // 
            this.btguardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btguardar.BackColor = System.Drawing.Color.Transparent;
            this.btguardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btguardar.Image = global::Facturacion_Vista.Properties.Resources.save_ico;
            this.btguardar.Location = new System.Drawing.Point(60, 175);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(78, 25);
            this.btguardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btguardar.TabIndex = 12;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btcancelar.BackColor = System.Drawing.Color.Transparent;
            this.btcancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btcancelar.Image = global::Facturacion_Vista.Properties.Resources.cancel_ico;
            this.btcancelar.Location = new System.Drawing.Point(249, 175);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(81, 25);
            this.btcancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btcancelar.TabIndex = 11;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // FrmCodigo_Documento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 226);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.group);
            this.DoubleBuffered = true;
            this.Name = "FrmCodigo_Documento";
            this.Text = "FrmCodigo_Documento";
            this.group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btguardar;
        private DevComponents.DotNetBar.ButtonX btcancelar;
        private DevComponents.DotNetBar.Controls.GroupPanel group;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdocumento;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcodigo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ErrorProvider erroricono;
    }
}