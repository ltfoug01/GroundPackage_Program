namespace Prog4
{
    partial class Form1
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
            this.originZipLbl = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.destZipLbl = new System.Windows.Forms.Label();
            this.lengthLbl = new System.Windows.Forms.Label();
            this.widthLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.originZipTextBox = new System.Windows.Forms.TextBox();
            this.destZipTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.sendToButton = new System.Windows.Forms.Button();
            this.sendFromButton = new System.Windows.Forms.Button();
            this.addPackageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originZipLbl
            // 
            this.originZipLbl.AutoSize = true;
            this.originZipLbl.Location = new System.Drawing.Point(38, 47);
            this.originZipLbl.Name = "originZipLbl";
            this.originZipLbl.Size = new System.Drawing.Size(83, 13);
            this.originZipLbl.TabIndex = 0;
            this.originZipLbl.Text = "Origin Zip Code:";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(80, 172);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(41, 13);
            this.heightLbl.TabIndex = 1;
            this.heightLbl.Text = "Height:";
            // 
            // destZipLbl
            // 
            this.destZipLbl.AutoSize = true;
            this.destZipLbl.Location = new System.Drawing.Point(12, 76);
            this.destZipLbl.Name = "destZipLbl";
            this.destZipLbl.Size = new System.Drawing.Size(109, 13);
            this.destZipLbl.TabIndex = 2;
            this.destZipLbl.Text = "Destination Zip Code:";
            // 
            // lengthLbl
            // 
            this.lengthLbl.AutoSize = true;
            this.lengthLbl.Location = new System.Drawing.Point(78, 108);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(43, 13);
            this.lengthLbl.TabIndex = 3;
            this.lengthLbl.Text = "Length:";
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(83, 139);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(38, 13);
            this.widthLbl.TabIndex = 4;
            this.widthLbl.Text = "Width:";
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(77, 205);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(44, 13);
            this.weightLbl.TabIndex = 5;
            this.weightLbl.Text = "Weight:";
            // 
            // originZipTextBox
            // 
            this.originZipTextBox.Location = new System.Drawing.Point(127, 44);
            this.originZipTextBox.Name = "originZipTextBox";
            this.originZipTextBox.Size = new System.Drawing.Size(100, 20);
            this.originZipTextBox.TabIndex = 0;
            // 
            // destZipTextBox
            // 
            this.destZipTextBox.Location = new System.Drawing.Point(127, 73);
            this.destZipTextBox.Name = "destZipTextBox";
            this.destZipTextBox.Size = new System.Drawing.Size(100, 20);
            this.destZipTextBox.TabIndex = 1;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(127, 105);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 2;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(127, 136);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 3;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(127, 169);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 4;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(127, 202);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 5;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(293, 44);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(156, 173);
            this.outputListBox.TabIndex = 12;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(455, 44);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 45);
            this.detailsButton.TabIndex = 7;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click_1);
            // 
            // sendToButton
            // 
            this.sendToButton.Location = new System.Drawing.Point(455, 173);
            this.sendToButton.Name = "sendToButton";
            this.sendToButton.Size = new System.Drawing.Size(75, 45);
            this.sendToButton.TabIndex = 9;
            this.sendToButton.Text = "Send to UofL";
            this.sendToButton.UseVisualStyleBackColor = true;
            this.sendToButton.Click += new System.EventHandler(this.sendToButton_Click);
            // 
            // sendFromButton
            // 
            this.sendFromButton.Location = new System.Drawing.Point(455, 108);
            this.sendFromButton.Name = "sendFromButton";
            this.sendFromButton.Size = new System.Drawing.Size(75, 45);
            this.sendFromButton.TabIndex = 8;
            this.sendFromButton.Text = "Send From UofL";
            this.sendFromButton.UseVisualStyleBackColor = true;
            this.sendFromButton.Click += new System.EventHandler(this.sendFromButton_Click);
            // 
            // addPackageButton
            // 
            this.addPackageButton.Location = new System.Drawing.Point(119, 238);
            this.addPackageButton.Name = "addPackageButton";
            this.addPackageButton.Size = new System.Drawing.Size(108, 23);
            this.addPackageButton.TabIndex = 6;
            this.addPackageButton.Text = "Add Package";
            this.addPackageButton.UseVisualStyleBackColor = true;
            this.addPackageButton.Click += new System.EventHandler(this.addPackageButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.addPackageButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 318);
            this.Controls.Add(this.addPackageButton);
            this.Controls.Add(this.sendFromButton);
            this.Controls.Add(this.sendToButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.destZipTextBox);
            this.Controls.Add(this.originZipTextBox);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.lengthLbl);
            this.Controls.Add(this.destZipLbl);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.originZipLbl);
            this.Name = "Form1";
            this.Text = "Prog4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originZipLbl;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Label destZipLbl;
        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.TextBox originZipTextBox;
        private System.Windows.Forms.TextBox destZipTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button sendToButton;
        private System.Windows.Forms.Button sendFromButton;
        private System.Windows.Forms.Button addPackageButton;
    }
}

