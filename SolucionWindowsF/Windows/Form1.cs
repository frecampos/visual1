﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            int x = 1;
            MessageBox.Show(""+x);
            MessageBox.Show("hola mundo real");
            if (true)
            {
                MessageBox.Show("nuevo mensaje");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nuevos datos");
        }
    }
}
