using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Cursor.Clip = new Rectangle(this.Location, this.Size);

            Move_to_start();
        }

        private void Label11_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Вы прошли 1 уровень лабиринта");
            Form2 form2 = new();
            Hide();
            form2.ShowDialog();
        }

        private void Move_to_start()
        {
            Point start_point = panel1.Location;
            start_point.Offset(14, 32);
            Cursor.Position = PointToScreen(start_point);
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            Move_to_start();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            Cursor.Clip = Bounds;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Clip = this.Bounds;
        }
    }
}