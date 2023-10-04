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
    public partial class creatorTable : UserControl
    {
        ParametrosConexion parametros = new ParametrosConexion();

        public creatorTable(ParametrosConexion parametrosConexion)
        {
            InitializeComponent();
            parametros = parametrosConexion;
        }

        private void btnClosefrmTabla_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
