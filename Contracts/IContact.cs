using Portfolio.Models;

namespace Portfolio.Contracts
{
    public interface IContact
    {
        List<Contact> GetContacts();
        void AddContact(Contact contact);
    }
}
