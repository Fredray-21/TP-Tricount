using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_TRICOUNT
{
    public class Depense
    {
        private Participant lePayeur;
        private List<Participant> pConcernes = new List<Participant>();


        private String titre;
        private float montant;
        private DateTime date;

        public Depense(String Titre, float Montant, DateTime Date, Participant Payeur, List<Participant> Concernes)
        {
            this.titre = Titre;
            this.montant = Montant;
            this.date = Date;
            this.lePayeur = Payeur;
            this.pConcernes = Concernes;
        }

        public String GetTitre()
        {
            return this.titre;
        }
        public float GetMontant()
        {
            return this.montant;
        }
        public DateTime GetDate()
        {
            return this.date;
        }

        public Participant GetPayeur()
        {
            return this.lePayeur;
        }

        public List<Participant> GetPConcernes()
        {
            return this.pConcernes;
        }


    }
}
