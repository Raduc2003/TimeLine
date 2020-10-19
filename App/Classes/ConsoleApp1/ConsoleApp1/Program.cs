using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ConsoleApp1
{
    
    class Program
    {

        public class Database
        {
            private static Database database = new Database();
            List<object> tabel = new List<object>();
            static int i = 0;

            private Database()
            {
            }
            public static Database Getdatabase()
            {
                return database;
            }
            public void AddEntry(object x)
            {
                database.tabel.Add(x);
                i++;
            }
            

        }

        public class Users
        {
            string nume;
            int varsta;
            string sex;
            public Users(string a,string b,int c)
            {
                nume = a;
                sex = b;
                varsta = c;
            }
        }

        static void Main(string[] args)
        {
            Users Radu = new Users("asad", "asda", 3);
            Database db = Database.Getdatabase();
            db.AddEntry(Radu);
            Console.WriteLine(db);
        }
    }
}
