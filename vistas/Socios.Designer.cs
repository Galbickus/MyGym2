namespace MyGym2
{
    partial class Socios
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
            this.lblSocios = new System.Windows.Forms.Label();
            this.btnGuardarSocio = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.groupBoxMedico = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpVencimientoApto = new System.Windows.Forms.DateTimePicker();
            this.txtCoberturaMedica = new System.Windows.Forms.TextBox();
            this.txtContactoEmergencia = new System.Windows.Forms.TextBox();
            this.chkbAptoMedico = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.pnlContenedor.SuspendLayout();
            this.groupBoxMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSocios
            // 
            this.lblSocios.AutoSize = true;
            this.lblSocios.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocios.Location = new System.Drawing.Point(264, 16);
            this.lblSocios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSocios.Name = "lblSocios";
            this.lblSocios.Size = new System.Drawing.Size(244, 34);
            this.lblSocios.TabIndex = 0;
            this.lblSocios.Text = "Inscripción Socios";
            // 
            // btnGuardarSocio
            // 
            this.btnGuardarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGuardarSocio.FlatAppearance.BorderSize = 0;
            this.btnGuardarSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarSocio.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarSocio.ForeColor = System.Drawing.Color.White;
            this.btnGuardarSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarSocio.Location = new System.Drawing.Point(80, 391);
            this.btnGuardarSocio.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarSocio.Name = "btnGuardarSocio";
            this.btnGuardarSocio.Size = new System.Drawing.Size(270, 60);
            this.btnGuardarSocio.TabIndex = 2;
            this.btnGuardarSocio.Text = "Guardar ";
            this.btnGuardarSocio.UseVisualStyleBackColor = false;
            this.btnGuardarSocio.Click += new System.EventHandler(this.btnGuardarSocio_Click);
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblX.Location = new System.Drawing.Point(715, 16);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(23, 24);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContenedor.Controls.Add(this.groupBoxMedico);
            this.pnlContenedor.Controls.Add(this.btnLimpiar);
            this.pnlContenedor.Controls.Add(this.txtMail);
            this.pnlContenedor.Controls.Add(this.txtDomicilio);
            this.pnlContenedor.Controls.Add(this.txtTelefono);
            this.pnlContenedor.Controls.Add(this.txtDNI);
            this.pnlContenedor.Controls.Add(this.txtApellido);
            this.pnlContenedor.Controls.Add(this.txtNombreSocio);
            this.pnlContenedor.Controls.Add(this.lblSocios);
            this.pnlContenedor.Controls.Add(this.lblX);
            this.pnlContenedor.Controls.Add(this.btnGuardarSocio);
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(799, 492);
            this.pnlContenedor.TabIndex = 4;
            // 
            // groupBoxMedico
            // 
            this.groupBoxMedico.Controls.Add(this.label1);
            this.groupBoxMedico.Controls.Add(this.dtpVencimientoApto);
            this.groupBoxMedico.Controls.Add(this.txtCoberturaMedica);
            this.groupBoxMedico.Controls.Add(this.txtContactoEmergencia);
            this.groupBoxMedico.Controls.Add(this.chkbAptoMedico);
            this.groupBoxMedico.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBoxMedico.Location = new System.Drawing.Point(12, 244);
            this.groupBoxMedico.Name = "groupBoxMedico";
            this.groupBoxMedico.Size = new System.Drawing.Size(725, 125);
            this.groupBoxMedico.TabIndex = 14;
            this.groupBoxMedico.TabStop = false;
            this.groupBoxMedico.Text = "Información Médica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Vencimiento";
            // 
            // dtpVencimientoApto
            // 
            this.dtpVencimientoApto.CalendarFont = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimientoApto.CalendarForeColor = System.Drawing.SystemColors.GrayText;
            this.dtpVencimientoApto.CalendarTitleForeColor = System.Drawing.SystemColors.GrayText;
            this.dtpVencimientoApto.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimientoApto.Location = new System.Drawing.Point(519, 82);
            this.dtpVencimientoApto.Name = "dtpVencimientoApto";
            this.dtpVencimientoApto.Size = new System.Drawing.Size(200, 28);
            this.dtpVencimientoApto.TabIndex = 14;
            // 
            // txtCoberturaMedica
            // 
            this.txtCoberturaMedica.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoberturaMedica.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtCoberturaMedica.Location = new System.Drawing.Point(6, 31);
            this.txtCoberturaMedica.Multiline = true;
            this.txtCoberturaMedica.Name = "txtCoberturaMedica";
            this.txtCoberturaMedica.Size = new System.Drawing.Size(350, 30);
            this.txtCoberturaMedica.TabIndex = 12;
            // 
            // txtContactoEmergencia
            // 
            this.txtContactoEmergencia.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactoEmergencia.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtContactoEmergencia.Location = new System.Drawing.Point(376, 31);
            this.txtContactoEmergencia.Multiline = true;
            this.txtContactoEmergencia.Name = "txtContactoEmergencia";
            this.txtContactoEmergencia.Size = new System.Drawing.Size(343, 30);
            this.txtContactoEmergencia.TabIndex = 13;
            // 
            // chkbAptoMedico
            // 
            this.chkbAptoMedico.AutoSize = true;
            this.chkbAptoMedico.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbAptoMedico.ForeColor = System.Drawing.SystemColors.GrayText;
            this.chkbAptoMedico.Location = new System.Drawing.Point(6, 82);
            this.chkbAptoMedico.Name = "chkbAptoMedico";
            this.chkbAptoMedico.Size = new System.Drawing.Size(188, 24);
            this.chkbAptoMedico.TabIndex = 10;
            this.chkbAptoMedico.Text = "Apto médico vigente";
            this.chkbAptoMedico.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(416, 391);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(270, 60);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtMail.Location = new System.Drawing.Point(388, 183);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(350, 30);
            this.txtMail.TabIndex = 9;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtDomicilio.Location = new System.Drawing.Point(12, 183);
            this.txtDomicilio.Multiline = true;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(350, 30);
            this.txtDomicilio.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtTelefono.Location = new System.Drawing.Point(388, 122);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(350, 30);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtDNI.Location = new System.Drawing.Point(12, 122);
            this.txtDNI.Multiline = true;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(350, 30);
            this.txtDNI.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtApellido.Location = new System.Drawing.Point(388, 68);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(350, 30);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSocio.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNombreSocio.Location = new System.Drawing.Point(12, 68);
            this.txtNombreSocio.Multiline = true;
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.Size = new System.Drawing.Size(350, 30);
            this.txtNombreSocio.TabIndex = 4;
            // 
            // Socios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 492);
            this.Controls.Add(this.pnlContenedor);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Socios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Socios";
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.groupBoxMedico.ResumeLayout(false);
            this.groupBoxMedico.PerformLayout();
            this.ResumeLayout(false);

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