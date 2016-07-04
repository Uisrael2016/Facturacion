namespace Facturacion_Vista.Vistas
{
    partial class FrmEmpresa
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboAmbiente = new System.Windows.Forms.ComboBox();
            this.textPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textDirecMatriz = new System.Windows.Forms.TextBox();
            this.textRazonSocial = new System.Windows.Forms.TextBox();
            this.textRuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.group = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblEstado = new DevComponents.DotNetBar.LabelX();
            this.checkContabilidad = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkEstado = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Obligado a llevar contabilidad";
            // 
            // comboAmbiente
            // 
            this.comboAmbiente.FormattingEnabled = true;
            this.comboAmbiente.Location = new System.Drawing.Point(222, 170);
            this.comboAmbiente.Name = "comboAmbiente";
            this.comboAmbiente.Size = new System.Drawing.Size(180, 21);
            this.comboAmbiente.TabIndex = 13;
            this.comboAmbiente.Text = "SELECCIONE";
            this.comboAmbiente.SelectedIndexChanged += new System.EventHandler(this.comboAmbiente_SelectedIndexChanged);
            // 
            // textPath
            // 
            this.textPath.Enabled = false;
            this.textPath.Location = new System.Drawing.Point(83, 120);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(211, 20);
            this.textPath.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "+ Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textDirecMatriz
            // 
            this.textDirecMatriz.Location = new System.Drawing.Point(178, 82);
            this.textDirecMatriz.Name = "textDirecMatriz";
            this.textDirecMatriz.Size = new System.Drawing.Size(233, 20);
            this.textDirecMatriz.TabIndex = 6;
            // 
            // textRazonSocial
            // 
            this.textRazonSocial.Location = new System.Drawing.Point(178, 47);
            this.textRazonSocial.Name = "textRazonSocial";
            this.textRazonSocial.Size = new System.Drawing.Size(233, 20);
            this.textRazonSocial.TabIndex = 5;
            // 
            // textRuc
            // 
            this.textRuc.Location = new System.Drawing.Point(178, 12);
            this.textRuc.Name = "textRuc";
            this.textRuc.Size = new System.Drawing.Size(233, 20);
            this.textRuc.TabIndex = 4;
            this.textRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRuc_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Logo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección Matriz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruc";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Image = global::Facturacion_Vista.Properties.Resources.cancel_ico;
            this.cancelarBtn.Location = new System.Drawing.Point(288, 304);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(91, 37);
            this.cancelarBtn.TabIndex = 2;
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Image = global::Facturacion_Vista.Properties.Resources.save_ico;
            this.guardarBtn.Location = new System.Drawing.Point(164, 304);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(87, 37);
            this.guardarBtn.TabIndex = 1;
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Silver;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // group
            // 
            this.group.CanvasColor = System.Drawing.SystemColors.Control;
            this.group.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.group.Controls.Add(this.labelX1);
            this.group.Controls.Add(this.lblEstado);
            this.group.Controls.Add(this.checkContabilidad);
            this.group.Controls.Add(this.checkEstado);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.label6);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.comboAmbiente);
            this.group.Controls.Add(this.label4);
            this.group.Controls.Add(this.textPath);
            this.group.Controls.Add(this.textRuc);
            this.group.Controls.Add(this.textRazonSocial);
            this.group.Controls.Add(this.button1);
            this.group.Controls.Add(this.textDirecMatriz);
            this.group.DisabledBackColor = System.Drawing.Color.Empty;
            this.group.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.Location = new System.Drawing.Point(53, 13);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(437, 270);
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
            this.group.TabIndex = 12;
            this.group.Text = "Informacion Empresa";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(21, 167);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "Ambiente";
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(288, 208);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 23);
            this.lblEstado.TabIndex = 19;
            this.lblEstado.Text = "Estado";
            // 
            // checkContabilidad
            // 
            this.checkContabilidad.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkContabilidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkContabilidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkContabilidad.Location = new System.Drawing.Point(235, 208);
            this.checkContabilidad.Name = "checkContabilidad";
            this.checkContabilidad.Size = new System.Drawing.Size(47, 23);
            this.checkContabilidad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkContabilidad.TabIndex = 18;
            this.checkContabilidad.Text = "Si";
            // 
            // checkEstado
            // 
            this.checkEstado.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkEstado.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEstado.Location = new System.Drawing.Point(342, 208);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(60, 23);
            this.checkEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkEstado.TabIndex = 17;
            this.checkEstado.Text = "Activo";
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 357);
            this.Controls.Add(this.group);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.guardarBtn);
            this.Name = "FrmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textDirecMatriz;
        private System.Windows.Forms.TextBox textRazonSocial;
        private System.Windows.Forms.TextBox textRuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.ComboBox comboAmbiente;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.GroupPanel group;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkContabilidad;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkEstado;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblEstado;
    }
}