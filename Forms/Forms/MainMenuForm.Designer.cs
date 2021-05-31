namespace Forms
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HelloText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogOutLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EndButton = new System.Windows.Forms.Button();
            this.CarLabel = new System.Windows.Forms.Label();
            this.FareLabel = new System.Windows.Forms.Label();
            this.DriverLabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressCurr = new System.Windows.Forms.TextBox();
            this.RequestButton = new System.Windows.Forms.Button();
            this.AddressToGo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(147)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.HelloText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 100);
            this.panel1.TabIndex = 4;
            // 
            // HelloText
            // 
            this.HelloText.AutoSize = true;
            this.HelloText.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloText.ForeColor = System.Drawing.SystemColors.Control;
            this.HelloText.Location = new System.Drawing.Point(338, 54);
            this.HelloText.Name = "HelloText";
            this.HelloText.Size = new System.Drawing.Size(71, 27);
            this.HelloText.TabIndex = 1;
            this.HelloText.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(339, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donbass Taxi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.LogOutLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.AddressCurr);
            this.panel2.Controls.Add(this.RequestButton);
            this.panel2.Controls.Add(this.AddressToGo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 450);
            this.panel2.TabIndex = 5;
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.AutoSize = true;
            this.LogOutLabel.CausesValidation = false;
            this.LogOutLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogOutLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogOutLabel.Location = new System.Drawing.Point(217, 301);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(58, 16);
            this.LogOutLabel.TabIndex = 11;
            this.LogOutLabel.Text = "Log Out:";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutLabel_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.EndButton);
            this.panel3.Controls.Add(this.CarLabel);
            this.panel3.Controls.Add(this.FareLabel);
            this.panel3.Controls.Add(this.DriverLabel);
            this.panel3.Controls.Add(this.DiscountLabel);
            this.panel3.Controls.Add(this.DistanceLabel);
            this.panel3.Controls.Add(this.AboutLabel);
            this.panel3.Location = new System.Drawing.Point(435, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 330);
            this.panel3.TabIndex = 9;
            // 
            // EndButton
            // 
            this.EndButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(147)))), ((int)(((byte)(33)))));
            this.EndButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EndButton.Enabled = false;
            this.EndButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EndButton.Location = new System.Drawing.Point(111, 260);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(93, 42);
            this.EndButton.TabIndex = 10;
            this.EndButton.Text = "End";
            this.EndButton.UseMnemonic = false;
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // CarLabel
            // 
            this.CarLabel.AutoSize = true;
            this.CarLabel.CausesValidation = false;
            this.CarLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CarLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CarLabel.Location = new System.Drawing.Point(3, 178);
            this.CarLabel.Name = "CarLabel";
            this.CarLabel.Size = new System.Drawing.Size(31, 16);
            this.CarLabel.TabIndex = 5;
            this.CarLabel.Text = "Car:";
            // 
            // FareLabel
            // 
            this.FareLabel.AutoSize = true;
            this.FareLabel.CausesValidation = false;
            this.FareLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.FareLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FareLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FareLabel.Location = new System.Drawing.Point(3, 212);
            this.FareLabel.Name = "FareLabel";
            this.FareLabel.Size = new System.Drawing.Size(36, 16);
            this.FareLabel.TabIndex = 4;
            this.FareLabel.Text = "Fare:";
            // 
            // DriverLabel
            // 
            this.DriverLabel.AutoSize = true;
            this.DriverLabel.CausesValidation = false;
            this.DriverLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DriverLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DriverLabel.Location = new System.Drawing.Point(3, 142);
            this.DriverLabel.Name = "DriverLabel";
            this.DriverLabel.Size = new System.Drawing.Size(46, 16);
            this.DriverLabel.TabIndex = 3;
            this.DriverLabel.Text = "Driver:";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.CausesValidation = false;
            this.DiscountLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DiscountLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DiscountLabel.Location = new System.Drawing.Point(3, 105);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(61, 16);
            this.DiscountLabel.TabIndex = 2;
            this.DiscountLabel.Text = "Discount:";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DistanceLabel.Location = new System.Drawing.Point(3, 66);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(60, 16);
            this.DistanceLabel.TabIndex = 1;
            this.DistanceLabel.Text = "Distance:";
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AboutLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AboutLabel.Location = new System.Drawing.Point(3, 7);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(110, 16);
            this.AboutLabel.TabIndex = 0;
            this.AboutLabel.Text = "About your ride:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(147)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(24, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Where to go?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(147)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Where are you?";
            // 
            // AddressCurr
            // 
            this.AddressCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressCurr.Location = new System.Drawing.Point(147, 55);
            this.AddressCurr.Multiline = true;
            this.AddressCurr.Name = "AddressCurr";
            this.AddressCurr.Size = new System.Drawing.Size(216, 48);
            this.AddressCurr.TabIndex = 5;
            // 
            // RequestButton
            // 
            this.RequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(147)))), ((int)(((byte)(33)))));
            this.RequestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RequestButton.Location = new System.Drawing.Point(179, 213);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(153, 45);
            this.RequestButton.TabIndex = 4;
            this.RequestButton.Text = "Request a ride";
            this.RequestButton.UseMnemonic = false;
            this.RequestButton.UseVisualStyleBackColor = false;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // AddressToGo
            // 
            this.AddressToGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressToGo.Location = new System.Drawing.Point(147, 131);
            this.AddressToGo.Multiline = true;
            this.AddressToGo.Name = "AddressToGo";
            this.AddressToGo.Size = new System.Drawing.Size(216, 48);
            this.AddressToGo.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(194, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox AddressCurr;
        private System.Windows.Forms.Button RequestButton;
        private System.Windows.Forms.TextBox AddressToGo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HelloText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label FareLabel;
        private System.Windows.Forms.Label DriverLabel;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label CarLabel;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Label LogOutLabel;
    }
}