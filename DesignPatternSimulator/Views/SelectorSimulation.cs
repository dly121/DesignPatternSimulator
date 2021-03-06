﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternSimulator.Views
{
    public partial class SelectorSimulation : Form
    {
        public SelectorSimulation()
        {
            InitializeComponent();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //DialogResult  decision =  MessageBox.Show("Are you sure?", "Choose one decision", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //if (decision == DialogResult.OK)
            //{
                //SelectorSimulation.ActiveForm.Close();
                
            //}
        }

        private void nouvellePartieToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Damier.Damier fm = new Damier.Damier();//.Damier();
            fm.MdiParent = this;
            fm.Show();
        }

        private void nouvellePartieToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.MdiParent = this;
            fm.Show();
        }


        //Labyrinthe
        private void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Labyrinthe.Labyrinthe fm = new Labyrinthe.Labyrinthe();
            fm.MdiParent = this;
            fm.Show();
        }
    }
}
