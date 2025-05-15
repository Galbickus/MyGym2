using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MyGym2.vistas;

namespace MyGym2
{
    public partial class FrmPpal : Form
    {
        public FrmPpal()
        {
            InitializeComponent();
        }
        ///**Para que se pueda arrastrar importar la libreria 'System.Runtime.InteropServices' clickeando boron izq en la barra sup y arrastra
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        /// 
        
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 56;  //ver 56
            }
            else
            {
                MenuVertical.Width = 250;


            }
        }
        
        private void picbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picbRestaurar.Visible = true;
            picbMaximizar.Visible = false;
        }

        private void picbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picbRestaurar.Visible = false;
            picbMaximizar.Visible = true;
        }

        private void picbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void BtnInscribirSocio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Socios());

        }

        /*private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }*/

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");

            // Capitaliza la primera letra de la fecha
            string fecha = DateTime.Now.ToLongDateString();
            lblFecha.Text = char.ToUpper(fecha[0]) + fecha.Substring(1);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("¿Estás seguro de Cerrar Sesión?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide();
            }
        }

        /*
        private void LoginUsuario(string username, string password)
        {
            // Aquí, implementas la lógica de acceso a la base de datos
            // Por ejemplo, supongamos que tienes una función GetUserCategory que obtiene la categoría del usuario
            string categoria = GetUserCategory(username, password);  // Esto es solo un ejemplo

            // Supongamos que el nombre del usuario también se obtiene desde la base de datos
            string nombreUsuario = GetUserName(username);  // Esto es solo un ejemplo

            // Mostrar en el Label
            lblMuestraUsuario.Text = $"Usuario: {nombreUsuario} | Categoría: {categoria}";
        }
        */
    }
}

