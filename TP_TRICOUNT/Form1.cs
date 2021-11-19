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
                MessageBox.Show("Veuiller rentré un Nom Valide");
            }
            else
            {
                LBtricount.Items.Add(txtBNameTricount.Text);
                object LastID = LeTricount.AjouterTriCount(txtBNameTricount.Text);
                if (LastID != null)
                {
                    MessageBox.Show($"L'ajout à bien été effectue le TriCount a pour N°{LastID}");
                }
                else
                {
                    MessageBox.Show("L'ajout n'a pas été effectue");
                }
            }

        }

        private void btnSelectTricount_Click(object sender, EventArgs e)
        {
            Tricount t = (Tricount)LBtricount.SelectedItem;
            if(t == null)
            {
                MessageBox.Show("Veuillez selectionée un Tricount");
            }
            LeTricount.SessionIdTricount = t;

            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
