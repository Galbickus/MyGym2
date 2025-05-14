using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGym2.vistas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            /*txtpassword.UseSystemPasswordChar = !chkMostrarContra.Checked;*/
            txtpassword.PasswordChar = chkMostrarContra.Checked ? '\0' : '*';
        }
    }
}
