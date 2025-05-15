using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {


            datos.UsuarioDao dato = new datos.UsuarioDao();
            DataTable tablaLogin = dato.Log_Usu(txtUsuario.Text, txtpassword.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                // Usuario válido
                MessageBox.Show("Ingreso exitoso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); // Ocultamos el formulario de login

                FrmPpal principal = new FrmPpal(); // Instanciamos el formulario principal
                principal.FormClosed += (s, args) => Application.Exit(); // Cuando se cierre Form1, cierra la app
                principal.Show(); // Mostramos Form1
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            /*DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            datos.UsuarioDao dato = new datos.UsuarioDao(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtpassword.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }*/

        }
    }
}
