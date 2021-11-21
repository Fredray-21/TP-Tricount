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
            MAJLBequilibreParticipant();

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
                "Delete",
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


        public void MAJLBequilibreParticipant()
        {
            LBequilibreParticipant.Items.Clear();
            List<Participant> lesParticicpants = LeTricount.GetToutParticipantPARtricount(LeTricount.SessionIdTricount);
            lesParticicpants.Sort(new TriBalance());
            foreach (Participant p in LeTricount.GetToutParticipantPARtricount(LeTricount.SessionIdTricount))
            {
                if (p.GetBalance() >= 0)
                {
                    LBequilibreParticipant.Items.Add(p.GetNom() + "|" + p.GetBalance().ToString());
                }
                else
                {
                    LBequilibreParticipant.Items.Add(p.GetBalance().ToString() + "|" + p.GetNom());

                }
            }
        }

        private void DataGVdepense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGVdepense.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sur?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<Depense> listDepense = LeTricount.GetToutDepensePARtricount(LeTricount.SessionIdTricount);

                    foreach (Depense d in listDepense)
                    {
                        List<Participant> listPConcerner = LeTricount.GetPconcernePARtricount(d); // ici on set la list des concerner dans la depense
                        foreach (Participant Participant in listPConcerner) // ici on set la balance des concerner
                        {
                            Participant.SetBalanceParDefault(LeTricount.GetBalance(Participant));
                        }
                        d.SetPConcernes(listPConcerner);

                    }
                    LeTricount.SuprimeDepense(listDepense[e.RowIndex]);
                    MessageBox.Show("La Dépense à bien été supprimer ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MAJlisteDepence();
                    MAJLBequilibreParticipant();

                }
            }
        }
    }
}