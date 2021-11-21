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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDepense = new System.Windows.Forms.TabPage();
            this.btnSuprParticipant = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddParticipant = new System.Windows.Forms.Button();
            this.txtBNomParticipant = new System.Windows.Forms.TextBox();
            this.lbListParticipants = new System.Windows.Forms.ListBox();
            this.btnAddDepense = new System.Windows.Forms.Button();
            this.DataGVdepense = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concerner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalDep = new System.Windows.Forms.Label();
            this.lblCoutTotal = new System.Windows.Forms.Label();
            this.titleLBLtotalDepense = new System.Windows.Forms.Label();
            this.titleLBLcoutTotal = new System.Windows.Forms.Label();
            this.tabEquilibres = new System.Windows.Forms.TabPage();
            this.LBequilibreParticipant = new System.Windows.Forms.ListBox();
            this.lblLeTricountActuel = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabDepense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVdepense)).BeginInit();
            this.tabEquilibres.SuspendLayout();
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
            this.tabDepense.Controls.Add(this.btnSuprParticipant);
            this.tabDepense.Controls.Add(this.btnRetour);
            this.tabDepense.Controls.Add(this.label3);
            this.tabDepense.Controls.Add(this.btnAddParticipant);
            this.tabDepense.Controls.Add(this.txtBNomParticipant);
            this.tabDepense.Controls.Add(this.lbListParticipants);
            this.tabDepense.Controls.Add(this.btnAddDepense);
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
            // btnSuprParticipant
            // 
            this.btnSuprParticipant.Location = new System.Drawing.Point(727, 286);
            this.btnSuprParticipant.Name = "btnSuprParticipant";
            this.btnSuprParticipant.Size = new System.Drawing.Size(142, 42);
            this.btnSuprParticipant.TabIndex = 15;
            this.btnSuprParticipant.Text = "Supprimer le Participant";
            this.btnSuprParticipant.UseVisualStyleBackColor = true;
            this.btnSuprParticipant.Click += new System.EventHandler(this.btnSuprParticipant_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Montserrat", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRetour.Location = new System.Drawing.Point(825, 408);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(89, 44);
            this.btnRetour.TabIndex = 14;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
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
            this.btnAddDepense.Font = new System.Drawing.Font("Montserrat", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddDepense.Location = new System.Drawing.Point(346, 338);
            this.btnAddDepense.Name = "btnAddDepense";
            this.btnAddDepense.Size = new System.Drawing.Size(208, 52);
            this.btnAddDepense.TabIndex = 9;
            this.btnAddDepense.Text = "Ajouter une Dépenses";
            this.btnAddDepense.UseVisualStyleBackColor = true;
            this.btnAddDepense.Click += new System.EventHandler(this.btnAddDepense_Click);
            // 
            // DataGVdepense
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGVdepense.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGVdepense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGVdepense.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGVdepense.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGVdepense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVdepense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn5,
            this.payeur,
            this.date,
            this.montant,
            this.concerner});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.267326F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGVdepense.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGVdepense.Location = new System.Drawing.Point(10, 6);
            this.DataGVdepense.MultiSelect = false;
            this.DataGVdepense.Name = "DataGVdepense";
            this.DataGVdepense.RowHeadersWidth = 43;
            this.DataGVdepense.RowTemplate.Height = 27;
            this.DataGVdepense.Size = new System.Drawing.Size(707, 313);
            this.DataGVdepense.TabIndex = 5;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.FillWeight = 58F;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.FillWeight = 110.2941F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // payeur
            // 
            this.payeur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payeur.DefaultCellStyle = dataGridViewCellStyle4;
            this.payeur.FillWeight = 110.2941F;
            this.payeur.HeaderText = "Payer par";
            this.payeur.Name = "payeur";
            this.payeur.ReadOnly = true;
            this.payeur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.date.DefaultCellStyle = dataGridViewCellStyle5;
            this.date.FillWeight = 110.2941F;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // montant
            // 
            this.montant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.montant.DefaultCellStyle = dataGridViewCellStyle6;
            this.montant.FillWeight = 115F;
            this.montant.HeaderText = "Montant (€)";
            this.montant.Name = "montant";
            this.montant.ReadOnly = true;
            this.montant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // concerner
            // 
            this.concerner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.concerner.DefaultCellStyle = dataGridViewCellStyle7;
            this.concerner.HeaderText = "Pour";
            this.concerner.Name = "concerner";
            this.concerner.ReadOnly = true;
            this.concerner.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.concerner.Width = 230;
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
            this.tabEquilibres.Controls.Add(this.LBequilibreParticipant);
            this.tabEquilibres.Location = new System.Drawing.Point(4, 26);
            this.tabEquilibres.Name = "tabEquilibres";
            this.tabEquilibres.Padding = new System.Windows.Forms.Padding(3);
            this.tabEquilibres.Size = new System.Drawing.Size(920, 458);
            this.tabEquilibres.TabIndex = 1;
            this.tabEquilibres.Text = "ÉQUILIBRES";
            this.tabEquilibres.UseVisualStyleBackColor = true;
            // 
            // LBequilibreParticipant
            // 
            this.LBequilibreParticipant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBequilibreParticipant.FormattingEnabled = true;
            this.LBequilibreParticipant.ItemHeight = 17;
            this.LBequilibreParticipant.Location = new System.Drawing.Point(3, 6);
            this.LBequilibreParticipant.Name = "LBequilibreParticipant";
            this.LBequilibreParticipant.Size = new System.Drawing.Size(165, 208);
            this.LBequilibreParticipant.TabIndex = 0;
            // 
            // lblLeTricountActuel
            // 
            this.lblLeTricountActuel.AutoSize = true;
            this.lblLeTricountActuel.Location = new System.Drawing.Point(660, 9);
            this.lblLeTricountActuel.Name = "lblLeTricountActuel";
            this.lblLeTricountActuel.Size = new System.Drawing.Size(0, 17);
            this.lblLeTricountActuel.TabIndex = 8;
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
            this.Text = "Tricount";
            this.tabControl.ResumeLayout(false);
            this.tabDepense.ResumeLayout(false);
            this.tabDepense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVdepense)).EndInit();
            this.tabEquilibres.ResumeLayout(false);
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
        private Label lblLeTricountActuel;
        private Button btnAddDepense;
        private ListBox lbListParticipants;
        private Button btnAddParticipant;
        private TextBox txtBNomParticipant;
        private Label label3;
        private Button btnRetour;
        private Button btnSuprParticipant;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn payeur;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn montant;
        private DataGridViewTextBoxColumn concerner;
        private ListBox LBequilibreParticipant;
    }
}