namespace MyGym2.vistas
{
    partial class Caja
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
            this.lblCaja = new System.Windows.Forms.Label();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.DNI = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorID = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.btnImprimirComprobante = new System.Windows.Forms.Button();
            this.lblDatosSocio = new System.Windows.Forms.Label();
            this.DNI.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.Location = new System.Drawing.Point(280, 31);
            this.lblCaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(70, 34);
            this.lblCaja.TabIndex = 1;
            this.lblCaja.Text = "Caja";
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRegistrarPago.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPago.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPago.Location = new System.Drawing.Point(45, 323);
            this.btnRegistrarPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(270, 60);
            this.btnRegistrarPago.TabIndex = 3;
            this.btnRegistrarPago.Text = "Registrar Pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = false;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // DNI
            // 
            this.DNI.Controls.Add(this.btnBuscarPorID);
            this.DNI.Controls.Add(this.txtID);
            this.DNI.Location = new System.Drawing.Point(45, 77);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(548, 86);
            this.DNI.TabIndex = 4;
            this.DNI.TabStop = false;
            this.DNI.Text = "N° de Cliente";
            // 
            // btnBuscarPorID
            // 
            this.btnBuscarPorID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscarPorID.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBuscarPorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorID.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPorID.Location = new System.Drawing.Point(306, 34);
            this.btnBuscarPorID.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPorID.Name = "btnBuscarPorID";
            this.btnBuscarPorID.Size = new System.Drawing.Size(200, 30);
            this.btnBuscarPorID.TabIndex = 6;
            this.btnBuscarPorID.Text = "Buscar";
            this.btnBuscarPorID.UseVisualStyleBackColor = false;
            this.btnBuscarPorID.Click += new System.EventHandler(this.btnBuscarPorID_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtID.Location = new System.Drawing.Point(6, 34);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(250, 30);
            this.txtID.TabIndex = 5;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtMonto.Location = new System.Drawing.Point(51, 245);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(250, 30);
            this.txtMonto.TabIndex = 6;
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Debito",
            "Credito"});
            this.cmbFormaPago.Location = new System.Drawing.Point(351, 249);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(200, 24);
            this.cmbFormaPago.TabIndex = 7;
            // 
            // btnImprimirComprobante
            // 
            this.btnImprimirComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnImprimirComprobante.FlatAppearance.BorderSize = 0;
            this.btnImprimirComprobante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnImprimirComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirComprobante.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirComprobante.ForeColor = System.Drawing.Color.White;
            this.btnImprimirComprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirComprobante.Location = new System.Drawing.Point(329, 323);
            this.btnImprimirComprobante.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimirComprobante.Name = "btnImprimirComprobante";
            this.btnImprimirComprobante.Size = new System.Drawing.Size(270, 60);
            this.btnImprimirComprobante.TabIndex = 8;
            this.btnImprimirComprobante.Text = "Imprimir Comprobante";
            this.btnImprimirComprobante.UseVisualStyleBackColor = false;
            // 
            // lblDatosSocio
            // 
            this.lblDatosSocio.AutoSize = true;
            this.lblDatosSocio.Location = new System.Drawing.Point(60, 193);
            this.lblDatosSocio.Name = "lblDatosSocio";
            this.lblDatosSocio.Size = new System.Drawing.Size(44, 16);
            this.lblDatosSocio.TabIndex = 9;
            this.lblDatosSocio.Text = "label1";
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 492);
            this.Controls.Add(this.lblDatosSocio);
            this.Controls.Add(this.btnImprimirComprobante);
            this.Controls.Add(this.cmbFormaPago);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.lblCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Caja";
            this.Text = "Caja";
            this.DNI.ResumeLayout(false);
            this.DNI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.GroupBox DNI;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuscarPorID;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Button btnImprimirComprobante;
        private System.Windows.Forms.Label lblDatosSocio;
    }
}