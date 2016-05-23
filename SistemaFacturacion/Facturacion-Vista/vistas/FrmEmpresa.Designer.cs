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
            this.radioD = new System.Windows.Forms.RadioButton();
            this.radioH = new System.Windows.Forms.RadioButton();
            this.estdoLbl = new System.Windows.Forms.Label();
            this.pathLbl = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioD);
            this.groupBox1.Controls.Add(this.radioH);
            this.groupBox1.Controls.Add(this.estdoLbl);
            this.groupBox1.Controls.Add(this.pathLbl);
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
            this.groupBox1.Size = new System.Drawing.Size(440, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Empresa";
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.Location = new System.Drawing.Point(287, 187);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(116, 21);
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
            this.radioH.Location = new System.Drawing.Point(164, 187);
            this.radioH.Name = "radioH";
            this.radioH.Size = new System.Drawing.Size(88, 21);
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
            this.estdoLbl.Location = new System.Drawing.Point(21, 190);
            this.estdoLbl.Name = "estdoLbl";
            this.estdoLbl.Size = new System.Drawing.Size(49, 17);
            this.estdoLbl.TabIndex = 9;
            this.estdoLbl.Text = "Estado";
            this.estdoLbl.Visible = false;
            // 
            // pathLbl
            // 
            this.pathLbl.AutoSize = true;
            this.pathLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLbl.Location = new System.Drawing.Point(70, 156);
            this.pathLbl.Name = "pathLbl";
            this.pathLbl.Size = new System.Drawing.Size(0, 12);
            this.pathLbl.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
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
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Logo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección Matriz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruc";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Image = global::Facturacion_Vista.Properties.Resources.cancel_ico;
            this.cancelarBtn.Location = new System.Drawing.Point(285, 273);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(91, 37);
            this.cancelarBtn.TabIndex = 2;
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Image = global::Facturacion_Vista.Properties.Resources.save_ico;
            this.guardarBtn.Location = new System.Drawing.Point(162, 273);
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
            this.ClientSize = new System.Drawing.Size(519, 358);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmpresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label pathLbl;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.RadioButton radioH;
        private System.Windows.Forms.Label estdoLbl;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}