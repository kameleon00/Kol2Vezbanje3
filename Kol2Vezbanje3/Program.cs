using System;
using System.Collections.Generic;

namespace Kol2Vezbanje3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Kreirati ulančanu listu ispita tipa string
            LinkedList<string> ispiti = new LinkedList<string>();
            
            //2) Dodati ispit „Objektno orijentisano programiranje“ na početak liste
            ispiti.AddFirst("Objektno orijentisano programiranje");
            //3) Dodati ispit „Programerski alati“ na kraj liste
            ispiti.AddLast("Programerski alati");
            //4) Dodati ispit „Baze podataka“ pre poslednjeg ispita
            ispiti.AddBefore(ispiti.Last,"Baze podataka");
            //5) Dodati ispit „Napredne baze podataka“ posle prvog ispita
            ispiti.AddAfter(ispiti.First, "Napredne baze podataka");
            //6) Dodati ispit „Internet programerski alati“ posle ispita „Objektno orijentisano programiranje“
            ispiti.AddAfter(ispiti.First, "Internet programerski alati");
            
            //7) Ispisati sve ispite iz ulančane liste
            Console.WriteLine("Svi elementi iz liste:");
            Console.WriteLine("-----------------------------------");
            foreach (var ispit in ispiti)
            {
                Console.WriteLine(ispit);
            }
            Console.WriteLine("===================================");
            Console.WriteLine();
            
            //8) Ukloniti prvi ispit iz ulančane liste
            ispiti.RemoveFirst();
            //9) Ukloniti poslednji ispit iz ulančane liste
            ispiti.RemoveLast();
            //10) Ukloniti ispit „Internet programerski alati“ iz ulančane liste
            ispiti.Remove("Internet programerski alati");
            
            //11) Ispis ulancane liste
            Console.WriteLine("Ispis liste nakon uklanjanja elemenata:");
            Console.WriteLine("-----------------------------------");
            foreach (var ispit in ispiti)
            {
                Console.WriteLine(ispit);
            }
            Console.WriteLine("===================================");
        }
    }
}