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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String usuario = txtUser.Text;
            String password = txtPass.PasswordChar.ToString();

            HomeFrm home = new HomeFrm(this);
            this.Hide();
            home.Show();
        }
    }
}
