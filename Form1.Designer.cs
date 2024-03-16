namespace SPEEDPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrchid;
            button1.Location = new Point(579, 71);
            button1.Name = "button1";
            button1.Size = new Size(427, 142);
            button1.TabIndex = 0;
            button1.Text = "KILL ALL CHROME TASKS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(131, 71);
            button2.Name = "button2";
            button2.Size = new Size(426, 142);
            button2.TabIndex = 1;
            button2.Text = "DISABLE CORTANA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSeaGreen;
            button3.Location = new Point(131, 239);
            button3.Name = "button3";
            button3.Size = new Size(426, 142);
            button3.TabIndex = 2;
            button3.Text = "CLEAR TEMP FILES";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(130, 580);
            button4.Name = "button4";
            button4.Size = new Size(427, 141);
            button4.TabIndex = 3;
            button4.Text = "EMPTY RECYCLE BIN";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumSlateBlue;
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(131, 408);
            button5.Name = "button5";
            button5.Size = new Size(426, 146);
            button5.TabIndex = 4;
            button5.Text = "KILL ALL EDGE TASKS";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DeepPink;
            button6.ForeColor = Color.Black;
            button6.Location = new Point(579, 580);
            button6.Name = "button6";
            button6.Size = new Size(427, 141);
            button6.TabIndex = 5;
            button6.Text = "FORCE RESTART PC";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // button7
            // 
            button7.BackColor = Color.GreenYellow;
            button7.ForeColor = Color.Black;
            button7.Location = new Point(1026, 72);
            button7.Name = "button7";
            button7.Size = new Size(427, 141);
            button7.TabIndex = 6;
            button7.Text = "DEFRAG HARD DRIVE";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Highlight;
            button8.ForeColor = Color.Black;
            button8.Location = new Point(1026, 240);
            button8.Name = "button8";
            button8.Size = new Size(427, 141);
            button8.TabIndex = 7;
            button8.Text = "RESTART EXPLORER";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1574, 808);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
