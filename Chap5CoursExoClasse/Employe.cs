using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5CoursExoClasse
{
    class Employe
    {
        private string matricule;
        private string nom;
        private float salaireMensuel;
        private string leDiplome;

        private void Augmenter(float augment)
        {
            salaireMensuel = salaireMensuel + augment;
        }
        public string GetMatricule()
        {
            return matricule;
        }
        public string GetNom()
        {
            return nom;
        }
        public void SetNom(string unNom)
        {
            this.nom = unNom;
        }
        public Employe(string unMatricule, string unNom, float unSalaire, string unDiplome)
        {
            this.matricule = unMatricule;
            this.nom = unNom;
            this.salaireMensuel = unSalaire;
            this.leDiplome = unDiplome;

        }
    }
}
