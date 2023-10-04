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
    public partial class Login : Form
    {
        Datos conn = new Datos();
        ParametrosConexion parametros = new ParametrosConexion();
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            parametros.Server = txbServer.Text;
            parametros.User = txbUser.Text;
            parametros.Password = txbPassword.Text;

            try
            {
                conn.OpenConexion(parametros);
                this.Hide();
                Gestor gestorBD = new Gestor(txbServer.Text, parametros);
                if (gestorBD.Visible)
                {
                    
                }
                else
                {
                    gestorBD.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
