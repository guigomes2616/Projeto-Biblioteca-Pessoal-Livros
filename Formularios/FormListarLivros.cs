using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormListarLivros : Form
    {  
        private int usuarioId;
        private string connectionString = "server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';";

        public FormListarLivros(int id_usuario)
        {
            InitializeComponent(); 
            this.usuarioId = id_usuario;
            CarregarLivros();
        }

        private void CarregarLivros()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT nome_livro, autor_livro, ano_publicacao FROM livro WHERE id_usuario = @UsuarioId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridViewLivros.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar livros: {ex.Message}");
            }
        }
    }
}
