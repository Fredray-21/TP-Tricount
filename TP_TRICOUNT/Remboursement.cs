using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_TRICOUNT
{
    public class Remboursement
    {
        private Participant lePayeur;
        private Participant lePayer;

        private float montant;
        private DateTime date;

        public Remboursement(float Montant, DateTime Date, Participant Payeur, Participant Payer)
        {
            this.montant = Montant;
            this.date = Date;
            this.lePayeur = Payeur;
            this.lePayer = Payer;
        }

    }
}
