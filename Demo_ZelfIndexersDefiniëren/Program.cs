using System;

namespace Demo_ZelfIndexersDefiniëren
{
    class Program
    {
        static void Main(string[] args)
        {
            KlantenBestand klantenBestand = new KlantenBestand();
            klantenBestand.VoegKlantToe("Jan Jansen", 77452858965);
            Console.WriteLine("Eerste indexer aanroepen: " + klantenBestand[77452858965]);
            klantenBestand[77452858965]="Piet Pieters";
            Console.WriteLine("Tweede indexer aanroepen: " + klantenBestand["Piet Pieters"]);
        }
    }
}
