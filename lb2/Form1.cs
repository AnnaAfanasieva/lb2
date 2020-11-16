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

            universities.Add(new University(3, 8, 100, 12, "ХНУРЭ", 10, 7));

            universities.Add(new University(3, 8, 100, 12, "ХПИ", 10, 7));

            University khai = new University(new University(3, 8, 100, 12, "ХАИ", 10, 7));
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
            comboBox1.SelectedIndex = 0;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = universities[comboBox1.SelectedIndex].faculty.ToString();
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
            label9.Text = universities[comboBox1.SelectedIndex][1].ToString();
        }

        private void deletelaboratory_Click(object sender, EventArgs e)
        {
            universities[comboBox1.SelectedIndex].deletelab();
            label9.Text = universities[comboBox1.SelectedIndex][1].ToString();
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
            label11.Text = universities[comboBox1.SelectedIndex][2].ToString();
        }

        private void deleteroom_Click(object sender, EventArgs e)
        {
            universities[comboBox1.SelectedIndex].deleteroom();
            label11.Text = universities[comboBox1.SelectedIndex][2].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            universities[0] += universities[1];
            universities.Remove(universities[1]);
            initCombo();
        }

        private void Info_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Если вы пытаетесь изменить поле *Количество студентов*, но у вас не получается, то увеличте поле *Количество преподавателей* или наоборот, также работает с полями *Количество аудиторий* и *Количество персонала*, так как они взаимозависимы. Также любое число не может быть отрицательным!", "Важная информация");
        }



        class UniversityEqualityComparer : IEqualityComparer<University>
        {

            bool IEqualityComparer<University>.Equals(University firstun, University secondun)
            {
                bool equals = firstun.faculty == secondun.faculty &&
                    firstun.laboratory == secondun.laboratory && firstun.students == secondun.students && firstun.rooms == secondun.rooms
                    && firstun.univname.Equals(secondun.univname) && firstun.teachers == secondun.teachers && firstun.assistant == secondun.assistant;

                if (firstun == null && secondun == null)
                    return true;
                else if (firstun == null || secondun == null)
                    return false;
                else if (equals)
                    return true;
                else
                    return false;
            }

            int IEqualityComparer<University>.GetHashCode(University obj)
            {
                int hashCode = 1297206626;
                hashCode = hashCode * -1521134295 + obj.faculty.GetHashCode();
                hashCode = hashCode * -1521134295 + obj.laboratory.GetHashCode();
                hashCode = hashCode * -1521134295 + obj.students.GetHashCode();
                hashCode = hashCode * -1521134295 + obj.rooms.GetHashCode();
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(obj.univname);
                hashCode = hashCode * -1521134295 + obj.teachers.GetHashCode();
                hashCode = hashCode * -1521134295 + obj.assistant.GetHashCode();
                return hashCode;
            }
        }

    }
}
