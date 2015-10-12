using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur_des
{
    public class DeGenerique
    {
        public int Face;
        public Boolean pipe;
        public int[] Valeurs;

        public DeGenerique(int f = 6)
        {
            Face = f;
            pipe = false;
            Valeurs = new int[Face];
            for (int i = 0; i < f; i++)
            {
                Valeurs[i] = i + 1;
            }
        }
    }
}
