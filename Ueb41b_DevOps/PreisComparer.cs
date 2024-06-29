using System.Collections.Generic;

namespace Ueb08d_Sortieren_Fruechte
{
    public class PreisComparer : IComparer<Frucht>
    {
        // Wie Sie sehen kann man wirklich Aepfel mit Birnen vergleichen...
        public int Compare(Frucht x, Frucht y)
        {
            if (x.Preis > y.Preis)
            {
                return 1;
            }
            else if (x.Preis < y.Preis)
            {
                return -1;
            }

            return 0;
        }
    }
}