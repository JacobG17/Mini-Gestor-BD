using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using opDatos;

namespace miniGestor
{
    public partial class Gestor : Form
    {
        Datos datos = new Datos();
        List<string> serverList = new List<string>();
        List<string> bdList = new List<string>();
        List<string> tableList = new List<string>();
        List<string> camposList = new List<string>();

        ParametrosConexion parametros = new ParametrosConexion();
        string Server;
        public Gestor(string servidor, ParametrosConexion ParametrosConn)
        {
            InitializeComponent();
            parametros = ParametrosConn;
            Server = servidor;
            cargarArbol(servidor, parametros);
        }

        public void cargarArbol(string servidor, ParametrosConexion parametros)
        {
            TreeNode nodoServidor = new TreeNode(servidor);

            treeView.Nodes.Add(nodoServidor);

            serverList.Add(servidor);

            string query = "SELECT name FROM sys.databases;";
            bdList = datos.ObtieneDatos(parametros, query);

            foreach (var database in bdList)
            {
                TreeNode nodoDatabase = new TreeNode(database);
                nodoServidor.Nodes.Add(nodoDatabase);

                query = $"USE {database}; SELECT table_name = t.name FROM sys.tables t INNER JOIN sys.schemas s ON t.schema_id = s.schema_id ORDER BY t.name; ";
                tableList = datos.ObtieneDatos(parametros, query);
                foreach (var tabla in tableList)
                {
                    TreeNode nodoTabla = new TreeNode(tabla);
                    nodoDatabase.Nodes.Add(nodoTabla);

                    TreeNode nodoColumna = new TreeNode("Columnns");
                    nodoTabla.Nodes.Add(nodoColumna);

                    query = $"USE {database}; SELECT COLUMN_NAME + ' (' + DATA_TYPE + CASE WHEN CHARACTER_MAXIMUM_LENGTH IS NOT NULL THEN '(' + CAST(CHARACTER_MAXIMUM_LENGTH AS NVARCHAR(255)) + ')' ELSE '' END + CASE WHEN IS_NULLABLE = 'YES' THEN ' null' + ')' ELSE ' not null' + ')' END AS InformacionColumna FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tabla}'; ";

                    camposList = datos.ObtieneDatos(parametros, query);
                    foreach (var campo in camposList)
                    {
                        TreeNode nodoCampo = new TreeNode(campo);
                        nodoColumna.Nodes.Add(nodoCampo);
                    }
                }
                nodoServidor.Expand();
            }
        }

        private void btnConectServer_Click(object sender, EventArgs e)
        {
            Login NewServer = new Login();
            NewServer.Show();
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Verifica si se hizo clic derecho
            {
                // Obtén el nodo que se hizo clic
                TreeNode clickedNode = e.Node;

                foreach (var server in serverList)
                {
                    if (clickedNode.Text == server)
                    {
                        cmServer.Show(treeView, e.Location);
                        treeView.SelectedNode = clickedNode;
                    }
                }

                foreach (var bd in bdList)
                {
                    if (clickedNode.Text == bd)
                    {
                        cmBD.Show(treeView, e.Location);
                        treeView.SelectedNode = clickedNode;
                    }
                }

                foreach (var tabla in tableList)
                {
                    if (clickedNode.Text == tabla)
                    {
                        cmTabla.Show(treeView, e.Location);
                        treeView.SelectedNode = clickedNode;
                    }
                }
            }
        }

        private void nuevaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearTabla crearBD = new crearTabla(parametros);
            crearBD.Location = new Point(0, 0);
            crearBD.Size = panel1.Size;
            panel1.Controls.Add(crearBD);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        public void actualizar()
        {
            treeView.Nodes.Clear();
            cargarArbol(Server, parametros);
        }

        private void eliminarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreNodo = treeView.SelectedNode.Text;
            DialogResult resultado = MessageBox.Show($"¿Deseas Eliminar la Base de Datos {nombreNodo}?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            // Verifica la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                datos.deleteBD(parametros, nombreNodo);
                MessageBox.Show("!Eliminado Correctamente!","CORRECTO");
                actualizar();
            }
            else if (resultado == DialogResult.No)
            {
                
            }
        }

        private void agregarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            creatorTable createTable = new creatorTable(parametros);
            createTable.Location = new Point(0, 0);
            createTable.Size = panel1.Size;
            panel1.Controls.Add(createTable);
        }
    }
}
