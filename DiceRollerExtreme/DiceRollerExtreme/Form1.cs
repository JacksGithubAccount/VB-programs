using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollerExtreme
{
    public partial class Form1 : Form
    {
        int totalInt = 0;
        int[] diceArray = new int[7];
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private  int rollDice(int amount, int type)
        {
            int totalAmount = 0;
            for(int i = 0; i < amount; i++)
            {
                totalAmount += random.Next(1, type + 1);
            }
            return totalAmount;
        }
        private void buttonRoll_Click(object sender, EventArgs e)
        {
            totalInt = 0;
            if (textBoxd4.Text == "")
            {
                diceArray[0] = 0;
            }
            else
            {
                diceArray[0] = int.Parse(textBoxd4.Text);
            }
            if (textBoxd6.Text == "")
            {
                diceArray[1] = 0;
            }
            else
            {
                diceArray[1] = int.Parse(textBoxd6.Text);
            }
            if (textBoxd8.Text == "")
            {
                diceArray[2] = 0;
            }
            else
            {
                diceArray[2] = int.Parse(textBoxd8.Text);
            }
            if (textBoxd10.Text == "")
            {
                diceArray[3] = 0;
            }
            else
            {
                diceArray[3] = int.Parse(textBoxd10.Text);
            }
            if (textBoxd12.Text == "")
            {
                diceArray[4] = 0;
            }
            else
            {
                diceArray[4] = int.Parse(textBoxd12.Text);
            }
            if (textBoxd20.Text == "")
            {
                diceArray[5] = 0;
            }
            else
            {
                diceArray[5] = int.Parse(textBoxd20.Text);
            }
            if (textBoxPercentile.Text == "")
            {
                diceArray[6] = 0;
            }
            else
            {
                diceArray[6] = int.Parse(textBoxPercentile.Text);
            }
            totalInt += rollDice(diceArray[0], 4);
            totalInt += rollDice(diceArray[1], 6);
            totalInt += rollDice(diceArray[2], 8);
            totalInt += rollDice(diceArray[3], 10);
            totalInt += rollDice(diceArray[4], 12);
            totalInt += rollDice(diceArray[5], 20);
            totalInt += rollDice(diceArray[6], 100);
            textBoxResults.Text = totalInt.ToString();
        }
    }
}
