using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        readonly string helloText = "Введите число в поле ниже";
        readonly string smaller = "Не угадали - меньше. Повторите ввод";
        readonly string bigger = "Не угадали - больше. Повторите ввод";
        readonly string winText = "Поздравляю! Вы угадали число!";
        readonly int from = 0, to = 100;
        int i = 0, x, y;
        readonly Random rnd = new Random();

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            i = 0;
            stepsLabel.Text = i.ToString();
            topLabel.Text = helloText;
            textBox1.Text = "";
            x = rnd.Next(from, to);
            resetBtn.Visible = false;
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            y = Convert.ToInt32(textBox1.Text);
            if (y < x)
            {
                i++;
                if (i < 6)
                {
                    stepsLabel.ForeColor = System.Drawing.Color.DarkGreen;
                }
                else if (i >= 6 && i < 8)
                {
                    stepsLabel.ForeColor = System.Drawing.Color.Gold;
                }
                else
                {
                    stepsLabel.ForeColor = System.Drawing.Color.IndianRed;
                }
                topLabel.Text = bigger;
                textBox1.Text = "";
                stepsLabel.Text = i.ToString();
            }
            else if (y > x)
            {
                i++;
                if (i < 6)
                {
                    stepsLabel.ForeColor = System.Drawing.Color.DarkGreen;
                }
                else if (i >= 6 && i < 8)
                {
                    stepsLabel.ForeColor = System.Drawing.Color.Gold;
                }
                else
                {
                    stepsLabel.ForeColor = System.Drawing.Color.IndianRed;
                }
                topLabel.Text = smaller;
                textBox1.Text = "";
                stepsLabel.Text = i.ToString();
            }
            else if (y == x)
            {
                if (i < 6)
                {
                    stepsLabel.ForeColor = System.Drawing.Color.DarkGreen;
                }
                else if (i >= 6 && i < 8)
                {
                    stepsLabel.ForeColor = System.Drawing.Color.Gold;
                }
                else
                {
                    stepsLabel.ForeColor = System.Drawing.Color.IndianRed;
                }
                topLabel.Text = winText;
                resetBtn.Visible = true;

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            topLabel.Text = helloText;
            x = rnd.Next(from, to);
            stepsLabel.Text = i.ToString();
        }
    }
}
