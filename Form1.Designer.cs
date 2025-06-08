namespace Algoritmos
{
    partial class formLogin
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtBUsuario = new System.Windows.Forms.TextBox();
            this.txtBContraseña = new System.Windows.Forms.TextBox();
            this.bttnIngresar = new System.Windows.Forms.Button();
            this.llblRegistarse = new System.Windows.Forms.LinkLabel();
            this.llblCambiar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(315, 45);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(112, 13);
            this.lblUsuario.TabIndex = 1000;
            this.lblUsuario.Text = "Ingresar usuario o mail";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(317, 109);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(101, 13);
            this.lblContraseña.TabIndex = 1001;
            this.lblContraseña.Text = "Ingresar contraseña";
            // 
            // txtBUsuario
            // 
            this.txtBUsuario.Location = new System.Drawing.Point(318, 70);
            this.txtBUsuario.Name = "txtBUsuario";
            this.txtBUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtBUsuario.TabIndex = 0;
            // 
            // txtBContraseña
            // 
            this.txtBContraseña.Location = new System.Drawing.Point(318, 134);
            this.txtBContraseña.Name = "txtBContraseña";
            this.txtBContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtBContraseña.TabIndex = 1;
            this.txtBContraseña.UseSystemPasswordChar = true;
            // 
            // bttnIngresar
            // 
            this.bttnIngresar.Location = new System.Drawing.Point(333, 172);
            this.bttnIngresar.Name = "bttnIngresar";
            this.bttnIngresar.Size = new System.Drawing.Size(75, 23);
            this.bttnIngresar.TabIndex = 10;
            this.bttnIngresar.Text = "Ingresar";
            this.bttnIngresar.UseVisualStyleBackColor = true;
            this.bttnIngresar.Click += new System.EventHandler(this.bttnIngresar_Click);
            // 
            // llblRegistarse
            // 
            this.llblRegistarse.ActiveLinkColor = System.Drawing.Color.Black;
            this.llblRegistarse.AutoSize = true;
            this.llblRegistarse.Location = new System.Drawing.Point(339, 210);
            this.llblRegistarse.Name = "llblRegistarse";
            this.llblRegistarse.Size = new System.Drawing.Size(60, 13);
            this.llblRegistarse.TabIndex = 100;
            this.llblRegistarse.TabStop = true;
            this.llblRegistarse.Text = "Registrarse";
            this.llblRegistarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegistarse_LinkClicked);
            // 
            // llblCambiar
            // 
            this.llblCambiar.ActiveLinkColor = System.Drawing.Color.Black;
            this.llblCambiar.AutoSize = true;
            this.llblCambiar.Location = new System.Drawing.Point(323, 238);
            this.llblCambiar.Name = "llblCambiar";
            this.llblCambiar.Size = new System.Drawing.Size(101, 13);
            this.llblCambiar.TabIndex = 101;
            this.llblCambiar.TabStop = true;
            this.llblCambiar.Text = "Cambiar contraseña";
            this.llblCambiar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCambiar_LinkClicked);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llblCambiar);
            this.Controls.Add(this.llblRegistarse);
            this.Controls.Add(this.bttnIngresar);
            this.Controls.Add(this.txtBContraseña);
            this.Controls.Add(this.txtBUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Name = "formLogin";
            this.Text = "Formulario de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtBUsuario;
        private System.Windows.Forms.TextBox txtBContraseña;
        private System.Windows.Forms.Button bttnIngresar;
        private System.Windows.Forms.LinkLabel llblRegistarse;
        private System.Windows.Forms.LinkLabel llblCambiar;
    }
}

