using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            string imie = textBox1.Text;
            string nazwisko = textBox2.Text;
            string data = dateTimePicker1.Text;
            if (textBox1.TextLength != 0 && textBox2.TextLength != 0)
            {
                MessageBox.Show("Brawo podales dane. " + imie + " " + nazwisko + " " + data);
            }
            else
            {
                MessageBox.Show("Nie podano wszystkich danych.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
