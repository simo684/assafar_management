namespace GestionDeStock.PL
{
    partial class FRM_produit_commande
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
            this.grproduits = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtremise = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtqte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lbi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblprix = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnsave = new System.Windows.Forms.Button();
            this.grproduits.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grproduits
            // 
            this.grproduits.Controls.Add(this.label8);
            this.grproduits.Controls.Add(this.label7);
            this.grproduits.Controls.Add(this.txttotal);
            this.grproduits.Controls.Add(this.label6);
            this.grproduits.Controls.Add(this.txtremise);
            this.grproduits.Controls.Add(this.label5);
            this.grproduits.Controls.Add(this.txtqte);
            this.grproduits.Controls.Add(this.label4);
            this.grproduits.Controls.Add(this.groupBox2);
            this.grproduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grproduits.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grproduits.Location = new System.Drawing.Point(12, 12);
            this.grproduits.Name = "grproduits";
            this.grproduits.Size = new System.Drawing.Size(436, 326);
            this.grproduits.TabIndex = 0;
            this.grproduits.TabStop = false;
            this.grproduits.Text = "VENTE PRODUIT";
            this.grproduits.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = ".............................";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(249, 242);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(152, 26);
            this.txttotal.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "....Total............";
            // 
            // txtremise
            // 
            this.txtremise.Location = new System.Drawing.Point(249, 155);
            this.txtremise.Name = "txtremise";
            this.txtremise.Size = new System.Drawing.Size(111, 26);
            this.txtremise.TabIndex = 4;
            this.txtremise.TextChanged += new System.EventHandler(this.txtremise_TextChanged);
            this.txtremise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtremise_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "....Remise............";
            // 
            // txtqte
            // 
            this.txtqte.Location = new System.Drawing.Point(248, 68);
            this.txtqte.Name = "txtqte";
            this.txtqte.Size = new System.Drawing.Size(152, 26);
            this.txtqte.TabIndex = 2;
            this.txtqte.TextChanged += new System.EventHandler(this.txtqte_TextChanged);
            this.txtqte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqte_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "....quantite............";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lbi);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblprix);
            this.groupBox2.Controls.Add(this.lblstock);
            this.groupBox2.Controls.Add(this.lblnom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(6, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 283);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "detail produit";
            // 
            // Lbi
            // 
            this.Lbi.AutoSize = true;
            this.Lbi.Location = new System.Drawing.Point(74, 37);
            this.Lbi.Name = "Lbi";
            this.Lbi.Size = new System.Drawing.Size(21, 20);
            this.Lbi.TabIndex = 7;
            this.Lbi.Text = "Li";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(5, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Id:";
            // 
            // lblprix
            // 
            this.lblprix.AutoSize = true;
            this.lblprix.Location = new System.Drawing.Point(75, 205);
            this.lblprix.Name = "lblprix";
            this.lblprix.Size = new System.Drawing.Size(21, 20);
            this.lblprix.TabIndex = 5;
            this.lblprix.Text = "lp";
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Location = new System.Drawing.Point(75, 148);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(20, 20);
            this.lblstock.TabIndex = 4;
            this.lblstock.Text = "ls";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(75, 93);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(21, 20);
            this.lblnom.TabIndex = 3;
            this.lblnom.Text = "ln";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(5, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prix :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(5, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(5, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom:";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Red;
            this.btnsave.Location = new System.Drawing.Point(126, 354);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(202, 40);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "ENREGISTRER";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // FRM_produit_commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(460, 404);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.grproduits);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_produit_commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUIT";
            this.grproduits.ResumeLayout(false);
            this.grproduits.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.Label lblprix;
        public System.Windows.Forms.Label lblstock;
        public System.Windows.Forms.Label lblnom;
        public System.Windows.Forms.TextBox txttotal;
        public System.Windows.Forms.TextBox txtqte;
        public System.Windows.Forms.Label Lbi;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.GroupBox grproduits;
        public System.Windows.Forms.TextBox txtremise;
    }
}