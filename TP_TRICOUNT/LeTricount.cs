using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_TRICOUNT
{
    public static class LeTricount
    {

        private static List<Depense> lesDepenses = new List<Depense>();
        private static List<Participant> lesParticipants = new List<Participant>();
        private static bool AjouterDepense(Depense d)
        {
            lesDepenses.Add(d);
            Participant payeur = d.GetPayeur();
            List<Participant> listeP = d.GetPConcernes();
            foreach(Participant p in listeP)
            {
                p.AddDepense(d);
            }
            if(listeP.IndexOf(payeur) <= 0)
            {
                payeur.AddDepense(d);
            }
            return true;

        }

        private static bool AjouterParticipant(Participant a)
        {
            lesParticipants.Add(a);
            return true;
        }

        private static bool SurpimeDepense(Depense d)
        {
            lesDepenses.Remove(d);
            return true;

        }
    }
}
