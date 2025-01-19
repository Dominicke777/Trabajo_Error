namespace BibliotecaDB.Usuario
{
    partial class Registrar_Usuario
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsuario3 = new System.Windows.Forms.TextBox();
            this.txtEmail3 = new System.Windows.Forms.TextBox();
            this.txtNombre3 = new System.Windows.Forms.TextBox();
            this.txtTelefono3 = new System.Windows.Forms.TextBox();
            this.txtApellido3 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDBDataSet = new BibliotecaDB.BibliotecaDBDataSet();
            this.usuariosTableAdapter = new BibliotecaDB.BibliotecaDBDataSetTableAdapters.UsuariosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bibliotecaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtUsuario3
            // 
            this.txtUsuario3.Location = new System.Drawing.Point(593, 196);
            this.txtUsuario3.Name = "txtUsuario3";
            this.txtUsuario3.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario3.TabIndex = 14;
            this.txtUsuario3.Text = "Usuario";
            // 
            // txtEmail3
            // 
            this.txtEmail3.Location = new System.Drawing.Point(593, 271);
            this.txtEmail3.Name = "txtEmail3";
            this.txtEmail3.Size = new System.Drawing.Size(100, 22);
            this.txtEmail3.TabIndex = 13;
            this.txtEmail3.Text = "Email";
            // 
            // txtNombre3
            // 
            this.txtNombre3.Location = new System.Drawing.Point(593, 63);
            this.txtNombre3.Name = "txtNombre3";
            this.txtNombre3.Size = new System.Drawing.Size(100, 22);
            this.txtNombre3.TabIndex = 12;
            this.txtNombre3.Text = "Nombre";
            this.txtNombre3.TextChanged += new System.EventHandler(this.txtNombre3_TextChanged);
            // 
            // txtTelefono3
            // 
            this.txtTelefono3.Location = new System.Drawing.Point(593, 332);
            this.txtTelefono3.Name = "txtTelefono3";
            this.txtTelefono3.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono3.TabIndex = 11;
            this.txtTelefono3.Text = "Telefono";
            // 
            // txtApellido3
            // 
            this.txtApellido3.Location = new System.Drawing.Point(593, 122);
            this.txtApellido3.Name = "txtApellido3";
            this.txtApellido3.Size = new System.Drawing.Size(100, 22);
            this.txtApellido3.TabIndex = 10;
            this.txtApellido3.Text = "Apellido";
            this.txtApellido3.TextChanged += new System.EventHandler(this.txtApellido3_TextChanged);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.bibliotecaDBDataSet;
            // 
            // bibliotecaDBDataSet
            // 
            this.bibliotecaDBDataSet.DataSetName = "BibliotecaDBDataSet";
            this.bibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuariosBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(31, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 199);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bibliotecaDBDataSetBindingSource
            // 
            this.bibliotecaDBDataSetBindingSource.DataSource = this.bibliotecaDBDataSet;
            this.bibliotecaDBDataSetBindingSource.Position = 0;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            this.usuariosBindingSource1.DataSource = this.bibliotecaDBDataSetBindingSource;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuariosBindingSource2
            // 
            this.usuariosBindingSource2.DataMember = "Usuarios";
            this.usuariosBindingSource2.DataSource = this.bibliotecaDBDataSetBindingSource;
            // 
            // Registrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUsuario3);
            this.Controls.Add(this.txtEmail3);
            this.Controls.Add(this.txtNombre3);
            this.Controls.Add(this.txtTelefono3);
            this.Controls.Add(this.txtApellido3);
            this.Name = "Registrar_Usuario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Registrar_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUsuario3;
        private System.Windows.Forms.TextBox txtEmail3;
        private System.Windows.Forms.TextBox txtNombre3;
        private System.Windows.Forms.TextBox txtTelefono3;
        private System.Windows.Forms.TextBox txtApellido3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private BibliotecaDBDataSet bibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private BibliotecaDBDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuariosBindingSource2;
        private System.Windows.Forms.BindingSource bibliotecaDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
    }
}