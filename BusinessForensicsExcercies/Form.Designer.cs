namespace BusinessForensicsExcercies
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plMainPanel = new System.Windows.Forms.Panel();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.plMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // plMainPanel
            // 
            this.plMainPanel.Controls.Add(this.btnSubmit);
            this.plMainPanel.Controls.Add(this.lblMessage);
            this.plMainPanel.Controls.Add(this.lblInput);
            this.plMainPanel.Controls.Add(this.tbInput);
            this.plMainPanel.Location = new System.Drawing.Point(-1, 0);
            this.plMainPanel.Name = "plMainPanel";
            this.plMainPanel.Size = new System.Drawing.Size(426, 123);
            this.plMainPanel.TabIndex = 0;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(197, 37);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(137, 20);
            this.tbInput.TabIndex = 0;
            
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(20, 40);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(171, 13);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Enter a number between 1 and 20:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(23, 57);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(340, 37);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 125);
            this.Controls.Add(this.plMainPanel);
            this.Name = "Form";
            this.Text = "Form1";
            this.plMainPanel.ResumeLayout(false);
            this.plMainPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel plMainPanel;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnSubmit;
    }
}

