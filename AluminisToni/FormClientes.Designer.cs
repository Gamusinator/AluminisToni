namespace AluminisToni
{
    partial class FormClientes
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
            this.button_modificar_clientes = new System.Windows.Forms.Button();
            this.button_listar_clientes = new System.Windows.Forms.Button();
            this.button_añadir_clientes = new System.Windows.Forms.Button();
            this.label_clientes = new System.Windows.Forms.Label();
            this.button_salir_clientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_modificar_clientes
            // 
            this.button_modificar_clientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_modificar_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_modificar_clientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_modificar_clientes.FlatAppearance.BorderSize = 10;
            this.button_modificar_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar_clientes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_modificar_clientes.Location = new System.Drawing.Point(378, 201);
            this.button_modificar_clientes.Name = "button_modificar_clientes";
            this.button_modificar_clientes.Size = new System.Drawing.Size(138, 74);
            this.button_modificar_clientes.TabIndex = 12;
            this.button_modificar_clientes.Text = "Modificar";
            this.toolTip3.SetToolTip(this.button_modificar_clientes, "Modifica los datos del cliente que elijas");
            this.button_modificar_clientes.UseVisualStyleBackColor = false;
            // 
            // button_listar_clientes
            // 
            this.button_listar_clientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_listar_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_listar_clientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_listar_clientes.FlatAppearance.BorderSize = 10;
            this.button_listar_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_listar_clientes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_listar_clientes.Location = new System.Drawing.Point(196, 201);
            this.button_listar_clientes.Name = "button_listar_clientes";
            this.button_listar_clientes.Size = new System.Drawing.Size(138, 74);
            this.button_listar_clientes.TabIndex = 11;
            this.button_listar_clientes.Text = "Listar";
            this.toolTip2.SetToolTip(this.button_listar_clientes, "Lista todos los clientes de la base de datos y te da la opción de eliminarlos.");
            this.button_listar_clientes.UseVisualStyleBackColor = false;
            // 
            // button_añadir_clientes
            // 
            this.button_añadir_clientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_añadir_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_añadir_clientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_añadir_clientes.FlatAppearance.BorderSize = 10;
            this.button_añadir_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_añadir_clientes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_añadir_clientes.Location = new System.Drawing.Point(13, 201);
            this.button_añadir_clientes.Name = "button_añadir_clientes";
            this.button_añadir_clientes.Size = new System.Drawing.Size(138, 74);
            this.button_añadir_clientes.TabIndex = 10;
            this.button_añadir_clientes.Text = "Añadir";
            this.toolTip1.SetToolTip(this.button_añadir_clientes, "Añade nuevos clientes a la base de datos");
            this.button_añadir_clientes.UseVisualStyleBackColor = false;
            // 
            // label_clientes
            // 
            this.label_clientes.AutoSize = true;
            this.label_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clientes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_clientes.Location = new System.Drawing.Point(189, 120);
            this.label_clientes.Name = "label_clientes";
            this.label_clientes.Size = new System.Drawing.Size(143, 38);
            this.label_clientes.TabIndex = 9;
            this.label_clientes.Text = "Clientes";
            // 
            // button_salir_clientes
            // 
            this.button_salir_clientes.BackgroundImage = global::AluminisToni.Properties.Resources.exit;
            this.button_salir_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_salir_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_salir_clientes.Location = new System.Drawing.Point(403, 13);
            this.button_salir_clientes.Name = "button_salir_clientes";
            this.button_salir_clientes.Size = new System.Drawing.Size(113, 52);
            this.button_salir_clientes.TabIndex = 8;
            this.button_salir_clientes.UseVisualStyleBackColor = true;
            this.button_salir_clientes.Click += new System.EventHandler(this.button_salir_clientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AluminisToni.Properties.Resources.Aluminis_toni1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(529, 289);
            this.Controls.Add(this.button_modificar_clientes);
            this.Controls.Add(this.button_listar_clientes);
            this.Controls.Add(this.button_añadir_clientes);
            this.Controls.Add(this.label_clientes);
            this.Controls.Add(this.button_salir_clientes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_modificar_clientes;
        private System.Windows.Forms.Button button_listar_clientes;
        private System.Windows.Forms.Button button_añadir_clientes;
        private System.Windows.Forms.Label label_clientes;
        private System.Windows.Forms.Button button_salir_clientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}