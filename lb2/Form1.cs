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
        University khpi;
        University khai;
        University khnpu;
        public Form1()
        {
            InitializeComponent();
            khnure = new University(3, 8, 100, 12, "University", 9, 7);
            khnure.univname = "KhNURE";
            khpi = new University(khnure);
            khpi.univname = "KhPI";
            khai = new University(khnure);
            khai.univname = "KhAI";
            khnpu = new University(khnure);
            khnpu.univname = "KhNPU";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = khnure.univname.ToString() ;
            
        }
    }
}
