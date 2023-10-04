namespace miniGestor
{
    partial class Gestor
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
            this.components = new System.ComponentModel.Container();
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnConectServer = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmServer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevaBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmBD = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmTabla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarCampoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCampoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCamposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmServer.SuspendLayout();
            this.cmBD.SuspendLayout();
            this.cmTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(2, 51);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(180, 531);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // btnConectServer
            // 
            this.btnConectServer.Location = new System.Drawing.Point(2, 13);
            this.btnConectServer.Name = "btnConectServer";
            this.btnConectServer.Size = new System.Drawing.Size(50, 32);
            this.btnConectServer.TabIndex = 1;
            this.btnConectServer.Text = "Conectar";
            this.btnConectServer.UseVisualStyleBackColor = true;
            this.btnConectServer.Click += new System.EventHandler(this.btnConectServer_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(58, 12);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(54, 32);
            this.btnDesconectar.TabIndex = 2;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(118, 13);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(64, 32);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Refrescar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmServer
            // 
            this.cmServer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaBaseDeDatosToolStripMenuItem});
            this.cmServer.Name = "contextMenuStrip1";
            this.cmServer.Size = new System.Drawing.Size(185, 26);
            // 
            // nuevaBaseDeDatosToolStripMenuItem
            // 
            this.nuevaBaseDeDatosToolStripMenuItem.Name = "nuevaBaseDeDatosToolStripMenuItem";
            this.nuevaBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.nuevaBaseDeDatosToolStripMenuItem.Text = "Nueva Base de Datos";
            this.nuevaBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.nuevaBaseDeDatosToolStripMenuItem_Click);
            // 
            // cmBD
            // 
            this.cmBD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTablaToolStripMenuItem,
            this.eliminarBaseDeDatosToolStripMenuItem});
            this.cmBD.Name = "cmBD";
            this.cmBD.Size = new System.Drawing.Size(194, 70);
            // 
            // agregarTablaToolStripMenuItem
            // 
            this.agregarTablaToolStripMenuItem.Name = "agregarTablaToolStripMenuItem";
            this.agregarTablaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.agregarTablaToolStripMenuItem.Text = "Agregar tabla";
            this.agregarTablaToolStripMenuItem.Click += new System.EventHandler(this.agregarTablaToolStripMenuItem_Click);
            // 
            // eliminarBaseDeDatosToolStripMenuItem
            // 
            this.eliminarBaseDeDatosToolStripMenuItem.Name = "eliminarBaseDeDatosToolStripMenuItem";
            this.eliminarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.eliminarBaseDeDatosToolStripMenuItem.Text = "Eliminar Base de Datos";
            this.eliminarBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.eliminarBaseDeDatosToolStripMenuItem_Click);
            // 
            // cmTabla
            // 
            this.cmTabla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCampoToolStripMenuItem,
            this.editarCampoToolStripMenuItem,
            this.eliminarCamposToolStripMenuItem,
            this.eliminarTablaToolStripMenuItem});
            this.cmTabla.Name = "cmTabla";
            this.cmTabla.Size = new System.Drawing.Size(165, 92);
            // 
            // agregarCampoToolStripMenuItem
            // 
            this.agregarCampoToolStripMenuItem.Name = "agregarCampoToolStripMenuItem";
            this.agregarCampoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.agregarCampoToolStripMenuItem.Text = "Agregar Campo";
            // 
            // editarCampoToolStripMenuItem
            // 
            this.editarCampoToolStripMenuItem.Name = "editarCampoToolStripMenuItem";
            this.editarCampoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.editarCampoToolStripMenuItem.Text = "Editar Campos";
            // 
            // eliminarCamposToolStripMenuItem
            // 
            this.eliminarCamposToolStripMenuItem.Name = "eliminarCamposToolStripMenuItem";
            this.eliminarCamposToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.eliminarCamposToolStripMenuItem.Text = "Eliminar Campos";
            // 
            // eliminarTablaToolStripMenuItem
            // 
            this.eliminarTablaToolStripMenuItem.Name = "eliminarTablaToolStripMenuItem";
            this.eliminarTablaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.eliminarTablaToolStripMenuItem.Text = "Eliminar Tabla";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(188, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 531);
            this.panel1.TabIndex = 5;
            // 
            // Gestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectServer);
            this.Controls.Add(this.treeView);
            this.Name = "Gestor";
            this.Text = "Gestor";
            this.cmServer.ResumeLayout(false);
            this.cmBD.ResumeLayout(false);
            this.cmTabla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button btnConectServer;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ContextMenuStrip cmServer;
        private System.Windows.Forms.ToolStripMenuItem nuevaBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmBD;
        private System.Windows.Forms.ToolStripMenuItem agregarTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmTabla;
        private System.Windows.Forms.ToolStripMenuItem agregarCampoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCampoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCamposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTablaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}