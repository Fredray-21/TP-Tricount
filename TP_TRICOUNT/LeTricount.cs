using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
namespace TP_TRICOUNT
{
    public static class LeTricount
    {

        private static List<Depense> lesDepenses = new List<Depense>();
        private static List<Participant> lesParticipants = new List<Participant>();
        public static Tricount SessionIdTricount = null;

        // Note
        // ExecuteNonQuery() -> int  uptade/insert/delete 
        // ExecuteReader() -> table  Select
        // ExecuteScalar() -> objet  Si on veux resevoir un object

        private static String cs = @"server=localhost;userid=root;password=;database=tp_tricount";
        private static MySqlConnection conn = null;

        public static bool Connexion()
        {
            conn = new MySqlConnection(cs);
            conn.Open();
            return (conn.State == ConnectionState.Open);
        }


        public static object AjouterTriCount(String NameTricount) // btn ajouter compte
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqI = $"INSERT INTO tricount (id,nom) VALUES(null,'{NameTricount}')";
            objCmd.CommandText = reqI;
            int nbMaj = objCmd.ExecuteNonQuery();


            if (nbMaj == 1)
            {
                String reqNumId = "SELECT LAST_INSERT_ID()";
                objCmd.CommandText = reqNumId;
                object numPers = objCmd.ExecuteScalar();

                return numPers;
            }
            else
            {
                return -1;
            }

        }

        public static List<Tricount> GetToutLesTricount() // btn afficher tout les comptes
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            MySqlDataReader rdr;
            List<Tricount> lesTricount = new List<Tricount>();

            String reqCount = "SELECT * FROM tricount";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();

