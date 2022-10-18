using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_5
{
    public partial class Form1 : Form
    {
        int rand_num;

        public Form1()
        {
            InitializeComponent();
        }

        public int generate_rand_num()
        {
            Random rnd = new Random();
            rand_num = rnd.Next(1, 101);
            return rand_num;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand_num = generate_rand_num();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value < rand_num)
            {
                MessageBox.Show("The number is too low!");
            }else if(numericUpDown1.Value > rand_num)
            {
                MessageBox.Show("The number is too high!");
            }else
            {
                MessageBox.Show("You guessed correctly! Try to guess the new number");
                rand_num = generate_rand_num();
            }
        }

    }
}
