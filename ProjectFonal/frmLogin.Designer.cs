
namespace ProjectFonal
{
    partial class frmLogin
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
            this.txtNombreLogin = new System.Windows.Forms.TextBox();
            this.txtContraLogin = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreLogin
            // 
            this.txtNombreLogin.Location = new System.Drawing.Point(103, 98);
            this.txtNombreLogin.Name = "txtNombreLogin";
            this.txtNombreLogin.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLogin.TabIndex = 0;
            // 
            // txtContraLogin
            // 
            this.txtContraLogin.Location = new System.Drawing.Point(103, 151);
            this.txtContraLogin.Name = "txtContraLogin";
            this.txtContraLogin.Size = new System.Drawing.Size(100, 20);
            this.txtContraLogin.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(254, 98);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(116, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 315);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraLogin);
            this.Controls.Add(this.txtNombreLogin);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreLogin;
        private System.Windows.Forms.TextBox txtContraLogin;
        private System.Windows.Forms.Button btnIngresar;
    }
}

