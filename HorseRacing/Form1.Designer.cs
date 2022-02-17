namespace HorseRacing
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.customProgressBar1 = new DancingBar.CustomProgressBar();
            this.customProgressBar2 = new DancingBar.CustomProgressBar();
            this.customProgressBar3 = new DancingBar.CustomProgressBar();
            this.customProgressBar4 = new DancingBar.CustomProgressBar();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(517, 63);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(908, 140);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "button1";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // customProgressBar1
            // 
            this.customProgressBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customProgressBar1.Color = System.Drawing.Color.Green;
            this.customProgressBar1.Location = new System.Drawing.Point(75, 294);
            this.customProgressBar1.MaxValue = 1000;
            this.customProgressBar1.Name = "customProgressBar1";
            this.customProgressBar1.RectangleSize = 20;
            this.customProgressBar1.Size = new System.Drawing.Size(1700, 100);
            this.customProgressBar1.TabIndex = 1;
            this.customProgressBar1.Value = 0;
            // 
            // customProgressBar2
            // 
            this.customProgressBar2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customProgressBar2.Color = System.Drawing.Color.SaddleBrown;
            this.customProgressBar2.Location = new System.Drawing.Point(75, 468);
            this.customProgressBar2.MaxValue = 1000;
            this.customProgressBar2.Name = "customProgressBar2";
            this.customProgressBar2.RectangleSize = 20;
            this.customProgressBar2.Size = new System.Drawing.Size(1700, 100);
            this.customProgressBar2.TabIndex = 2;
            this.customProgressBar2.Value = 0;
            // 
            // customProgressBar3
            // 
            this.customProgressBar3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customProgressBar3.Color = System.Drawing.Color.Magenta;
            this.customProgressBar3.Location = new System.Drawing.Point(75, 646);
            this.customProgressBar3.MaxValue = 1000;
            this.customProgressBar3.Name = "customProgressBar3";
            this.customProgressBar3.RectangleSize = 20;
            this.customProgressBar3.Size = new System.Drawing.Size(1700, 100);
            this.customProgressBar3.TabIndex = 3;
            this.customProgressBar3.Value = 0;
            // 
            // customProgressBar4
            // 
            this.customProgressBar4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customProgressBar4.Color = System.Drawing.Color.Indigo;
            this.customProgressBar4.Location = new System.Drawing.Point(75, 822);
            this.customProgressBar4.MaxValue = 1000;
            this.customProgressBar4.Name = "customProgressBar4";
            this.customProgressBar4.RectangleSize = 20;
            this.customProgressBar4.Size = new System.Drawing.Size(1700, 100);
            this.customProgressBar4.TabIndex = 4;
            this.customProgressBar4.Value = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.customProgressBar4);
            this.Controls.Add(this.customProgressBar3);
            this.Controls.Add(this.customProgressBar2);
            this.Controls.Add(this.customProgressBar1);
            this.Controls.Add(this.buttonRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private DancingBar.CustomProgressBar customProgressBar1;
        private DancingBar.CustomProgressBar customProgressBar2;
        private DancingBar.CustomProgressBar customProgressBar3;
        private DancingBar.CustomProgressBar customProgressBar4;
    }
}
