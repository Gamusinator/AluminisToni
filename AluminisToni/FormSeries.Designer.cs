namespace AluminisToni
{
    partial class FormSeries
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
            this.button_modificar_series = new System.Windows.Forms.Button();
            this.button_listar_series = new System.Windows.Forms.Button();
            this.button_añadir_series = new System.Windows.Forms.Button();
            this.label_series = new System.Windows.Forms.Label();
            this.button_salir_series = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_modificar_series
            // 
            this.button_modificar_series.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_modificar_series.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_modificar_series.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_modificar_series.FlatAppearance.BorderSize = 10;
            this.button_modificar_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar_series.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_modificar_series.Location = new System.Drawing.Point(378, 201);
            this.button_modificar_series.Name = "button_modificar_series";
            this.button_modificar_series.Size = new System.Drawing.Size(138, 74);
            this.button_modificar_series.TabIndex = 18;
            this.button_modificar_series.Text = "Modificar";
            this.toolTip3.SetToolTip(this.button_modificar_series, "Modifica los datos de la serie que elijas");
            this.button_modificar_series.UseVisualStyleBackColor = false;
            // 
            // button_listar_series
            // 
            this.button_listar_series.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_listar_series.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_listar_series.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_listar_series.FlatAppearance.BorderSize = 10;
            this.button_listar_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_listar_series.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_listar_series.Location = new System.Drawing.Point(196, 201);
            this.button_listar_series.Name = "button_listar_series";
            this.button_listar_series.Size = new System.Drawing.Size(138, 74);
            this.button_listar_series.TabIndex = 17;
            this.button_listar_series.Text = "Listar";
            this.toolTip2.SetToolTip(this.button_listar_series, "Lista todas las series de la base de datos y te da la opción de eliminarlos");
            this.button_listar_series.UseVisualStyleBackColor = false;
            // 
            // button_añadir_series
            // 
            this.button_añadir_series.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_añadir_series.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_añadir_series.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_añadir_series.FlatAppearance.BorderSize = 10;
            this.button_añadir_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_añadir_series.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_añadir_series.Location = new System.Drawing.Point(13, 201);
            this.button_añadir_series.Name = "button_añadir_series";
            this.button_añadir_series.Size = new System.Drawing.Size(138, 74);
            this.button_añadir_series.TabIndex = 16;
            this.button_añadir_series.Text = "Añadir";
            this.toolTip1.SetToolTip(this.button_añadir_series, "Añade nuevas series a la base de datos");
            this.button_añadir_series.UseVisualStyleBackColor = false;
            // 
            // label_series
            // 
            this.label_series.AutoSize = true;
            this.label_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_series.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_series.Location = new System.Drawing.Point(207, 123);
            this.label_series.Name = "label_series";
            this.label_series.Size = new System.Drawing.Size(116, 38);
            this.label_series.TabIndex = 15;
            this.label_series.Text = "Series";
            // 
            // button_salir_series
            // 
            this.button_salir_series.BackgroundImage = global::AluminisToni.Properties.Resources.exit;
            this.button_salir_series.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_salir_series.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_salir_series.Location = new System.Drawing.Point(403, 13);
            this.button_salir_series.Name = "button_salir_series";
            this.button_salir_series.Size = new System.Drawing.Size(113, 52);
            this.button_salir_series.TabIndex = 14;
            this.button_salir_series.UseVisualStyleBackColor = true;
            this.button_salir_series.Click += new System.EventHandler(this.button_salir_series_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AluminisToni.Properties.Resources.Aluminis_toni1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FormSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(529, 289);
            this.Controls.Add(this.button_modificar_series);
            this.Controls.Add(this.button_listar_series);
            this.Controls.Add(this.button_añadir_series);
            this.Controls.Add(this.label_series);
            this.Controls.Add(this.button_salir_series);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSeries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSeries";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_modificar_series;
        private System.Windows.Forms.Button button_listar_series;
        private System.Windows.Forms.Button button_añadir_series;
        private System.Windows.Forms.Label label_series;
        private System.Windows.Forms.Button button_salir_series;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}