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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPpal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.picbMarca = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.picbCerrar = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.picbMaximizar = new System.Windows.Forms.PictureBox();
            this.picbRestaurar = new System.Windows.Forms.PictureBox();
            this.picbMinimizar = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbMarca)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.picbMarca);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
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
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContenedor.Location = new System.Drawing.Point(250, 50);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1050, 600);
            this.pnlContenedor.TabIndex = 2;
            // 
            // picbMaximizar
            // 
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
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPpal";
            this.Text = "Equipo 10";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbMarca)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMinimizar)).EndInit();
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
    }
}

