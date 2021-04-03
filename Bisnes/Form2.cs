using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bisnes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public class User
        {
            string lastname;
            string name;
            string otch;
            string gender;
            string datebirth;
            string login;
            string pass;
            string numphone;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != ""  && textBox5.Text != "" && textBox6.Text != "" && dateTimePicker1.Text != "" && maskedTextBox1.Text != "" && textBox1 == textBox3)
            {
                //User user = new User() { LastName = textBox5.Text, name = textBox6.Text, };

                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Заполните все поля, поле Отчество может быть пустым");
            }    
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox3.Image = new Bitmap(d.FileName);
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    string[] s = d.FileName.Split(new char[] { '\\' });
                    textBox7.Text = s[s.Length - 1];

                }
                catch
                {

                }
            }

        }
    }
}
