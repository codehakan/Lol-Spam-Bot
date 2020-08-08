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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" && textBox2.Text=="")
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre girişi yapın.\nDoğru bilgiler girilmeden panel açılmayacaktır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(textBox1.Text!="admin")
            {
                MessageBox.Show("Kullanıcı adını yanlış girdiniz.", "Kullanıcı adı yanlış", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textBox2.Text!="admin")
            {
                MessageBox.Show("Şifreyi yanlış girdiniz.", "Şifre yanlış",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form2 form2yeni = new Form2();
                form2yeni.Show();
                this.Hide();
            }
        }
    }
}
