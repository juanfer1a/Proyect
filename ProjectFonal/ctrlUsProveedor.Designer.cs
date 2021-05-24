
namespace ProjectFonal
{
    partial class ctrlUsProveedor
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.dtgvProveedor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNitProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCtaBancariaProveedor = new System.Windows.Forms.TextBox();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(86, 82);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(139, 20);
            this.txtNombreProveedor.TabIndex = 0;
            // 
            // dtgvProveedor
            // 
            this.dtgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProveedor.Location = new System.Drawing.Point(237, 51);
            this.dtgvProveedor.Name = "dtgvProveedor";
            this.dtgvProveedor.Size = new System.Drawing.Size(423, 346);
            this.dtgvProveedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nit:";
            // 
            // txtNitProveedor
            // 
            this.txtNitProveedor.Location = new System.Drawing.Point(86, 124);
            this.txtNitProveedor.Name = "txtNitProveedor";
            this.txtNitProveedor.Size = new System.Drawing.Size(139, 20);
            this.txtNitProveedor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Teléfono:";
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(86, 164);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(139, 20);
            this.txtTelefonoProveedor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cta.Bancaria:";
            // 
            // txtCtaBancariaProveedor
            // 
            this.txtCtaBancariaProveedor.Location = new System.Drawing.Point(86, 210);
            this.txtCtaBancariaProveedor.Name = "txtCtaBancariaProveedor";
            this.txtCtaBancariaProveedor.Size = new System.Drawing.Size(139, 20);
            this.txtCtaBancariaProveedor.TabIndex = 7;
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Location = new System.Drawing.Point(49, 251);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(138, 24);
            this.btnGuardarProveedor.TabIndex = 9;
            this.btnGuardarProveedor.Text = "Guardar";
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Location = new System.Drawing.Point(18, 311);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(86, 26);
            this.btnModificarProveedor.TabIndex = 10;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Location = new System.Drawing.Point(122, 311);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(93, 26);
            this.btnEliminarProveedor.TabIndex = 11;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "PROVEEDOR";
            // 
            // ctrlUsProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.btnGuardarProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCtaBancariaProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefonoProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNitProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvProveedor);
            this.Controls.Add(this.txtNombreProveedor);
            this.Name = "ctrlUsProveedor";
            this.Size = new System.Drawing.Size(686, 417);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.DataGridView dtgvProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNitProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCtaBancariaProveedor;
        private System.Windows.Forms.Button btnGuardarProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Label label5;
    }
}
