using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5CoursExoClasse
{
    class Secretaire:Employe
    {
        private int niveauAnglais;

        public Secretaire(string matricule, string nom, float salaireMensuel, string unDiplome, int niveau):base(matricule,nom,salaireMensuel,unDiplome)
        {
            this.niveauAnglais = niveau;
        }
        public int GetNivAnglais()
        {
            return niveauAnglais;
        }
        public void SetNivAnglais(int niveau)
        {
            this.niveauAnglais = niveau;
        }
    }
}
