namespace miniGestor
{
    partial class creatorTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(creatorTable));
            this.btnClosefrmTabla = new System.Windows.Forms.Button();
            this.btnCrearBD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowNull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txbNameTabla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClosefrmTabla
            // 
            this.btnClosefrmTabla.BackColor = System.Drawing.Color.Transparent;
            this.btnClosefrmTabla.FlatAppearance.BorderSize = 0;
            this.btnClosefrmTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosefrmTabla.ForeColor = System.Drawing.Color.Transparent;
            this.btnClosefrmTabla.Image = ((System.Drawing.Image)(resources.GetObject("btnClosefrmTabla.Image")));
            this.btnClosefrmTabla.Location = new System.Drawing.Point(716, 8);
            this.btnClosefrmTabla.Name = "btnClosefrmTabla";
            this.btnClosefrmTabla.Size = new System.Drawing.Size(42, 32);
            this.btnClosefrmTabla.TabIndex = 16;
            this.btnClosefrmTabla.UseVisualStyleBackColor = false;
            this.btnClosefrmTabla.Click += new System.EventHandler(this.btnClosefrmTabla_Click);
            // 
            // btnCrearBD
            // 
            this.btnCrearBD.Location = new System.Drawing.Point(15, 399);
            this.btnCrearBD.Name = "btnCrearBD";
            this.btnCrearBD.Size = new System.Drawing.Size(105, 38);
            this.btnCrearBD.TabIndex = 15;
            this.btnCrearBD.Text = "Crear Tabla";
            this.btnCrearBD.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "- Campos -";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.dataType,
            this.allowNull,
            this.identity,
            this.primaryKey});
            this.dataGridView1.Location = new System.Drawing.Point(15, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 290);
            this.dataGridView1.TabIndex = 13;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Nombre Columna";
            this.columnName.Name = "columnName";
            this.columnName.Width = 200;
            // 
            // dataType
            // 
            this.dataType.HeaderText = "Tipo de Dato";
            this.dataType.Name = "dataType";
            this.dataType.Width = 200;
            // 
            // allowNull
            // 
            this.allowNull.HeaderText = "Not Null";
            this.allowNull.Name = "allowNull";
            // 
            // identity
            // 
            this.identity.HeaderText = "Identity";
            this.identity.Name = "identity";
            // 
            // primaryKey
            // 
            this.primaryKey.HeaderText = "Primary Key";
            this.primaryKey.Name = "primaryKey";
            // 
            // txbNameTabla
            // 
            this.txbNameTabla.Location = new System.Drawing.Point(121, 24);
            this.txbNameTabla.Name = "txbNameTabla";
            this.txbNameTabla.Size = new System.Drawing.Size(133, 20);
            this.txbNameTabla.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre de la Tabla:";
            // 
            // creatorTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClosefrmTabla);
            this.Controls.Add(this.btnCrearBD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbNameTabla);
            this.Controls.Add(this.label1);
            this.Name = "creatorTable";
            this.Size = new System.Drawing.Size(775, 445);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClosefrmTabla;
        private System.Windows.Forms.Button btnCrearBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allowNull;
        private System.Windows.Forms.DataGridViewTextBoxColumn identity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn primaryKey;
        private System.Windows.Forms.TextBox txbNameTabla;
        private System.Windows.Forms.Label label1;
    }
}
