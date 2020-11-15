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
        List<University> universities;
        //University selectedUniversity;
      //  University khnure;
      //  University khpi;
      //  University khai;
       // University khnpu;
        public Form1()
        {
            InitializeComponent();
            universities = new List<University>();

            universities.Add(new University(3, 8, 100, 12, "ХНУРЭ", 9, 7));

            universities.Add(new University(3, 8, 90, 12, "ХПИ", 8, 7));

            University khai = new University(new University(3, 8, 100, 12, "ХАИ", 9, 7));
            universities.Add(khai);

            University khnpu = new University(khai);
            khnpu.univname = "ХНПУ";
            universities.Add(khnpu);

            // khnure = new University(3, 8, 100, 12, "University", 9, 7);
            //khnure.univname = "KhNURE";
            // khpi = new University(khnure);
            //  khpi.univname = "KhPI";
            //  universities.Add(khpi);
            //  khai = new University(khnure);
            //  khai.univname = "KhAI";
  
            initCombo();

        }

        private void initCombo()
        {
            comboBox1.Items.Clear();

            foreach (University univ in universities)
            {
                comboBox1.Items.Add(univ.univname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("change");
            //string str = comboBox1.SelectedItem.ToString();
            //foreach (University univ in universities)
            //{
            //    if (str.Equals(univ.univname))
            //    {

            //        selectedUniversity = univ;


            //        break;
            //    }
            //}

            label8.Text = universities[comboBox1.SelectedIndex].faculty.ToString() ;
            label9.Text = universities[comboBox1.SelectedIndex].laboratory.ToString();
            label10.Text = universities[comboBox1.SelectedIndex].students.ToString();
            label11.Text = universities[comboBox1.SelectedIndex].rooms.ToString();
            label12.Text = universities[comboBox1.SelectedIndex].univname.ToString();
            label13.Text = universities[comboBox1.SelectedIndex].teachers.ToString();
            label14.Text = universities[comboBox1.SelectedIndex].assistant.ToString();

        }
    }
}
