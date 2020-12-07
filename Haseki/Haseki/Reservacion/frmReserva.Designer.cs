namespace Haseki
{
    partial class frmReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.NumOcu = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rbdSI = new System.Windows.Forms.RadioButton();
            this.rbdNO = new System.Windows.Forms.RadioButton();
            this.txtNumHab = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumOcu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(182, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especificaciones de reserva";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(60, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de habitación:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(60, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha y Hora:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(60, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 60);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de ocupantes:";
            // 
            // cmdTipoHabitacion
            // 
            this.cmdTipoHabitacion.FormattingEnabled = true;
            this.cmdTipoHabitacion.Items.AddRange(new object[] {
            "Plata",
            "Oro",
            "Diamante",
            "DLRR"});
            this.cmdTipoHabitacion.Location = new System.Drawing.Point(294, 94);
            this.cmdTipoHabitacion.Name = "cmdTipoHabitacion";
            this.cmdTipoHabitacion.Size = new System.Drawing.Size(349, 33);
            this.cmdTipoHabitacion.TabIndex = 7;
            this.cmdTipoHabitacion.SelectedIndexChanged += new System.EventHandler(this.cmdTipoHabitacion_SelectedIndexChanged);
            this.cmdTipoHabitacion.Leave += new System.EventHandler(this.cmdTipoHabitacion_Leave);
            // 
            // NumOcu
            // 
            this.NumOcu.Location = new System.Drawing.Point(355, 331);
            this.NumOcu.Name = "NumOcu";
            this.NumOcu.Size = new System.Drawing.Size(88, 33);
            this.NumOcu.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(187, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 43);
            this.button1.TabIndex = 23;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(365, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 43);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(60, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Solicitud de estacionamiento:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // rbdSI
            // 
            this.rbdSI.BackColor = System.Drawing.Color.Transparent;
            this.rbdSI.Location = new System.Drawing.Point(401, 388);
            this.rbdSI.Name = "rbdSI";
            this.rbdSI.Size = new System.Drawing.Size(62, 34);
            this.rbdSI.TabIndex = 14;
            this.rbdSI.TabStop = true;
            this.rbdSI.Text = "Si";
            this.rbdSI.UseVisualStyleBackColor = false;
            // 
            // rbdNO
            // 
            this.rbdNO.BackColor = System.Drawing.Color.Transparent;
            this.rbdNO.Location = new System.Drawing.Point(487, 388);
            this.rbdNO.Name = "rbdNO";
            this.rbdNO.Size = new System.Drawing.Size(65, 34);
            this.rbdNO.TabIndex = 15;
            this.rbdNO.TabStop = true;
            this.rbdNO.Text = "No";
            this.rbdNO.UseVisualStyleBackColor = false;
            // 
            // txtNumHab
            // 
            this.txtNumHab.Enabled = false;
            this.txtNumHab.Location = new System.Drawing.Point(294, 153);
            this.txtNumHab.Name = "txtNumHab";
            this.txtNumHab.Size = new System.Drawing.Size(349, 33);
            this.txtNumHab.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 39);
            this.label7.TabIndex = 25;
            this.label7.Text = "Numero Habitacion";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(294, 236);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(349, 33);
            this.txtFecha.TabIndex = 27;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Haseki.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 508);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNumHab);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbdNO);
            this.Controls.Add(this.rbdSI);
            this.Controls.Add(this.NumOcu);
            this.Controls.Add(this.cmdTipoHabitacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmReserva";
            this.Text = "Especificaciones de reserva";
            ((System.ComponentModel.ISupportInitialize)(this.NumOcu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmdTipoHabitacion;
        private System.Windows.Forms.NumericUpDown NumOcu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbdSI;
        private System.Windows.Forms.RadioButton rbdNO;
        private System.Windows.Forms.TextBox txtNumHab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFecha;
    }
}