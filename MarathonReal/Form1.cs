using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarathonReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }
            
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label4.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут до старта марафона!";
        }
    }
}
