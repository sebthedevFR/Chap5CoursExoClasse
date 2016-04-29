using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5CoursExoClasse
{
    class Reparateur:Employe
    {
        private int coutHorraire;

        public int GetCoutHorraire()
        {
            return coutHorraire;
        }
        public void SetCoutHorraire(int unCout)
        {
            this.coutHorraire = unCout;
        }
        public Reparateur(string unMatricule, string unNom, float salaireMensuel, string unDiplome, int unCout):base(unMatricule,unNom,salaireMensuel,unDiplome)
        {
            this.coutHorraire = unCout;
        }
    }
}
