using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataLayer.DataContacts
{
    internal class ContactContext:DbContext
    {
        private string connectionString = 
           " Data Source = LAPTOP - 0PUR4A2V\\SQLEXPRESS;Initial Catalog = Lesson7; Integrated Security = True; Trust Server Certificate=True";
       
        public DbSet<Contact> Contact { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        internal void waite()
        {
            throw new NotImplementedException();
        }
    }
}
