using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulateur_des
{
    class Jeu
    {
        public Lancer Jet;
        public int Objectif;
        public String Condition;

        public Jeu(int obj, String cond, Lancer dernierJet)
        {
            Objectif = obj;
            Condition = cond;
            Jet = dernierJet;
        }

        public void ResultatJeu()
        {
            switch (Condition)
            {
                case "<":
                    if (Jet.resultat < Objectif)
                        MessageBox.Show("Jet réussi!");
                    else
                        MessageBox.Show("Echec du jet: Vous n'avez pas atteint l'objectif fixé(le résultat devait être inférieur à"+Objectif+").");
                    break;
                case "=":
                    if (Jet.resultat == Objectif)
                        MessageBox.Show("Jet réussi!");
                    else
                        MessageBox.Show("Echec du jet: Vous n'avez pas atteint l'objectif fixé(le résultat devait être égal à" + Objectif + ").");
                    break;
                case ">":
                    if (Jet.resultat > Objectif)
                        MessageBox.Show("Jet réussi!");
                    else
                        MessageBox.Show("Echec du jet: Vous n'avez pas atteint l'objectif fixé(le résultat devait être supérieur à" + Objectif + ").");
                    break;
            }
        }
    }
}
