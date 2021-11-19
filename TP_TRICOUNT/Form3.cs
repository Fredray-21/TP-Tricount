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
                MessageBox.Show("Veuillez selectionée un Payeur");
            }
            else if (String.IsNullOrWhiteSpace(txtBTitre.Text))
            {
                MessageBox.Show("Veuiller rentré un Titre Valide");
            }
            else if (String.IsNullOrWhiteSpace(txtBMontant.Text))
            {
                MessageBox.Show("Veuiller rentré un Montant Valide");

            }
            else
            {
                List<Participant> pConcerne = new List<Participant>();
                foreach (Participant itemChecked in checkBoxPourQui.CheckedItems)
                {
                    pConcerne.Add(itemChecked);
                }

                bool convertOK = float.TryParse(txtBMontant.Text, out float Montant);
                if (convertOK)
                {
                    Depense d = new Depense(txtBTitre.Text, Montant, DTPdate.Value, payeur, pConcerne);
                    object LastID = LeTricount.AjouterDepense(d);
                    if (LastID != null)
                    {
                        int IdDepense = Convert.ToInt32(LastID);

                        foreach (Participant ParticipantConcere in pConcerne)
                        {
                            LeTricount.AjouterConcerner(ParticipantConcere.GetID(),IdDepense);
                        }
                        this.Close();
                        MessageBox.Show($"L'ajout de la Dépense à bien été effectue avec pour N°{LastID}");

                    }
                    else
                    {
                        MessageBox.Show("L'ajout n'a pas été effectue");
                    }
                }

            }
        }
    }
}
