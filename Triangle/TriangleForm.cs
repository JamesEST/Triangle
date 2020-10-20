using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class TriangleForm : Form
    {
        TextBox _TextBoxA, _TextBoxB, _TextBoxC;
        ListBox _listboxinfo;
        Button _btnStart;
        int karim = 1;
        public double a, b, c;

        public TriangleForm()
        { 
            //InitializeComponent();

            Text = "Стороны Треугольника";
            Width = 1081;
            Height = 458;

            _listboxinfo = new ListBox()
            {
                Location = new Point(12, 12),
                Width = 439,
                Height = 308,
            };

            _btnStart = new Button()
            {
                Location = new Point(894, 306),
                Width = 159,
                Height = 98,
            };
            _TextBoxA = new TextBox()
            {
                Location = new Point(818, 51),
                Width = 144,
                Height = 20,
            };
            _TextBoxB = new TextBox()
            {
                Location = new Point(818, 77),
                Width = 144,
                Height = 20
            };
            _TextBoxC = new TextBox()
            {
                Location = new Point(818, 103),
                Width = 144,
                Height = 20
            };


            _btnStart.Click += _btnStart_Click;

      

            Controls.Add(_TextBoxA);
            Controls.Add(_TextBoxB);
            Controls.Add(_TextBoxC);
            Controls.Add(_btnStart);
            Controls.Add(_listboxinfo);


    
            
          
        }

        private void _btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                
                int result = Int32.Parse(_TextBoxA.Text);
                a = Convert.ToDouble(_TextBoxA.Text);
                b = Convert.ToDouble(_TextBoxB.Text);
                c = Convert.ToDouble(_TextBoxC.Text);
                Triangle triangle = new Triangle(a, b, c);

               

                


                _listboxinfo.Items.Insert(0, "Сторона a :" + " " + triangle.outputA());
                _listboxinfo.Items.Insert(1, "Сторона b :" + " " + triangle.outputB());
                _listboxinfo.Items.Insert(2, "Сторона c :" + " " + triangle.outputC());
                _listboxinfo.Items.Insert(3, "Высота :" + " " + karim);
                _listboxinfo.Items.Insert(4, "Периметр" + " " + karim);
                _listboxinfo.Items.Insert(5, "Площадь" + " " + karim);
                _listboxinfo.Items.Insert(6, "Существует" + " " + karim);
            }
            catch (FormatException)
            {
                MessageBox.Show("Напиши правильное число", "Name");
            }
        }

        private void TriangleForm_Load(object sender, EventArgs e)
        {
        }
    }
}
