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

namespace BibliotecaDB.Usuario
{
    public partial class Registrar_Usuario : Form
    {
        public Registrar_Usuario()
        {
            InitializeComponent();
        }
        private string connectionString = "Server=.;Database=BibliotecaDB;Trusted_Connection=True;";

        private void CargarUsuarios()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Usuarios";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table; // Reemplazar dataGridViewUsuarios con dataGridView1
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar usuarios: {ex.Message}");
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Usuarios (Nombre, Apellido, Email, Telefono) VALUES (@Nombre, @Apellido, @Email, @Telefono)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Nombre", txtNombre3.Text);
                    command.Parameters.AddWithValue("@Apellido", txtApellido3.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail3.Text);
                    command.Parameters.AddWithValue("@Telefono", txtTelefono3.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Usuario agregado correctamente.");
                    CargarUsuariosData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar usuario: {ex.Message}");
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario3.Text))
            {
                MessageBox.Show("Por favor, selecciona un usuario para editar.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Telefono = @Telefono WHERE IdUsuario = @IdUsuario";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@IdUsuario", Convert.ToInt32(txtUsuario3.Text));
                    command.Parameters.AddWithValue("@Nombre", txtNombre3.Text);
                    command.Parameters.AddWithValue("@Apellido", txtApellido3.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail3.Text);
                    command.Parameters.AddWithValue("@Telefono", txtTelefono3.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Usuario actualizado correctamente.");
                    CargarUsuariosData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar usuario: {ex.Message}");
                }
            }
        }

        private void CargarUsuariosData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdUsuario, Nombre, Apellido, Email, Telefono FROM Usuarios";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario3.Text))
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminar.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@IdUsuario", Convert.ToInt32(txtUsuario3.Text));

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Usuario eliminado correctamente.");
                    CargarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar usuario: {ex.Message}");
                }
            }
        }
        private void txtApellido3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registrar_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDBDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bibliotecaDBDataSet.Usuarios);

        }

        private void txtNombre3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txtUsuario3.Text = row.Cells["IdUsuario"].Value.ToString();
                    txtNombre3.Text = row.Cells["Nombre"].Value.ToString();
                    txtApellido3.Text = row.Cells["Apellido"].Value.ToString();
                    txtEmail3.Text = row.Cells["Email"].Value.ToString();
                    txtTelefono3.Text = row.Cells["Telefono"].Value.ToString();
                }
            }
        }
    }
}
