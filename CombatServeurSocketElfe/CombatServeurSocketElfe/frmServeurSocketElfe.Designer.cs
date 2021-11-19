namespace CombatServeurSocketElfe
{
    partial class frmServeurSocketElfe
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServeurSocketElfe));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAttente = new System.Windows.Forms.Button();
            this.lblSortElfe = new System.Windows.Forms.Label();
            this.lblArmeNain = new System.Windows.Forms.Label();
            this.lblForceElfe = new System.Windows.Forms.Label();
            this.lblForceNain = new System.Windows.Forms.Label();
            this.lblVieElfe = new System.Windows.Forms.Label();
            this.lblVieNain = new System.Windows.Forms.Label();
            this.picElfe = new System.Windows.Forms.PictureBox();
            this.picNain = new System.Windows.Forms.PictureBox();
            this.lstReception = new System.Windows.Forms.ListBox();
            this.txtGagnant = new System.Windows.Forms.TextBox();
            this.lblServeurElfe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picElfe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(211, 270);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 23);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(211, 241);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(102, 23);
            this.btnFermer.TabIndex = 20;
            this.btnFermer.Text = "FERMER";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAttente
            // 
            this.btnAttente.Location = new System.Drawing.Point(210, 60);
            this.btnAttente.Name = "btnAttente";
            this.btnAttente.Size = new System.Drawing.Size(102, 23);
            this.btnAttente.TabIndex = 19;
            this.btnAttente.Text = "Attente d\'un client";
            this.btnAttente.UseVisualStyleBackColor = true;
            this.btnAttente.Click += new System.EventHandler(this.btnAttente_Click);
            // 
            // lblSortElfe
            // 
            this.lblSortElfe.AccessibleDescription = "";
            this.lblSortElfe.AutoSize = true;
            this.lblSortElfe.Location = new System.Drawing.Point(333, 275);
            this.lblSortElfe.Name = "lblSortElfe";
            this.lblSortElfe.Size = new System.Drawing.Size(32, 13);
            this.lblSortElfe.TabIndex = 18;
            this.lblSortElfe.Text = "Sort: ";
            // 
            // lblArmeNain
            // 
            this.lblArmeNain.AutoSize = true;
            this.lblArmeNain.Location = new System.Drawing.Point(35, 277);
            this.lblArmeNain.Name = "lblArmeNain";
            this.lblArmeNain.Size = new System.Drawing.Size(37, 13);
            this.lblArmeNain.TabIndex = 17;
            this.lblArmeNain.Text = "Arme: ";
            // 
            // lblForceElfe
            // 
            this.lblForceElfe.AutoSize = true;
            this.lblForceElfe.Location = new System.Drawing.Point(333, 253);
            this.lblForceElfe.Name = "lblForceElfe";
            this.lblForceElfe.Size = new System.Drawing.Size(40, 13);
            this.lblForceElfe.TabIndex = 16;
            this.lblForceElfe.Text = "Force: ";
            // 
            // lblForceNain
            // 
            this.lblForceNain.AutoSize = true;
            this.lblForceNain.Location = new System.Drawing.Point(35, 255);
            this.lblForceNain.Name = "lblForceNain";
            this.lblForceNain.Size = new System.Drawing.Size(37, 13);
            this.lblForceNain.TabIndex = 15;
            this.lblForceNain.Text = "Force:";
            // 
            // lblVieElfe
            // 
            this.lblVieElfe.AutoSize = true;
            this.lblVieElfe.Location = new System.Drawing.Point(333, 231);
            this.lblVieElfe.Name = "lblVieElfe";
            this.lblVieElfe.Size = new System.Drawing.Size(28, 13);
            this.lblVieElfe.TabIndex = 14;
            this.lblVieElfe.Text = "Vie: ";
            // 
            // lblVieNain
            // 
            this.lblVieNain.AutoSize = true;
            this.lblVieNain.Location = new System.Drawing.Point(35, 233);
            this.lblVieNain.Name = "lblVieNain";
            this.lblVieNain.Size = new System.Drawing.Size(28, 13);
            this.lblVieNain.TabIndex = 13;
            this.lblVieNain.Text = "Vie: ";
            // 
            // picElfe
            // 
            this.picElfe.Image = ((System.Drawing.Image)(resources.GetObject("picElfe.Image")));
            this.picElfe.Location = new System.Drawing.Point(319, 60);
            this.picElfe.Name = "picElfe";
            this.picElfe.Size = new System.Drawing.Size(180, 160);
            this.picElfe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picElfe.TabIndex = 12;
            this.picElfe.TabStop = false;
            // 
            // picNain
            // 
            this.picNain.Image = ((System.Drawing.Image)(resources.GetObject("picNain.Image")));
            this.picNain.Location = new System.Drawing.Point(24, 60);
            this.picNain.Name = "picNain";
            this.picNain.Size = new System.Drawing.Size(180, 160);
            this.picNain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNain.TabIndex = 11;
            this.picNain.TabStop = false;
            // 
            // lstReception
            // 
            this.lstReception.FormattingEnabled = true;
            this.lstReception.Location = new System.Drawing.Point(529, 60);
            this.lstReception.Name = "lstReception";
            this.lstReception.Size = new System.Drawing.Size(369, 277);
            this.lstReception.TabIndex = 22;
            // 
            // txtGagnant
            // 
            this.txtGagnant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGagnant.ForeColor = System.Drawing.Color.Red;
            this.txtGagnant.Location = new System.Drawing.Point(76, 305);
            this.txtGagnant.Name = "txtGagnant";
            this.txtGagnant.Size = new System.Drawing.Size(431, 29);
            this.txtGagnant.TabIndex = 24;
            this.txtGagnant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblServeurElfe
            // 
            this.lblServeurElfe.AutoSize = true;
            this.lblServeurElfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServeurElfe.Location = new System.Drawing.Point(331, 9);
            this.lblServeurElfe.Name = "lblServeurElfe";
            this.lblServeurElfe.Size = new System.Drawing.Size(204, 29);
            this.lblServeurElfe.TabIndex = 25;
            this.lblServeurElfe.Text = "Serveur de l\'elfe";
            // 
            // frmServeurSocketElfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 357);
            this.Controls.Add(this.lblServeurElfe);
            this.Controls.Add(this.txtGagnant);
            this.Controls.Add(this.lstReception);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAttente);
            this.Controls.Add(this.lblSortElfe);
            this.Controls.Add(this.lblArmeNain);
            this.Controls.Add(this.lblForceElfe);
            this.Controls.Add(this.lblForceNain);
            this.Controls.Add(this.lblVieElfe);
            this.Controls.Add(this.lblVieNain);
            this.Controls.Add(this.picElfe);
            this.Controls.Add(this.picNain);
            this.Name = "frmServeurSocketElfe";
            this.Text = "SERVEUR socket ELFE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServeurSocketElfe_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picElfe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAttente;
        private System.Windows.Forms.Label lblSortElfe;
        private System.Windows.Forms.Label lblArmeNain;
        private System.Windows.Forms.Label lblForceElfe;
        private System.Windows.Forms.Label lblForceNain;
        private System.Windows.Forms.Label lblVieElfe;
        private System.Windows.Forms.Label lblVieNain;
        private System.Windows.Forms.PictureBox picElfe;
        private System.Windows.Forms.PictureBox picNain;
        private System.Windows.Forms.ListBox lstReception;
        private System.Windows.Forms.TextBox txtGagnant;
        private System.Windows.Forms.Label lblServeurElfe;
    }
}

