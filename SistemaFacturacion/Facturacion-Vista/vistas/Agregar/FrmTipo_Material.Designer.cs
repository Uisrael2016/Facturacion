namespace Facturacion_Vista.Vistas.Agregar
{
    partial class FrmTipo_Material
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
            this.btCancelar = new DevComponents.DotNetBar.ButtonX();
            this.btAgregar = new DevComponents.DotNetBar.ButtonX();
            this.group = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCancelar.Image = global::Facturacion_Vista.Properties.Resources.cancel_ico;
            this.btCancelar.Location = new System.Drawing.Point(197, 138);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(96, 43);
            this.btCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btAgregar.Image = global::Facturacion_Vista.Properties.Resources.new_ico;
            this.btAgregar.Location = new System.Drawing.Point(48, 138);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(95, 43);
            this.btAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btAgregar.TabIndex = 4;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // group
            // 
            this.group.CanvasColor = System.Drawing.SystemColors.Control;
            this.group.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.group.Controls.Add(this.textBoxX1);
            this.group.Controls.Add(this.labelX1);
            this.group.DisabledBackColor = System.Drawing.Color.Empty;
            this.group.Location = new System.Drawing.Point(12, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(302, 108);
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
            this.group.Text = "Ingrese el tipo de material";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(103, 42);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(175, 20);
            this.textBoxX1.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(15, 39);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(93, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tipo de material: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmTipo_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 185);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.group);
            this.DoubleBuffered = true;
            this.Name = "FrmTipo_Material";
            this.Text = "FrmTipo_Material";
            this.Load += new System.EventHandler(this.FrmTipo_Material_Load);
            this.group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btCancelar;
        private DevComponents.DotNetBar.ButtonX btAgregar;
        private DevComponents.DotNetBar.Controls.GroupPanel group;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}