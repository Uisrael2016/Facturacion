namespace Facturacion_Vista.Vistas.Agregar
{
    partial class FrmTarifa
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
            this.radioD = new System.Windows.Forms.RadioButton();
            this.radioH = new System.Windows.Forms.RadioButton();
            this.estdoLbl = new System.Windows.Forms.Label();
            this.txtvalor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.btguardar = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.CanvasColor = System.Drawing.SystemColors.Control;
            this.group.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.group.Controls.Add(this.radioD);
            this.group.Controls.Add(this.radioH);
            this.group.Controls.Add(this.estdoLbl);
            this.group.Controls.Add(this.txtvalor);
            this.group.Controls.Add(this.labelX1);
            this.group.DisabledBackColor = System.Drawing.Color.Empty;
            this.group.Location = new System.Drawing.Point(12, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(391, 124);
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
            this.group.TabIndex = 8;
            this.group.Text = "groupPanel1";
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.BackColor = System.Drawing.Color.Transparent;
            this.radioD.Location = new System.Drawing.Point(239, 61);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(95, 17);
            this.radioD.TabIndex = 20;
            this.radioD.TabStop = true;
            this.radioD.Text = "Desahabilitado";
            this.radioD.UseVisualStyleBackColor = false;
            this.radioD.CheckedChanged += new System.EventHandler(this.radioD_CheckedChanged);
            // 
            // radioH
            // 
            this.radioH.AutoSize = true;
            this.radioH.BackColor = System.Drawing.Color.Transparent;
            this.radioH.Location = new System.Drawing.Point(151, 61);
            this.radioH.Name = "radioH";
            this.radioH.Size = new System.Drawing.Size(72, 17);
            this.radioH.TabIndex = 19;
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
            this.estdoLbl.Location = new System.Drawing.Point(30, 61);
            this.estdoLbl.Name = "estdoLbl";
            this.estdoLbl.Size = new System.Drawing.Size(50, 19);
            this.estdoLbl.TabIndex = 18;
            this.estdoLbl.Text = "Estado";
            // 
            // txtvalor
            // 
            // 
            // 
            // 
            this.txtvalor.Border.Class = "TextBoxBorder";
            this.txtvalor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtvalor.Location = new System.Drawing.Point(151, 18);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.PreventEnterBeep = true;
            this.txtvalor.Size = new System.Drawing.Size(170, 20);
            this.txtvalor.TabIndex = 2;
            this.txtvalor.WatermarkText = "Ingrese el valor de la Tarifa";
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
            this.labelX1.Text = "Valor ";
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // btguardar
            // 
            this.btguardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btguardar.BackColor = System.Drawing.Color.Transparent;
            this.btguardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btguardar.Image = global::Facturacion_Vista.Properties.Resources.save_ico;
            this.btguardar.Location = new System.Drawing.Point(62, 153);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(78, 28);
            this.btguardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btguardar.TabIndex = 11;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.Color.Transparent;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::Facturacion_Vista.Properties.Resources.cancel_ico;
            this.buttonX2.Location = new System.Drawing.Point(251, 153);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(81, 28);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 10;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // FrmTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 194);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.group);
            this.DoubleBuffered = true;
            this.Name = "FrmTarifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmTarifa";
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel group;
        private DevComponents.DotNetBar.Controls.TextBoxX txtvalor;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btguardar;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.Label estdoLbl;
        private System.Windows.Forms.ErrorProvider erroricono;
        public System.Windows.Forms.RadioButton radioH;
        public System.Windows.Forms.RadioButton radioD;
    }
}