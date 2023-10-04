namespace miniGestor
{
    partial class crearTabla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearTabla));
            this.label1 = new System.Windows.Forms.Label();
            this.txbNameBD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearBD = new System.Windows.Forms.Button();
            this.btnClosefrmBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Base de Datos:";
            // 
            // txbNameBD
            // 
            this.txbNameBD.Location = new System.Drawing.Point(308, 168);
            this.txbNameBD.Name = "txbNameBD";
            this.txbNameBD.Size = new System.Drawing.Size(266, 20);
            this.txbNameBD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Crear Base de Datos";
            // 
            // btnCrearBD
            // 
            this.btnCrearBD.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearBD.Location = new System.Drawing.Point(242, 275);
            this.btnCrearBD.Name = "btnCrearBD";
            this.btnCrearBD.Size = new System.Drawing.Size(191, 54);
            this.btnCrearBD.TabIndex = 6;
            this.btnCrearBD.Text = "Crear Base de Datos";
            this.btnCrearBD.UseVisualStyleBackColor = true;
            this.btnCrearBD.Click += new System.EventHandler(this.btnCrearBD_Click);
            // 
            // btnClosefrmBD
            // 
            this.btnClosefrmBD.BackColor = System.Drawing.Color.Transparent;
            this.btnClosefrmBD.FlatAppearance.BorderSize = 0;
            this.btnClosefrmBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosefrmBD.ForeColor = System.Drawing.Color.Transparent;
            this.btnClosefrmBD.Image = ((System.Drawing.Image)(resources.GetObject("btnClosefrmBD.Image")));
            this.btnClosefrmBD.Location = new System.Drawing.Point(626, 17);
            this.btnClosefrmBD.Name = "btnClosefrmBD";
            this.btnClosefrmBD.Size = new System.Drawing.Size(42, 32);
            this.btnClosefrmBD.TabIndex = 7;
            this.btnClosefrmBD.UseVisualStyleBackColor = false;
            this.btnClosefrmBD.Click += new System.EventHandler(this.btnClosefrmBD_Click);
            // 
            // crearTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClosefrmBD);
            this.Controls.Add(this.btnCrearBD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNameBD);
            this.Name = "crearTabla";
            this.Size = new System.Drawing.Size(692, 427);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNameBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearBD;
        private System.Windows.Forms.Button btnClosefrmBD;
    }
}
