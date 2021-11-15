namespace TP_TRICOUNT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            /* List<Participant> participants = new List<Participant>();
             Participant p1 = new Participant("Hubert");
             Participant p2 = new Participant("Huberts");
            Participant p3 = new Participant("Hugo");
            participants.Add(p1);
             participants.Add(p2);
             //MessageBox.Show(participants.IndexOf(p2).ToString());
            
            List<Depense> depense = new List<Depense>();
            Depense d1 = new Depense("Vente", 500, DateTime.Now, p3, participants);
            Depense d2 = new Depense("Vente", 500, DateTime.Now, p3, participants);
            depense.Add(d1);
            depense.Add(d2);
            MessageBox.Show(depense.IndexOf(d2).ToString());*/
        }
    }
}