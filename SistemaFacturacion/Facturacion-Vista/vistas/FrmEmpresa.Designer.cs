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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkContabilidad = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.radioD = new System.Windows.Forms.RadioButton();
            this.radioH = new System.Windows.Forms.RadioButton();
            this.estdoLbl = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkContabilidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboAmbiente);
            this.groupBox1.Controls.Add(this.textPath);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textDirecMatriz);
            this.groupBox1.Controls.Add(this.textRazonSocial);
            this.groupBox1.Controls.Add(this.textRuc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Empresa";
            // 
            // checkContabilidad
            // 
            this.checkContabilidad.AutoSize = true;
            this.checkContabilidad.Location = new System.Drawing.Point(311, 243);
            this.checkContabilidad.Name = "checkContabilidad";
            this.checkContabilidad.Size = new System.Drawing.Size(39, 23);
            this.checkContabilidad.TabIndex = 16;
            this.checkContabilidad.Text = "Si";
            this.checkContabilidad.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Obligado a llevar contabilidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Empresa";
            // 
            // comboAmbiente
            // 
            this.comboAmbiente.FormattingEnabled = true;
            this.comboAmbiente.Location = new System.Drawing.Point(218, 199);
            this.comboAmbiente.Name = "comboAmbiente";
            this.comboAmbiente.Size = new System.Drawing.Size(180, 27);
            this.comboAmbiente.TabIndex = 13;
            this.comboAmbiente.Text = "SELECCIONE";
            this.comboAmbiente.SelectedIndexChanged += new System.EventHandler(this.comboAmbiente_SelectedIndexChanged);
            this.comboAmbiente.DataSourceChanged += new System.EventHandler(this.comboAmbiente_DataSourceChanged);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(79, 149);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(211, 24);
            this.textPath.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "+ Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textDirecMatriz
            // 
            this.textDirecMatriz.Location = new System.Drawing.Point(218, 111);
            this.textDirecMatriz.Name = "textDirecMatriz";
            this.textDirecMatriz.Size = new System.Drawing.Size(180, 24);
            this.textDirecMatriz.TabIndex = 6;
            // 
            // textRazonSocial
            // 
            this.textRazonSocial.Location = new System.Drawing.Point(218, 76);
            this.textRazonSocial.Name = "textRazonSocial";
            this.textRazonSocial.Size = new System.Drawing.Size(180, 24);
            this.textRazonSocial.TabIndex = 5;
            // 
            // textRuc
            // 
            this.textRuc.Location = new System.Drawing.Point(218, 41);
            this.textRuc.Name = "textRuc";
            this.textRuc.Size = new System.Drawing.Size(180, 24);
            this.textRuc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Logo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección Matriz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruc";
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.Location = new System.Drawing.Point(342, 303);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(95, 17);
            this.radioD.TabIndex = 11;
            this.radioD.TabStop = true;
            this.radioD.Text = "Desahabilitado";
            this.radioD.UseVisualStyleBackColor = true;
            this.radioD.Visible = false;
            this.radioD.CheckedChanged += new System.EventHandler(this.radioD_CheckedChanged);
            // 
            // radioH
            // 
            this.radioH.AutoSize = true;
            this.radioH.Location = new System.Drawing.Point(205, 301);
            this.radioH.Name = "radioH";
            this.radioH.Size = new System.Drawing.Size(72, 17);
            this.radioH.TabIndex = 10;
            this.radioH.TabStop = true;
            this.radioH.Text = "Habilitado";
            this.radioH.UseVisualStyleBackColor = true;
            this.radioH.Visible = false;
            this.radioH.CheckedChanged += new System.EventHandler(this.radioH_CheckedChanged);
            // 
            // estdoLbl
            // 
            this.estdoLbl.AutoSize = true;
            this.estdoLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estdoLbl.Location = new System.Drawing.Point(66, 296);
            this.estdoLbl.Name = "estdoLbl";
            this.estdoLbl.Size = new System.Drawing.Size(50, 19);
            this.estdoLbl.TabIndex = 9;
            this.estdoLbl.Text = "Estado";
            this.estdoLbl.Visible = false;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Image = global::Facturacion_Vista.Properties.Resources.cancel_ico;
            this.cancelarBtn.Location = new System.Drawing.Point(287, 342);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(91, 37);
            this.cancelarBtn.TabIndex = 2;
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Image = global::Facturacion_Vista.Properties.Resources.save_ico;
            this.guardarBtn.Location = new System.Drawing.Point(159, 342);
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
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 399);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.radioD);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.radioH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.estdoLbl);
            this.Name = "FrmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmpresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textDirecMatriz;
        private System.Windows.Forms.TextBox textRazonSocial;
        private System.Windows.Forms.TextBox textRuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
       // private System.Windows.Forms.Label pathLbl;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.RadioButton radioH;
        private System.Windows.Forms.Label estdoLbl;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboAmbiente;
        private System.Windows.Forms.CheckBox checkContabilidad;
        private System.Windows.Forms.Label label6;
    }
}