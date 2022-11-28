using System.Windows.Forms.VisualStyles;

namespace SimplifiedPerceptron
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TestButton = new System.Windows.Forms.Button();
            this.TrainButton = new System.Windows.Forms.Button();
            this.TopLabel = new System.Windows.Forms.Label();
            this.NumberInput = new System.Windows.Forms.TextBox();
            this.CurrentNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(482, 83);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(94, 29);
            this.TestButton.TabIndex = 0;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButtonClick);
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(251, 83);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(94, 29);
            this.TrainButton.TabIndex = 1;
            this.TrainButton.Text = "Train";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButtonClick);
            // 
            // OutputLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(351, 25);
            this.TopLabel.Name = "OutputLabel";
            this.TopLabel.Size = new System.Drawing.Size(127, 20);
            this.TopLabel.TabIndex = 2;
            this.TopLabel.Text = "Training Number: ";
            // 
            // NumberInput
            // 
            this.NumberInput.Location = new System.Drawing.Point(351, 83);
            this.NumberInput.Name = "NumberInput";
            this.NumberInput.Size = new System.Drawing.Size(125, 27);
            this.NumberInput.TabIndex = 3;
            // 
            // CurrentNumber
            // 
            this.CurrentNumber.AutoSize = true;
            this.CurrentNumber.Location = new System.Drawing.Point(484, 25);
            this.CurrentNumber.Name = "CurrentNumber";
            this.CurrentNumber.Size = new System.Drawing.Size(27, 20);
            this.CurrentNumber.TabIndex = 4;
            this.CurrentNumber.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CurrentNumber);
            this.Controls.Add(this.NumberInput);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.TrainButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button TestButton;
        private Button TrainButton;
        private Label TopLabel;
        private TextBox NumberInput;
        private Label CurrentNumber;
    }
}