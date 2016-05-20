namespace Facturacion_Vista
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.btnIngreso = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ribbonBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Silver;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Controls.Add(this.pictureBox1);
            this.ribbonBar1.Controls.Add(this.btnCancelar);
            this.ribbonBar1.Controls.Add(this.btnIngreso);
            this.ribbonBar1.Controls.Add(this.label2);
            this.ribbonBar1.Controls.Add(this.label1);
            this.ribbonBar1.Controls.Add(this.textPassword);
            this.ribbonBar1.Controls.Add(this.textUser);
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(472, 274);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.ribbonBar1.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ItemClick += new System.EventHandler(this.ribbonBar1_ItemClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Facturacion_Vista.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(26, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 123);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Image = global::Facturacion_Vista.Properties.Resources.cancel_ico;
            this.btnCancelar.Location = new System.Drawing.Point(307, 171);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 38);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 5;
            // 
            // btnIngreso
            // 
            this.btnIngreso.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIngreso.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIngreso.Image = global::Facturacion_Vista.Properties.Resources.home_ico;
            this.btnIngreso.Location = new System.Drawing.Point(189, 171);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(84, 38);
            this.btnIngreso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIngreso.TabIndex = 4;
            this.btnIngreso.Tooltip = "Ingresar al Sistema";
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // textPassword
            // 
            // 
            // 
            // 
            this.textPassword.Border.Class = "TextBoxBorder";
            this.textPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textPassword.Location = new System.Drawing.Point(243, 121);
            this.textPassword.Name = "textPassword";
            this.textPassword.PreventEnterBeep = true;
            this.textPassword.Size = new System.Drawing.Size(151, 20);
            this.textPassword.TabIndex = 1;
            // 
            // textUser
            // 
            // 
            // 
            // 
            this.textUser.Border.Class = "TextBoxBorder";
            this.textUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textUser.Location = new System.Drawing.Point(241, 73);
            this.textUser.Name = "textUser";
            this.textUser.PreventEnterBeep = true;
            this.textUser.Size = new System.Drawing.Size(151, 20);
            this.textUser.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 274);
            this.Controls.Add(this.ribbonBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Ingreso";
            this.ribbonBar1.ResumeLayout(false);
            this.ribbonBar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.Controls.TextBoxX textUser;
        private DevComponents.DotNetBar.Controls.TextBoxX textPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.ButtonX btnIngreso;
    }
}

