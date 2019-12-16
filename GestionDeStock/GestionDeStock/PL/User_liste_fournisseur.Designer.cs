namespace GestionDeStock.PL
{
    partial class User_liste_fournisseur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dgvcfourns = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtserchfourns = new System.Windows.Forms.TextBox();
            this.btnexcell = new System.Windows.Forms.Button();
            this.btnimprimall = new System.Windows.Forms.Button();
            this.btnajouter_fournsii = new System.Windows.Forms.Button();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcfourns)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Location = new System.Drawing.Point(555, 85);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(221, 3);
            this.panel9.TabIndex = 24;
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
            // dgvcfourns
            // 
            this.dgvcfourns.AllowUserToAddRows = false;
            this.dgvcfourns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcfourns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcfourns.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvcfourns.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcfourns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcfourns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcfourns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Modifier,
            this.supprimer});
            this.dgvcfourns.EnableHeadersVisualStyles = false;
            this.dgvcfourns.Location = new System.Drawing.Point(119, 110);
            this.dgvcfourns.Name = "dgvcfourns";
            this.dgvcfourns.RowHeadersVisible = false;
            this.dgvcfourns.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcfourns.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcfourns.Size = new System.Drawing.Size(863, 480);
            this.dgvcfourns.TabIndex = 27;
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
            this.Column2.HeaderText = "nom fournisseur";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "tel";
            this.Column3.Name = "Column3";
            // 
            // Modifier
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime;
            this.Modifier.DefaultCellStyle = dataGridViewCellStyle2;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // supprimer
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.supprimer.DefaultCellStyle = dataGridViewCellStyle3;
            this.supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.supprimer.HeaderText = "supprimer";
            this.supprimer.Name = "supprimer";
            this.supprimer.Text = "supprimer";
            this.supprimer.UseColumnTextForButtonValue = true;
            // 
            // txtserchfourns
            // 
            this.txtserchfourns.BackColor = System.Drawing.Color.White;
            this.txtserchfourns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtserchfourns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserchfourns.Location = new System.Drawing.Point(555, 40);
            this.txtserchfourns.Multiline = true;
            this.txtserchfourns.Name = "txtserchfourns";
            this.txtserchfourns.Size = new System.Drawing.Size(221, 39);
            this.txtserchfourns.TabIndex = 25;
            this.txtserchfourns.Text = "Rechercher";
            this.txtserchfourns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnexcell.Location = new System.Drawing.Point(627, 634);
            this.btnexcell.Name = "btnexcell";
            this.btnexcell.Size = new System.Drawing.Size(214, 47);
            this.btnexcell.TabIndex = 29;
            this.btnexcell.Text = "sauvegarder";
            this.btnexcell.UseVisualStyleBackColor = false;
            // 
            // btnimprimall
            // 
            this.btnimprimall.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnimprimall.BackColor = System.Drawing.Color.Silver;
            this.btnimprimall.FlatAppearance.BorderSize = 0;
            this.btnimprimall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnimprimall.Image = global::GestionDeStock.Properties.Resources.icons8_impression_24;
            this.btnimprimall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimall.Location = new System.Drawing.Point(294, 634);
            this.btnimprimall.Name = "btnimprimall";
            this.btnimprimall.Size = new System.Drawing.Size(234, 47);
            this.btnimprimall.TabIndex = 28;
            this.btnimprimall.Text = "imprimer tous";
            this.btnimprimall.UseVisualStyleBackColor = false;
            // 
            // btnajouter_fournsii
            // 
            this.btnajouter_fournsii.BackColor = System.Drawing.Color.Black;
            this.btnajouter_fournsii.FlatAppearance.BorderSize = 0;
            this.btnajouter_fournsii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter_fournsii.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter_fournsii.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnajouter_fournsii.Image = global::GestionDeStock.Properties.Resources.icons8_ajouter_48;
            this.btnajouter_fournsii.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouter_fournsii.Location = new System.Drawing.Point(119, 40);
            this.btnajouter_fournsii.Name = "btnajouter_fournsii";
            this.btnajouter_fournsii.Size = new System.Drawing.Size(238, 47);
            this.btnajouter_fournsii.TabIndex = 26;
            this.btnajouter_fournsii.Text = "Ajouter";
            this.btnajouter_fournsii.UseVisualStyleBackColor = false;
            this.btnajouter_fournsii.Click += new System.EventHandler(this.btnajouter_fournsii_Click);
            // 
            // User_liste_fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.dgvcfourns);
            this.Controls.Add(this.txtserchfourns);
            this.Controls.Add(this.btnexcell);
            this.Controls.Add(this.btnimprimall);
            this.Controls.Add(this.btnajouter_fournsii);
            this.Name = "User_liste_fournisseur";
            this.Size = new System.Drawing.Size(1100, 720);
            this.Load += new System.EventHandler(this.User_liste_fournisseur_Load);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcfourns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView dgvcfourns;
        private System.Windows.Forms.TextBox txtserchfourns;
        private System.Windows.Forms.Button btnexcell;
        private System.Windows.Forms.Button btnimprimall;
        private System.Windows.Forms.Button btnajouter_fournsii;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn supprimer;
    }
}
