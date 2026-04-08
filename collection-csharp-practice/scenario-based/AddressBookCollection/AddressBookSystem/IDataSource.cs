using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal interface IDataSource
    {
        Task SaveAsync(List<Contact> contacts);
        Task<List<Contact>> LoadAsync();
        Task DeleteAsync(string firstName, string lastName);
    }
}