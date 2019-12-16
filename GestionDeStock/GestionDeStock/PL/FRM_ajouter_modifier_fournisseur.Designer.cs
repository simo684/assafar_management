namespace GestionDeStock.PL
{
    partial class FRM_ajouter_modifier_fournisseur
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
            this.btnenregistrer_fr = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtnom_fr = new System.Windows.Forms.TextBox();
            this.lbltitre = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtel_fr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnenregistrer_fr
            // 
            this.btnenregistrer_fr.BackColor = System.Drawing.Color.Red;
            this.btnenregistrer_fr.FlatAppearance.BorderSize = 0;
            this.btnenregistrer_fr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenregistrer_fr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer_fr.Location = new System.Drawing.Point(29, 316);
            this.btnenregistrer_fr.Name = "btnenregistrer_fr";
            this.btnenregistrer_fr.Size = new System.Drawing.Size(205, 38);
            this.btnenregistrer_fr.TabIndex = 63;
            this.btnenregistrer_fr.Text = "Enregistrer";
            this.btnenregistrer_fr.UseVisualStyleBackColor = false;
            this.btnenregistrer_fr.Click += new System.EventHandler(this.btnenregistrer_fr_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 159);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 1);
            this.textBox2.TabIndex = 61;
            // 
            // txtnom_fr
            // 
            this.txtnom_fr.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtnom_fr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnom_fr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom_fr.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtnom_fr.Location = new System.Drawing.Point(29, 119);
            this.txtnom_fr.Multiline = true;
            this.txtnom_fr.Name = "txtnom_fr";
            this.txtnom_fr.Size = new System.Drawing.Size(225, 38);
            this.txtnom_fr.TabIndex = 62;
            this.txtnom_fr.Text = "NOM FOURNISSEUR";
            this.txtnom_fr.Enter += new System.EventHandler(this.txtnom_fr_Enter);
            this.txtnom_fr.Leave += new System.EventHandler(this.txtnom_fr_Leave);
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltitre.Location = new System.Drawing.Point(17, 19);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(349, 31);
            this.lbltitre.TabIndex = 60;
            this.lbltitre.Text = "AJOUTER FOURNISSEUR";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(4, 364);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(407, 4);
            this.panel4.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 4);
            this.panel3.TabIndex = 57;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(411, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 368);
            this.panel2.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 368);
            this.panel1.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GestionDeStock.Properties.Resources.icons8_fermer_la_fenêtre_48;
            this.button1.Location = new System.Drawing.Point(373, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 37);
            this.button1.TabIndex = 64;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 245);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 1);
            this.textBox1.TabIndex = 65;
            // 
            // txtel_fr
            // 
            this.txtel_fr.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtel_fr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtel_fr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtel_fr.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtel_fr.Location = new System.Drawing.Point(29, 205);
            this.txtel_fr.Multiline = true;
            this.txtel_fr.Name = "txtel_fr";
            this.txtel_fr.Size = new System.Drawing.Size(225, 38);
            this.txtel_fr.TabIndex = 66;
            this.txtel_fr.Text = "TEL FOURNISSEUR";
            this.txtel_fr.Enter += new System.EventHandler(this.txtel_fr_Enter);
            this.txtel_fr.Leave += new System.EventHandler(this.txtel_fr_Leave);
            // 
            // FRM_ajouter_modifier_fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(415, 368);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtel_fr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnenregistrer_fr);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtnom_fr);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ajouter_modifier_fournisseur";
            this.Text = "FRM_ajouter_modifier_fournisseur";
            this.Load += new System.EventHandler(this.FRM_ajouter_modifier_fournisseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnenregistrer_fr;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox txtnom_fr;
        public System.Windows.Forms.Label lbltitre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txtel_fr;
    }
}