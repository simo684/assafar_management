namespace GestionDeStock.PL
{
    partial class User_liste_produit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvproduit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbserchprod = new System.Windows.Forms.ComboBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtserchprod = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnexcell = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnimprimer = new System.Windows.Forms.Button();
            this.btnmodifier_prod = new System.Windows.Forms.Button();
            this.btnajouter_prod = new System.Windows.Forms.Button();
            this.btnsupprimer_prod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduit)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvproduit
            // 
            this.dgvproduit.AllowUserToAddRows = false;
            this.dgvproduit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproduit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvproduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvproduit.EnableHeadersVisualStyles = false;
            this.dgvproduit.Location = new System.Drawing.Point(119, 164);
            this.dgvproduit.Name = "dgvproduit";
            this.dgvproduit.RowHeadersVisible = false;
            this.dgvproduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvproduit.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproduit.Size = new System.Drawing.Size(863, 480);
            this.dgvproduit.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "select";
            this.Column1.Name = "Column1";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "id";
            this.Column8.Name = "Column8";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "quantite";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "prix_vente";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "categorie";
            this.Column5.Name = "Column5";
            // 
            // cmbserchprod
            // 
            this.cmbserchprod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbserchprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbserchprod.FormattingEnabled = true;
            this.cmbserchprod.Items.AddRange(new object[] {
            "nom",
            "categorie"});
            this.cmbserchprod.Location = new System.Drawing.Point(222, 71);
            this.cmbserchprod.Name = "cmbserchprod";
            this.cmbserchprod.Size = new System.Drawing.Size(215, 33);
            this.cmbserchprod.TabIndex = 17;
            this.cmbserchprod.SelectedIndexChanged += new System.EventHandler(this.cmbserchprod_SelectedIndexChanged);
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(0, 25);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(221, 3);
            this.panel12.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(0, 25);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(221, 3);
            this.panel11.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(0, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(221, 3);
            this.panel10.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Location = new System.Drawing.Point(492, 101);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(221, 3);
            this.panel9.TabIndex = 15;
            // 
            // txtserchprod
            // 
            this.txtserchprod.BackColor = System.Drawing.Color.White;
            this.txtserchprod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtserchprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserchprod.Location = new System.Drawing.Point(492, 65);
            this.txtserchprod.Multiline = true;
            this.txtserchprod.Name = "txtserchprod";
            this.txtserchprod.Size = new System.Drawing.Size(221, 39);
            this.txtserchprod.TabIndex = 16;
            this.txtserchprod.Text = "Rechercher";
            this.txtserchprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtserchprod.TextChanged += new System.EventHandler(this.txtserchprod_TextChanged);
            this.txtserchprod.Enter += new System.EventHandler(this.txtserchprod_Enter);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(0, 25);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(863, 3);
            this.panel8.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(0, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(863, 3);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(863, 3);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Location = new System.Drawing.Point(119, 139);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(863, 3);
            this.panel5.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 3);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(863, 3);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 3);
            this.panel3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(119, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 3);
            this.panel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::GestionDeStock.Properties.Resources.updated__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(770, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 47);
            this.button1.TabIndex = 22;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexcell
            // 
            this.btnexcell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcell.BackColor = System.Drawing.Color.Black;
            this.btnexcell.FlatAppearance.BorderSize = 0;
            this.btnexcell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexcell.Image = global::GestionDeStock.Properties.Resources.icons8_ms_excel_48;
            this.btnexcell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcell.Location = new System.Drawing.Point(768, 661);
            this.btnexcell.Name = "btnexcell";
            this.btnexcell.Size = new System.Drawing.Size(214, 47);
            this.btnexcell.TabIndex = 21;
            this.btnexcell.Text = "To Excel";
            this.btnexcell.UseVisualStyleBackColor = false;
            this.btnexcell.Click += new System.EventHandler(this.btnexcell_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnmodifier.BackColor = System.Drawing.Color.Silver;
            this.btnmodifier.FlatAppearance.BorderSize = 0;
            this.btnmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmodifier.Image = global::GestionDeStock.Properties.Resources.icons8_impression_24;
            this.btnmodifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifier.Location = new System.Drawing.Point(435, 661);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(234, 47);
            this.btnmodifier.TabIndex = 20;
            this.btnmodifier.Text = "imprimer tous";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnimprimer
            // 
            this.btnimprimer.BackColor = System.Drawing.Color.Gray;
            this.btnimprimer.FlatAppearance.BorderSize = 0;
            this.btnimprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnimprimer.Image = global::GestionDeStock.Properties.Resources.icons8_impression_24;
            this.btnimprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimer.Location = new System.Drawing.Point(119, 661);
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.Size = new System.Drawing.Size(238, 47);
            this.btnimprimer.TabIndex = 19;
            this.btnimprimer.Text = "imprimer";
            this.btnimprimer.UseVisualStyleBackColor = false;
            this.btnimprimer.Click += new System.EventHandler(this.btnajouter_client_Click);
            // 
            // btnmodifier_prod
            // 
            this.btnmodifier_prod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnmodifier_prod.BackColor = System.Drawing.Color.Black;
            this.btnmodifier_prod.FlatAppearance.BorderSize = 0;
            this.btnmodifier_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifier_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier_prod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmodifier_prod.Image = global::GestionDeStock.Properties.Resources.icons8_recycler_48;
            this.btnmodifier_prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifier_prod.Location = new System.Drawing.Point(435, 3);
            this.btnmodifier_prod.Name = "btnmodifier_prod";
            this.btnmodifier_prod.Size = new System.Drawing.Size(234, 47);
            this.btnmodifier_prod.TabIndex = 11;
            this.btnmodifier_prod.Text = "modifier";
            this.btnmodifier_prod.UseVisualStyleBackColor = false;
            this.btnmodifier_prod.Click += new System.EventHandler(this.btnmodifier_prod_Click);
            // 
            // btnajouter_prod
            // 
            this.btnajouter_prod.BackColor = System.Drawing.Color.Black;
            this.btnajouter_prod.FlatAppearance.BorderSize = 0;
            this.btnajouter_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter_prod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnajouter_prod.Image = global::GestionDeStock.Properties.Resources.icons8_ajouter_48;
            this.btnajouter_prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouter_prod.Location = new System.Drawing.Point(119, 3);
            this.btnajouter_prod.Name = "btnajouter_prod";
            this.btnajouter_prod.Size = new System.Drawing.Size(238, 47);
            this.btnajouter_prod.TabIndex = 10;
            this.btnajouter_prod.Text = "Ajouter";
            this.btnajouter_prod.UseVisualStyleBackColor = false;
            this.btnajouter_prod.Click += new System.EventHandler(this.btnajouter_prod_Click);
            // 
            // btnsupprimer_prod
            // 
            this.btnsupprimer_prod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsupprimer_prod.BackColor = System.Drawing.Color.Black;
            this.btnsupprimer_prod.FlatAppearance.BorderSize = 0;
            this.btnsupprimer_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimer_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer_prod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsupprimer_prod.Image = global::GestionDeStock.Properties.Resources.icons8_supprimer_pour_toujours_48;
            this.btnsupprimer_prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimer_prod.Location = new System.Drawing.Point(768, 3);
            this.btnsupprimer_prod.Name = "btnsupprimer_prod";
            this.btnsupprimer_prod.Size = new System.Drawing.Size(214, 47);
            this.btnsupprimer_prod.TabIndex = 12;
            this.btnsupprimer_prod.Text = "supprimer";
            this.btnsupprimer_prod.UseVisualStyleBackColor = false;
            this.btnsupprimer_prod.Click += new System.EventHandler(this.btnsupprimer_prod_Click);
            // 
            // User_liste_produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexcell);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.dgvproduit);
            this.Controls.Add(this.cmbserchprod);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.txtserchprod);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnmodifier_prod);
            this.Controls.Add(this.btnajouter_prod);
            this.Controls.Add(this.btnsupprimer_prod);
            this.Name = "User_liste_produit";
            this.Size = new System.Drawing.Size(1100, 720);
            this.Load += new System.EventHandler(this.User_liste_produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduit)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvproduit;
        private System.Windows.Forms.ComboBox cmbserchprod;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtserchprod;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnmodifier_prod;
        private System.Windows.Forms.Button btnajouter_prod;
        private System.Windows.Forms.Button btnsupprimer_prod;
        private System.Windows.Forms.Button btnexcell;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnimprimer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
    }
}
