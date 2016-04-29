using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5CoursExoClasse
{
    public class Commercial:Employe
    {
        private float txCommission;
        private float mtCa;

        public float GetTxCom()
        {
            return txCommission;
        }
        public float GetMtCa()
        {
            return mtCa;
        }
        public float GetMtCom()
        {
            return this.GetMtCa() * this.GetTxCom() / 100;
        }
        public void SetTxCom(float txCom)
        {
            this.txCommission = txCom;
        }
        public void AugmentVente(float montant)
        {
            mtCa = mtCa + montant;
        }
        public Commercial(string unMatricule, string unNom, float unSalaire, string unDiplome, float unTx, float unCa):base(unMatricule,unNom,unSalaire,unDiplome)
        {
            this.txCommission = unTx;
            this.mtCa = unCa;
        }
    }
}
