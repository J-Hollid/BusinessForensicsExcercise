using System;

namespace BusinessForensicsExcercies
{
    public partial class Form : System.Windows.Forms.Form
    {
        private UInt16 TargetNumber = 5;
        private UInt16 AttemptsMade = 0;
        private bool SuccessfulAttempt = false;

        public Form()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            try
            {
                UInt16 inputNumber = UInt16.Parse(this.tbInput.Text);
                if (inputNumber >= 20)
                {
                    throw new Exception();
                }
                else if (inputNumber != TargetNumber)
                {
                    IncorrectAttempt();
                }
                else
                {
                    CorrectAttempt();
                }
            }
            catch (Exception)
            {
                InvalidAttempt();
            }  
        }

        private void InvalidAttempt()
        {
            SuccessfulAttempt = false;
            this.lblMessage.Text = "Input was invalid, please enter a number between 1 and 20.";
        }

        private void IncorrectAttempt()
        {
            AttemptsMade++;
            this.lblMessage.Text = "Incorrect! You have currently had " + AttemptsMade + " tries." + ((AttemptsMade >= 3) ? " You have now exceeded the limit of 3 tries." : "");
        }

        private void CorrectAttempt()
        {
            AttemptsMade++;
            this.lblMessage.Text = "Congratulations, you have guessed correctly in " + AttemptsMade + " tries.";
        }
    }
}
