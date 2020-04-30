using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class ItemBestellt
    {
        public string ItemName { get; set; }
        public string Zutaten { get; set; }
        public string Preis { get; set; }
        public int Menge { get; set; }
        public double Total { get; set; }
        
    }
}
