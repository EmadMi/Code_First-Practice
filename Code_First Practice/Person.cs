using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Practice
{
    public class Person
    {
        public Person()
        {
            Id = 0;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string NationCode { get; set; }
        public string MobileNumber { get; set; }
        public bool SexType { get; set; }

        public bool RegisterPerson(Person NewPerson)
        {
            try
            {
                db DataBase = new db();
                DataBase.Persons.Add(NewPerson);
                DataBase.SaveChanges();
                //
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }
        public bool ExistPerson(Person Person)
        {
            try
            {
                db DataBase = new db();
                var q = DataBase.Persons.Where(i => i.NationCode == Person.NationCode && i.Id != Person.Id).ToList();
                if (q.Count() > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return true;
                throw;
            }
        }
    }
}
