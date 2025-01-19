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

namespace BibliotecaDB.Reservas
{
    public partial class Reservar_Libro : Form
    {
        public Reservar_Libro()
        {
            InitializeComponent();
            CargarReservas();
        }
        private string connectionString = "Server=.;Database=BibliotecaDB;User ID=sa;Password=12345678";

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void FormReservas_Load(object sender, EventArgs e)
        {
            CargarReservas();
            CargarUsuarios();
            CargarLibros();
        }

        private void CargarUsuarios()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdUsuario, Nombre FROM Usuarios";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                comboBoxUsuarios.DataSource = table;
                comboBoxUsuarios.DisplayMember = "Nombre";
                comboBoxUsuarios.ValueMember = "IdUsuario";
            }
        }


        private void CargarLibros()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ISBN, Titulo FROM Libros";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                comboBoxLibros.DataSource = table;
                comboBoxLibros.DisplayMember = "Titulo";
                comboBoxLibros.ValueMember = "ISBN";
            }
        }
        private void CargarReservas()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT r.IdReserva, r.IdUsuario, u.Nombre AS Usuario, r.ISBNLibro, l.Titulo AS Libro, r.FechaReserva, r.FechaRetorno " +
                               "FROM Reservas r " +
                               "INNER JOIN Usuarios u ON r.IdUsuario = u.IdUsuario " +
                               "INNER JOIN Libros l ON r.ISBNLibro = l.ISBN";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewReservas.DataSource = table;
            }
        }


        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Reservas WHERE IdReserva = @IdReserva";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@IdReserva", txtIdReserva.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Reserva eliminada correctamente.");
                CargarReservas();
            }
        }

        private void btnEditarReserva_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Reservas SET IdUsuario = @IdUsuario, ISBNLibro = @ISBNLibro, FechaReserva = @FechaReserva, FechaRetorno = @FechaRetorno WHERE IdReserva = @IdReserva";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@IdReserva", txtIdReserva.Text);
                command.Parameters.AddWithValue("@IdUsuario", comboBoxUsuarios.SelectedValue);
                command.Parameters.AddWithValue("@ISBNLibro", comboBoxLibros.SelectedValue);
                command.Parameters.AddWithValue("@FechaReserva", dateTimePickerReserva.Value);
                command.Parameters.AddWithValue("@FechaRetorno", dateTimePickerRetorno.Value == null ? DBNull.Value : (object)dateTimePickerRetorno.Value);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Reserva actualizada correctamente.");
                CargarReservas();
            }
        }

        private void btnAgregarReserva_Click(object sender, EventArgs e)
        {



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Reservas (IdUsuario, ISBNLibro, FechaReserva, FechaRetorno) VALUES (@IdUsuario, @ISBNLibro, @FechaReserva, @FechaRetorno)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@IdUsuario", comboBoxUsuarios.SelectedValue ?? DBNull.Value);
                command.Parameters.AddWithValue("@ISBNLibro", comboBoxLibros.SelectedValue ?? DBNull.Value);
                command.Parameters.AddWithValue("@FechaReserva", dateTimePickerReserva.Value);
                command.Parameters.AddWithValue("@FechaRetorno", DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Reserva agregada correctamente.");
                CargarReservas();
            }

        }

        private void dataGridViewReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewReservas.Rows[e.RowIndex];
                txtIdReserva.Text = row.Cells["IdReserva"].Value.ToString();
                comboBoxUsuarios.SelectedValue = row.Cells["IdUsuario"].Value;
                comboBoxLibros.SelectedValue = row.Cells["ISBNLibro"].Value;
                dateTimePickerReserva.Value = Convert.ToDateTime(row.Cells["FechaReserva"].Value);

                if (row.Cells["FechaRetorno"].Value != DBNull.Value)
                {
                    dateTimePickerRetorno.Value = Convert.ToDateTime(row.Cells["FechaRetorno"].Value);
                }
                else
                {
                    dateTimePickerRetorno.Value = DateTime.Now;
                }
            }
        }
    }
}
