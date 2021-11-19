namespace TP_TRICOUNT
{
    public class Tricount
    {
        private int ID;
        private String Nom;
        public Tricount(int ID, String Name)
        {
            this.ID = ID;
            this.Nom = Name;
        }
        public int GetID()
        {
            return this.ID;
        }
        public String GetNom()
        {
            return this.Nom;
        }

        public override string ToString()
        {
            return $"{this.ID} > {this.Nom}";
        }
    }
}