            while (rdr.Read())
            {
                Tricount t = new Tricount((int)rdr["id"], (string)rdr["nom"]);
                lesTricount.Add(t);
            }
            rdr.Close();
            return lesTricount;
        }

        public static bool DeleteTricount(Tricount t)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqI = $"DELETE FROM tricount WHERE id = '{t.GetID()}'";
            objCmd.CommandText = reqI;
            int nbMaj = objCmd.ExecuteNonQuery();
            return nbMaj == 1;

        }

        public static List<Participant> GetToutParticipantPARtricount(Tricount t) // btn afficher tout les comptes
        {
            lesParticipants.Clear();
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            MySqlDataReader rdr;

            String reqCount = $"SELECT * FROM membre WHERE id_tricount = {t.GetID()}";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();

            while (rdr.Read())
            {
                Participant p = new Participant((int)rdr["id"], (string)rdr["nom"], (float)rdr["balance"], (float)rdr["monCoutTotal"], (int)rdr["id_tricount"]);
                lesParticipants.Add(p);
            }
            rdr.Close();
            return lesParticipants;
        }

       

        public static List<Depense> GetToutDepensePARtricount(Tricount t)
        {
            lesDepenses.Clear();
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            MySqlDataReader rdr;
            List<Participant> lesConcerne = new List<Participant>();
            DateTime date = new DateTime();
            String reqCount = $"SELECT * FROM depense INNER JOIN membre ON depense.id_payeur = membre.id where id_tricount = {t.GetID()}";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();

            while (rdr.Read())
            {
                Participant payeur = new Participant((int)rdr["id"], (string)rdr["nom"], (float)rdr["balance"], (float)rdr["monCoutTotal"], (int)rdr["id_tricount"]);
                date = (DateTime)rdr["date"];
                Depense d = new Depense((int)rdr["idDep"], (string)rdr["intutile"], (float)rdr["montant"], date, payeur, lesConcerne);
                lesDepenses.Add(d);
            }
            rdr.Close();
            return lesDepenses;
        }

        public static List<Participant> GetPconcernePARtricount(Depense d)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            MySqlDataReader rdr;
            List<Participant> lesConcerne = new List<Participant>();
            String reqCount = $"SELECT id,nom,balance,monCoutTotal,id_tricount FROM depense INNER JOIN concerner ON depense.idDep = concerner.id_depense INNER JOIN membre ON membre.id = concerner.id_concerne where idDep = {d.GetID()}";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();

            while (rdr.Read())
            {
                Participant p = new Participant((int)rdr["id"], (string)rdr["nom"], (float)rdr["balance"], (float)rdr["monCoutTotal"], (int)rdr["id_tricount"]);

                lesConcerne.Add(p);
            }
            rdr.Close();
            return lesConcerne;
        }

        public static object AjouterParticipant(Participant p)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();


            String reqI = $"INSERT INTO membre (id,nom,balance,monCoutTotal,id_tricount) VALUES(null,'{p.GetNom()}',{p.GetBalance()},{p.GetCoutTotal()},{p.GetTricout()})";
            objCmd.CommandText = reqI;
            int nbMaj = objCmd.ExecuteNonQuery();
            if (nbMaj == 1)
            {
                String reqNumId = "SELECT LAST_INSERT_ID()";
                objCmd.CommandText = reqNumId;
                object numPers = objCmd.ExecuteScalar();

                return numPers;
            }
            else
            {
                return -1;
            }

        }

        public static bool DeleteParticipant(Participant p)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            String reqI = $"DELETE FROM membre WHERE id = '{p.GetID()}' and NOT EXISTS (SELECT id_concerne FROM concerner WHERE id_concerne = {p.GetID()})";
            objCmd.CommandText = reqI;
            int nbMaj = objCmd.ExecuteNonQuery();
            return nbMaj == 1;

        }

        public static object AjouterDepense(Depense d)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            String reqI = $"INSERT INTO depense (idDep,intutile,montant,date,id_payeur) VALUES(null,'{d.GetTitre()}','{d.GetMontant().ToString().Replace(',', '.')}','{d.GetDate().ToString("yyyy-MM-dd")}','{d.GetPayeur().GetID()}')";
            objCmd.CommandText = reqI;
            int nbMaj = objCmd.ExecuteNonQuery();
            if (nbMaj == 1)
            {
                String reqNumId = "SELECT LAST_INSERT_ID()";
                objCmd.CommandText = reqNumId;
                object numDep = objCmd.ExecuteScalar();

                return numDep;
            }
            else
            {
                return -1;
            }

        }

        public static bool AjouterBalance(Participant p)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            String reqI = $"UPDATE membre SET balance = {p.GetBalance().ToString().Replace(',', '.')} WHERE id = {p.GetID()}";
            objCmd.CommandText = reqI;
            int nbMaj = objCmd.ExecuteNonQuery();
            return nbMaj == 1;
        }
        public static float GetBalance(Participant p)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            MySqlDataReader rdr;
            float Balance = 0;
            String reqCount = $"SELECT balance FROM membre WHERE id ={p.GetID()}";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();

            if (rdr.Read())
            {
                Balance = (float)rdr["balance"];

            }
            rdr.Close();
            return Balance;
        }

        public static bool AjouterConcerner(Participant p, int IdDepense)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            String reqI = $"INSERT INTO concerner (id_concerne,id_depense) VALUES({p.GetID()},'{IdDepense}')";
            objCmd.CommandText = reqI;
            int nbMaj = objCmd.ExecuteNonQuery();

            return nbMaj == 1;

        }

        public static decimal GetTotalDepenses(Tricount t)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            MySqlDataReader rdr;
            decimal Total = 0;
            String reqCount = $"SELECT DISTINCT(idDep), montant FROM depense INNER JOIN concerner ON depense.idDep = concerner.id_depense INNER JOIN membre ON membre.id = concerner.id_concerne where  id_tricount = {t.GetID()}";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();

            while (rdr.Read())
            {
                decimal.TryParse(((float)rdr["montant"]).ToString(), out decimal Montant);
                Total += Montant;

            }
            rdr.Close();
            return Total;
        }

        private static bool SuprimeDepense(Depense d)
        {
            lesDepenses.Remove(d);
            return true;

        }
    }
}
