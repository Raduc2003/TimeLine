using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ConsoleApp1
{

    class Program
    {

        public class Database
        {
            private static Database database = new Database();
            static int i = 0;

            private Database()
            {
            }
            public static Database Getdatabase()
            {
                return database;
            }
            Table[] table = new Table[200];

            public void AddEntry(Table x)
            {
                i++;
                table[i] = x;
                x.addToShelf(x);

            }

            public void ShowEntry(int x)
            {
                table[x].ReturnData();
            }

        }
        public abstract class Table
        {
            abstract  public void addToShelf(Table x);
            abstract public void ReturnData();
            abstract public void Delete();
        }
        public class Users : Table
        {
            static int idD = 0;
            int id = 0;
            string nume;
            int varsta;
            string sex;
            static int i = 1;
            public static Users[] object_shelf = new Users[100];
            
            public Users(string a, string b, int c)
            {
                nume = a;
                sex = b;
                varsta = c;
                idD++;
                id = idD;
            }
            public override void addToShelf(Table x)
            {
                object_shelf[id] = (Users)x;
                i++;
            }
            public  static void FindById(int x)
            {
                object_shelf[x].ReturnData();
            }
            public static void FindFirst()
            {
                object_shelf[1].ReturnData();
            }
            public override void ReturnData()
            {
                Console.WriteLine(this.id);
                Console.WriteLine("varsta: " + this.varsta);
                Console.WriteLine("sex: " + this.sex);
                Console.WriteLine("nume: " + this.nume);
            }
            public static void DeleteEntry(int x)
            {
                object_shelf[x] = null;
            }
            public override void Delete()
            {
                DeleteEntry(this.id);
            }
        }
        public class TimeLineInfo : Table
        {
            static int idD = 0;
            int id = 0;
            int durata_actiune;
            string actiune;
            static TimeLineInfo[] object_shelf = new TimeLineInfo[100];
            
            public TimeLineInfo(int a, string b)
            {
                durata_actiune = a;
                actiune = b;
                idD++;
                id = idD;
            }
            public override void addToShelf(Table x)
            {
                object_shelf[id] = (TimeLineInfo)x;
            }
            public static void FindById(int x)
            {
                object_shelf[x].ReturnData();
            }
            public override void ReturnData()
            {
                Console.WriteLine(this.id);
                Console.WriteLine("Actiune: " + actiune);
                Console.WriteLine("Durata actiune: " + durata_actiune);
            }
            public static void FindFirst()
            {
                object_shelf[1].ReturnData();
            }
            public static void DeleteEntry(int x)
            {
                object_shelf[x] = null;
            }
            public override void Delete()
            {
                DeleteEntry(this.id);
            }
        }
        static void Main(string[] args)
        {
            Table Radu = new Users("asad", "asda", 3);
            Table Radu2 = new Users("asdadd", "aaaaaa", 10);
            Database db = Database.Getdatabase();
            Table GGGG = new TimeLineInfo(30, "mancat");
            Table Radu3 = new Users("asd", "asd", 15);
            Table GGGG2 = new TimeLineInfo(300, "dormit");
            db.AddEntry(GGGG);
            db.AddEntry(Radu);
            db.AddEntry(GGGG2);
            db.AddEntry(Radu2);
            db.AddEntry(Radu3);
            Users.FindById(2);
            Radu2.Delete();
            Users.FindById(2);


        }
    }
}
