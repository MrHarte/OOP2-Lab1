namespace OOP2_Lab1
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.parkingPassLabel = new System.Windows.Forms.Label();
            this.loadExampleButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.buyPassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(141, 21);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(228, 27);
            this.nameTextBox.TabIndex = 0;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(141, 75);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(228, 27);
            this.phoneNumberTextBox.TabIndex = 1;
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(141, 128);
            this.emailAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(228, 27);
            this.emailAddressTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(23, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 20);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(23, 80);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(111, 20);
            this.phoneNumberLabel.TabIndex = 4;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(23, 133);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(106, 20);
            this.emailAddressLabel.TabIndex = 5;
            this.emailAddressLabel.Text = "Email Address:";
            // 
            // parkingPassLabel
            // 
            this.parkingPassLabel.AutoSize = true;
            this.parkingPassLabel.Location = new System.Drawing.Point(23, 187);
            this.parkingPassLabel.Name = "parkingPassLabel";
            this.parkingPassLabel.Size = new System.Drawing.Size(141, 20);
            this.parkingPassLabel.TabIndex = 6;
            this.parkingPassLabel.Text = "No person selected!";
            // 
            // loadExampleButton
            // 
            this.loadExampleButton.Location = new System.Drawing.Point(20, 240);
            this.loadExampleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadExampleButton.Name = "loadExampleButton";
            this.loadExampleButton.Size = new System.Drawing.Size(115, 31);
            this.loadExampleButton.TabIndex = 7;
            this.loadExampleButton.Text = "Load Example";
            this.loadExampleButton.UseVisualStyleBackColor = true;
            this.loadExampleButton.Click += new System.EventHandler(this.loadExampleButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(140, 240);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 31);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // buyPassButton
            // 
            this.buyPassButton.Location = new System.Drawing.Point(260, 240);
            this.buyPassButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buyPassButton.Name = "buyPassButton";
            this.buyPassButton.Size = new System.Drawing.Size(115, 31);
            this.buyPassButton.TabIndex = 9;
            this.buyPassButton.Text = "Buy Pass";
            this.buyPassButton.UseVisualStyleBackColor = true;
            this.buyPassButton.Click += new System.EventHandler(this.buyPassButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 303);
            this.Controls.Add(this.buyPassButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadExampleButton);
            this.Controls.Add(this.parkingPassLabel);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox emailAddressTextBox;
        private Label nameLabel;
        private Label phoneNumberLabel;
        private Label emailAddressLabel;
        private Label parkingPassLabel;
        private Button loadExampleButton;
        private Button saveButton;
        private Button buyPassButton;
    }
}