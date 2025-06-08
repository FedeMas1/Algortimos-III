namespace Algoritmos
{
    partial class formCambio
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNContraseña = new System.Windows.Forms.Label();
            this.lblRContraseña = new System.Windows.Forms.Label();
            this.txtbUsuario = new System.Windows.Forms.TextBox();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.txtbNContraseña = new System.Windows.Forms.TextBox();
            this.txtbRContraseña = new System.Windows.Forms.TextBox();
            this.bttnCambiar = new System.Windows.Forms.Button();
            this.bttnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(349, 51);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(82, 13);
            this.lblUsuario.TabIndex = 1000;
            this.lblUsuario.Text = "Ingresar usuario";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(349, 110);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 13);
            this.lblCodigo.TabIndex = 1001;
            this.lblCodigo.Text = "Ingresar codigo";
            // 
            // lblNContraseña
            // 
            this.lblNContraseña.AutoSize = true;
            this.lblNContraseña.Location = new System.Drawing.Point(324, 168);
            this.lblNContraseña.Name = "lblNContraseña";
            this.lblNContraseña.Size = new System.Drawing.Size(134, 13);
            this.lblNContraseña.TabIndex = 1002;
            this.lblNContraseña.Text = "Ingresar nueva contraseña";
            // 
            // lblRContraseña
            // 
            this.lblRContraseña.AutoSize = true;
            this.lblRContraseña.Location = new System.Drawing.Point(343, 227);
            this.lblRContraseña.Name = "lblRContraseña";
            this.lblRContraseña.Size = new System.Drawing.Size(97, 13);
            this.lblRContraseña.TabIndex = 1003;
            this.lblRContraseña.Text = "Repetir contraseña";
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.Location = new System.Drawing.Point(340, 67);
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtbUsuario.TabIndex = 10;
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Location = new System.Drawing.Point(340, 126);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtbCodigo.TabIndex = 11;
            // 
            // txtbNContraseña
            // 
            this.txtbNContraseña.Location = new System.Drawing.Point(340, 184);
            this.txtbNContraseña.Name = "txtbNContraseña";
            this.txtbNContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtbNContraseña.TabIndex = 12;
            this.txtbNContraseña.UseSystemPasswordChar = true;
            // 
            // txtbRContraseña
            // 
            this.txtbRContraseña.Location = new System.Drawing.Point(340, 243);
            this.txtbRContraseña.Name = "txtbRContraseña";
            this.txtbRContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtbRContraseña.TabIndex = 13;
            this.txtbRContraseña.UseSystemPasswordChar = true;
            // 
            // bttnCambiar
            // 
            this.bttnCambiar.Location = new System.Drawing.Point(352, 279);
            this.bttnCambiar.Name = "bttnCambiar";
            this.bttnCambiar.Size = new System.Drawing.Size(75, 23);
            this.bttnCambiar.TabIndex = 0;
            this.bttnCambiar.Text = "Cambiar ";
            this.bttnCambiar.UseVisualStyleBackColor = true;
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(-1, 1);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(75, 23);
            this.bttnBack.TabIndex = 1;
            this.bttnBack.Text = "Back";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // formCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.bttnCambiar);
            this.Controls.Add(this.txtbRContraseña);
            this.Controls.Add(this.txtbNContraseña);
            this.Controls.Add(this.txtbCodigo);
            this.Controls.Add(this.txtbUsuario);
            this.Controls.Add(this.lblRContraseña);
            this.Controls.Add(this.lblNContraseña);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblUsuario);
            this.Name = "formCambio";
            this.Text = "formCambio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNContraseña;
        private System.Windows.Forms.Label lblRContraseña;
        private System.Windows.Forms.TextBox txtbUsuario;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.TextBox txtbNContraseña;
        private System.Windows.Forms.TextBox txtbRContraseña;
        private System.Windows.Forms.Button bttnCambiar;
        private System.Windows.Forms.Button bttnBack;
    }
}