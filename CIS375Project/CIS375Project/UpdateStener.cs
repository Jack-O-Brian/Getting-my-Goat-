﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS375Project.classes;

namespace CIS375Project
{
    public partial class UpdateStener : Form
    {
     public List<List<string>> Array { get; set; }
     public List<List<string>> Arr { get; set; }
        public UpdateStener()
        {
            InitializeComponent();
            STENER c = new STENER();
            listBox1.Items.Add("Department\tStener");
            List<List<string>> Arr  = c.ViewS(c);
            foreach (List<string> ArrInner in Arr) {
                listBox1.Items.Add(ArrInner[0] +"\t" + ArrInner[1] + "\t" + ArrInner[2]);
            }
            this.Array=Arr;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeCurr_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Did you select a question?");
            }
            else
            {
                Questions Change = new Questions();
                if (textBox1.TextLength == 0)
                {
                    MessageBox.Show("This won't change anything.");
                }
                else
                {
                    Change.UpdateQ(Change, textBox1.Text, Arr[listBox2.SelectedIndex][4]);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Questions Q = new Questions();
             Arr=Q.DisplayQandA(Q, listBox1.SelectedIndex);
            MessageBox.Show(Arr[0][4]);
            listBox2.Items.Clear();
            foreach (List<string> ArrInner in Arr){
                listBox2.Items.Add(ArrInner[0] +"\t" + ArrInner[1] + "\t" + ArrInner[2] + "\t" + ArrInner[3] + "\t" + ArrInner[4]);
            }

        }
    }
}