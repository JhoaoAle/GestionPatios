﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoInventariosBD
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label2.Text = Form1.obtenervalor;
            label2.Visible = true;


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseInsertType f = new ChooseInsertType();
            f.Show();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
