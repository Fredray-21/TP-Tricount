namespace TP_TRICOUNT
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBTitre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnAddDep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxPourQui = new System.Windows.Forms.CheckedListBox();
            this.lblPayer = new System.Windows.Forms.Label();
            this.lbListParticipant = new System.Windows.Forms.ListBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.DTPdate = new System.Windows.Forms.DateTimePicker();
            this.txtBMontant = new System.Windows.Forms.TextBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBTitre
            // 
            this.txtBTitre.Font = new System.Drawing.Font("Montserrat", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBTitre.Location = new System.Drawing.Point(157, 83);
            this.txtBTitre.Name = "txtBTitre";
            this.txtBTitre.Size = new System.Drawing.Size(150, 28);
            this.txtBTitre.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRetour);
            this.groupBox1.Controls.Add(this.btnAddDep);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxPourQui);
            this.groupBox1.Controls.Add(this.lblPayer);
            this.groupBox1.Controls.Add(this.lbListParticipant);
            this.groupBox1.Controls.Add(this.lblEuro);
            this.groupBox1.Controls.Add(this.DTPdate);
            this.groupBox1.Controls.Add(this.txtBMontant);
            this.groupBox1.Controls.Add(this.lblMontant);
            this.groupBox1.Controls.Add(this.lblTitre);
            this.groupBox1.Controls.Add(this.txtBTitre);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 22.09901F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 543);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvelle Dépense";
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Montserrat", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRetour.Location = new System.Drawing.Point(6, 501);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(81, 36);
            this.btnRetour.TabIndex = 12;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnAddDep
            // 
            this.btnAddDep.Font = new System.Drawing.Font("Montserrat", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddDep.Location = new System.Drawing.Point(249, 484);
            this.btnAddDep.Name = "btnAddDep";
            this.btnAddDep.Size = new System.Drawing.Size(180, 49);
            this.btnAddDep.TabIndex = 11;
            this.btnAddDep.Text = "Ajouter la dépense";
            this.btnAddDep.UseVisualStyleBackColor = true;
            this.btnAddDep.Click += new System.EventHandler(this.btnAddDep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pour Qui:";
            // 
            // checkBoxPourQui
            // 
            this.checkBoxPourQui.Font = new System.Drawing.Font("Montserrat", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPourQui.FormattingEnabled = true;
            this.checkBoxPourQui.Location = new System.Drawing.Point(157, 313);
            this.checkBoxPourQui.Name = "checkBoxPourQui";
            this.checkBoxPourQui.Size = new System.Drawing.Size(150, 142);
            this.checkBoxPourQui.TabIndex = 9;
            // 
            // lblPayer
            // 
            this.lblPayer.AutoSize = true;
            this.lblPayer.Font = new System.Drawing.Font("Montserrat", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPayer.Location = new System.Drawing.Point(55, 173);
            this.lblPayer.Name = "lblPayer";
            this.lblPayer.Size = new System.Drawing.Size(99, 24);
            this.lblPayer.TabIndex = 8;
            this.lblPayer.Text = "Payer Par :";
            // 
            // lbListParticipant
            // 
            this.lbListParticipant.Font = new System.Drawing.Font("Montserrat", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbListParticipant.FormattingEnabled = true;
            this.lbListParticipant.ItemHeight = 24;
            this.lbListParticipant.Location = new System.Drawing.Point(157, 172);
            this.lbListParticipant.Name = "lbListParticipant";
            this.lbListParticipant.Size = new System.Drawing.Size(150, 124);
            this.lbListParticipant.TabIndex = 7;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(313, 131);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(34, 32);
            this.lblEuro.TabIndex = 6;
            this.lblEuro.Text = "€";
            // 
            // DTPdate
            // 
            this.DTPdate.Font = new System.Drawing.Font("Montserrat", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTPdate.Location = new System.Drawing.Point(157, 40);
            this.DTPdate.Name = "DTPdate";
            this.DTPdate.Size = new System.Drawing.Size(272, 28);
            this.DTPdate.TabIndex = 5;
            // 
            // txtBMontant
            // 
            this.txtBMontant.Font = new System.Drawing.Font("Montserrat", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBMontant.Location = new System.Drawing.Point(157, 130);
            this.txtBMontant.Name = "txtBMontant";
            this.txtBMontant.Size = new System.Drawing.Size(150, 28);
            this.txtBMontant.TabIndex = 4;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Montserrat", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMontant.Location = new System.Drawing.Point(61, 129);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(93, 24);
            this.lblMontant.TabIndex = 3;
            this.lblMontant.Text = "Montant :";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Montserrat", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(98, 83);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(57, 24);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Titre :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 567);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Tricount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtBTitre;
        private GroupBox groupBox1;
        private Label lblTitre;
        private DateTimePicker DTPdate;
        private TextBox txtBMontant;
        private Label lblMontant;
        private Label lblPayer;
        private ListBox lbListParticipant;
        private Label lblEuro;
        private Label label1;
        private CheckedListBox checkBoxPourQui;
        private Button btnAddDep;
        private Button btnRetour;
    }
}