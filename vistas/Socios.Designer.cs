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
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSocios
            // 
            this.lblSocios.AutoSize = true;
            this.lblSocios.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocios.Location = new System.Drawing.Point(273, 16);
            this.lblSocios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSocios.Name = "lblSocios";
            this.lblSocios.Size = new System.Drawing.Size(244, 34);
            this.lblSocios.TabIndex = 0;
            this.lblSocios.Text = "Inscripcion Socios";
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
            this.btnGuardarSocio.Location = new System.Drawing.Point(234, 417);
            this.btnGuardarSocio.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarSocio.Name = "btnGuardarSocio";
            this.btnGuardarSocio.Size = new System.Drawing.Size(344, 60);
            this.btnGuardarSocio.TabIndex = 2;
            this.btnGuardarSocio.Text = "Guardar socio ";
            this.btnGuardarSocio.UseVisualStyleBackColor = false;
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblX.Location = new System.Drawing.Point(1001, 16);
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
            this.pnlContenedor.Controls.Add(this.lblSocios);
            this.pnlContenedor.Controls.Add(this.lblX);
            this.pnlContenedor.Controls.Add(this.btnGuardarSocio);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1050, 600);
            this.pnlContenedor.TabIndex = 4;
            // 
            // Socios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.pnlContenedor);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Socios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Socios";
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSocios;
        private System.Windows.Forms.Button btnGuardarSocio;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}