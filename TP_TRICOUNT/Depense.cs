﻿using System;
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

        private int ID;
        private String titre;
        private float montant;
        private DateTime date;

        public Depense(String Titre, float Montant, DateTime Date, Participant Payeur, List<Participant> Concernes)
        {
            this.ID = 0;
            this.titre = Titre;
            this.montant = Montant;
            this.date = Date;
            this.lePayeur = Payeur;
            this.pConcernes = Concernes;
        }
        public Depense(int ID, String Titre, float Montant, DateTime Date, Participant Payeur, List<Participant> Concernes)
        {
            this.ID = ID;
            this.titre = Titre;
            this.montant = Montant;
            this.date = Date;
            this.lePayeur = Payeur;
            this.pConcernes = Concernes;
        }

        public int GetID()
        {
            return this.ID;
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

        public void SetPConcernes(List<Participant> listP)
        {
           
           this.pConcernes = listP;
        }

        public override string ToString()
        {
           
            return this.ID.ToString();
        }
        /*public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Depense p = (Depense)obj;
                return (titre == p.titre) && (montant == p.montant) && (date == p.date);
            }
        }*/
    }
}
