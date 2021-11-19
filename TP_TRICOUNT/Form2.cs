namespace TP_TRICOUNT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MAJlblSession();
            MAJlisteBParticipant();

        }
        private void MAJlisteBParticipant()
        {
            lbListParticipants.Items.Clear();
            lbListParticipants.Items.AddRange(LeTricount.GetToutParticipantPARtricount(LeTricount.SessionIdTricount).ToArray());
        }

        public void MAJlblSession()
        {
            Tricount t = LeTricount.SessionIdTricount;
            lblLeTricountActuel.Text = $"Tricount Actuel : {t.GetNom()}";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*Participant payeur = new Participant("jules");

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
            */
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBNomParticipant.Text))
            {
                MessageBox.Show("Veuiller rentré un Nom Valide");
            }
            else
            {
                lbListParticipants.Items.Add(txtBNomParticipant.Text);
                Participant p = new Participant(txtBNomParticipant.Text, LeTricount.SessionIdTricount.GetID());
                object LastID = LeTricount.AjouterParticipant(p);
                if (LastID != null)
                {
                    txtBNomParticipant.Clear();
                    MessageBox.Show($"L'ajout à bien été effectue le Participant a pour N°{LastID}");

                }
                else
                {
                    MessageBox.Show("L'ajout n'a pas été effectue");
                }
            }
        }

        private void btnAddDepense_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form3 = new Form3();
            form3.Show();

            // form2.Closed += (s, args) => this.Close();
        }
    }
}