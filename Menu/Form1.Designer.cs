namespace BibliotecaDB.Menu
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Registrar = new System.Windows.Forms.Button();
            this.Guardar_Libro = new System.Windows.Forms.Button();
            this.Reservar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(520, 321);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(135, 23);
            this.Registrar.TabIndex = 0;
            this.Registrar.Text = "Registrar Usuario";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Guardar_Libro
            // 
            this.Guardar_Libro.Location = new System.Drawing.Point(338, 321);
            this.Guardar_Libro.Name = "Guardar_Libro";
            this.Guardar_Libro.Size = new System.Drawing.Size(128, 23);
            this.Guardar_Libro.TabIndex = 1;
            this.Guardar_Libro.Text = "Guardar Libro";
            this.Guardar_Libro.UseVisualStyleBackColor = true;
            this.Guardar_Libro.BackgroundImageChanged += new System.EventHandler(this.button2_BackgroundImageChanged);
            this.Guardar_Libro.Click += new System.EventHandler(this.button3_Click);
            // 
            // Reservar
            // 
            this.Reservar.Location = new System.Drawing.Point(129, 321);
            this.Reservar.Name = "Reservar";
            this.Reservar.Size = new System.Drawing.Size(129, 23);
            this.Reservar.TabIndex = 2;
            this.Reservar.Text = "Reservar Libro";
            this.Reservar.UseVisualStyleBackColor = true;
            this.Reservar.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 266);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Reservar);
            this.Controls.Add(this.Guardar_Libro);
            this.Controls.Add(this.Registrar);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button Guardar_Libro;
        private System.Windows.Forms.Button Reservar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}