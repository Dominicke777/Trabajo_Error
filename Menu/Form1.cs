using BibliotecaDB.Libros;
using BibliotecaDB.Reservas;
using BibliotecaDB.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaDB.Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reservar_Libro reservarLibroForm = new Reservar_Libro();
            reservarLibroForm.Show();
            this.Close();
        }
        }

        private void button2_BackgroundImageChanged(object sender, EventArgs e)
        {
            Gestor_Libros gestorLibrosForm = new Gestor_Libros();
            gestorLibrosForm.Show();
            this.Close();

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Registrar_Usuario registrarUsuarioForm = new Registrar_Usuario();
            registrarUsuarioForm.Show();
            this.Close();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
