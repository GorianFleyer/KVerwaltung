using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontoverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            CList clist = new CList();
            int read = 0;
            string yn = "";
            do
            {
                Console.WriteLine("  Kontoverwatlungstool   v1.0");
                Console.WriteLine("=============================");
                Console.WriteLine("  [1] Konto hinzufuegen");
                Console.WriteLine("  [2] Konto loeschen");
                Console.WriteLine("  [5] Konten anzeigen");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("  [0] Beenden");
                try
                {
                    read = Int32.Parse(Console.ReadLine());
                    if(read == 1)
                    {
                        CElement cElement = new CElement();
                        Console.WriteLine("Kontoinhaber: ");
                        cElement.Kontoinhaber = Console.ReadLine();
                        Console.WriteLine("Kontonummer: ");
                        cElement.Kontonummer = long.Parse(Console.ReadLine());
                        Console.WriteLine("Kontostand: ");
                        cElement.Kontostand = Double.Parse(Console.ReadLine());

                        clist.AddElement(cElement);
                        Console.WriteLine("Konto erfolgreich hinzugefügt");
                    }
                    if(read == 2)
                    {
                        long kn = 0;
                       
                        Console.WriteLine("Bitte die Kontonnummer des zu löschenden Kontos angeben:");
                        kn = long.Parse(Console.ReadLine());
                        Console.WriteLine("Konto mit der Nummer " + kn + " wirklich löschen? y/n [default n]");
                        yn = Console.ReadLine();
                        if(yn.Equals("y"))
                        {
                            bool erfolg = true;
                           erfolg = clist.RemoveElement(kn);
                            if(erfolg)
                            {
                                Console.WriteLine("Konto " + kn + " erfolgreich gelöscht" );
                            }
                            else
                            {
                                Console.WriteLine("Konto " + kn + " konnte nicht gelöscht werden");
                            }
                        }

                    }
                    if (read == 5)
                    {
                        clist.ShowList();
                    }
                    else if(read !=1 && read != 2 && read != 5 && read != 0 )
                    {
                        Console.WriteLine("Falsche Eingabe");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (read != 0);
        }
    }
}
