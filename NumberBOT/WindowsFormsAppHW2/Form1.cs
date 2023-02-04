using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHW2
{
    public partial class Form1 : Form
    {
        private int yoursPoints;
        private int botPoints;
        public Form1()
        {
            InitializeComponent();
            yoursPoints = 0;
            botPoints = 0;
            tbPointsY.Text = Convert.ToString(yoursPoints);
            tbPointsBot.Text = Convert.ToString(botPoints);
        }

        private void btnAddNum_Click(object sender, EventArgs e)
        {
            NumberAdd numberCreator = new NumberAdd();
            NumberBOT bot = new NumberBOT();
            if (numberCreator.ShowDialog() ==  DialogResult.OK)
            {
                if(numberCreator.numCreator._number < 0 
                || numberCreator.numCreator._number > 2000 
                || numberCreator.numCreator._amountOfTries == 0 
                || numberCreator.numCreator._amountOfTries < 0)
                {
                    botPoints +=10;
                    tbPointsBot.Text = Convert.ToString(botPoints);
                }
                else
                {
                    lbAddNumbers.Text = numberCreator.numCreator.ToString();
                    bot.searchedValue = numberCreator.numCreator._number;
                    bot.Search();
                    if (bot._triesAmount <= numberCreator.numCreator._amountOfTries)
                    {
                        botPoints++;
                        lbGuessedNumbers.ForeColor = Color.Green;
                        lbGuessedNumbers.Text = bot.ToString();
                        tbPointsBot.Text = Convert.ToString(botPoints);
                    }
                    else
                    {
                        yoursPoints++;
                        lbGuessedNumbers.ForeColor = Color.Red;
                        lbGuessedNumbers.Text = bot.ToString();
                        tbPointsY.Text = Convert.ToString(yoursPoints);
                    }
                }
                
            }
        }
    }
}