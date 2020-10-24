using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Net.Mail;

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
                ++x.Id;

            }

            public void ShowEntry(int x)
            {
                table[x].ReturnData();
            }
            
        }
        public abstract class Table
        {

            abstract public void ReturnData();
            public abstract int Id
            {
                get;
                set;
            }
            abstract public void FindById(int x);
            public abstract Table[] Objectshelf
            {
                get;
                set;
            }

        }
        public class Users : Table
        {
            int idUser=0;
            string nume;
            int varsta;
            string sex;
            public Table[] objectshelf =new Table[100];
            public Users(string a, string b, int c)
            {
                nume = a;
                sex = b;
                varsta = c;
            }
            public override int Id
            {
                get { return idUser; }
                set { idUser = value; }
            }
            public override Table[] Objectshelf
            {
                get { return objectshelf[2]; }
                set { objectshelf[Id]=}
            }
            public override void FindById(int x)
            {

            }
            public override void ReturnData()
            {
                Console.WriteLine("varsta: " + this.varsta);
                Console.WriteLine("sex: " + this.sex);
                Console.WriteLine("nume: " + this.nume);
                Console.WriteLine(Id);
            }
            

        }
        public class TimeLineInfo:Table
        {
            int idTimeLine=0 ;
            int durata_actiune;
            string actiune;
            public TimeLineInfo(int a,string b)
            {
                durata_actiune = a;
                actiune = b;
            }
            public override int Id
            {
                get { return idTimeLine; }
                set { idTimeLine = value; }
            }
            public override void ReturnData()
            {
                Console.WriteLine("Actiune: " + actiune);
                Console.WriteLine("Durata actiune: " + durata_actiune);
                Console.WriteLine(Id);
            }

        }
        static void Main(string[] args)
        {
            Table Radu = new Users("asad", "asda", 3);
            Table Radu2 = new Users("asdadd", "aaaaaa", 10);
            Database db = Database.Getdatabase();
            Radu.ReturnData();
            db.AddEntry(Radu);
            db.AddEntry(Radu2);
            db.ShowEntry(2);
            Table GGGG = new TimeLineInfo(30, "mancat");
            Table Radu3 = new Users("asd", "asd", 15);
            Table GGGG2 = new TimeLineInfo(300, "dormit");
            db.AddEntry(GGGG);
            db.ShowEntry(3);
            db.AddEntry(Radu3);
            db.ShowEntry(4);
            db.AddEntry(GGGG2);
            db.ShowEntry(5);
            Console.WriteLine(Radu3.Id);
        }

    }
}
