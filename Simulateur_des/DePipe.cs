using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur_des
{
    public class DePipe : DeGenerique
    {

        public DePipe(int f, int[] val)
        {
            Face = f;
            pipe = true;
            Valeurs = val;
        }
    }
}
