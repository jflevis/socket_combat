namespace CombatClientSocketNaIn
{
    partial class frmClienSocketNain
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFrappe = new System.Windows.Forms.Button();
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
            this.btnReset.Location = new System.Drawing.Point(511, 275);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 23);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFrappe
            // 
            this.btnFrappe.Location = new System.Drawing.Point(280, 126);
            this.btnFrappe.Name = "btnFrappe";
            this.btnFrappe.Size = new System.Drawing.Size(96, 46);
            this.btnFrappe.TabIndex = 19;
            this.btnFrappe.Text = "Frapper   -->       <--Lancer Sort";
            this.btnFrappe.UseVisualStyleBackColor = true;
            this.btnFrappe.Click += new System.EventHandler(this.btnFrappe_Click);
            // 
            // lblSortElfe
            // 
            this.lblSortElfe.AccessibleDescription = "";
            this.lblSortElfe.AutoSize = true;
            this.lblSortElfe.Location = new System.Drawing.Point(397, 285);
            this.lblSortElfe.Name = "lblSortElfe";
            this.lblSortElfe.Size = new System.Drawing.Size(32, 13);
            this.lblSortElfe.TabIndex = 18;
            this.lblSortElfe.Text = "Sort: ";
            // 
            // lblArmeNain
            // 
            this.lblArmeNain.AutoSize = true;
            this.lblArmeNain.Location = new System.Drawing.Point(50, 287);
            this.lblArmeNain.Name = "lblArmeNain";
            this.lblArmeNain.Size = new System.Drawing.Size(37, 13);
            this.lblArmeNain.TabIndex = 17;
            this.lblArmeNain.Text = "Arme: ";
            // 
            // lblForceElfe
            // 
            this.lblForceElfe.AutoSize = true;
            this.lblForceElfe.Location = new System.Drawing.Point(397, 263);
            this.lblForceElfe.Name = "lblForceElfe";
            this.lblForceElfe.Size = new System.Drawing.Size(40, 13);
            this.lblForceElfe.TabIndex = 16;
            this.lblForceElfe.Text = "Force: ";
            // 
            // lblForceNain
            // 
            this.lblForceNain.AutoSize = true;
            this.lblForceNain.Location = new System.Drawing.Point(50, 265);
            this.lblForceNain.Name = "lblForceNain";
            this.lblForceNain.Size = new System.Drawing.Size(37, 13);
            this.lblForceNain.TabIndex = 15;
            this.lblForceNain.Text = "Force:";
            // 
            // lblVieElfe
            // 
            this.lblVieElfe.AutoSize = true;
            this.lblVieElfe.Location = new System.Drawing.Point(397, 241);
            this.lblVieElfe.Name = "lblVieElfe";
            this.lblVieElfe.Size = new System.Drawing.Size(28, 13);
            this.lblVieElfe.TabIndex = 14;
            this.lblVieElfe.Text = "Vie: ";
            // 
            // lblVieNain
            // 
            this.lblVieNain.AutoSize = true;
            this.lblVieNain.Location = new System.Drawing.Point(50, 243);
            this.lblVieNain.Name = "lblVieNain";
            this.lblVieNain.Size = new System.Drawing.Size(28, 13);
            this.lblVieNain.TabIndex = 13;
            this.lblVieNain.Text = "Vie: ";
            // 
            // picElfe
            // 
            this.picElfe.Image = global::CombatClientSocketNaIn.Properties.Resources.elfeOreille;
            this.picElfe.Location = new System.Drawing.Point(393, 70);
            this.picElfe.Name = "picElfe";
            this.picElfe.Size = new System.Drawing.Size(220, 160);
            this.picElfe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picElfe.TabIndex = 12;
            this.picElfe.TabStop = false;
            // 
            // picNain
            // 
            this.picNain.Image = global::CombatClientSocketNaIn.Properties.Resources.nainArme;
            this.picNain.Location = new System.Drawing.Point(39, 70);
            this.picNain.Name = "picNain";
            this.picNain.Size = new System.Drawing.Size(220, 160);
            this.picNain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNain.TabIndex = 11;
            this.picNain.TabStop = false;
            // 
            // lstReception
            // 
            this.lstReception.FormattingEnabled = true;
            this.lstReception.Location = new System.Drawing.Point(633, 70);
            this.lstReception.Name = "lstReception";
            this.lstReception.Size = new System.Drawing.Size(261, 277);
            this.lstReception.TabIndex = 22;
            // 
            // txtGagnant
            // 
            this.txtGagnant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGagnant.ForeColor = System.Drawing.Color.Red;
            this.txtGagnant.Location = new System.Drawing.Point(98, 320);
            this.txtGagnant.Name = "txtGagnant";
            this.txtGagnant.Size = new System.Drawing.Size(471, 29);
            this.txtGagnant.TabIndex = 23;
            this.txtGagnant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblServeurElfe
            // 
            this.lblServeurElfe.AutoSize = true;
            this.lblServeurElfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServeurElfe.Location = new System.Drawing.Point(302, 18);
            this.lblServeurElfe.Name = "lblServeurElfe";
            this.lblServeurElfe.Size = new System.Drawing.Size(196, 29);
            this.lblServeurElfe.TabIndex = 26;
            this.lblServeurElfe.Text = "Serveur du nain";
            // 
            // frmClienSocketNain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 371);
            this.Controls.Add(this.lblServeurElfe);
            this.Controls.Add(this.txtGagnant);
            this.Controls.Add(this.lstReception);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFrappe);
            this.Controls.Add(this.lblSortElfe);
            this.Controls.Add(this.lblArmeNain);
            this.Controls.Add(this.lblForceElfe);
            this.Controls.Add(this.lblForceNain);
            this.Controls.Add(this.lblVieElfe);
            this.Controls.Add(this.lblVieNain);
            this.Controls.Add(this.picElfe);
            this.Controls.Add(this.picNain);
            this.Name = "frmClienSocketNain";
            this.Text = "CLIENT socket NAIN";
            ((System.ComponentModel.ISupportInitialize)(this.picElfe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFrappe;
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

