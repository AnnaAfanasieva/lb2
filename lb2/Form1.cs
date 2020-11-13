using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb2
{
    public partial class Form1 : Form
    {
        University khnure;
        public Form1()
        {
            InitializeComponent();
            khnure = new University();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = khnure.faculty.ToString() ;
            
        }
    }
}
