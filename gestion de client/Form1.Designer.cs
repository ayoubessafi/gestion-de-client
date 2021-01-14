
namespace gestion_de_client
{
    partial class Form1
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
            this.ajouter = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prénom = new System.Windows.Forms.ComboBox();
            this.nom = new System.Windows.Forms.ComboBox();
            this.adresse = new System.Windows.Forms.ComboBox();
            this.ville = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.enrgistrer = new System.Windows.Forms.Button();
            this.rechercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(587, 19);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(95, 37);
            this.ajouter.TabIndex = 0;
            this.ajouter.Text = "ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(587, 78);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(95, 37);
            this.supprimer.TabIndex = 1;
            this.supprimer.Text = "supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(587, 136);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(95, 37);
            this.modifier.TabIndex = 2;
            this.modifier.Text = "modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(576, 160);
            this.dataGridView1.TabIndex = 3;
            // 
            // prénom
            // 
            this.prénom.FormattingEnabled = true;
            this.prénom.Location = new System.Drawing.Point(192, 42);
            this.prénom.Name = "prénom";
            this.prénom.Size = new System.Drawing.Size(146, 24);
            this.prénom.TabIndex = 5;
            // 
            // nom
            // 
            this.nom.FormattingEnabled = true;
            this.nom.Location = new System.Drawing.Point(192, 92);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(146, 24);
            this.nom.TabIndex = 6;
            // 
            // adresse
            // 
            this.adresse.FormattingEnabled = true;
            this.adresse.Location = new System.Drawing.Point(192, 139);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(146, 24);
            this.adresse.TabIndex = 7;
            // 
            // ville
            // 
            this.ville.FormattingEnabled = true;
            this.ville.Location = new System.Drawing.Point(192, 189);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(146, 24);
            this.ville.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "ville";
            // 
            // id
            // 
            this.id.FormattingEnabled = true;
            this.id.Location = new System.Drawing.Point(192, 3);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(146, 24);
            this.id.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "id";
            // 
            // enrgistrer
            // 
            this.enrgistrer.Location = new System.Drawing.Point(587, 189);
            this.enrgistrer.Name = "enrgistrer";
            this.enrgistrer.Size = new System.Drawing.Size(95, 37);
            this.enrgistrer.TabIndex = 15;
            this.enrgistrer.Text = "enrgistrer";
            this.enrgistrer.UseVisualStyleBackColor = true;
            this.enrgistrer.Click += new System.EventHandler(this.enrgistrer_Click);
            // 
            // rechercher
            // 
            this.rechercher.Location = new System.Drawing.Point(403, 112);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(95, 37);
            this.rechercher.TabIndex = 16;
            this.rechercher.Text = "recherche";
            this.rechercher.UseVisualStyleBackColor = true;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.enrgistrer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prénom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.ajouter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox prénom;
        private System.Windows.Forms.ComboBox nom;
        private System.Windows.Forms.ComboBox adresse;
        private System.Windows.Forms.ComboBox ville;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button enrgistrer;
        private System.Windows.Forms.Button rechercher;
    }
}

