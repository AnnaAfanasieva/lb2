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

        public Form1()
        {
            InitializeComponent();
            universities = new List<University>();

            universities.Add(new University(3, 8, 100, 12, "ХНУРЭ", 9, 7));

            universities.Add(new University(3, 8, 100, 12, "ХПИ", 9, 7));

            University khai = new University(new University(3, 8, 100, 12, "ХАИ", 9, 7));
            universities.Add(khai);

            University khnpu = new University(khai);
            khnpu.univname = "ХНПУ";
            universities.Add(khnpu);
  
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

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("change");

            label8.Text = universities[comboBox1.SelectedIndex].faculty.ToString() ;
            label9.Text = universities[comboBox1.SelectedIndex].laboratory.ToString();
            label10.Text = universities[comboBox1.SelectedIndex].students.ToString();
            label11.Text = universities[comboBox1.SelectedIndex].rooms.ToString();
            label12.Text = universities[comboBox1.SelectedIndex].univname.ToString();
            label13.Text = universities[comboBox1.SelectedIndex].teachers.ToString();
            label14.Text = universities[comboBox1.SelectedIndex].assistant.ToString();

        }

        private void addlaboratory_Click(object sender, EventArgs e)
        {
            universities[comboBox1.SelectedIndex].addlab();
            label9.Text = universities[comboBox1.SelectedIndex].laboratory.ToString();
        }

        private void deletelaboratory_Click(object sender, EventArgs e)
        {
            universities[comboBox1.SelectedIndex].deletelab();
            label9.Text = universities[comboBox1.SelectedIndex].laboratory.ToString();
        }

        private void addstudent_Click(object sender, EventArgs e)
        {
            universities[comboBox1.SelectedIndex].addstud();
            label10.Text = universities[comboBox1.SelectedIndex].students.ToString();
        }

        private void deletestudent_Click(object sender, EventArgs e)
        {
            universities[comboBox1.SelectedIndex].deletestud();
            label10.Text = universities[comboBox1.SelectedIndex].students.ToString();
        }

        private void addroom_Click(object sender, EventArgs e)
        {
            universities[comboBox1.SelectedIndex].addroom();
            label11.Text = universities[comboBox1.SelectedIndex].rooms.ToString();
        }

        private void deleteroom_Click(object sender, EventArgs e)
        {
            universities[comboBox1.SelectedIndex].deleteroom();
            label11.Text = universities[comboBox1.SelectedIndex].rooms.ToString();
        }

        private void addteacher_Click(object sender, EventArgs e)
        {
            universities[comboBox1.SelectedIndex].addteach();
            label13.Text = universities[comboBox1.SelectedIndex].teachers.ToString();
        }

        private void deleteteacher_Click(object sender, EventArgs e)
        {
            universities[comboBox1.SelectedIndex].deleteteach();
            label13.Text = universities[comboBox1.SelectedIndex].teachers.ToString();
        }

        private void addassistant_Click(object sender, EventArgs e)
        {
            universities[comboBox1.SelectedIndex].addassis();
            label14.Text = universities[comboBox1.SelectedIndex].assistant.ToString();
        }

        private void deleteassistant_Click(object sender, EventArgs e)
        {
            universities[comboBox1.SelectedIndex].deleteassis();
            label14.Text = universities[comboBox1.SelectedIndex].assistant.ToString();
        }
    }
}
