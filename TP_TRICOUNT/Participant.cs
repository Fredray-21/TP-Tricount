﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_TRICOUNT
{
    public class Participant : IComparable
    {
        private List<Depense> mesDepenses;

        private String nom;
        private float balance;
        private float monCoutTotal;
        private float remboursement;

        public Participant(String Nom)
        {
            this.nom = Nom;
            this.balance = 0;
            this.monCoutTotal = 0;
            this.remboursement = 0;
            this.mesDepenses = new List<Depense>();
        }

        public String GetNom()
        {
            return this.nom;
        }
        public float GetBalance()
        {
            return this.balance;
        }
        public float GetCoutTotal()
        {
            return this.monCoutTotal;
        }
        public float GetRemboursement()
        {
            return this.remboursement;
        }

        public bool SetBalance(float Balance)
        {
            this.balance += Balance;
            return true;
        }

        public bool AddDepense(Depense d)
        {
            this.mesDepenses.Add(d);
            return true;
        }

        public bool RemoveDepense(Depense d)
        {
            this.mesDepenses.Remove(d);
            return true;
        }

       
        public int CompareTo(object? obj)
        {           
                return Math.Abs(this.balance).CompareTo(Math.Abs(((Participant)obj).balance)) *(-1);
        }
        /*  public override bool Equals(Object obj)
 {
     //Check for null and compare run-time types.
     if ((obj == null) || !this.GetType().Equals(obj.GetType()))
     {
         return false;
     }
     else
     {
         Participant p = (Participant)obj;
         return (nom == p.nom);
     }
 }*/
    }
}
