using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Start_Form2();
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Победа!!! Вы успешно прошли все задания");
            this.Close();
        }

        private void Start_Form2()
        {
            Point start = panel2.Location;
            start.Offset(14, 32);
            Cursor.Position = PointToScreen(start);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Start_Form2();
        }
    }
}
