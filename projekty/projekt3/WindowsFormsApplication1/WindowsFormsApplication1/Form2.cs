﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private ConnectionMode cMode = new ConnectionMode();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsienkiewiczDataSet.cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.dsienkiewiczDataSet.cars);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 connectionMode = new Form3();
            connectionMode.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 connectionMode = new Form1();
            connectionMode.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 connectionMode = new Form4();
            connectionMode.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 connectionMode = new Form5();
            connectionMode.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 connectionMode = new Form6();
            connectionMode.Show();
        }
    }
}