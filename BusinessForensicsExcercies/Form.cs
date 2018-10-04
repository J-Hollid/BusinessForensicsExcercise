using System;

namespace BusinessForensicsExcercies
{
    // Class for handling UI events in this form.
    public partial class Form : System.Windows.Forms.Form
    {
        private UInt16 TargetNumber = 5;
        private UInt16 AttemptsMade = 0;

        public Form()
        {
            InitializeComponent();
        }

        // Onclick event handler for the submit button, tries to compare inputted
        // number against the target number and informs the user if their input
        // is incorrect, correct, how many attempts they've made or invalid input.
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

        // Function for handling invalid attempts.
        private void InvalidAttempt()
        {
            this.lblMessage.Text = "Input was invalid, please enter a number between 1 and 20.";
        }

        // Function for handling incorrect attempts.
        private void IncorrectAttempt()
        {
            AttemptsMade++;
            if (AttemptsMade >= 3)
            {
                this.btnSubmit.Enabled = false;
                this.tbInput.Enabled = false;
                this.lblMessage.Text = "Incorrect! You have now exceeded the limit of 3 tries.";
            }
            this.lblMessage.Text = "Incorrect! You have currently had " + AttemptsMade + " tries.";
        }

        // Function for handling correct attempts.
        private void CorrectAttempt()
        {
            AttemptsMade++;
            this.btnSubmit.Enabled = false;
            this.tbInput.Enabled = false;
            this.lblMessage.Text = "Congratulations, you have guessed correctly in " + AttemptsMade + " tries.";
        }
    }
}
