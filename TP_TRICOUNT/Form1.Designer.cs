namespace TP_TRICOUNT
{
    partial class Form1
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
            this.LBtricount = new System.Windows.Forms.ListBox();
            this.txtBNameTricount = new System.Windows.Forms.TextBox();
            this.btnAddTricount = new System.Windows.Forms.Button();
            this.btnSelectTricount = new System.Windows.Forms.Button();
            this.btnDeleteTricount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBtricount
            // 
            this.LBtricount.FormattingEnabled = true;
            this.LBtricount.ItemHeight = 17;
            this.LBtricount.Location = new System.Drawing.Point(12, 12);
            this.LBtricount.Name = "LBtricount";
            this.LBtricount.Size = new System.Drawing.Size(343, 208);
            this.LBtricount.TabIndex = 0;
            // 
            // txtBNameTricount
            // 
            this.txtBNameTricount.Location = new System.Drawing.Point(12, 226);
            this.txtBNameTricount.Name = "txtBNameTricount";
            this.txtBNameTricount.Size = new System.Drawing.Size(155, 25);
            this.txtBNameTricount.TabIndex = 1;
            // 
            // btnAddTricount
            // 
            this.btnAddTricount.Location = new System.Drawing.Point(12, 257);
            this.btnAddTricount.Name = "btnAddTricount";
            this.btnAddTricount.Size = new System.Drawing.Size(79, 24);
            this.btnAddTricount.TabIndex = 2;
            this.btnAddTricount.Text = "Ajouter";
            this.btnAddTricount.UseVisualStyleBackColor = true;
            this.btnAddTricount.Click += new System.EventHandler(this.btnAddTricount_Click);
            // 
            // btnSelectTricount
            // 
            this.btnSelectTricount.Location = new System.Drawing.Point(230, 226);
            this.btnSelectTricount.Name = "btnSelectTricount";
            this.btnSelectTricount.Size = new System.Drawing.Size(125, 37);
            this.btnSelectTricount.TabIndex = 3;
            this.btnSelectTricount.Text = "Choisir ce TriCount";
            this.btnSelectTricount.UseVisualStyleBackColor = true;
            this.btnSelectTricount.Click += new System.EventHandler(this.btnSelectTricount_Click);
            // 
            // btnDeleteTricount
            // 
            this.btnDeleteTricount.Location = new System.Drawing.Point(97, 257);
            this.btnDeleteTricount.Name = "btnDeleteTricount";
            this.btnDeleteTricount.Size = new System.Drawing.Size(79, 24);
            this.btnDeleteTricount.TabIndex = 4;
            this.btnDeleteTricount.Text = "Supprimer";
            this.btnDeleteTricount.UseVisualStyleBackColor = true;
            this.btnDeleteTricount.Click += new System.EventHandler(this.btnDeleteTricount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 304);
            this.Controls.Add(this.btnDeleteTricount);
            this.Controls.Add(this.btnSelectTricount);
            this.Controls.Add(this.btnAddTricount);
            this.Controls.Add(this.txtBNameTricount);
            this.Controls.Add(this.LBtricount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LBtricount;
        private TextBox txtBNameTricount;
        private Button btnAddTricount;
        private Button btnSelectTricount;
        private Button btnDeleteTricount;
    }
}