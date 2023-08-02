using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataLayer;
using DataLayer.Interface;
using DataLayer.Repository;

namespace BusinessLayer
{
    public class ContactService
    {
        static IContactRepository repository;
        static ContactService()
        {
            repository = new ContactRepository();
        }
        public static List<Contact> GetAll()
        {
            return repository.GetAll();
        }
        public static Contact GetByID(int id)
        {
            return repository.GetByID(id);
        }
        public static Contact Create(Contact contact)
        {
            return repository.Create(contact);
        }
        public static void Update(Contact contact)
        {
            repository.Update(contact);
        }
        public static void Delete(Contact contact)
        {
            repository.Delete(contact);
        }
    }
}