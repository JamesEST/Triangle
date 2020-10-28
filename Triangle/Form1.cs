using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();//Очистка формы от значений
               

            }
            if (txtA.Text.Length > 0 && txtB.Text.Length > 0 && txtC.Text.Length > 0) // Проверка на введённые символы
            {
                double a, b, c;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                Triangle triangle = new Triangle(a, b, c);
                listView1.Items.Add("Сторона a");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");
                listView1.Items.Add("Высота");
                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Существует?");
                listView1.Items.Add("Спецификатор");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());
                listView1.Items[2].SubItems.Add(triangle.outputC());
                listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Height()));//Высота
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter()));
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Surface()));
                /*
                if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Cуществует"); }
                    if (a == b && b == c && c == b) { listView1.Items[7].SubItems.Add("Равносторонний"); pictureBox1.Image = Properties.Resources._1; }
                    else if (a == b || b == c || c == a) { listView1.Items[7].SubItems.Add("Равнобедренный"); pictureBox1.Image = Properties.Resources._2; }
                    else if (a != b && a != c && b != c) { listView1.Items[7].SubItems.Add("Разносторонний"); pictureBox1.Image = Properties.Resources._3; }
                else listView1.Items[6].SubItems.Add("Не существует");
*/
             





            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TriangleForm f2 = new TriangleForm();
            f2.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
