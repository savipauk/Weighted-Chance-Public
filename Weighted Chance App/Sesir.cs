using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weighted_Chance_App
{
    public class Sesir
    {
        List<string> sesir = new List<string>();
        public void dodajUSesir(int numberOfEntries, string item)
        {
            if (numberOfEntries < 0)
            {
                throw new Exception("number of entries lower than 0");
            }

            for (int i = 0; i < numberOfEntries; i++)
            {
                sesir.Add(item);
            }
        }

        public string dajIzSesira()
        {
            Random ran = new Random();

            return sesir[ran.Next(sesir.Count)];
        }

        // Run 1 000 000 times and show percentages
        public string simulirajSesir()
        {
            string output = "";
            // Initialize dictionary with pick rates
            Dictionary<string, int> sesirEntries = new Dictionary<string, int>();
            foreach (string n in sesir)
            {
                if (!sesirEntries.ContainsKey(n))
                {
                    sesirEntries.Add(n, 0);
                    continue;
                }
            }

            // Pick a random entry, show pick rates
            for (int i = 0; i < 1000000; i++)
            {
                string n = dajIzSesira();
                sesirEntries[n]++;
            }

            foreach (var pick in sesirEntries)
            {
                float percentage = (pick.Value / 1000000f) * 100;
                output += pick + "\t" + percentage + " % \n";
            }

            return output;
        }
    }
}
