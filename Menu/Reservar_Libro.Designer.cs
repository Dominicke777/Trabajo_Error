namespace BibliotecaDB.Reservas
{
    partial class Reservar_Libro
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
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.btnAgregarReserva = new System.Windows.Forms.Button();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.dateTimePickerRetorno = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReserva = new System.Windows.Forms.DateTimePicker();
            this.comboBoxLibros = new System.Windows.Forms.ComboBox();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservas.Location = new System.Drawing.Point(43, 190);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.RowHeadersWidth = 51;
            this.dataGridViewReservas.RowTemplate.Height = 24;
            this.dataGridViewReservas.Size = new System.Drawing.Size(714, 177);
            this.dataGridViewReservas.TabIndex = 17;
            this.dataGridViewReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservas_CellContentClick);
            // 
            // btnEditarReserva
            // 
            this.btnEditarReserva.Location = new System.Drawing.Point(194, 398);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnEditarReserva.TabIndex = 16;
            this.btnEditarReserva.Text = "Editar";
            this.btnEditarReserva.UseVisualStyleBackColor = true;
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.Location = new System.Drawing.Point(328, 398);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarReserva.TabIndex = 15;
            this.btnEliminarReserva.Text = "Eliminar";
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            // 
            // btnAgregarReserva
            // 
            this.btnAgregarReserva.Location = new System.Drawing.Point(47, 398);
            this.btnAgregarReserva.Name = "btnAgregarReserva";
            this.btnAgregarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarReserva.TabIndex = 14;
            this.btnAgregarReserva.Text = "Agregar";
            this.btnAgregarReserva.UseVisualStyleBackColor = true;
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(604, 56);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(100, 22);
            this.txtIdReserva.TabIndex = 13;
            this.txtIdReserva.Text = "ID Reserva";
            // 
            // dateTimePickerRetorno
            // 
            this.dateTimePickerRetorno.Location = new System.Drawing.Point(43, 123);
            this.dateTimePickerRetorno.Name = "dateTimePickerRetorno";
            this.dateTimePickerRetorno.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerRetorno.TabIndex = 12;
            // 
            // dateTimePickerReserva
            // 
            this.dateTimePickerReserva.Location = new System.Drawing.Point(43, 31);
            this.dateTimePickerReserva.Name = "dateTimePickerReserva";
            this.dateTimePickerReserva.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerReserva.TabIndex = 11;
            // 
            // comboBoxLibros
            // 
            this.comboBoxLibros.FormattingEnabled = true;
            this.comboBoxLibros.Location = new System.Drawing.Point(353, 121);
            this.comboBoxLibros.Name = "comboBoxLibros";
            this.comboBoxLibros.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLibros.TabIndex = 10;
            this.comboBoxLibros.Text = "Nombre Libro";
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(353, 29);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(121, 24);
            this.comboBoxUsuarios.TabIndex = 9;
            this.comboBoxUsuarios.Text = "Nombre Cliente";
            // 
            // Reservar_Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewReservas);
            this.Controls.Add(this.btnEditarReserva);
            this.Controls.Add(this.btnEliminarReserva);
            this.Controls.Add(this.btnAgregarReserva);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.dateTimePickerRetorno);
            this.Controls.Add(this.dateTimePickerReserva);
            this.Controls.Add(this.comboBoxLibros);
            this.Controls.Add(this.comboBoxUsuarios);
            this.Name = "Reservar_Libro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReservas;
        private System.Windows.Forms.Button btnEditarReserva;
        private System.Windows.Forms.Button btnEliminarReserva;
        private System.Windows.Forms.Button btnAgregarReserva;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.DateTimePicker dateTimePickerRetorno;
        private System.Windows.Forms.DateTimePicker dateTimePickerReserva;
        private System.Windows.Forms.ComboBox comboBoxLibros;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
    }
}