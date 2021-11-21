namespace TP_TRICOUNT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MAJlblSession();
            MAJlisteBParticipant();
            MAJlisteDepence();
            MAJmontantTotal();
            this.DataGVdepense.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

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

        public void MAJmontantTotal()
        {
            decimal montant = LeTricount.GetTotalDepenses(LeTricount.SessionIdTricount);
            if (montant == 0)
            {
                lblTotalDep.Text = "00,00 €";

            }
            else
            {
                lblTotalDep.Text = montant.ToString() + " €";
            }
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

        public void MAJlisteDepence()
        {
            DataGVdepense.Rows.Clear();
            Tricount t = LeTricount.SessionIdTricount;
            List<Depense> listDepense = LeTricount.GetToutDepensePARtricount(t);


            foreach (Depense d in listDepense)
            {
                List<Participant> listPconcerner = LeTricount.GetPconcernePARtricount(d);
                string txt = "";

                foreach (Participant p in listPconcerner)
                {
                    txt = txt + p.GetNom() + " / ";
                }


                string[] row;
                row = new string[]
                {
                d.GetID().ToString(),
                d.GetTitre().ToString(),
                d.GetPayeur().GetNom().ToString(),
                d.GetDate().ToString("dd-MM-yyyy"),
                d.GetMontant().ToString(),
               txt
                    };
                DataGVdepense.Rows.Add(row);
            }
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBNomParticipant.Text))
            {
                MessageBox.Show("Veuiller rentré un Nom Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Participant p = new Participant(txtBNomParticipant.Text, LeTricount.SessionIdTricount.GetID());

                object LastID = LeTricount.AjouterParticipant(p);
                if (LastID != null)
                {
                    txtBNomParticipant.Clear();
                    MessageBox.Show($"L'ajout à bien été effectue le Participant a pour N°{LastID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MAJlisteBParticipant();
                }
                else
                {
                    MessageBox.Show("L'ajout n'a pas été effectue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddDepense_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Show();
            form3.Closed += (s, args) => this.Close();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Show();
            form1.Closed += (s, args) => this.Close();
        }

        private void btnSuprParticipant_Click(object sender, EventArgs e)
        {
            Participant p = (Participant)lbListParticipants.SelectedItem;
            if (p == null)
            {
                MessageBox.Show("Veuiller Selectioné un Participante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Voulez-vous supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (LeTricount.DeleteParticipant(p))
                    {
                        MessageBox.Show("Le Participant à bien été supprimer ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MAJlisteBParticipant();
                    }
                    else
                    {
                        MessageBox.Show("Le Participant n'a pas été Supprimer car il est impliquer dans au moin une dépense", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }
    }
}