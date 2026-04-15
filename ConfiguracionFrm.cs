using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDB_PED_Biblioteca
{
    public partial class ConfiguracionFrm : Form
    {
        Form home;
        public ConfiguracionFrm(Form frmHome)
        {
            InitializeComponent();
            home = frmHome;
        }

        private void lblConfigVolver_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }
    }
}
