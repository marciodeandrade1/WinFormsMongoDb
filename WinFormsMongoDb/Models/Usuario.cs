using MongoDB.Bson;

namespace WinFormsMongoDb.Models
{
    public class Usuario
    {
        public ObjectId Id { get; set; } // campo obrigatório para o MongoDb
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
