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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{ENTER}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = true;
            textBox1.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F5)
            {
                button1_Click(button1, new EventArgs());
            }
            if(e.KeyCode==Keys.F6)
            {
                button2_Click(button2, new EventArgs());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                textBox1.Text = "--> " + checkBox1.Text.ToString() + " <--";
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox1.Text = "--> " + checkBox2.Text.ToString() + " <--";
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox1.Text = "--> " + checkBox3.Text.ToString() + " <--";
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox1.Text = "--> " + checkBox4.Text.ToString() + " <--";
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox1.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox1.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox1.Text = "--> " + checkBox5.Text.ToString() + " <--";
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox1.Enabled = false;
                checkBox6.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox1.Enabled = true;
                checkBox6.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox1.Text = "--> " + checkBox6.Text.ToString() + " <--";
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox1.Enabled = true;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program reload58(hakanbey) tarafından yapılmıştır.\n\nİletişim: code.hakan@gmail.com", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3yeni = new Form3();
            form3yeni.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 yeniform = new Form3();
            yeniform.Show();
        }
    }
}
