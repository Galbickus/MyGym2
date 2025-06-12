namespace MyGym2.vistas
{
    partial class Visitantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Visitantes";
        }

        #endregion
        private System.Windows.Forms.Label lblSocios;
        private System.Windows.Forms.Button btnGuardarSocio;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox chkbAptoMedico;
        private System.Windows.Forms.TextBox txtCoberturaMedica;
        private System.Windows.Forms.TextBox txtContactoEmergencia;
        private System.Windows.Forms.GroupBox groupBoxMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpVencimientoApto;

    }
}