using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessForensicsExcercies
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, System.EventArgs e)
        {
            this.lblMessage.Text = "You clicked submit";  
        }
    }
}
