using MyGym2.datos;
using MyGym2.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGym2
{
    public partial class Socios : Form
    {
        public Socios()
        {
            InitializeComponent();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*

        private void btnGuardarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                // Recolectar datos desde los campos del formulario
                string nombre = txtNombreSocio.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string dni = txtDNI.Text.Trim();
                string email = txtMail.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                bool aptoFisico = chkbAptoMedico.Checked;
                bool estadoSocio = true; // Podés ajustar según tu lógica

                // Crear objeto Socio
                Socio nuevoSocio = new Socio(estadoSocio, aptoFisico, nombre, apellido, dni, email, telefono);

                // Guardar en la base de datos
                bool exito = SocioDatos.InsertarSocio(nuevoSocio);

                if (exito)
                {
                    MessageBox.Show("Socio guardado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el socio.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        */

        private void btnGuardarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                // Datos del socio
                string nombre = txtNombreSocio.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string dni = txtDNI.Text.Trim();
                string email = txtMail.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                bool aptoFisico = chkbAptoMedico.Checked;
                bool estadoSocio = true;

                Socio socio = new Socio(estadoSocio, aptoFisico, nombre, apellido, dni, email, telefono);

                // Insertar socio y obtener ID
                int idSocio = SocioDatos.InsertarSocioYDevolverID(socio);

                if (idSocio > 0)
                {
                    // Datos médicos
                    string cobertura = txtCoberturaMedica.Text.Trim();
                    string contacto = txtContactoEmergencia.Text.Trim();
                    DateTime vencimiento = dtpVencimientoApto.Value;

                    InformacionMedica info = new InformacionMedica(idSocio, cobertura, contacto, vencimiento);

                    bool exitoInfo = InformacionMedicaDatos.InsertarInformacionMedica(info);

                    if (exitoInfo)
                        MessageBox.Show("Socio y datos médicos guardados correctamente.");
                    else
                        MessageBox.Show("Socio guardado, pero hubo un problema al guardar la información médica.");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el socio.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
