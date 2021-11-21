using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_TRICOUNT
{
    public class Participant : IComparable
    {
        private List<Depense> mesDepenses;

        private int ID;
        private String nom;
        private float balance;
        private float monCoutTotal;
        private float remboursement;
        private int ID_tricount;

        public Participant(String Nom, int Id_Tricount)
        {
            this.ID = 0;
            this.nom = Nom;
            this.balance = 0;
            this.monCoutTotal = 0;
            this.remboursement = 0;
            this.ID_tricount = Id_Tricount;
            this.mesDepenses = new List<Depense>();
        }

        public Participant(int Id,String Nom, int Id_Tricount)
        {
            this.ID = Id;
            this.nom = Nom;
            this.balance = 0;
            this.monCoutTotal = 0;
            this.remboursement = 0;
            this.ID_tricount = Id_Tricount;
            this.mesDepenses = new List<Depense>();
        }

        public Participant(int Id, String Nom,float Balance, float MonCoutTotal, int ID_tricount)
        {
            this.ID = Id;
            this.nom = Nom;
            this.balance = Balance;
            this.monCoutTotal = MonCoutTotal;
            this.ID_tricount = ID_tricount;
            this.mesDepenses = new List<Depense>();

        }

        public int GetID()
        {
           return this.ID;
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
            this.balance = Balance;
            return true;
        }
        public bool AddToBalance(float Balance)
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
            // return Math.Abs(this.balance).CompareTo(Math.Abs(((Participant)obj).balance)) *(-1);
            return this.ID.CompareTo(((Participant)obj).ID);
        }

        public int GetTricout()
        {
            return this.ID_tricount;
        }

        public override string ToString()
        {
            return $"{this.nom} / {this.balance}";
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
