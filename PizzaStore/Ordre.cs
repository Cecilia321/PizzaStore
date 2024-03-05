using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Ordre
    {
        DateTime _date;
        private static int idcounter = 0;


        public DateTime Date { get => _date; private set => _date = value; }
        public Ordre()
        {
            Date = DateTime.Now;
            idcounter++;
        }
        public override string ToString()
        {
            return  Date.ToString("dd:MM:yy kl HH:mm:ss");
        }
    }
}
