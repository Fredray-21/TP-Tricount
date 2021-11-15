namespace TP_TRICOUNT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Participant payeur = new Participant("jules");

            Participant p1 = new Participant("p1");
            Participant p2 = new Participant("p2");
            Participant p3 = new Participant("p3");
            Participant p4 = new Participant("p4");

            List<Participant> participants = new List<Participant>();
            participants.Add(p1);
            participants.Add(p2);
            participants.Add(p3);
            participants.Add(p4);
            Depense d = new Depense("test1", 333, DateTime.Now,payeur, participants);

            string[] row;
            row = new string[]
            {
                d.GetTitre().ToString(),
                d.GetPayeur().GetNom().ToString(),
                d.GetDate().ToString(),
                d.GetMontant().ToString()
                };
            DataGVdepense.Rows.Add(row);

        }
    }
}