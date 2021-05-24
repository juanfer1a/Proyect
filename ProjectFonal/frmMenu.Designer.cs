
namespace ProjectFonal
{
    partial class frmMenu
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
            this.txtUsuarios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.Location = new System.Drawing.Point(171, 75);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(433, 43);
            this.txtUsuarios.TabIndex = 0;
            this.txtUsuarios.Text = "Usuarios";
            this.txtUsuarios.UseVisualStyleBackColor = true;
            this.txtUsuarios.Click += new System.EventHandler(this.txtUsuarios_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(433, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(433, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Usuarios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(433, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Usuarios";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUsuarios);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtUsuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}