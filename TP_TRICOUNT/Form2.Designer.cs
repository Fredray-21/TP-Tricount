namespace TP_TRICOUNT
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing); 
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDepense = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddParticipant = new System.Windows.Forms.Button();
            this.txtBNomParticipant = new System.Windows.Forms.TextBox();
            this.lbListParticipants = new System.Windows.Forms.ListBox();
            this.btnAddDepense = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGVdepense = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalDep = new System.Windows.Forms.Label();
            this.lblCoutTotal = new System.Windows.Forms.Label();
            this.titleLBLtotalDepense = new System.Windows.Forms.Label();
            this.titleLBLcoutTotal = new System.Windows.Forms.Label();
            this.tabEquilibres = new System.Windows.Forms.TabPage();
            this.lblLeTricountActuel = new System.Windows.Forms.Label();
            this.depenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabDepense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVdepense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDepense);
            this.tabControl.Controls.Add(this.tabEquilibres);
            this.tabControl.Location = new System.Drawing.Point(12, 21);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(928, 488);
            this.tabControl.TabIndex = 0;
            // 
            // tabDepense
            // 
            this.tabDepense.Controls.Add(this.label3);
            this.tabDepense.Controls.Add(this.btnAddParticipant);
            this.tabDepense.Controls.Add(this.txtBNomParticipant);
            this.tabDepense.Controls.Add(this.lbListParticipants);
            this.tabDepense.Controls.Add(this.btnAddDepense);
            this.tabDepense.Controls.Add(this.label2);
            this.tabDepense.Controls.Add(this.label1);
            this.tabDepense.Controls.Add(this.DataGVdepense);
            this.tabDepense.Controls.Add(this.lblTotalDep);
            this.tabDepense.Controls.Add(this.lblCoutTotal);
            this.tabDepense.Controls.Add(this.titleLBLtotalDepense);
            this.tabDepense.Controls.Add(this.titleLBLcoutTotal);
            this.tabDepense.Location = new System.Drawing.Point(4, 26);
            this.tabDepense.Name = "tabDepense";
            this.tabDepense.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepense.Size = new System.Drawing.Size(920, 458);
            this.tabDepense.TabIndex = 0;
            this.tabDepense.Text = "DÉPENSES";
            this.tabDepense.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(723, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Participants :";
            // 
            // btnAddParticipant
            // 
            this.btnAddParticipant.Location = new System.Drawing.Point(727, 238);
            this.btnAddParticipant.Name = "btnAddParticipant";
            this.btnAddParticipant.Size = new System.Drawing.Size(142, 42);
            this.btnAddParticipant.TabIndex = 12;
            this.btnAddParticipant.Text = "Ajouter le Participant";
            this.btnAddParticipant.UseVisualStyleBackColor = true;
            this.btnAddParticipant.Click += new System.EventHandler(this.btnAddParticipant_Click);
            // 
            // txtBNomParticipant
            // 
            this.txtBNomParticipant.Location = new System.Drawing.Point(727, 207);
            this.txtBNomParticipant.Name = "txtBNomParticipant";
            this.txtBNomParticipant.Size = new System.Drawing.Size(187, 25);
            this.txtBNomParticipant.TabIndex = 11;
            // 
            // lbListParticipants
            // 
            this.lbListParticipants.FormattingEnabled = true;
            this.lbListParticipants.ItemHeight = 17;
            this.lbListParticipants.Location = new System.Drawing.Point(727, 28);
            this.lbListParticipants.Name = "lbListParticipants";
            this.lbListParticipants.Size = new System.Drawing.Size(187, 174);
            this.lbListParticipants.TabIndex = 10;
            // 
            // btnAddDepense
            // 
            this.btnAddDepense.Location = new System.Drawing.Point(346, 338);
            this.btnAddDepense.Name = "btnAddDepense";
            this.btnAddDepense.Size = new System.Drawing.Size(175, 52);
            this.btnAddDepense.TabIndex = 9;
            this.btnAddDepense.Text = "Ajouter une Dépenses";
            this.btnAddDepense.UseVisualStyleBackColor = true;
            this.btnAddDepense.Click += new System.EventHandler(this.btnAddDepense_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(214, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "€";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "€";
            // 
            // DataGVdepense
            // 
            this.DataGVdepense.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DataGVdepense.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGVdepense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVdepense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.payeur,
            this.date,
            this.montant});
            this.DataGVdepense.Location = new System.Drawing.Point(10, 6);
            this.DataGVdepense.MultiSelect = false;
            this.DataGVdepense.Name = "DataGVdepense";
            this.DataGVdepense.RowHeadersWidth = 43;
            this.DataGVdepense.RowTemplate.Height = 27;
            this.DataGVdepense.Size = new System.Drawing.Size(511, 313);
            this.DataGVdepense.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 105;
            // 
            // payeur
            // 
            this.payeur.HeaderText = "Payer par";
            this.payeur.Name = "payeur";
            this.payeur.Width = 105;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 105;
            // 
            // montant
            // 
            this.montant.HeaderText = "Montant";
            this.montant.Name = "montant";
            this.montant.Width = 105;
            // 
            // lblTotalDep
            // 
            this.lblTotalDep.AutoSize = true;
            this.lblTotalDep.Font = new System.Drawing.Font("Segoe UI", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDep.Location = new System.Drawing.Point(164, 371);
            this.lblTotalDep.Name = "lblTotalDep";
            this.lblTotalDep.Size = new System.Drawing.Size(44, 19);
            this.lblTotalDep.TabIndex = 4;
            this.lblTotalDep.Text = "00,00";
            // 
            // lblCoutTotal
            // 
            this.lblCoutTotal.AutoSize = true;
            this.lblCoutTotal.Font = new System.Drawing.Font("Segoe UI", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCoutTotal.Location = new System.Drawing.Point(10, 371);
            this.lblCoutTotal.Name = "lblCoutTotal";
            this.lblCoutTotal.Size = new System.Drawing.Size(44, 19);
            this.lblCoutTotal.TabIndex = 3;
            this.lblCoutTotal.Text = "00,00";
            // 
            // titleLBLtotalDepense
            // 
            this.titleLBLtotalDepense.AutoSize = true;
            this.titleLBLtotalDepense.Font = new System.Drawing.Font("Segoe UI", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLBLtotalDepense.Location = new System.Drawing.Point(164, 339);
            this.titleLBLtotalDepense.Name = "titleLBLtotalDepense";
            this.titleLBLtotalDepense.Size = new System.Drawing.Size(124, 23);
            this.titleLBLtotalDepense.TabIndex = 2;
            this.titleLBLtotalDepense.Text = "Total Dépenses";
            // 
            // titleLBLcoutTotal
            // 
            this.titleLBLcoutTotal.AutoSize = true;
            this.titleLBLcoutTotal.Font = new System.Drawing.Font("Segoe UI", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLBLcoutTotal.Location = new System.Drawing.Point(10, 339);
            this.titleLBLcoutTotal.Name = "titleLBLcoutTotal";
            this.titleLBLcoutTotal.Size = new System.Drawing.Size(128, 23);
            this.titleLBLcoutTotal.TabIndex = 1;
            this.titleLBLcoutTotal.Text = "Mon Coût Total";
            // 
            // tabEquilibres
            // 
            this.tabEquilibres.Location = new System.Drawing.Point(4, 26);
            this.tabEquilibres.Name = "tabEquilibres";
            this.tabEquilibres.Padding = new System.Windows.Forms.Padding(3);
            this.tabEquilibres.Size = new System.Drawing.Size(920, 458);
            this.tabEquilibres.TabIndex = 1;
            this.tabEquilibres.Text = "ÉQUILIBRES";
            this.tabEquilibres.UseVisualStyleBackColor = true;
            // 
            // lblLeTricountActuel
            // 
            this.lblLeTricountActuel.AutoSize = true;
            this.lblLeTricountActuel.Location = new System.Drawing.Point(660, 9);
            this.lblLeTricountActuel.Name = "lblLeTricountActuel";
            this.lblLeTricountActuel.Size = new System.Drawing.Size(0, 17);
            this.lblLeTricountActuel.TabIndex = 8;
            // 
            // depenseBindingSource
            // 
            this.depenseBindingSource.DataSource = typeof(TP_TRICOUNT.Depense);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 105;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 105;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 105;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 105;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 105;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 521);
            this.Controls.Add(this.lblLeTricountActuel);
            this.Controls.Add(this.tabControl);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabDepense.ResumeLayout(false);
            this.tabDepense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVdepense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depenseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabDepense;
        private TabPage tabEquilibres;
        private Label titleLBLcoutTotal;
        private Label lblTotalDep;
        private Label lblCoutTotal;
        private Label titleLBLtotalDepense;
        private DataGridView DataGVdepense;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn payeur;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn montant;
        private Label label2;
        private Label label1;
        private BindingSource depenseBindingSource;
        private Label lblLeTricountActuel;
        private Button btnAddDepense;
        private ListBox lbListParticipants;
        private Button btnAddParticipant;
        private TextBox txtBNomParticipant;
        private Label label3;
    }
}