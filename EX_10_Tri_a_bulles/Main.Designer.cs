namespace EX_10_Tri_a_bulles
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.pnlGraphique = new System.Windows.Forms.Panel();
            this.btnRandomNbr = new System.Windows.Forms.Button();
            this.btnBulles = new System.Windows.Forms.Button();
            this.btnTas = new System.Windows.Forms.Button();
            this.btnRapide = new System.Windows.Forms.Button();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlGraphique
            // 
            this.pnlGraphique.Location = new System.Drawing.Point(18, 15);
            this.pnlGraphique.Name = "pnlGraphique";
            this.pnlGraphique.Size = new System.Drawing.Size(758, 243);
            this.pnlGraphique.TabIndex = 0;
            // 
            // btnRandomNbr
            // 
            this.btnRandomNbr.Location = new System.Drawing.Point(19, 275);
            this.btnRandomNbr.Name = "btnRandomNbr";
            this.btnRandomNbr.Size = new System.Drawing.Size(757, 32);
            this.btnRandomNbr.TabIndex = 1;
            this.btnRandomNbr.Text = "Nouveaux nombres";
            this.btnRandomNbr.UseVisualStyleBackColor = true;
            this.btnRandomNbr.Click += new System.EventHandler(this.btnRandomNbr_Click);
            // 
            // btnBulles
            // 
            this.btnBulles.Location = new System.Drawing.Point(19, 336);
            this.btnBulles.Name = "btnBulles";
            this.btnBulles.Size = new System.Drawing.Size(757, 32);
            this.btnBulles.TabIndex = 2;
            this.btnBulles.Text = "Tri à Bulles";
            this.btnBulles.UseVisualStyleBackColor = true;
            this.btnBulles.Click += new System.EventHandler(this.btnBulles_Click);
            // 
            // btnTas
            // 
            this.btnTas.Location = new System.Drawing.Point(19, 374);
            this.btnTas.Name = "btnTas";
            this.btnTas.Size = new System.Drawing.Size(757, 32);
            this.btnTas.TabIndex = 2;
            this.btnTas.Text = "Trie par tas";
            this.btnTas.UseVisualStyleBackColor = true;
            // 
            // btnRapide
            // 
            this.btnRapide.Location = new System.Drawing.Point(18, 412);
            this.btnRapide.Name = "btnRapide";
            this.btnRapide.Size = new System.Drawing.Size(757, 32);
            this.btnRapide.TabIndex = 2;
            this.btnRapide.Text = "Tri rapide";
            this.btnRapide.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.btnRapide);
            this.Controls.Add(this.btnTas);
            this.Controls.Add(this.btnBulles);
            this.Controls.Add(this.btnRandomNbr);
            this.Controls.Add(this.pnlGraphique);
            this.Name = "Main";
            this.Text = "Ex10_Tri à bulle";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGraphique;
        private System.Windows.Forms.Button btnRandomNbr;
        private System.Windows.Forms.Button btnBulles;
        private System.Windows.Forms.Button btnTas;
        private System.Windows.Forms.Button btnRapide;
        private System.Windows.Forms.Timer tmrMain;
    }
}

