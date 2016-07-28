namespace Facturacion_Vista.Vistas.Agregar
{
    partial class FrmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.group = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnImagen = new DevComponents.DotNetBar.ButtonX();
            this.pictureProducto = new System.Windows.Forms.PictureBox();
           this.textDescuento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textPrecio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comboTipoPro = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.textDescPro = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnDetalle = new DevComponents.DotNetBar.ButtonX();
            this.btnIngresar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(3, 22);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(127, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Descripcion Prodcuto";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(3, 62);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Tipo Prodcuto";
            // 
            // group
            // 
            this.group.CanvasColor = System.Drawing.SystemColors.Control;
            this.group.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.group.Controls.Add(this.btnImagen);
            this.group.Controls.Add(this.pictureProducto);
            
            this.group.Controls.Add(this.textDescuento);
            this.group.Controls.Add(this.textPrecio);
            this.group.Controls.Add(this.comboTipoPro);
            this.group.Controls.Add(this.textDescPro);
            this.group.Controls.Add(this.labelX3);
            this.group.Controls.Add(this.labelX2);
            this.group.DisabledBackColor = System.Drawing.Color.Empty;
            this.group.Location = new System.Drawing.Point(31, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(671, 219);
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
            this.group.Text = "Informacion Necesario";
            // 
            // btnImagen
            // 
            this.btnImagen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImagen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnImagen.Image")));
            this.btnImagen.Location = new System.Drawing.Point(314, 146);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(42, 39);
            this.btnImagen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImagen.TabIndex = 11;
            this.btnImagen.Tooltip = "Agregar Imagen";
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // pictureProducto
            // 
            this.pictureProducto.Location = new System.Drawing.Point(375, 3);
            this.pictureProducto.Name = "pictureProducto";
            this.pictureProducto.Size = new System.Drawing.Size(277, 182);
            this.pictureProducto.TabIndex = 10;
            this.pictureProducto.TabStop = false;
            
            // 
            // textDescuento
            // 
            // 
            // 
            // 
            this.textDescuento.Border.Class = "TextBoxBorder";
            this.textDescuento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textDescuento.Location = new System.Drawing.Point(239, 107);
            this.textDescuento.Name = "textDescuento";
            this.textDescuento.PreventEnterBeep = true;
            this.textDescuento.Size = new System.Drawing.Size(100, 20);
            this.textDescuento.TabIndex = 7;
            // 
            // textPrecio
            // 
            // 
            // 
            // 
            this.textPrecio.Border.Class = "TextBoxBorder";
            this.textPrecio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textPrecio.Location = new System.Drawing.Point(63, 107);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.PreventEnterBeep = true;
            this.textPrecio.Size = new System.Drawing.Size(84, 20);
            this.textPrecio.TabIndex = 6;
            // 
            // comboTipoPro
            // 
            this.comboTipoPro.DisplayMember = "Text";
            this.comboTipoPro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTipoPro.FormattingEnabled = true;
            this.comboTipoPro.ItemHeight = 14;
            this.comboTipoPro.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.comboTipoPro.Location = new System.Drawing.Point(133, 61);
            this.comboTipoPro.Name = "comboTipoPro";
            this.comboTipoPro.Size = new System.Drawing.Size(207, 20);
            this.comboTipoPro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboTipoPro.TabIndex = 5;
            this.comboTipoPro.WatermarkText = "SELECCIONE";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "NORMAL";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "A MEDIDA";
            // 
            // textDescPro
            // 
            // 
            // 
            // 
            this.textDescPro.Border.Class = "TextBoxBorder";
            this.textDescPro.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textDescPro.Location = new System.Drawing.Point(133, 22);
            this.textDescPro.Name = "textDescPro";
            this.textDescPro.PreventEnterBeep = true;
            this.textDescPro.Size = new System.Drawing.Size(207, 20);
            this.textDescPro.TabIndex = 4;
            // 
            // dataGridViewX1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewX1.EnableHeadersVisualStyles = false;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(31, 290);
            this.dataGridViewX1.Name = "dataGridViewX1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewX1.Size = new System.Drawing.Size(671, 168);
            this.dataGridViewX1.TabIndex = 7;
            // 
            // btnDetalle
            // 
            this.btnDetalle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDetalle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalle.Image")));
            this.btnDetalle.Location = new System.Drawing.Point(32, 248);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(39, 36);
            this.btnDetalle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDetalle.TabIndex = 6;
            this.btnDetalle.Tooltip = "Añadir Detalle Producto";
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIngresar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.Location = new System.Drawing.Point(253, 464);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(85, 38);
            this.btnIngresar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(386, 464);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 38);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 508);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.group);
            this.DoubleBuffered = true;
            this.Name = "FrmProducto";
            this.Text = "Ingreso de Producto";
            this.group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.GroupPanel group;
        private DevComponents.DotNetBar.ButtonX btnDetalle;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboTipoPro;
        private DevComponents.DotNetBar.Controls.TextBoxX textDescPro;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.ButtonX btnIngresar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textDescuento;
        private DevComponents.DotNetBar.Controls.TextBoxX textPrecio;
        private DevComponents.DotNetBar.ButtonX btnImagen;
        private System.Windows.Forms.PictureBox pictureProducto;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}