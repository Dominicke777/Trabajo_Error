using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Libro
{
    public partial class FormLibros : Form
    {
        public FormLibros()
        {

            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }
        private string connectionString = "Server=.;Database=BibliotecaDB;Trusted_Connection=True;";
        private void CargarLibros()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Libros";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewLibros.DataSource = table;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDBDataSet.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.bibliotecaDBDataSet1.Libros);
        }

        private void btnAgregar_Click_Click(object sender, EventArgs e)
        {
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Libros (ISBN, Titulo, Autor, Editorial, AnioPublicacion, Genero, NumeroCopias) VALUES (@ISBN, @Titulo, @Autor, @Editorial, @AnioPublicacion, @Genero, @NumeroCopias)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    command.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                    command.Parameters.AddWithValue("@Autor", txtAutor.Text);
                    command.Parameters.AddWithValue("@Editorial", txtEditorial.Text);

                    if (int.TryParse(txtAnioPublicacion.Text, out int anioPublicacion))
                    {
                        command.Parameters.AddWithValue("@AnioPublicacion", anioPublicacion);
                    }
                    else
                    {
                        MessageBox.Show("El año de publicación no es válido.");
                        return;
                    }

                    command.Parameters.AddWithValue("@Genero", txtGenero.Text);
                    if (int.TryParse(txtNumeroCopias.Text, out int numeroCopias))
                    {
                        command.Parameters.AddWithValue("@NumeroCopias", numeroCopias);
                    }
                    else
                    {
                        MessageBox.Show("El número de copias no es válido.");
                        return;
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Libro agregado correctamente.");
                    CargarLibros();
                }
            }


        }


        private void btnEliminar_Click_Click(object sender, EventArgs e)
        {
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Libros WHERE ISBN = @ISBN";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ISBN", txtISBN.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Libro eliminado correctamente.");
                    CargarLibros();
                }
            }
        }

       

        private void FormLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDBDataSet1.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.bibliotecaDBDataSet1.Libros);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewLibros.Rows[e.RowIndex];
                txtISBN.Text = row.Cells["ISBN"].Value.ToString();
                txtTitulo.Text = row.Cells["Titulo"].Value.ToString();
                txtAutor.Text = row.Cells["Autor"].Value.ToString();
                txtEditorial.Text = row.Cells["Editorial"].Value.ToString();
                txtAnioPublicacion.Text = row.Cells["AnioPublicacion"].Value.ToString();
                txtGenero.Text = row.Cells["Genero"].Value.ToString();
                txtNumeroCopias.Text = row.Cells["NumeroCopias"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Libros SET Titulo = @Titulo, Autor = @Autor, Editorial = @Editorial, AnioPublicacion = @AnioPublicacion, Genero = @Genero, NumeroCopias = @NumeroCopias WHERE ISBN = @ISBN";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                command.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                command.Parameters.AddWithValue("@Autor", txtAutor.Text);
                command.Parameters.AddWithValue("@Editorial", txtEditorial.Text);
                command.Parameters.AddWithValue("@AnioPublicacion", int.Parse(txtAnioPublicacion.Text));
                command.Parameters.AddWithValue("@Genero", txtGenero.Text);
                command.Parameters.AddWithValue("@NumeroCopias", int.Parse(txtNumeroCopias.Text));

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Libro actualizado correctamente.");
                CargarLibros();
            }
        }
    }
}

