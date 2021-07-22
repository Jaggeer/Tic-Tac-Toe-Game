using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form3 : Form
    {
        public string Winner;

        public Form3(string x)
        {
            InitializeComponent();
            Winner = x;
            if (Winner == "D")
            {
                label1.Text = "Draw! Play again?";
            }else if(Winner == "X"|| Winner == "O")
            {
                label1.Text = $"{Winner} wins! Play again?";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
