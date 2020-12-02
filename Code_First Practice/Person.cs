using System;
using System.Collections;
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
            catch
            {
                return false;
                throw;
            }
        }
        public bool UpdatePerson(Person NewPerson)
        {
            try
            {
                db DataBase = new db();
                Person UpdatedPerson = DataBase.Persons.Find(NewPerson.Id);
                UpdatedPerson.FullName = NewPerson.FullName;
                UpdatedPerson.NationCode = NewPerson.NationCode;
                UpdatedPerson.MobileNumber = NewPerson.MobileNumber;
                UpdatedPerson.SexType = NewPerson.SexType;
                //
                DataBase.SaveChanges();
                //
                return true;
            }
            catch
            {
                return false;
                throw;
            }
        }
        public bool DeletePerson(int Id)
        {
            try
            {
                db DataBase = new db();
                Person CurrentPerson = Read(Id);
                DataBase.Entry(CurrentPerson).State = System.Data.Entity.EntityState.Deleted;
                DataBase.Persons.Remove(CurrentPerson);
                //
                DataBase.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
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
        public IEnumerable Read()
        {
            db DataBase = new db();
            //
            return DataBase.Persons.Select(i => new { Id = i.Id, نام = i.FullName, کدملی = i.NationCode, موبایل = i.MobileNumber, جنسیت = i.SexType ? "مرد" : "زن" }).ToList();
        }
        public IEnumerable Read(string SearchText)
        {
            db DataBase = new db();
            var q = DataBase.Persons.Select(i => new { Id = i.Id, نام = i.FullName, کدملی = i.NationCode, موبایل = i.MobileNumber, جنسیت = i.SexType ? "مرد" : "زن" }).ToList();
            q = q.Where(i => i.نام.Contains(SearchText) || i.کدملی.Contains(SearchText) || i.موبایل.Contains(SearchText) || i.جنسیت.Contains(SearchText)).ToList();
            //
            return q;
        }
        public Person Read (int Id)
        {
            db DataBase = new db();
            var q = DataBase.Persons.Where(i => i.Id == Id).ToList();

            Person Result = q.Single();

            return Result;
        }
    }
}
