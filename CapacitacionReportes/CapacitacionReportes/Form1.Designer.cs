namespace CapacitacionReportes
{
    partial class frm_Inicio
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
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Empleados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Clientes.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Clientes.Location = new System.Drawing.Point(193, 340);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(183, 64);
            this.btn_Clientes.TabIndex = 1;
            this.btn_Clientes.Text = "Reporte Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = false;
            this.btn_Clientes.Click += new System.EventHandler(this.Btn_Clientes_Click);
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Empleados.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Empleados.Location = new System.Drawing.Point(394, 340);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.Size = new System.Drawing.Size(183, 63);
            this.btn_Empleados.TabIndex = 2;
            this.btn_Empleados.Text = "Reporte Empleados";
            this.btn_Empleados.UseVisualStyleBackColor = false;
            this.btn_Empleados.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Auditoría - Reportes";
            // 
            // frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapacitacionReportes.Properties.Resources.FONDORANDY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Empleados);
            this.Controls.Add(this.btn_Clientes);
            this.MaximumSize = new System.Drawing.Size(675, 468);
            this.MinimumSize = new System.Drawing.Size(675, 468);
            this.Name = "frm_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Inicio_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Empleados;
        private System.Windows.Forms.Label label2;
    }
}

