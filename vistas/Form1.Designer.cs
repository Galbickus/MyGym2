namespace MyGym2
{
    partial class FrmPpal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPpal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnListarSocios = new System.Windows.Forms.Button();
            this.btnPagarCuota = new System.Windows.Forms.Button();
            this.btnInscribirActividad = new System.Windows.Forms.Button();
            this.btnEmitirCarnet = new System.Windows.Forms.Button();
            this.btnIncribirVisitantes = new System.Windows.Forms.Button();
            this.btnInscribirSocio = new System.Windows.Forms.Button();
            this.picbMarca = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.picbMinimizar = new System.Windows.Forms.PictureBox();
            this.picbRestaurar = new System.Windows.Forms.PictureBox();
            this.picbMaximizar = new System.Windows.Forms.PictureBox();
            this.picbCerrar = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.btnLogOut = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbMarca)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btnLogOut);
            this.MenuVertical.Controls.Add(this.lblFecha);
            this.MenuVertical.Controls.Add(this.lblHora);
            this.MenuVertical.Controls.Add(this.btnListarSocios);
            this.MenuVertical.Controls.Add(this.btnPagarCuota);
            this.MenuVertical.Controls.Add(this.btnInscribirActividad);
            this.MenuVertical.Controls.Add(this.btnEmitirCarnet);
            this.MenuVertical.Controls.Add(this.btnIncribirVisitantes);
            this.MenuVertical.Controls.Add(this.btnInscribirSocio);
            this.MenuVertical.Controls.Add(this.picbMarca);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFecha.Location = new System.Drawing.Point(-3, 483);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 15);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHora.Location = new System.Drawing.Point(-6, 511);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(89, 34);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "HORA";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListarSocios
            // 
            this.btnListarSocios.FlatAppearance.BorderSize = 0;
            this.btnListarSocios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btnListarSocios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btnListarSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarSocios.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarSocios.ForeColor = System.Drawing.Color.White;
            this.btnListarSocios.Image = ((System.Drawing.Image)(resources.GetObject("btnListarSocios.Image")));
            this.btnListarSocios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarSocios.Location = new System.Drawing.Point(0, 395);
            this.btnListarSocios.Name = "btnListarSocios";
            this.btnListarSocios.Size = new System.Drawing.Size(250, 40);
            this.btnListarSocios.TabIndex = 6;
            this.btnListarSocios.Text = "Listar socios";
            this.btnListarSocios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarSocios.UseVisualStyleBackColor = true;
            // 
            // btnPagarCuota
            // 
            this.btnPagarCuota.FlatAppearance.BorderSize = 0;
            this.btnPagarCuota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btnPagarCuota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btnPagarCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarCuota.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarCuota.ForeColor = System.Drawing.Color.White;
            this.btnPagarCuota.Image = ((System.Drawing.Image)(resources.GetObject("btnPagarCuota.Image")));
            this.btnPagarCuota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagarCuota.Location = new System.Drawing.Point(0, 336);
            this.btnPagarCuota.Name = "btnPagarCuota";
            this.btnPagarCuota.Size = new System.Drawing.Size(250, 40);
            this.btnPagarCuota.TabIndex = 5;
            this.btnPagarCuota.Text = "Pagar cuota";
            this.btnPagarCuota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagarCuota.UseVisualStyleBackColor = true;
            // 
            // btnInscribirActividad
            // 
            this.btnInscribirActividad.FlatAppearance.BorderSize = 0;
            this.btnInscribirActividad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btnInscribirActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btnInscribirActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribirActividad.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribirActividad.ForeColor = System.Drawing.Color.White;
            this.btnInscribirActividad.Image = ((System.Drawing.Image)(resources.GetObject("btnInscribirActividad.Image")));
            this.btnInscribirActividad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscribirActividad.Location = new System.Drawing.Point(0, 279);
            this.btnInscribirActividad.Name = "btnInscribirActividad";
            this.btnInscribirActividad.Size = new System.Drawing.Size(250, 40);
            this.btnInscribirActividad.TabIndex = 4;
            this.btnInscribirActividad.Text = "Inscribir actividad";
            this.btnInscribirActividad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInscribirActividad.UseVisualStyleBackColor = true;
            // 
            // btnEmitirCarnet
            // 
            this.btnEmitirCarnet.FlatAppearance.BorderSize = 0;
            this.btnEmitirCarnet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btnEmitirCarnet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btnEmitirCarnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirCarnet.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirCarnet.ForeColor = System.Drawing.Color.White;
            this.btnEmitirCarnet.Image = ((System.Drawing.Image)(resources.GetObject("btnEmitirCarnet.Image")));
            this.btnEmitirCarnet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmitirCarnet.Location = new System.Drawing.Point(0, 222);
            this.btnEmitirCarnet.Name = "btnEmitirCarnet";
            this.btnEmitirCarnet.Size = new System.Drawing.Size(250, 40);
            this.btnEmitirCarnet.TabIndex = 3;
            this.btnEmitirCarnet.Text = "Emitir carnet";
            this.btnEmitirCarnet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmitirCarnet.UseVisualStyleBackColor = true;
            // 
            // btnIncribirVisitantes
            // 
            this.btnIncribirVisitantes.FlatAppearance.BorderSize = 0;
            this.btnIncribirVisitantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btnIncribirVisitantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btnIncribirVisitantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncribirVisitantes.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncribirVisitantes.ForeColor = System.Drawing.Color.White;
            this.btnIncribirVisitantes.Image = ((System.Drawing.Image)(resources.GetObject("btnIncribirVisitantes.Image")));
            this.btnIncribirVisitantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncribirVisitantes.Location = new System.Drawing.Point(0, 160);
            this.btnIncribirVisitantes.Name = "btnIncribirVisitantes";
            this.btnIncribirVisitantes.Size = new System.Drawing.Size(250, 40);
            this.btnIncribirVisitantes.TabIndex = 2;
            this.btnIncribirVisitantes.Text = "Inscribir visitantes";
            this.btnIncribirVisitantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncribirVisitantes.UseVisualStyleBackColor = true;
            // 
            // btnInscribirSocio
            // 
            this.btnInscribirSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInscribirSocio.FlatAppearance.BorderSize = 0;
            this.btnInscribirSocio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btnInscribirSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btnInscribirSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribirSocio.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribirSocio.ForeColor = System.Drawing.Color.White;
            this.btnInscribirSocio.Image = ((System.Drawing.Image)(resources.GetObject("btnInscribirSocio.Image")));
            this.btnInscribirSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscribirSocio.Location = new System.Drawing.Point(0, 102);
            this.btnInscribirSocio.Name = "btnInscribirSocio";
            this.btnInscribirSocio.Size = new System.Drawing.Size(250, 40);
            this.btnInscribirSocio.TabIndex = 1;
            this.btnInscribirSocio.Text = "Inscribir socio";
            this.btnInscribirSocio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInscribirSocio.UseVisualStyleBackColor = false;
            this.btnInscribirSocio.Click += new System.EventHandler(this.BtnInscribirSocio_Click);
            // 
            // picbMarca
            // 
            this.picbMarca.Image = ((System.Drawing.Image)(resources.GetObject("picbMarca.Image")));
            this.picbMarca.Location = new System.Drawing.Point(0, 3);
            this.picbMarca.Name = "picbMarca";
            this.picbMarca.Size = new System.Drawing.Size(250, 50);
            this.picbMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbMarca.TabIndex = 0;
            this.picbMarca.TabStop = false;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTitulo.Controls.Add(this.picbMinimizar);
            this.pnlTitulo.Controls.Add(this.picbRestaurar);
            this.pnlTitulo.Controls.Add(this.picbMaximizar);
            this.pnlTitulo.Controls.Add(this.picbCerrar);
            this.pnlTitulo.Controls.Add(this.btnSlide);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(250, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1050, 50);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // picbMinimizar
            // 
            this.picbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picbMinimizar.Image")));
            this.picbMinimizar.Location = new System.Drawing.Point(949, 12);
            this.picbMinimizar.Name = "picbMinimizar";
            this.picbMinimizar.Size = new System.Drawing.Size(20, 20);
            this.picbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbMinimizar.TabIndex = 4;
            this.picbMinimizar.TabStop = false;
            this.picbMinimizar.Click += new System.EventHandler(this.picbMinimizar_Click);
            // 
            // picbRestaurar
            // 
            this.picbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("picbRestaurar.Image")));
            this.picbRestaurar.Location = new System.Drawing.Point(975, 12);
            this.picbRestaurar.Name = "picbRestaurar";
            this.picbRestaurar.Size = new System.Drawing.Size(20, 20);
            this.picbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbRestaurar.TabIndex = 3;
            this.picbRestaurar.TabStop = false;
            this.picbRestaurar.Click += new System.EventHandler(this.picbRestaurar_Click);
            // 
            // picbMaximizar
            // 
            this.picbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("picbMaximizar.Image")));
            this.picbMaximizar.Location = new System.Drawing.Point(975, 12);
            this.picbMaximizar.Name = "picbMaximizar";
            this.picbMaximizar.Size = new System.Drawing.Size(20, 20);
            this.picbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbMaximizar.TabIndex = 2;
            this.picbMaximizar.TabStop = false;
            this.picbMaximizar.Click += new System.EventHandler(this.picbMaximizar_Click);
            // 
            // picbCerrar
            // 
            this.picbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picbCerrar.Image")));
            this.picbCerrar.Location = new System.Drawing.Point(1001, 12);
            this.picbCerrar.Name = "picbCerrar";
            this.picbCerrar.Size = new System.Drawing.Size(20, 20);
            this.picbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbCerrar.TabIndex = 1;
            this.picbCerrar.TabStop = false;
            this.picbCerrar.Click += new System.EventHandler(this.picbCerrar_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(6, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContenedor.Location = new System.Drawing.Point(250, 50);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1050, 600);
            this.pnlContenedor.TabIndex = 2;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::MyGym2.Properties.Resources.logout_441;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(3, 578);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(241, 60);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Cerrar Sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipo 10";
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbMarca)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox picbMarca;
        private System.Windows.Forms.PictureBox picbCerrar;
        private System.Windows.Forms.PictureBox picbMinimizar;
        private System.Windows.Forms.PictureBox picbRestaurar;
        private System.Windows.Forms.PictureBox picbMaximizar;
        private System.Windows.Forms.Button btnInscribirSocio;
        private System.Windows.Forms.Button btnIncribirVisitantes;
        private System.Windows.Forms.Button btnEmitirCarnet;
        private System.Windows.Forms.Button btnInscribirActividad;
        private System.Windows.Forms.Button btnListarSocios;
        private System.Windows.Forms.Button btnPagarCuota;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnLogOut;
    }
}

