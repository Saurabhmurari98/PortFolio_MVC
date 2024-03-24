using MongoDB.Driver;
using Portfolio.Models;
using Portfolio.Constant;
using Portfolio.Contracts;

namespace Portfolio.Services
{
    public class ContactService:IContact
    {
        private readonly IMongoCollection<Contact> mongoCollection;
        public ContactService()
        {
            var mongos = new MongoClient(Consts.Server);
            var _database = mongos.GetDatabase(Consts.Database);
            this.mongoCollection = _database.GetCollection<Contact>(Consts.Collection);
        }

        public void AddContact(Contact contact)
        {
            mongoCollection.InsertOne(contact);
        }

        public List<Contact> GetContacts()
        {
            return mongoCollection.Find(e => true).ToList();
        }
    }
}
