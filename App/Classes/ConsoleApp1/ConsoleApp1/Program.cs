﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
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
            }

        }
        public abstract class Table
        {
            abstract public void ReturnEntry();
        }
        public class Users:Table
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
            public override void ReturnEntry()
            {
                Console.WriteLine("varsta: " + this.varsta);
                Console.WriteLine("sex: " + this.sex);
                Console.WriteLine("nume: " + this.nume);
            }
        }

        static void Main(string[] args)
        {
            Table Radu = new Users("asad", "asda", 3);
            Database db = Database.Getdatabase();
            db.AddEntry(Radu);
            Table.ReturnEntry();
        }
    }
}
