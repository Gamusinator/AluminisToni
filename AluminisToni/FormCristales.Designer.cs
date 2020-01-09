namespace AluminisToni
{
    partial class FormCristales
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
            this.label_cristales = new System.Windows.Forms.Label();
            this.button_añadir_cristales = new System.Windows.Forms.Button();
            this.button_listar_cristales = new System.Windows.Forms.Button();
            this.button_modificar_cristales = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.button_salir_cristales = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_cristales
            // 
            this.label_cristales.AutoSize = true;
            this.label_cristales.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cristales.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_cristales.Location = new System.Drawing.Point(188, 119);
            this.label_cristales.Name = "label_cristales";
            this.label_cristales.Size = new System.Drawing.Size(154, 38);
            this.label_cristales.TabIndex = 3;
            this.label_cristales.Text = "Cristales";
            // 
            // button_añadir_cristales
            // 
            this.button_añadir_cristales.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_añadir_cristales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_añadir_cristales.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_añadir_cristales.FlatAppearance.BorderSize = 10;
            this.button_añadir_cristales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_añadir_cristales.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_añadir_cristales.Location = new System.Drawing.Point(12, 200);
            this.button_añadir_cristales.Name = "button_añadir_cristales";
            this.button_añadir_cristales.Size = new System.Drawing.Size(138, 74);
            this.button_añadir_cristales.TabIndex = 4;
            this.button_añadir_cristales.Text = "Añadir";
            this.toolTip1.SetToolTip(this.button_añadir_cristales, "Añade nuevos tipos de cristales a la base de datos");
            this.button_añadir_cristales.UseVisualStyleBackColor = false;
            // 
            // button_listar_cristales
            // 
            this.button_listar_cristales.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_listar_cristales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_listar_cristales.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_listar_cristales.FlatAppearance.BorderSize = 10;
            this.button_listar_cristales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_listar_cristales.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_listar_cristales.Location = new System.Drawing.Point(195, 200);
            this.button_listar_cristales.Name = "button_listar_cristales";
            this.button_listar_cristales.Size = new System.Drawing.Size(138, 74);
            this.button_listar_cristales.TabIndex = 5;
            this.button_listar_cristales.Text = "Listar";
            this.toolTip2.SetToolTip(this.button_listar_cristales, "Lista todos los cristales de la base de datos y te da la opción de eliminarlos.");
            this.button_listar_cristales.UseVisualStyleBackColor = false;
            // 
            // button_modificar_cristales
            // 
            this.button_modificar_cristales.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_modificar_cristales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_modificar_cristales.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_modificar_cristales.FlatAppearance.BorderSize = 10;
            this.button_modificar_cristales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar_cristales.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_modificar_cristales.Location = new System.Drawing.Point(377, 200);
            this.button_modificar_cristales.Name = "button_modificar_cristales";
            this.button_modificar_cristales.Size = new System.Drawing.Size(138, 74);
            this.button_modificar_cristales.TabIndex = 6;
            this.button_modificar_cristales.Text = "Modificar";
            this.toolTip3.SetToolTip(this.button_modificar_cristales, "Modifica los datos del cristal que elijas");
            this.button_modificar_cristales.UseVisualStyleBackColor = false;
            // 
            // button_salir_cristales
            // 
            this.button_salir_cristales.BackgroundImage = global::AluminisToni.Properties.Resources.exit;
            this.button_salir_cristales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_salir_cristales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_salir_cristales.Location = new System.Drawing.Point(402, 12);
            this.button_salir_cristales.Name = "button_salir_cristales";
            this.button_salir_cristales.Size = new System.Drawing.Size(113, 52);
            this.button_salir_cristales.TabIndex = 2;
            this.button_salir_cristales.UseVisualStyleBackColor = true;
            this.button_salir_cristales.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AluminisToni.Properties.Resources.Aluminis_toni1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormCristales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(529, 289);
            this.Controls.Add(this.button_modificar_cristales);
            this.Controls.Add(this.button_listar_cristales);
            this.Controls.Add(this.button_añadir_cristales);
            this.Controls.Add(this.label_cristales);
            this.Controls.Add(this.button_salir_cristales);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormCristales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCristales";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_salir_cristales;
        private System.Windows.Forms.Label label_cristales;
        private System.Windows.Forms.Button button_añadir_cristales;
        private System.Windows.Forms.Button button_listar_cristales;
        private System.Windows.Forms.Button button_modificar_cristales;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}