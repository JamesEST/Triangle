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
    public partial class TriangleForm : Form
    {
        ListView _listViewData;
        public TriangleForm()
        {
            //InitializeComponent();
            Text = "Стороны Треугольника";
            Width = 1081;
            Height = 458;

            _listViewData = new ListView()
            {
                Location = new Point(12, 12),
                Width = 439,
                Height = 308,
            };

            Controls.Add(_listViewData);



         














        }

        private void TriangleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
