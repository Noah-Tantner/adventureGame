namespace adventureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.option3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Peru;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(604, 179);
            this.outputLabel.TabIndex = 0;
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox.Image = ((System.Drawing.Image)(resources.GetObject("imageBox.Image")));
            this.imageBox.Location = new System.Drawing.Point(17, 206);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(599, 192);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 1;
            this.imageBox.TabStop = false;
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.Location = new System.Drawing.Point(101, 420);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(423, 45);
            this.option1Label.TabIndex = 2;
            this.option1Label.Text = "option1Label";
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.Location = new System.Drawing.Point(101, 480);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(424, 45);
            this.option2Label.TabIndex = 3;
            this.option2Label.Text = "option2Label";
            // 
            // option1Button
            // 
            this.option1Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("option1Button.BackgroundImage")));
            this.option1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option1Button.Location = new System.Drawing.Point(17, 416);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(58, 49);
            this.option1Button.TabIndex = 4;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("option2Button.BackgroundImage")));
            this.option2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option2Button.Location = new System.Drawing.Point(17, 480);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(58, 45);
            this.option2Button.TabIndex = 5;
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("option3Button.BackgroundImage")));
            this.option3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option3Button.Location = new System.Drawing.Point(17, 541);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(58, 45);
            this.option3Button.TabIndex = 6;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Visible = false;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option3Label
            // 
            this.option3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.Location = new System.Drawing.Point(101, 541);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(424, 45);
            this.option3Label.TabIndex = 7;
            this.option3Label.Text = "option3Label";
            this.option3Label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(628, 592);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "German Festival Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label option3Label;
    }
}

