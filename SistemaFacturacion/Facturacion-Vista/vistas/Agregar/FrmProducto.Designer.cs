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
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnImagen = new DevComponents.DotNetBar.ButtonX();
            this.pictureProducto = new System.Windows.Forms.PictureBox();
            this.textDescuento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textPrecio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comboTipoPro = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.textDescPro = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtListaDetalle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnDetalle = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.textDescripcion = new DevComponents.DotNetBar.TextBoxItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.textCantidadDetalle = new DevComponents.DotNetBar.TextBoxItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnRemove = new DevComponents.DotNetBar.ButtonItem();
            this.btnIngresar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
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
            this.group.Controls.Add(this.labelX5);
            this.group.Controls.Add(this.labelX1);
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
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(174, 104);
            this.labelX5.Name = "labelX5";
            this.labelX5.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 15;
            this.labelX5.Text = "Descuento";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(3, 104);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(65, 23);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Precio";
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
            this.textDescuento.Location = new System.Drawing.Point(255, 107);
            this.textDescuento.Name = "textDescuento";
            this.textDescuento.PreventEnterBeep = true;
            this.textDescuento.Size = new System.Drawing.Size(84, 20);
            this.textDescuento.TabIndex = 7;
            this.textDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDescuento_KeyPress);
            // 
            // textPrecio
            // 
            // 
            // 
            // 
            this.textPrecio.Border.Class = "TextBoxBorder";
            this.textPrecio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textPrecio.Location = new System.Drawing.Point(78, 107);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.PreventEnterBeep = true;
            this.textPrecio.Size = new System.Drawing.Size(84, 20);
            this.textPrecio.TabIndex = 6;
            this.textPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecio_KeyPress);
            // 
            // comboTipoPro
            // 
            this.comboTipoPro.DisplayMember = "Text";
            this.comboTipoPro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTipoPro.FormattingEnabled = true;
            this.comboTipoPro.ItemHeight = 14;
            this.comboTipoPro.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem1,
            this.comboItem2});
            this.comboTipoPro.Location = new System.Drawing.Point(133, 61);
            this.comboTipoPro.Name = "comboTipoPro";
            this.comboTipoPro.Size = new System.Drawing.Size(207, 20);
            this.comboTipoPro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboTipoPro.TabIndex = 5;
            this.comboTipoPro.WatermarkText = "SELECCIONE";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "SELECCIONE";
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
            // dtListaDetalle
            // 
            this.dtListaDetalle.AllowUserToAddRows = false;
            this.dtListaDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtListaDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtListaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mat,
            this.descripcion,
            this.cantidad,
            this.color});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtListaDetalle.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtListaDetalle.EnableHeadersVisualStyles = false;
            this.dtListaDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtListaDetalle.Location = new System.Drawing.Point(33, 290);
            this.dtListaDetalle.Name = "dtListaDetalle";
            this.dtListaDetalle.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtListaDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtListaDetalle.RowHeadersVisible = false;
            this.dtListaDetalle.Size = new System.Drawing.Size(621, 168);
            this.dtListaDetalle.TabIndex = 7;
            // 
            // id
            // 
            this.id.FillWeight = 40.45308F;
            this.id.HeaderText = "N*";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // mat
            // 
            this.mat.FillWeight = 138.4445F;
            this.mat.HeaderText = "Material";
            this.mat.Name = "mat";
            this.mat.ReadOnly = true;
            this.mat.Width = 171;
            // 
            // descripcion
            // 
            this.descripcion.FillWeight = 157.8469F;
            this.descripcion.HeaderText = "Descripcion de Producto";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 195;
            // 
            // cantidad
            // 
            this.cantidad.FillWeight = 82.03371F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 102;
            // 
            // color
            // 
            this.color.FillWeight = 81.22178F;
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDetalle,
            this.labelItem1,
            this.textDescripcion,
            this.labelItem2,
            this.textCantidadDetalle,
            this.btnAdd,
            this.btnRemove});
            this.bar1.Location = new System.Drawing.Point(31, 240);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(623, 44);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 8;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnDetalle
            // 
            this.btnDetalle.Image = global::Facturacion_Vista.Properties.Resources.detail;
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Text = "Detalle Producto";
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click_1);
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Detalle Producto";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Enabled = false;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.TextBoxWidth = 120;
            this.textDescripcion.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "Cantidad";
            // 
            // textCantidadDetalle
            // 
            this.textCantidadDetalle.Enabled = false;
            this.textCantidadDetalle.Name = "textCantidadDetalle";
            this.textCantidadDetalle.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Facturacion_Vista.Properties.Resources.add;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "buttonItem1";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::Facturacion_Vista.Properties.Resources.resta;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Text = "buttonItem2";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 508);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.dtListaDetalle);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.group);
            this.DoubleBuffered = true;
            this.Name = "FrmProducto";
            this.Text = "Ingreso de Producto";
            this.group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.GroupPanel group;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboTipoPro;
        private DevComponents.DotNetBar.Controls.TextBoxX textDescPro;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.ButtonX btnIngresar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtListaDetalle;
        private DevComponents.DotNetBar.Controls.TextBoxX textDescuento;
        private DevComponents.DotNetBar.Controls.TextBoxX textPrecio;
        private DevComponents.DotNetBar.ButtonX btnImagen;
        private System.Windows.Forms.PictureBox pictureProducto;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private System.Windows.Forms.ErrorProvider erroricono;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnDetalle;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.TextBoxItem textDescripcion;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.TextBoxItem textCantidadDetalle;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}