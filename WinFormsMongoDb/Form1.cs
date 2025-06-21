using MongoDB.Bson;
using MongoDB.Driver;
using WinFormsMongoDb.Models;

namespace WinFormsMongoDb
{
    public partial class Form1 : Form
    {
        private IMongoCollection<Usuario> _colecaoUsuarios;
        public Form1()
        {
            InitializeComponent();
            // Conexão com o MongoDB (local)
            var client = new MongoClient("mongodb://localhost:27017"); //porta padrão 
            var database = client.GetDatabase("CadastroUsuarios");
            _colecaoUsuarios = database.GetCollection<Usuario>("usuarios");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text
            };

            _colecaoUsuarios.InsertOne(usuario);
            MessageBox.Show("Usuário salvo com sucesso!");
        }
    }
}
