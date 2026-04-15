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
    public partial class HomeFrm : Form
    {
        Form login;
        public HomeFrm(Form frmLogin)
        {
            InitializeComponent();
            login = frmLogin;
        }

        private void btnCerrarHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlHomeConfig_Click(object sender, EventArgs e)
        {
            login.Hide();
            ConfiguracionFrm config = new ConfiguracionFrm(this);
            config.Show();
        }

        private void pnlGestiones_Click(object sender, EventArgs e)
        {
            login.Hide();
            GestionesFrm gestiones = new GestionesFrm(this);
            gestiones.Show();
        }
    }
}
