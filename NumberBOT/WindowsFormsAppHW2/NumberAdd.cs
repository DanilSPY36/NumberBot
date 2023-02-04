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
    public partial class NumberAdd : Form
    {
        public NumberCreator numCreator { get; set; }
        int num1, num2;
        public NumberAdd()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            numCreator = new NumberCreator();
            
            if(int.TryParse(tbNumber.Text, out num1) && int.TryParse(tbTries.Text, out num2))
            {
                if(0 > num1 || num1 > 2000 || num2 == 0 || num2 < 0)
                {
                    var res = MessageBox.Show("Когда ты обманываешь,\nты обманываешь в первую очередь\nсамого себя",
                                    "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (res == DialogResult.Cancel)
                    {
                        tbNumber.Text = "";
                        tbTries.Text = "";
                    }
                    else
                    {
                        numCreator._number = Convert.ToInt32(tbNumber.Text);
                        numCreator._amountOfTries = Convert.ToInt32(tbTries.Text);
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    numCreator._number = Convert.ToInt32(tbNumber.Text);
                    numCreator._amountOfTries = Convert.ToInt32(tbTries.Text);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var res = MessageBox.Show("какие-то буквы\nвместо чисел", "Attention!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (res == DialogResult.Retry)
                {
                    tbNumber.Text = "";
                    tbTries.Text = "";
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }

        }
    }
}