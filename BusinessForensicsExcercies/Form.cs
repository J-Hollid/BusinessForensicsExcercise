using System;

namespace BusinessForensicsExcercies
{
    public partial class Form : System.Windows.Forms.Form
    {
        private UInt16 TargetNumber = 5;

        public Form()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            try
            {
                UInt16 inputNumber = UInt16.Parse(this.tbInput.Text);
                if (inputNumber > 20)
                {
                    throw new Exception();
                }
                else if (inputNumber == TargetNumber)
                {
                    this.lblMessage.Text = "Congratulations, you have guessed correctly.";
                }
            }
            catch
            {
                this.lblMessage.Text = "Input was invalid, please enter a number between 1 and 20.";
            }  
        }
    }
}
