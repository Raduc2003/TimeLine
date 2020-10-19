using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    public sealed class Baza_de_date
    {
        
        private static readonly Baza_de_date baza_de_date = new Baza_de_date();
        private object[] tabele;
        private Baza_de_date()
        {
        }
        public static Baza_de_date GetBaza()
        {
            return Baza_de_date.baza_de_date;
        }
    public class User
        {
            string Nume;
            int Varsta;
            string Sex;
            public User(string nume,int varsta,string sex)
            {
                Nume = nume;
                Varsta = varsta;
                Sex = sex;
            }
        }

    }

    private static void Main(string[] args)
    {
       
    }



    }
}
