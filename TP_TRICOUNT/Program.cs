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

            List<Participant> list = new List<Participant>();
            Participant p1 = new Participant("p1");
            Participant p2 = new Participant("p2");
            Participant p3 = new Participant("p3");
            Participant p4 = new Participant("p4");
            Participant p5 = new Participant("p5");
            Participant p6 = new Participant("p6");

            p2.SetBalance(30);
            p1.SetBalance(4);
            p4.SetBalance(-50);
            p5.SetBalance(-5);
            p6.SetBalance(-20);

            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            list.Add(p5);
            list.Add(p6);

            list.Sort();
            

           MessageBox.Show(list[0].GetBalance().ToString()+"\n"+ list[1].GetBalance().ToString() + "\n"+ list[2].GetBalance().ToString() + "\n" + list[3].GetBalance().ToString() + "\n" + list[4].GetBalance().ToString() + "\n" + list[5].GetBalance().ToString() + "\n");

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