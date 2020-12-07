namespace Haseki
{
    partial class frmPrincipal
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
            this.lblInicio = new System.Windows.Forms.Label();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitaciónOroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitaciónDiamanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitaciónDLRRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblInicio.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(142, 348);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(509, 44);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "¡Bienvenidos a Haseki Sultán!";
            // 
            // msPrincipal
            // 
            this.msPrincipal.BackColor = System.Drawing.Color.White;
            this.msPrincipal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habitacionesToolStripMenuItem,
            this.reservarToolStripMenuItem,
            this.estadoDeReservaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msPrincipal.Size = new System.Drawing.Size(788, 30);
            this.msPrincipal.TabIndex = 1;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habitaciónToolStripMenuItem,
            this.habitaciónOroToolStripMenuItem,
            this.habitaciónDiamanteToolStripMenuItem,
            this.habitaciónDLRRToolStripMenuItem});
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            this.habitacionesToolStripMenuItem.Click += new System.EventHandler(this.HabitacionesToolStripMenuItem_Click);
            // 
            // habitaciónToolStripMenuItem
            // 
            this.habitaciónToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitaciónToolStripMenuItem.Name = "habitaciónToolStripMenuItem";
            this.habitaciónToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.habitaciónToolStripMenuItem.Text = "Habitación plata";
            this.habitaciónToolStripMenuItem.Click += new System.EventHandler(this.HabitaciónToolStripMenuItem_Click);
            // 
            // habitaciónOroToolStripMenuItem
            // 
            this.habitaciónOroToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitaciónOroToolStripMenuItem.Name = "habitaciónOroToolStripMenuItem";
            this.habitaciónOroToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.habitaciónOroToolStripMenuItem.Text = "Habitación Oro";
            this.habitaciónOroToolStripMenuItem.Click += new System.EventHandler(this.HabitaciónOroToolStripMenuItem_Click);
            // 
            // habitaciónDiamanteToolStripMenuItem
            // 
            this.habitaciónDiamanteToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitaciónDiamanteToolStripMenuItem.Name = "habitaciónDiamanteToolStripMenuItem";
            this.habitaciónDiamanteToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.habitaciónDiamanteToolStripMenuItem.Text = "Habitación Diamante";
            this.habitaciónDiamanteToolStripMenuItem.Click += new System.EventHandler(this.HabitaciónDiamanteToolStripMenuItem_Click);
            // 
            // habitaciónDLRRToolStripMenuItem
            // 
            this.habitaciónDLRRToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitaciónDLRRToolStripMenuItem.Name = "habitaciónDLRRToolStripMenuItem";
            this.habitaciónDLRRToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.habitaciónDLRRToolStripMenuItem.Text = "Habitación DLRR";
            this.habitaciónDLRRToolStripMenuItem.Click += new System.EventHandler(this.HabitaciónDLRRToolStripMenuItem_Click);
            // 
            // reservarToolStripMenuItem
            // 
            this.reservarToolStripMenuItem.Name = "reservarToolStripMenuItem";
            this.reservarToolStripMenuItem.Size = new System.Drawing.Size(103, 26);
            this.reservarToolStripMenuItem.Text = "Reservar";
            this.reservarToolStripMenuItem.Click += new System.EventHandler(this.ReservarToolStripMenuItem_Click);
            // 
            // estadoDeReservaToolStripMenuItem
            // 
            this.estadoDeReservaToolStripMenuItem.Name = "estadoDeReservaToolStripMenuItem";
            this.estadoDeReservaToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.estadoDeReservaToolStripMenuItem.Text = "Administrador ";
            this.estadoDeReservaToolStripMenuItem.Click += new System.EventHandler(this.estadoDeReservaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Haseki.Properties.Resources.principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.msPrincipal);
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "¡Bienvenidos!";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitaciónOroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitaciónDiamanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitaciónDLRRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDeReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

