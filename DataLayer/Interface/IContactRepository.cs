using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IContactRepository
    {
        List<Contact> GetAll();
        Contact GetByID(int id);
    
        Contact Create(Contact contact);
        void Update(Contact contact);
        void Delete(Contact contact);
    }
}
