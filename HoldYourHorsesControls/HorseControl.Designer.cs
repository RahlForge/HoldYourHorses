namespace HoldYourHorsesTester
{
    partial class HorseControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.horseProgressBar = new System.Windows.Forms.ProgressBar();
            this.horseNumberLabel = new System.Windows.Forms.Label();
            this.horseStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // horseProgressBar
            // 
            this.horseProgressBar.Location = new System.Drawing.Point(38, 3);
            this.horseProgressBar.MarqueeAnimationSpeed = 1000;
            this.horseProgressBar.Name = "horseProgressBar";
            this.horseProgressBar.Size = new System.Drawing.Size(412, 23);
            this.horseProgressBar.TabIndex = 1;
            this.horseProgressBar.Tag = "2";
            // 
            // horseNumberLabel
            // 
            this.horseNumberLabel.AutoSize = true;
            this.horseNumberLabel.Font = new System.Drawing.Font("Moire", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horseNumberLabel.Location = new System.Drawing.Point(3, 5);
            this.horseNumberLabel.Name = "horseNumberLabel";
            this.horseNumberLabel.Size = new System.Drawing.Size(31, 19);
            this.horseNumberLabel.TabIndex = 2;
            this.horseNumberLabel.Text = "00";
            // 
            // horseStatusLabel
            // 
            this.horseStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horseStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.horseStatusLabel.Location = new System.Drawing.Point(456, 3);
            this.horseStatusLabel.Name = "horseStatusLabel";
            this.horseStatusLabel.Size = new System.Drawing.Size(46, 22);
            this.horseStatusLabel.TabIndex = 3;
            // 
            // HorseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.horseStatusLabel);
            this.Controls.Add(this.horseNumberLabel);
            this.Controls.Add(this.horseProgressBar);
            this.Name = "HorseControl";
            this.Size = new System.Drawing.Size(513, 29);
            this.Load += new System.EventHandler(this.HoldYourHorseContainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar horseProgressBar;
        private System.Windows.Forms.Label horseNumberLabel;
        private System.Windows.Forms.Label horseStatusLabel;
    }
}
