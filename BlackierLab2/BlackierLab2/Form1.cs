using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackierLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Chad Blackier, October 5th 2022, This program will do integer multiplication on the left hand side of the window and
        // will alternate showing a picture and a short description of the picture on the right hand side.

        //Places the picture box over the data label and hides it.
        private void btnPicture_Click(object sender, EventArgs e)
        {
            picWeasley.Show();
            lblData.Hide();
        }
        //Hides both the picture and the data label.
        private void btnHide_Click(object sender, EventArgs e)
        {
            picWeasley.Hide();
            lblData.Hide();
        }
        //Resets the text boxes and answer label. Places the cursour at the Number label to start again.
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMulti.Clear();
            txtNum.Clear();
            lblAnswer.Text = "";
            txtNum.Focus();
        }
        //Places the data label over the picture box and hides it.
        private void btnData_Click(object sender, EventArgs e)
        {
            lblData.Text = lblTopic.Text + ". He just turned 2 years old. He is super snuggly in the mornings.\n " + "\n"+
                "He loves to go outside.Sometimes in my spare time I will go walking through the woods with him.He doesnt go too far and like having company.\n " +"\n"+
                "He aslo has two brothers he like to nag and wrestle with. Even if they dont want to all the time.";

            lblData.Show();
            picWeasley.Hide();
        }
        //Opens a message box with a short description of the image in the picture box.
        private void picWeasley_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Weasley looking silly as usual.", "Chad Blackier");
        }
        //Does multiplication using number input from the user.
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Initialize local variable to use in calculation
            int multiplier, number, answer;

            //Converts string data typ to integer for calculation.

            multiplier = Convert.ToInt32(txtMulti.Text);
            number = Convert.ToInt32(txtNum.Text);

            //Doing the calculation and set the answer

            answer = number * multiplier;

            //Converts answer integer into a String to show in text box.

            lblAnswer.Text = answer.ToString();

        }

        //Closes the application.

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
