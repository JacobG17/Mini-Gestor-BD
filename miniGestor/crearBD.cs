using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using opDatos;

namespace miniGestor
{
    public partial class crearTabla : UserControl
    {
        Datos datos = new Datos();
        ParametrosConexion parametros = new ParametrosConexion();
        public crearTabla(ParametrosConexion parametrosConn)
        {
            InitializeComponent();
            parametros = parametrosConn;
            btnCrearBD.Enabled = false;
            if (txbNameBD.Text != null)
            {
                btnCrearBD.Enabled = true;
            }
        }

        private void btnCrearBD_Click(object sender, EventArgs e)
        {
            string bdName = txbNameBD.Text;
            try
            {
                datos.createBD(parametros, bdName);
                MessageBox.Show($"!La base de datos {bdName} fue creada con exito!", "CORRECTO");
                txbNameBD.Text = null;
                this.Hide();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "ERROR");
            }
            
        }

        private void btnClosefrmBD_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
