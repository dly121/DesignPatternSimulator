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
            Damier.TestDamier fm = new Damier.TestDamier();
            fm.MdiParent = this;
            fm.Show();
        }

        private void nouvellePartieToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.MdiParent = this;
            fm.Show();
        }
    }
}