namespace Facturacion_Vista.Vistas
{
    partial class FrmUsuario
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
            this.fechaIngreso = new System.Windows.Forms.Label();
            this.txtuser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label13 = new System.Windows.Forms.Label();
            this.ckCambiarClave = new System.Windows.Forms.CheckBox();
            this.cbTipoDocumento = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtTelefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtClave = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNombres = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btGuardar = new DevComponents.DotNetBar.ButtonX();
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
            this.group.Controls.Add(this.rdDesactivo);
            this.group.Controls.Add(this.rdActivo);
            this.group.Controls.Add(this.fechaIngreso);
            this.group.Controls.Add(this.txtuser);
            this.group.Controls.Add(this.label13);
            this.group.Controls.Add(this.ckCambiarClave);
            this.group.Controls.Add(this.cbTipoDocumento);
            this.group.Controls.Add(this.txtTelefono);
            this.group.Controls.Add(this.txtClave);
            this.group.Controls.Add(this.txtEmail);
            this.group.Controls.Add(this.txtNombres);
            this.group.Controls.Add(this.txtDocumento);
            this.group.Controls.Add(this.label10);
            this.group.Controls.Add(this.label9);
            this.group.Controls.Add(this.label8);
            this.group.Controls.Add(this.label6);
            this.group.Controls.Add(this.label5);
            this.group.Controls.Add(this.label4);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.label1);
            this.group.DisabledBackColor = System.Drawing.Color.Empty;
            this.group.Location = new System.Drawing.Point(21, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(653, 403);
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
            this.group.Text = "Datos Nuevo Usuario";
            // 
            // rdDesactivo
            // 
            this.rdDesactivo.AutoSize = true;
            this.rdDesactivo.BackColor = System.Drawing.Color.Transparent;
            this.rdDesactivo.Location = new System.Drawing.Point(515, 52);
            this.rdDesactivo.Name = "rdDesactivo";
            this.rdDesactivo.Size = new System.Drawing.Size(73, 17);
            this.rdDesactivo.TabIndex = 39;
            this.rdDesactivo.TabStop = true;
            this.rdDesactivo.Text = "Desactivo";
            this.rdDesactivo.UseVisualStyleBackColor = false;
            this.rdDesactivo.CheckedChanged += new System.EventHandler(this.rdDesactivo_CheckedChanged);
            // 
            // rdActivo
            // 
            this.rdActivo.AutoSize = true;
            this.rdActivo.BackColor = System.Drawing.Color.Transparent;
            this.rdActivo.Location = new System.Drawing.Point(515, 18);
            this.rdActivo.Name = "rdActivo";
            this.rdActivo.Size = new System.Drawing.Size(55, 17);
            this.rdActivo.TabIndex = 38;
            this.rdActivo.TabStop = true;
            this.rdActivo.Text = "Activo";
            this.rdActivo.UseVisualStyleBackColor = false;
            this.rdActivo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.AutoSize = true;
            this.fechaIngreso.BackColor = System.Drawing.Color.Transparent;
            this.fechaIngreso.Location = new System.Drawing.Point(512, 156);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(43, 13);
            this.fechaIngreso.TabIndex = 37;
            this.fechaIngreso.Text = "Fecha .";
            this.fechaIngreso.Visible = false;
            // 
            // txtuser
            // 
            // 
            // 
            // 
            this.txtuser.Border.Class = "TextBoxBorder";
            this.txtuser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtuser.Location = new System.Drawing.Point(130, 281);
            this.txtuser.Name = "txtuser";
            this.txtuser.PreventEnterBeep = true;
            this.txtuser.Size = new System.Drawing.Size(247, 20);
            this.txtuser.TabIndex = 36;
            this.txtuser.WatermarkText = "Ingrese el nombre usuario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(28, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Nombre de usuario";
            // 
            // ckCambiarClave
            // 
            this.ckCambiarClave.AutoSize = true;
            this.ckCambiarClave.Location = new System.Drawing.Point(515, 105);
            this.ckCambiarClave.Name = "ckCambiarClave";
            this.ckCambiarClave.Size = new System.Drawing.Size(15, 14);
            this.ckCambiarClave.TabIndex = 32;
            this.ckCambiarClave.UseVisualStyleBackColor = true;
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.DisplayMember = "Text";
            this.cbTipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.ItemHeight = 14;
            this.cbTipoDocumento.Location = new System.Drawing.Point(135, 25);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(247, 20);
            this.cbTipoDocumento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTipoDocumento.TabIndex = 29;
            this.cbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cbTipoDocumento_SelectedIndexChanged);
            // 
            // txtTelefono
            // 
            // 
            // 
            // 
            this.txtTelefono.Border.Class = "TextBoxBorder";
            this.txtTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTelefono.Location = new System.Drawing.Point(133, 177);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PreventEnterBeep = true;
            this.txtTelefono.Size = new System.Drawing.Size(247, 20);
            this.txtTelefono.TabIndex = 28;
            this.txtTelefono.WatermarkText = "593(__)(_______)";
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtClave
            // 
            // 
            // 
            // 
            this.txtClave.Border.Class = "TextBoxBorder";
            this.txtClave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtClave.Location = new System.Drawing.Point(130, 331);
            this.txtClave.Name = "txtClave";
            this.txtClave.PreventEnterBeep = true;
            this.txtClave.Size = new System.Drawing.Size(247, 20);
            this.txtClave.TabIndex = 27;
            this.txtClave.WatermarkText = "Ingrese la clave";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.Location = new System.Drawing.Point(133, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PreventEnterBeep = true;
            this.txtEmail.Size = new System.Drawing.Size(247, 20);
            this.txtEmail.TabIndex = 26;
            this.txtEmail.WatermarkText = "ejemplo@hotmail.com";
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtNombres
            // 
            // 
            // 
            // 
            this.txtNombres.Border.Class = "TextBoxBorder";
            this.txtNombres.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombres.Location = new System.Drawing.Point(133, 128);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PreventEnterBeep = true;
            this.txtNombres.Size = new System.Drawing.Size(247, 20);
            this.txtNombres.TabIndex = 24;
            // 
            // txtDocumento
            // 
            // 
            // 
            // 
            this.txtDocumento.Border.Class = "TextBoxBorder";
            this.txtDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocumento.Location = new System.Drawing.Point(135, 71);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PreventEnterBeep = true;
            this.txtDocumento.Size = new System.Drawing.Size(247, 20);
            this.txtDocumento.TabIndex = 23;
            this.txtDocumento.WatermarkText = "Ingrese su identificación";
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            this.txtDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.txtDocumento_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(412, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cambiar Clave";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(412, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(412, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha de ingreso";
            this.label8.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(28, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Clave";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(30, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(28, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres y Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de cedula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de documento";
            // 
            // btGuardar
            // 
            this.btGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btGuardar.Image = global::Facturacion_Vista.Properties.Resources.save_ico;
            this.btGuardar.Location = new System.Drawing.Point(135, 437);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(85, 49);
            this.btGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.Color.Transparent;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::Facturacion_Vista.Properties.Resources.cancel_ico;
            this.buttonX2.Location = new System.Drawing.Point(364, 437);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(95, 49);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 5;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 491);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.group);
            this.DoubleBuffered = true;
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel group;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cbTipoDocumento;
        public DevComponents.DotNetBar.Controls.TextBoxX txtTelefono;
        public DevComponents.DotNetBar.Controls.TextBoxX txtClave;
        public DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        public DevComponents.DotNetBar.Controls.TextBoxX txtNombres;
        public DevComponents.DotNetBar.Controls.TextBoxX txtDocumento;
        private System.Windows.Forms.CheckBox ckCambiarClave;
        public DevComponents.DotNetBar.Controls.TextBoxX txtuser;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.RadioButton rdDesactivo;
        public System.Windows.Forms.RadioButton rdActivo;
        public System.Windows.Forms.Label fechaIngreso;
        private DevComponents.DotNetBar.ButtonX btGuardar;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.ErrorProvider erroricono;
    }
}