using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int addend1;
        int addend2;

        int minuend;
        int subtrahend;

        int multiplicand;
        int multiplier;

        int dividend;
        int divisor;

        int timeLeft;

        public void StartTheQuiz() 
        {
            timeLabel.BackColor = Color.Gray;
            timeLabel.ForeColor = Color.Black;

            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;

            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);

            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            timeLeft = 20;
            timeLabel.Text =  timeLeft.ToString() + " seconds";
            timer1.Start();


        }

        private bool CheckTheAnswer() 
        {
            if (    (addend1 + addend2 == sum.Value)
                &&  (minuend - subtrahend == difference.Value)
                && (dividend / divisor == quotient.Value)
                && (multiplicand * multiplier == product.Value)
                
                )
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void sum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void product_ValueChanged(object sender, EventArgs e)
        {

        }

        private void quotient_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You answered all of the questions correctly!", "Congratulations");
                timeLabel.BackColor = Color.Green;
                timeLabel.ForeColor = Color.White;
                startButton.Enabled = true;

            }
            else if (timeLeft == 5) 
            {
                timeLeft--;
                timeLabel.BackColor = Color.Red;
                timeLabel.ForeColor = Color.White;
                timeLabel.Text = timeLeft + " seconds";
            }

            else if (timeLeft > 0)
            {
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {

                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;

                timeLabel.BackColor = Color.Gray;
                timeLabel.ForeColor = Color.Black;
                startButton.Enabled = true;



            }
        }

        private void timeControl_Click(object sender, EventArgs e)
        {
            timeLabel.ForeColor = Color.Yellow;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null) 
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }

        }

        private void difference_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
