using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("inserisci il nome della persona");
            string nome = Console.ReadLine();


            Console.WriteLine("inserisci il cognome della persona");        
            string cognome = Console.ReadLine();

            Console.WriteLine("inserisci èta della persona");
            int età = Convert.ToInt32(Console.ReadLine());



            Persona persona1 = new Persona("marco","polo",32);
            
            
            Console.WriteLine(persona1.GetDettagli());
            Console.WriteLine(persona1.GetEta());
            Console.WriteLine(persona1.GetCognome());

            Console.WriteLine("prezzo prodotto");
            int prezzo = Convert.ToInt32(Console.ReadLine());




            Prodotto prodotto1 = new Prodotto();
            prodotto1.Quantità = 25;
            prodotto1.Prezzo = 2;
            Console.WriteLine(prodotto1.CalcolaTotale());

            Prodotto prodotto2 = new Prodotto("ps5", 550, 2);
            Console.WriteLine(prodotto2.CalcolaTotale());



            Televisione tv=new Televisione();
            tv.Canale = 25;
           
            Console.WriteLine(tv.Canale);

            Televisione tv2 = new Televisione(true, 5, 45, false);
            Console.WriteLine(tv2.Canale);


            Console.WriteLine("gurda la tv?");
            bool accessoOspento = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("volume");
            int volume= char.Parse(Console.ReadLine());

            Console.WriteLine("alza il volume");
           
            tv2.AlzaVolume();
            tv2.PrintStatotv();


            Console.ReadLine();
           
        }
    }
}
