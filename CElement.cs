using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontoverwaltung
{
    class CElement
    {
        private long kontonummer;
        private String kontoinhaber;
        private double kontostand;
        private CElement next;
        public CElement()
        {
            kontonummer = 0;
            kontoinhaber = "Dr No";
            kontostand = 0.0;
            next = null;
        }

        public long Kontonummer { get => kontonummer; set => kontonummer = value; }
        public string Kontoinhaber { get => kontoinhaber; set => kontoinhaber = value; }
        public double Kontostand { get => kontostand; set => kontostand = value; }
        internal CElement Next { get => next; set => next = value; }
    }
}
