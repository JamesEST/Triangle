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
        RadioButton _RadioBtnA, _RadioBtnB, _RadioBtnC;
        TextBox _TextBoxA, _TextBoxB, _TextBoxC;
        Label _LabelA, _LabelB, _LabelC, _LabelTitle, _LabelMain;
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
                Text = "Посчитать",
                Font = new System.Drawing.Font("Times New Roman", 15f)

            };
           
            //TextBox
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
                Height = 20,
            };
            _TextBoxC = new TextBox()
            {
                Location = new Point(818, 103),
                Width = 144,
                Height = 20
            };
            //Label
            _LabelA = new Label()
            {
                Location = new Point(735, 50),
                Text = "Сторона A",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10f)
            };
            _LabelB = new Label()
            {
                Location = new Point(735, 77),
                Text = "Сторона B",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10f)
            };
            _LabelC = new Label()
            {
                Location = new Point(735, 103),
                Text = "Сторона C",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10f)
            };
            _LabelTitle = new Label()
            {
                Location = new Point(723, 12),
                Text = "Условие",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 15f)
            };
            _LabelMain = new Label()
            {
                Location = new Point(457, 12),
                Size = new Size(61, 25),
                Text = "Дано",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 15f)
            };

            //radiobtn

            _RadioBtnA = new RadioButton()
            {
                Location = new Point(467, 50),
                Text= "Стороны",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10f)
            };
            _RadioBtnB = new RadioButton()
            {
                Location = new Point(467, 73),
                Size = new Size(156, 21),
                Text = "Две стороны и угол",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10f)
            };
            _RadioBtnC = new RadioButton()
            {
                Location = new Point(467, 96),
                Size = new Size(162, 21),
                Text = "Основание и высота",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10f)
            };

            _RadioBtnA.CheckedChanged += _RadioBtnA_CheckedChanged;
            _RadioBtnB.CheckedChanged += _RadioBtnB_CheckedChanged;
            _RadioBtnC.CheckedChanged += _RadioBtnC_CheckedChanged;






            _btnStart.Click += _btnStart_Click;


            Controls.Add(_LabelMain);
            Controls.Add(_LabelTitle);
            
            Controls.Add(_btnStart);
        
            Controls.Add(_RadioBtnA);
            Controls.Add(_RadioBtnB);
            Controls.Add(_RadioBtnC);
            Controls.Add(_listboxinfo);



            


        }

        private void _RadioBtnC_CheckedChanged(object sender, EventArgs e)
        {
            _LabelA.Text = "Сторона A";
            _LabelB.Text = "Сторона B";
            _LabelC.Text = "Угол";

            Controls.Add(_TextBoxA);
            Controls.Add(_TextBoxB);
            Controls.Add(_TextBoxC);
            Controls.Add(_LabelA);
            Controls.Add(_LabelB);
            Controls.Add(_LabelC);
        }

        private void _RadioBtnB_CheckedChanged(object sender, EventArgs e)
        {
            _LabelA.Text = "Сторона A";
            _LabelB.Text = "Высота треугольника";
   

            Controls.Add(_TextBoxA);
            Controls.Add(_TextBoxB);
            Controls.Remove(_TextBoxC);
            Controls.Add(_LabelA);
            Controls.Add(_LabelB);
            Controls.Remove(_LabelC);
        }

        private void _RadioBtnA_CheckedChanged(object sender, EventArgs e)
        {
            _LabelA.Text = "Сторона A";
            _LabelB.Text = "Сторона B";
            _LabelC.Text = "Сторона C";

            Controls.Add(_TextBoxA);
            Controls.Add(_TextBoxB);
            Controls.Add(_TextBoxC);
            Controls.Add(_LabelA);
            Controls.Add(_LabelB);
            Controls.Add(_LabelC);
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
                _listboxinfo.Items.Insert(3, "Высота :" + " " + triangle.Height());
                _listboxinfo.Items.Insert(4, "Периметр" + " " + karim);
                _listboxinfo.Items.Insert(5, "Площадь" + " " + karim);
                _listboxinfo.Items.Insert(6, "Существует" + " " + karim);
            }
            catch (FormatException)
            {
                MessageBox.Show("Напиши правильное число", "н");
            }
        }

        private void TriangleForm_Load(object sender, EventArgs e)
        {
        }
    }
}
