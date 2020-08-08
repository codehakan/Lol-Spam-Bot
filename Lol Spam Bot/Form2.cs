using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lol_Spam_Bot
{
    public partial class Form2 : Form
    {

        int Move;
        int Mouse_X;
        int Mouse_Y;


        public Form2()
        {
            InitializeComponent();
            menuler.BackColor = Color.FromArgb(41, 53, 65);
            logo.BackColor = Color.FromArgb(229, 126, 49);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void icerik_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y; 
        }

        private void icerik_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void icerik_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
    }
}
