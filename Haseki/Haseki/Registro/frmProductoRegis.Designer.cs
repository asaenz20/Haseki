namespace Haseki
{
    partial class frmProductoRegis
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
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTipo_Producto = new System.Windows.Forms.TextBox();
            this.txtProId = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(395, 268);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(335, 31);
            this.txtPrecio.TabIndex = 17;
            // 
            // txtTipo_Producto
            // 
            this.txtTipo_Producto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo_Producto.Location = new System.Drawing.Point(395, 209);
            this.txtTipo_Producto.Name = "txtTipo_Producto";
            this.txtTipo_Producto.Size = new System.Drawing.Size(335, 31);
            this.txtTipo_Producto.TabIndex = 16;
            // 
            // txtProId
            // 
            this.txtProId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProId.Location = new System.Drawing.Point(395, 155);
            this.txtProId.Name = "txtProId";
            this.txtProId.Size = new System.Drawing.Size(335, 31);
            this.txtProId.TabIndex = 15;
            // 
            // Precio
            // 
            this.Precio.BackColor = System.Drawing.Color.Transparent;
            this.Precio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.ForeColor = System.Drawing.Color.White;
            this.Precio.Location = new System.Drawing.Point(125, 268);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(201, 30);
            this.Precio.TabIndex = 14;
            this.Precio.Text = "Precio del Producto";
            // 
            // Producto
            // 
            this.Producto.BackColor = System.Drawing.Color.Transparent;
            this.Producto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producto.ForeColor = System.Drawing.Color.White;
            this.Producto.Location = new System.Drawing.Point(125, 209);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(226, 30);
            this.Producto.TabIndex = 13;
            this.Producto.Text = "Nombre del Producto";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Codigo del Producto";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(438, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(227, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Digite la informacion del registro del producto";
            // 
            // ReProdAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Haseki.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTipo_Producto);
            this.Controls.Add(this.txtProId);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.label2);
            this.Name = "ReProdAdmin";
            this.Text = "ReProdAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTipo_Producto;
        private System.Windows.Forms.TextBox txtProId;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}