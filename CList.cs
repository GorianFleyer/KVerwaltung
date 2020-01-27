using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontoverwaltung
{
    class CList
    {

        private CElement lKopf, lEnde, lAusgabe, lNeu;
        public CList()
        {
            lKopf = null;
            lEnde = null;
            lAusgabe = null;
            lNeu = new CElement();
            lNeu.Kontoinhaber = "Horst";
            lNeu.Kontonummer = 0;
            lNeu.Kontostand = 0.0;
           


        }
        public CElement GetlKopf()
        { 
            return lKopf;
        }
        public void AddElement(CElement lNeu)
        {
            if (!(lKopf is null))
            {
                lEnde.Next = lNeu;
                lEnde = lNeu;
            }
            else
            {
                lKopf = lNeu;
                lEnde = lNeu;
            }
        }
        public bool RemoveElement(long Kontonummer)
        {
           
            CElement lAktuell = lKopf;
            CElement lVor = lKopf;

            // hier ende

            if(Kontonummer.Equals(lEnde.Kontonummer))
            {
                while(!(lAktuell.Next == lEnde))
                {
                    lVor = lAktuell;
                    lAktuell = lAktuell.Next;
                }
                lEnde = lVor.Next;
                return true;
            }
            while(!(lAktuell.Next is null))
            {
                if(Kontonummer.Equals(lAktuell.Kontonummer))
                {
                    if (lAktuell == lKopf)
                    {
                        lKopf = lKopf.Next;
                    }
                    else if (lAktuell == lEnde)
                    {
                        lVor.Next = lEnde;

                    }
                    else
                    {
                        lAktuell = lAktuell.Next;
                        
                    }
                    lVor.Next = lAktuell;
                    lAktuell = null;
                   return true;
                }
                lVor = lAktuell;
                lAktuell = lAktuell.Next;
                
            }
            

            
            return false;
        }
        public void ShowList()
        {
            lAusgabe = lKopf;
            while(!(lAusgabe is null))
            {
                Console.WriteLine("Kontoinhaber: " + lAusgabe.Kontoinhaber);
                Console.WriteLine("Kontonnummer: " + lAusgabe.Kontonummer);
                Console.WriteLine("Kontostand: " + lAusgabe.Kontostand + " Euro");
                lAusgabe = lAusgabe.Next;
            }

        }
    }
}
