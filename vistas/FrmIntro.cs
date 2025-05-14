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
    public partial class FrmIntro : Form
    {
        public FrmIntro()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlCarga2.Width += 9;
            if (pnlCarga2.Width >= 525)
            {
                timer1.Stop();
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }
    }
}
