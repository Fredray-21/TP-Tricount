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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LeTricount.Connexion();
            MAJlisteBTricount();

        }
        private void MAJlisteBTricount()
        {
            LBtricount.Items.Clear();
            LBtricount.Items.AddRange(LeTricount.GetToutLesTricount().ToArray());
        }
        private void btnAddTricount_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBNameTricount.Text))
            {
                MessageBox.Show("Veuiller rentré un Nom Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                object LastID = LeTricount.AjouterTriCount(txtBNameTricount.Text);
                if (LastID != null)
                {
                    Tricount t = new Tricount(Convert.ToInt32(LastID), txtBNameTricount.Text);
                    LBtricount.Items.Add(t);
                    MessageBox.Show($"L'ajout à bien été effectue le TriCount a pour N°{LastID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("L'ajout n'a pas été effectue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSelectTricount_Click(object sender, EventArgs e)
        {
            Tricount t = (Tricount)LBtricount.SelectedItem;
            if (t == null)
            {
                MessageBox.Show("Veuillez selectionée un Tricount", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LeTricount.SessionIdTricount = t;
                this.Hide();
                var form2 = new Form2();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }

        }

        private void btnDeleteTricount_Click(object sender, EventArgs e)
        {
            Tricount t = (Tricount)LBtricount.SelectedItem;
            if(t == null)
            {
                MessageBox.Show("Veuiller selectioné un TriCount a suprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Voulez-vous supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    LeTricount.DeleteTricount(t);
                    MAJlisteBTricount();
                    MessageBox.Show("Le Tricount à bien été supprimer ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
