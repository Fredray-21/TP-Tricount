using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_TRICOUNT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            MAJlisteBParticipant();
            CheckedItems();
        }

        private void MAJlisteBParticipant()
        {
            lbListParticipant.Items.Clear();
            checkBoxPourQui.Items.Clear();
            lbListParticipant.Items.AddRange(LeTricount.GetToutParticipantPARtricount(LeTricount.SessionIdTricount).ToArray());
            checkBoxPourQui.Items.AddRange(LeTricount.GetToutParticipantPARtricount(LeTricount.SessionIdTricount).ToArray());
        }

        private void CheckedItems()
        {
            for (int i = 0; i < checkBoxPourQui.Items.Count; i++)
            {
                checkBoxPourQui.SetItemChecked(i, true);
            }
        }

        private void btnAddDep_Click(object sender, EventArgs e)
        {
            Participant payeur = (Participant)lbListParticipant.SelectedItem;
            if (payeur == null)
            {
                MessageBox.Show("Veuillez selectionée un Payeur", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtBTitre.Text))
            {
                MessageBox.Show("Veuiller rentré un Titre Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtBMontant.Text))
            {
                MessageBox.Show("Veuiller rentré un Montant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                List<Participant> pConcerne = new List<Participant>();
                foreach (Participant itemChecked in checkBoxPourQui.CheckedItems)
                {
                    pConcerne.Add(itemChecked);
                }
                if (pConcerne.Count <= 0)
                {
                    MessageBox.Show("Veuillez selectionée les Concernés", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                bool convertOK = float.TryParse(txtBMontant.Text.Replace('.', ','), out float Montant);
                if (convertOK)
                {
                    Depense d = new Depense(txtBTitre.Text, Montant, DTPdate.Value, payeur, pConcerne);
                    object LastID = LeTricount.AjouterDepense(d);
                    if (LastID != null)
                    {
                        int IdDepense = Convert.ToInt32(LastID);
                        float montantUnitaire = 0;


                        float balance = LeTricount.GetBalance(payeur); // set balance du payeur
                        payeur.SetBalanceParDefault(balance);
                        float MontantPayeur = Montant + montantUnitaire;
                        payeur.AddToBalance(MontantPayeur); // on ajoute le prix total à la balance du payeur
                        LeTricount.AjouterBalance(payeur);
                        // ici le payeur a été crédité de ça balance


                        foreach (Participant ParticipantConcerne in pConcerne) // on ajoute les négatif
                        {
                            LeTricount.AjouterConcerner(ParticipantConcerne, IdDepense);
                            balance = LeTricount.GetBalance(ParticipantConcerne);
                            if (ParticipantConcerne.CompareTo(payeur) != 0) // si pas payeur on set ça balance == a celle de la BDD
                            {
                                ParticipantConcerne.SetBalanceParDefault(balance);
                            }
                          

                            if (pConcerne.Count() > 1)
                            {
                                if (ParticipantConcerne.CompareTo(payeur) == 0) // si c'est le payeur 
                                {
                                    montantUnitaire = Montant - Montant / pConcerne.Count(); // Montant Total - Montant par personne à payer
                                    ParticipantConcerne.AddToBalance(montantUnitaire);
                                    LeTricount.AjouterBalance(ParticipantConcerne);
                                }
                                else
                                {
                                    montantUnitaire = Montant / pConcerne.Count() * (-1); // Montant par personne à payer
                                    ParticipantConcerne.AddToBalance(montantUnitaire);
                                    LeTricount.AjouterBalance(ParticipantConcerne);
                                    
                                }
                            }
                            else
                            {
                                float MontantConcerne = Montant*(-1); // ici on retire le total du Montant ajouté + haut car il est seul concerné

                                ParticipantConcerne.AddToBalance(MontantConcerne);
                                LeTricount.AjouterBalance(ParticipantConcerne);
                            }
                        }

                        this.Hide();
                        var form2 = new Form2();
                        form2.Show();
                        form2.Closed += (s, args) => this.Close();
                        MessageBox.Show($"L'ajout de la Dépense à bien été effectue avec pour N°{LastID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("L'ajout n'a pas été effectue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Show();
            form2.Closed += (s, args) => this.Close();
        }
    }
}
