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
            this.Load += Socios_Load;

            // Asociar eventos a los TextBox
            txtNombreSocio.Enter += TextBox_Enter;
            txtNombreSocio.Leave += TextBox_Leave;

            txtApellido.Enter += TextBox_Enter;
            txtApellido.Leave += TextBox_Leave;

            txtDNI.Enter += TextBox_Enter;
            txtDNI.Leave += TextBox_Leave;

            txtMail.Enter += TextBox_Enter;
            txtMail.Leave += TextBox_Leave;

            txtTelefono.Enter += TextBox_Enter;
            txtTelefono.Leave += TextBox_Leave;

            txtDomicilio.Enter += TextBox_Enter;
            txtDomicilio.Leave += TextBox_Leave;

            txtContactoEmergencia.Enter += TextBox_Enter;
            txtContactoEmergencia.Leave += TextBox_Leave;

            txtCoberturaMedica.Enter += TextBox_Enter;
            txtCoberturaMedica.Leave += TextBox_Leave;


        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
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
                string domicilio = txtDomicilio.Text.Trim();

                Socio socio = new Socio(estadoSocio, aptoFisico, nombre, apellido, dni, email, telefono, domicilio);


                /*Socio socio = new Socio(estadoSocio, aptoFisico, nombre, apellido, dni, email, telefono);*/

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

                    if (exitoInfo) { 
                        MessageBox.Show("Socio y datos médicos guardados correctamente.");
                        btnLimpiar.PerformClick(); // Llama al botón limpiar
                    }

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreSocio.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtMail.Text = "";
            txtTelefono.Text = "";
            txtDomicilio.Text = "";
            txtContactoEmergencia.Text = "";
            txtCoberturaMedica.Text = "";
            dtpVencimientoApto.Value = DateTime.Now;
            chkbAptoMedico.Checked = false;
            // Restaurar los placeholders 
            RestaurarPlaceholders();

        }

        private void Socios_Load(object sender, EventArgs e)
        {
            RestaurarPlaceholders();
        }

        private void RestaurarPlaceholders()
        {
            txtNombreSocio.Text = "Ingrese nombre";
            txtApellido.Text = "Ingrese apellido";
            txtDNI.Text = "Ingrese DNI";
            txtMail.Text = "Ingrese email";
            txtTelefono.Text = "Ingrese teléfono";
            txtDomicilio.Text = "Ingrese domicilio";
            txtContactoEmergencia.Text = "Ingrese contacto de emergencia";
            txtCoberturaMedica.Text = "Ingrese cobertura médica";

            Color gris = Color.Gray;

            txtNombreSocio.ForeColor = gris;
            txtApellido.ForeColor = gris;
            txtDNI.ForeColor = gris;
            txtMail.ForeColor = gris;
            txtTelefono.ForeColor = gris;
            txtDomicilio.ForeColor = gris;
            txtContactoEmergencia.ForeColor = gris;
            txtCoberturaMedica.ForeColor = gris;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null && txt.ForeColor == Color.Gray)
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreSocio.Text))
            {
                txtNombreSocio.Text = "Ingrese nombre";
                txtNombreSocio.ForeColor = Color.Gray;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                txtApellido.Text = "Ingrese apellido";
                txtApellido.ForeColor = Color.Gray;
            }

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                txtDNI.Text = "Ingrese DNI";
                txtDNI.ForeColor = Color.Gray;
            }

            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                txtMail.Text = "Ingrese email";
                txtMail.ForeColor = Color.Gray;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                txtTelefono.Text = "Ingrese teléfono";
                txtTelefono.ForeColor = Color.Gray;
            }

            if (string.IsNullOrWhiteSpace(txtDomicilio.Text))
            {
                txtDomicilio.Text = "Ingrese domicilio";
                txtDomicilio.ForeColor = Color.Gray;
            }

            if (string.IsNullOrWhiteSpace(txtContactoEmergencia.Text))
            {
                txtContactoEmergencia.Text = "Ingrese contacto de emergencia";
                txtContactoEmergencia.ForeColor = Color.Gray;
            }

            if (string.IsNullOrWhiteSpace(txtCoberturaMedica.Text))
            {
                txtCoberturaMedica.Text = "Ingrese cobertura médica";
                txtCoberturaMedica.ForeColor = Color.Gray;
            }
        }



    }
}
