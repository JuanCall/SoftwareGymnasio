namespace SoftwareGymnasio
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.link_RecuperaciónContraseña = new System.Windows.Forms.LinkLabel();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_OcultarContraseña = new System.Windows.Forms.PictureBox();
            this.btn_VerContraseña = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_OcultarContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_VerContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.Peru;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.Location = new System.Drawing.Point(607, 275);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(141, 41);
            this.btn_Ingresar.TabIndex = 1;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // link_RecuperaciónContraseña
            // 
            this.link_RecuperaciónContraseña.AutoSize = true;
            this.link_RecuperaciónContraseña.Location = new System.Drawing.Point(584, 372);
            this.link_RecuperaciónContraseña.Name = "link_RecuperaciónContraseña";
            this.link_RecuperaciónContraseña.Size = new System.Drawing.Size(181, 16);
            this.link_RecuperaciónContraseña.TabIndex = 3;
            this.link_RecuperaciónContraseña.TabStop = true;
            this.link_RecuperaciónContraseña.Text = "Recuperación de contraseña";
            this.link_RecuperaciónContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_RecuperaciónContraseña_LinkClicked);
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.ForeColor = System.Drawing.Color.White;
            this.txt_Pass.Location = new System.Drawing.Point(563, 174);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(243, 38);
            this.txt_Pass.TabIndex = 6;
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.ForeColor = System.Drawing.Color.White;
            this.txt_User.Location = new System.Drawing.Point(563, 84);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(243, 38);
            this.txt_User.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SoftwareGymnasio.Properties.Resources.CLOSE1;
            this.pictureBox4.Location = new System.Drawing.Point(871, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btn_OcultarContraseña
            // 
            this.btn_OcultarContraseña.Image = global::SoftwareGymnasio.Properties.Resources.OJO_CERRADO;
            this.btn_OcultarContraseña.Location = new System.Drawing.Point(772, 183);
            this.btn_OcultarContraseña.Name = "btn_OcultarContraseña";
            this.btn_OcultarContraseña.Size = new System.Drawing.Size(24, 20);
            this.btn_OcultarContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_OcultarContraseña.TabIndex = 11;
            this.btn_OcultarContraseña.TabStop = false;
            this.btn_OcultarContraseña.Click += new System.EventHandler(this.btn_OcultarContraseña_Click);
            // 
            // btn_VerContraseña
            // 
            this.btn_VerContraseña.Image = global::SoftwareGymnasio.Properties.Resources.OJO_ABIERTO;
            this.btn_VerContraseña.Location = new System.Drawing.Point(772, 183);
            this.btn_VerContraseña.Name = "btn_VerContraseña";
            this.btn_VerContraseña.Size = new System.Drawing.Size(24, 20);
            this.btn_VerContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_VerContraseña.TabIndex = 10;
            this.btn_VerContraseña.TabStop = false;
            this.btn_VerContraseña.Click += new System.EventHandler(this.btn_VerContraseña_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SoftwareGymnasio.Properties.Resources.png_clipart_computer_icons_scalable_graphics_password_mastering_the_art_of_solutionfocused_counseling_computer_icons_password;
            this.pictureBox3.Location = new System.Drawing.Point(514, 174);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoftwareGymnasio.Properties.Resources.symbole_masculin_icone_l_utilisateur_gris;
            this.pictureBox1.Location = new System.Drawing.Point(514, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SoftwareGymnasio.Properties.Resources.BODYPLUSLOGO;
            this.pictureBox2.Location = new System.Drawing.Point(79, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(333, 332);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(915, 446);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_OcultarContraseña);
            this.Controls.Add(this.btn_VerContraseña);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.link_RecuperaciónContraseña);
            this.Controls.Add(this.btn_Ingresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_OcultarContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_VerContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.LinkLabel link_RecuperaciónContraseña;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btn_VerContraseña;
        private System.Windows.Forms.PictureBox btn_OcultarContraseña;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

