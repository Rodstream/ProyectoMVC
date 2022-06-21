namespace Vista
{
    partial class frmLogin
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
            this.labelCuenta_inexistente = new System.Windows.Forms.Label();
            this.labelCrear_cuenta = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.checkBoxMosContrasena = new System.Windows.Forms.CheckBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.label_contrasena = new System.Windows.Forms.Label();
            this.txtNombre_de_usuario = new System.Windows.Forms.TextBox();
            this.label_nombre_usuario = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCuenta_inexistente
            // 
            this.labelCuenta_inexistente.AutoSize = true;
            this.labelCuenta_inexistente.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuenta_inexistente.Location = new System.Drawing.Point(69, 342);
            this.labelCuenta_inexistente.Name = "labelCuenta_inexistente";
            this.labelCuenta_inexistente.Size = new System.Drawing.Size(300, 36);
            this.labelCuenta_inexistente.TabIndex = 24;
            this.labelCuenta_inexistente.Text = "No tienes una cuenta";
            // 
            // labelCrear_cuenta
            // 
            this.labelCrear_cuenta.AutoSize = true;
            this.labelCrear_cuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCrear_cuenta.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrear_cuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelCrear_cuenta.Location = new System.Drawing.Point(96, 369);
            this.labelCrear_cuenta.Name = "labelCrear_cuenta";
            this.labelCrear_cuenta.Size = new System.Drawing.Size(191, 36);
            this.labelCrear_cuenta.TabIndex = 23;
            this.labelCrear_cuenta.Text = "Crear cuenta";
            this.labelCrear_cuenta.Click += new System.EventHandler(this.labelCrear_cuenta_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnBorrar.Location = new System.Drawing.Point(32, 289);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(216, 35);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(32, 248);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(216, 35);
            this.btnEntrar.TabIndex = 21;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // checkBoxMosContrasena
            // 
            this.checkBoxMosContrasena.AutoSize = true;
            this.checkBoxMosContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxMosContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMosContrasena.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMosContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.checkBoxMosContrasena.Location = new System.Drawing.Point(115, 208);
            this.checkBoxMosContrasena.Name = "checkBoxMosContrasena";
            this.checkBoxMosContrasena.Size = new System.Drawing.Size(270, 35);
            this.checkBoxMosContrasena.TabIndex = 20;
            this.checkBoxMosContrasena.Text = "Mostrar contraseña";
            this.checkBoxMosContrasena.UseVisualStyleBackColor = true;
            this.checkBoxMosContrasena.CheckedChanged += new System.EventHandler(this.checkBoxMosContrasena_CheckedChanged);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontrasena.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontrasena.Location = new System.Drawing.Point(37, 174);
            this.txtcontrasena.Multiline = true;
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.PasswordChar = '•';
            this.txtcontrasena.Size = new System.Drawing.Size(216, 28);
            this.txtcontrasena.TabIndex = 17;
            // 
            // label_contrasena
            // 
            this.label_contrasena.AutoSize = true;
            this.label_contrasena.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label_contrasena.Location = new System.Drawing.Point(33, 152);
            this.label_contrasena.Name = "label_contrasena";
            this.label_contrasena.Size = new System.Drawing.Size(182, 39);
            this.label_contrasena.TabIndex = 16;
            this.label_contrasena.Text = "Contraseña";
            // 
            // txtNombre_de_usuario
            // 
            this.txtNombre_de_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtNombre_de_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre_de_usuario.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre_de_usuario.Location = new System.Drawing.Point(37, 98);
            this.txtNombre_de_usuario.Multiline = true;
            this.txtNombre_de_usuario.Name = "txtNombre_de_usuario";
            this.txtNombre_de_usuario.Size = new System.Drawing.Size(216, 28);
            this.txtNombre_de_usuario.TabIndex = 15;
            // 
            // label_nombre_usuario
            // 
            this.label_nombre_usuario.AutoSize = true;
            this.label_nombre_usuario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label_nombre_usuario.Location = new System.Drawing.Point(33, 76);
            this.label_nombre_usuario.Name = "label_nombre_usuario";
            this.label_nombre_usuario.Size = new System.Drawing.Size(292, 39);
            this.label_nombre_usuario.TabIndex = 14;
            this.label_nombre_usuario.Text = "Nombre de usuario";
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label_titulo.Location = new System.Drawing.Point(32, 26);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(303, 54);
            this.label_titulo.TabIndex = 13;
            this.label_titulo.Text = "Empecemos";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 415);
            this.Controls.Add(this.labelCuenta_inexistente);
            this.Controls.Add(this.labelCrear_cuenta);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.checkBoxMosContrasena);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.label_contrasena);
            this.Controls.Add(this.txtNombre_de_usuario);
            this.Controls.Add(this.label_nombre_usuario);
            this.Controls.Add(this.label_titulo);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCuenta_inexistente;
        private System.Windows.Forms.Label labelCrear_cuenta;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.CheckBox checkBoxMosContrasena;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label label_contrasena;
        private System.Windows.Forms.TextBox txtNombre_de_usuario;
        private System.Windows.Forms.Label label_nombre_usuario;
        private System.Windows.Forms.Label label_titulo;
    }
}