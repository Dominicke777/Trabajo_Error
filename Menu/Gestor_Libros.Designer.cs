namespace Gestor_Libro
{
    partial class FormLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibros));
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtNumeroCopias = new System.Windows.Forms.TextBox();
            this.txtAnioPublicacion = new System.Windows.Forms.TextBox();
            this.dataGridViewLibros = new System.Windows.Forms.DataGridView();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCopiasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDBDataSet1 = new BibliotecaDB.BibliotecaDBDataSet1();
            this.librosTableAdapter = new BibliotecaDB.BibliotecaDBDataSet1TableAdapters.LibrosTableAdapter();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(672, 56);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(258, 22);
            this.txtISBN.TabIndex = 0;
            this.txtISBN.Text = "IBN";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(672, 288);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(258, 22);
            this.txtGenero.TabIndex = 1;
            this.txtGenero.Text = "Genero";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(672, 235);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(258, 22);
            this.txtEditorial.TabIndex = 2;
            this.txtEditorial.Text = "Editorial";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(672, 180);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(258, 22);
            this.txtAutor.TabIndex = 3;
            this.txtAutor.Text = "txtAutor";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(672, 116);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(258, 22);
            this.txtTitulo.TabIndex = 4;
            this.txtTitulo.Text = "Titulo";
            // 
            // txtNumeroCopias
            // 
            this.txtNumeroCopias.Location = new System.Drawing.Point(672, 346);
            this.txtNumeroCopias.Name = "txtNumeroCopias";
            this.txtNumeroCopias.Size = new System.Drawing.Size(258, 22);
            this.txtNumeroCopias.TabIndex = 5;
            this.txtNumeroCopias.Text = "txtNumeroCopias";
            // 
            // txtAnioPublicacion
            // 
            this.txtAnioPublicacion.Location = new System.Drawing.Point(672, 385);
            this.txtAnioPublicacion.Name = "txtAnioPublicacion";
            this.txtAnioPublicacion.Size = new System.Drawing.Size(258, 22);
            this.txtAnioPublicacion.TabIndex = 6;
            this.txtAnioPublicacion.Text = "Fecha de Publicacion";
            // 
            // dataGridViewLibros
            // 
            this.dataGridViewLibros.AllowUserToOrderColumns = true;
            this.dataGridViewLibros.AutoGenerateColumns = false;
            this.dataGridViewLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.editorialDataGridViewTextBoxColumn,
            this.anioPublicacionDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.numeroCopiasDataGridViewTextBoxColumn});
            this.dataGridViewLibros.DataSource = this.librosBindingSource;
            this.dataGridViewLibros.Location = new System.Drawing.Point(21, 228);
            this.dataGridViewLibros.Name = "dataGridViewLibros";
            this.dataGridViewLibros.RowHeadersWidth = 51;
            this.dataGridViewLibros.RowTemplate.Height = 24;
            this.dataGridViewLibros.Size = new System.Drawing.Size(554, 104);
            this.dataGridViewLibros.TabIndex = 7;
            this.dataGridViewLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 125;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.Width = 125;
            // 
            // editorialDataGridViewTextBoxColumn
            // 
            this.editorialDataGridViewTextBoxColumn.DataPropertyName = "Editorial";
            this.editorialDataGridViewTextBoxColumn.HeaderText = "Editorial";
            this.editorialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.editorialDataGridViewTextBoxColumn.Name = "editorialDataGridViewTextBoxColumn";
            this.editorialDataGridViewTextBoxColumn.Width = 125;
            // 
            // anioPublicacionDataGridViewTextBoxColumn
            // 
            this.anioPublicacionDataGridViewTextBoxColumn.DataPropertyName = "AnioPublicacion";
            this.anioPublicacionDataGridViewTextBoxColumn.HeaderText = "AnioPublicacion";
            this.anioPublicacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anioPublicacionDataGridViewTextBoxColumn.Name = "anioPublicacionDataGridViewTextBoxColumn";
            this.anioPublicacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroCopiasDataGridViewTextBoxColumn
            // 
            this.numeroCopiasDataGridViewTextBoxColumn.DataPropertyName = "NumeroCopias";
            this.numeroCopiasDataGridViewTextBoxColumn.HeaderText = "NumeroCopias";
            this.numeroCopiasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroCopiasDataGridViewTextBoxColumn.Name = "numeroCopiasDataGridViewTextBoxColumn";
            this.numeroCopiasDataGridViewTextBoxColumn.Width = 125;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.bibliotecaDBDataSet1;
            // 
            // bibliotecaDBDataSet1
            // 
            this.bibliotecaDBDataSet1.DataSetName = "BibliotecaDBDataSet1";
            this.bibliotecaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(62, 354);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 59);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(239, 354);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(141, 59);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(408, 354);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 59);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(194, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 219);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormLibros
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewLibros);
            this.Controls.Add(this.txtAnioPublicacion);
            this.Controls.Add(this.txtNumeroCopias);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtISBN);
            this.Name = "FormLibros";
            this.Load += new System.EventHandler(this.FormLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtNumeroCopias;
        private System.Windows.Forms.TextBox txtAnioPublicacion;
        private System.Windows.Forms.DataGridView dataGridViewLibros;
        private BibliotecaDB.BibliotecaDBDataSet1 bibliotecaDBDataSet1;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private BibliotecaDB.BibliotecaDBDataSet1TableAdapters.LibrosTableAdapter librosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCopiasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}