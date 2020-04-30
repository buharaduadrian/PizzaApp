using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class KundenDaten
    {
        public string Vorname { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }
        public string ZahlungMethode { get; set; }
        public bool Speichern { get; set; }
        public string Lieferung { get; set; }
    }
}
