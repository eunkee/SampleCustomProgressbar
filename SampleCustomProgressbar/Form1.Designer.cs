
namespace SampleCustomProgressbar
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
            this.progressBar1 = new SampleCustomProgressbar.CustomProgressBar();
            this.buttonIncrease = new System.Windows.Forms.Button();
            this.buttonDecrease = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 57);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(589, 37);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Text = null;
            this.progressBar1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressBar1.TextColor = System.Drawing.SystemColors.ControlText;
            this.progressBar1.TextFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressBar1.TextMargin = new System.Drawing.Point(1, 1);
            // 
            // buttonIncrease
            // 
            this.buttonIncrease.Location = new System.Drawing.Point(451, 11);
            this.buttonIncrease.Name = "buttonIncrease";
            this.buttonIncrease.Size = new System.Drawing.Size(91, 34);
            this.buttonIncrease.TabIndex = 1;
            this.buttonIncrease.Text = "Increase";
            this.buttonIncrease.UseVisualStyleBackColor = true;
            this.buttonIncrease.Click += new System.EventHandler(this.ButtonIncrease_Click);
            // 
            // buttonDecrease
            // 
            this.buttonDecrease.Location = new System.Drawing.Point(75, 11);
            this.buttonDecrease.Name = "buttonDecrease";
            this.buttonDecrease.Size = new System.Drawing.Size(91, 34);
            this.buttonDecrease.TabIndex = 2;
            this.buttonDecrease.Text = "Decrease";
            this.buttonDecrease.UseVisualStyleBackColor = true;
            this.buttonDecrease.Click += new System.EventHandler(this.ButtonDecrease_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(357, 11);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(91, 34);
            this.buttonPlus.TabIndex = 3;
            this.buttonPlus.Text = "Plus";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(169, 12);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(91, 34);
            this.buttonMinus.TabIndex = 4;
            this.buttonMinus.Text = "Minus";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(263, 11);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(91, 34);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 104);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonDecrease);
            this.Controls.Add(this.buttonIncrease);
            this.Controls.Add(this.progressBar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sample Custom ProgressBar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SampleCustomProgressbar.CustomProgressBar progressBar1;
        private System.Windows.Forms.Button buttonIncrease;
        private System.Windows.Forms.Button buttonDecrease;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonStop;
    }
}

