using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private float diagonal=200;
        private int speed = 20;
        public Form1()
        {
            InitializeComponent();
            this.moveButton.Width = (int)(4 * diagonal / Math.Sqrt(17));
            this.moveButton.Height = (int)(diagonal / Math.Sqrt(17));
            int X = Size.Width / 2-moveButton.Width/2;
            int Y = Size.Height / 2-moveButton.Height/2-tableLayoutPanel1.Height;
            this.moveButton.Location = new Point(X,Y);
            
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            int X = moveButton.Location.X;
            int Y = moveButton.Location.Y - speed;
            if (Y >= menuStrip1.Size.Height)
                this.moveButton.Location = new Point(X, Y);
            else
                MessageBox.Show("Form border!");
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            int X = moveButton.Location.X;
            int Y = moveButton.Location.Y + speed;
            if (Y <= this.Size.Height- tableLayoutPanel1.Size.Height-moveButton.Height-40)
                this.moveButton.Location = new Point(X, Y);
            else
                MessageBox.Show("Form border!");
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            int X = moveButton.Location.X- speed;
            int Y = moveButton.Location.Y;
            if (X >= 0)
                this.moveButton.Location = new Point(X, Y);
            else
                MessageBox.Show("Form border!");
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            int X = moveButton.Location.X+ speed;
            int Y = moveButton.Location.Y;
            if (X <= this.Size.Width-moveButton.Size.Width-14)
                this.moveButton.Location = new Point(X, Y);
            else
                MessageBox.Show("Form border!");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int X = Size.Width / 2 - moveButton.Width / 2;
            int Y = Size.Height / 2 - moveButton.Height / 2 - tableLayoutPanel1.Height;
            this.moveButton.Location = new Point(X, Y);
        }

        private void UP_menu_Click(object sender, EventArgs e)
        {
            upButton_Click(sender, e);
        }

        private void DOWN_menu_Click(object sender, EventArgs e)
        {
            downButton_Click(sender, e);
        }

        private void LEFT_menu_Click(object sender, EventArgs e)
        {
            leftButton_Click(sender, e);
        }

        private void RIGHT_menu_Click(object sender, EventArgs e)
        {
            rightButton_Click(sender, e);
        }
    }
}
