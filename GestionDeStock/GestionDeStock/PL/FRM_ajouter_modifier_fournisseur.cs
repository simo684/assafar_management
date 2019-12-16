﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FRM_ajouter_modifier_fournisseur : Form
    {
        public FRM_ajouter_modifier_fournisseur()
        {
            InitializeComponent();
        }

        string test_obli()
        {
            if (txtnom_fr.Text == "" || txtnom_fr.Text =="NOM FOURNISSEUR")
            {
                return "entrer un fournisseur";
            }
            if (txtel_fr.Text == "" || txtel_fr.Text == "TEL FOURNISSEUR")
            {
                return "entrer telephone du fournisseur";
            }

            else return null;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_ajouter_modifier_fournisseur_Load(object sender, EventArgs e)
        {

        }

        private void btnenregistrer_fr_Click(object sender, EventArgs e)
        {
            if (test_obli() != null)
            {
                MessageBox.Show(test_obli());
            }
            else
            {
                if (lbltitre.Text == "AJOUTER FOURNISSEUR")
                {


                }
                else
                {
                }

            }
        }

        private void txtnom_fr_Enter(object sender, EventArgs e)
        {
            if (txtnom_fr.Text == "NOM FOURNISSEUR")
            {
                txtnom_fr.Text = "";
            }
        }

        private void txtel_fr_Enter(object sender, EventArgs e)
        {
            if (txtel_fr.Text == "TEL FOURNISSEUR")
            {
                txtel_fr.Text = "";
            }
        }

        private void txtnom_fr_Leave(object sender, EventArgs e)
        {
            if (txtnom_fr.Text == "")
            {
                txtnom_fr.Text = "NOM FOURNISSEUR";
            }
        }

        private void txtel_fr_Leave(object sender, EventArgs e)
        {
            if (txtel_fr.Text == "")
            {
                txtel_fr.Text = "TEL FOURNISSEUR";
            }
        }
    }
}
