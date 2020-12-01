using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Practice
{
    public class db:DbContext
    {
        public db():base("name=ConString")
        {
        }
        public DbSet<Person> Persons { set; get; }
    }
}
