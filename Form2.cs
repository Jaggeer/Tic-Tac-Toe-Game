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
    public partial class Form2 : Form
    {
        public char CurrentMove = 'X';
        public string Winner;
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (String.IsNullOrWhiteSpace(button.Text))
            {
                button.Text = Char.ToString(CurrentMove);
                if (CurrentMove == 'X')
                {
                    CurrentMove = 'O';
                }
                else
                {
                    CurrentMove = 'X';
                }
                turn_label.Text = $"{CurrentMove} move";
            }

            if(Win() == "X")
            {
                Winner = "X";
                Form3 f3 = new Form3(Winner);
                this.Hide();
                f3.ShowDialog();
                Application.Exit();
            }
            else if(Win() == "O")
            {
                Winner = "O";
                Form3 f3 = new Form3(Winner);
                this.Hide();
                f3.ShowDialog();
                Application.Exit();
            }

            if(IsDraw() == true)
            {
                Winner = "D";
                Form3 f3 = new Form3(Winner);
                this.Hide();
                f3.ShowDialog();
                Application.Exit();
            }
        }

        private bool IsDraw()
        {
            Button[] btn = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            int counter = 0;
            for (int i = 0; i < 9; i++)
            {
                if (btn[i].Text == "X" || btn[i].Text == "O")
                    counter++;
            }
            if (counter == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string Win()
        {
            Button[] btn = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            if(btn[0].Text == btn[1].Text && btn[1].Text == btn[2].Text)
            {
                return btn[0].Text;
            }else if(btn[3].Text == btn[4].Text && btn[4].Text == btn[5].Text)
            {
                return btn[4].Text;
            }else if(btn[6].Text == btn[7].Text && btn[7].Text == btn[8].Text)
            {
                return btn[7].Text;
            }else if(btn[0].Text == btn[3].Text && btn[3].Text == btn[6].Text)
            {
                return btn[0].Text;
            }else if(btn[1].Text == btn[4].Text && btn[4].Text == btn[7].Text)
            {
                return btn[1].Text;
            }else if(btn[2].Text == btn[5].Text && btn[5].Text == btn[8].Text)
            {
                return btn[2].Text;
            }else if(btn[0].Text == btn[4].Text && btn[4].Text == btn[8].Text)
            {
                return btn[0].Text;
            }else if(btn[2].Text == btn[4].Text && btn[4].Text == btn[6].Text)
            {
                return btn[2].Text;
            }
            return "n";
        }

    }
}
