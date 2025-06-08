namespace Algoritmos
{
    partial class formRegistro
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblRContraseña = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbMail = new System.Windows.Forms.TextBox();
            this.txtbContraseña = new System.Windows.Forms.TextBox();
            this.txtbRContraseña = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.bttnBack = new System.Windows.Forms.Button();
            this.lblNUsuario = new System.Windows.Forms.Label();
            this.txtbNUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(364, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1000;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(364, 106);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1001;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(373, 205);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 1002;
            this.lblMail.Text = "Mail";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(347, 258);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 1003;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblRContraseña
            // 
            this.lblRContraseña.AutoSize = true;
            this.lblRContraseña.Location = new System.Drawing.Point(336, 297);
            this.lblRContraseña.Name = "lblRContraseña";
            this.lblRContraseña.Size = new System.Drawing.Size(97, 13);
            this.lblRContraseña.TabIndex = 1004;
            this.lblRContraseña.Text = "Repetir contraseña";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(333, 73);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 20);
            this.txtbNombre.TabIndex = 10;
            // 
            // txtbApellido
            // 
            this.txtbApellido.Location = new System.Drawing.Point(333, 122);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(100, 20);
            this.txtbApellido.TabIndex = 11;
            // 
            // txtbMail
            // 
            this.txtbMail.Location = new System.Drawing.Point(333, 221);
            this.txtbMail.Name = "txtbMail";
            this.txtbMail.Size = new System.Drawing.Size(100, 20);
            this.txtbMail.TabIndex = 12;
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.Location = new System.Drawing.Point(333, 274);
            this.txtbContraseña.Name = "txtbContraseña";
            this.txtbContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtbContraseña.TabIndex = 13;
            this.txtbContraseña.UseSystemPasswordChar = true;
            // 
            // txtbRContraseña
            // 
            this.txtbRContraseña.Location = new System.Drawing.Point(333, 313);
            this.txtbRContraseña.Name = "txtbRContraseña";
            this.txtbRContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtbRContraseña.TabIndex = 14;
            this.txtbRContraseña.UseSystemPasswordChar = true;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(350, 350);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarse.TabIndex = 0;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(1, 0);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(75, 23);
            this.bttnBack.TabIndex = 1;
            this.bttnBack.Text = "Back";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // lblNUsuario
            // 
            this.lblNUsuario.AutoSize = true;
            this.lblNUsuario.Location = new System.Drawing.Point(337, 166);
            this.lblNUsuario.Name = "lblNUsuario";
            this.lblNUsuario.Size = new System.Drawing.Size(96, 13);
            this.lblNUsuario.TabIndex = 1005;
            this.lblNUsuario.Text = "Nombre de usuario";
            // 
            // txtbNUsuario
            // 
            this.txtbNUsuario.Location = new System.Drawing.Point(333, 182);
            this.txtbNUsuario.Name = "txtbNUsuario";
            this.txtbNUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtbNUsuario.TabIndex = 15;
            // 
            // formRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbNUsuario);
            this.Controls.Add(this.lblNUsuario);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txtbRContraseña);
            this.Controls.Add(this.txtbContraseña);
            this.Controls.Add(this.txtbMail);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblRContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "formRegistro";
            this.Text = "formRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblRContraseña;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbMail;
        private System.Windows.Forms.TextBox txtbContraseña;
        private System.Windows.Forms.TextBox txtbRContraseña;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Label lblNUsuario;
        private System.Windows.Forms.TextBox txtbNUsuario;
    }
}