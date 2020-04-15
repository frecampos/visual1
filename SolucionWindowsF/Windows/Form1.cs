using System;
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
            int x = 0;
            x = 88;
            MessageBox.Show("hola mundo real");
            if (x>8)
            {
                MessageBox.Show("nuevo mensaje");
            }
            else
            {
                MessageBox.Show("otro mensaje");
            }
        }
    }
}
