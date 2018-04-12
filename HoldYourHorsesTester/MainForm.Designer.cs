namespace HoldYourHorsesTester
{
    partial class MainForm
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
            this.rollButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.purseLabel = new System.Windows.Forms.Label();
            this.purseLabelLabel = new System.Windows.Forms.Label();
            this.nextRaceButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.deletePlayerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentRaceLabel = new System.Windows.Forms.Label();
            this.totalRacesTextBox = new System.Windows.Forms.TextBox();
            this.numberOfRacesLabel = new System.Windows.Forms.Label();
            this.horse12Control = new HoldYourHorsesTester.HorseControl();
            this.horse11Control = new HoldYourHorsesTester.HorseControl();
            this.horse10Control = new HoldYourHorsesTester.HorseControl();
            this.horse9Control = new HoldYourHorsesTester.HorseControl();
            this.horse8Control = new HoldYourHorsesTester.HorseControl();
            this.horse7Control = new HoldYourHorsesTester.HorseControl();
            this.horse6Control = new HoldYourHorsesTester.HorseControl();
            this.horse5Control = new HoldYourHorsesTester.HorseControl();
            this.horse4Control = new HoldYourHorsesTester.HorseControl();
            this.horse3Control = new HoldYourHorsesTester.HorseControl();
            this.horse2Control = new HoldYourHorsesTester.HorseControl();
            this.scoringTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(12, 426);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 34;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(93, 427);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(31, 22);
            this.resultLabel.TabIndex = 35;
            this.resultLabel.Text = "00";
            // 
            // purseLabel
            // 
            this.purseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purseLabel.Location = new System.Drawing.Point(417, 397);
            this.purseLabel.Name = "purseLabel";
            this.purseLabel.Size = new System.Drawing.Size(96, 22);
            this.purseLabel.TabIndex = 39;
            this.purseLabel.Text = "$00000.00";
            // 
            // purseLabelLabel
            // 
            this.purseLabelLabel.AutoSize = true;
            this.purseLabelLabel.Location = new System.Drawing.Point(367, 403);
            this.purseLabelLabel.Name = "purseLabelLabel";
            this.purseLabelLabel.Size = new System.Drawing.Size(44, 13);
            this.purseLabelLabel.TabIndex = 40;
            this.purseLabelLabel.Text = "PURSE";
            // 
            // nextRaceButton
            // 
            this.nextRaceButton.Location = new System.Drawing.Point(12, 397);
            this.nextRaceButton.Name = "nextRaceButton";
            this.nextRaceButton.Size = new System.Drawing.Size(75, 23);
            this.nextRaceButton.TabIndex = 42;
            this.nextRaceButton.Text = "Next Race";
            this.nextRaceButton.UseVisualStyleBackColor = true;
            this.nextRaceButton.Click += new System.EventHandler(this.nextRaceButton_Click);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(729, 397);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(95, 23);
            this.addPlayerButton.TabIndex = 43;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // deletePlayerButton
            // 
            this.deletePlayerButton.Location = new System.Drawing.Point(830, 397);
            this.deletePlayerButton.Name = "deletePlayerButton";
            this.deletePlayerButton.Size = new System.Drawing.Size(95, 23);
            this.deletePlayerButton.TabIndex = 44;
            this.deletePlayerButton.Text = "Delete Player";
            this.deletePlayerButton.UseVisualStyleBackColor = true;
            this.deletePlayerButton.Click += new System.EventHandler(this.deletePlayerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "SCORING";
            // 
            // currentRaceLabel
            // 
            this.currentRaceLabel.AutoSize = true;
            this.currentRaceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentRaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRaceLabel.Location = new System.Drawing.Point(93, 398);
            this.currentRaceLabel.Name = "currentRaceLabel";
            this.currentRaceLabel.Size = new System.Drawing.Size(31, 22);
            this.currentRaceLabel.TabIndex = 58;
            this.currentRaceLabel.Text = "00";
            // 
            // totalRacesTextBox
            // 
            this.totalRacesTextBox.Font = new System.Drawing.Font("Moire", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRacesTextBox.Location = new System.Drawing.Point(246, 396);
            this.totalRacesTextBox.MaxLength = 2;
            this.totalRacesTextBox.Name = "totalRacesTextBox";
            this.totalRacesTextBox.Size = new System.Drawing.Size(27, 27);
            this.totalRacesTextBox.TabIndex = 59;
            this.totalRacesTextBox.Text = "5";
            this.totalRacesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberOfRacesLabel
            // 
            this.numberOfRacesLabel.AutoSize = true;
            this.numberOfRacesLabel.Location = new System.Drawing.Point(130, 403);
            this.numberOfRacesLabel.Name = "numberOfRacesLabel";
            this.numberOfRacesLabel.Size = new System.Drawing.Size(110, 13);
            this.numberOfRacesLabel.TabIndex = 60;
            this.numberOfRacesLabel.Text = "NUMBER OF RACES";
            // 
            // horse12Control
            // 
            this.horse12Control.HorseNumber = 12;
            this.horse12Control.IsScratched = false;
            this.horse12Control.Location = new System.Drawing.Point(12, 362);
            this.horse12Control.Name = "horse12Control";
            this.horse12Control.RollsToWin = 3;
            this.horse12Control.Size = new System.Drawing.Size(513, 29);
            this.horse12Control.TabIndex = 57;
            // 
            // horse11Control
            // 
            this.horse11Control.HorseNumber = 11;
            this.horse11Control.IsScratched = false;
            this.horse11Control.Location = new System.Drawing.Point(12, 327);
            this.horse11Control.Name = "horse11Control";
            this.horse11Control.RollsToWin = 4;
            this.horse11Control.Size = new System.Drawing.Size(513, 29);
            this.horse11Control.TabIndex = 56;
            // 
            // horse10Control
            // 
            this.horse10Control.HorseNumber = 10;
            this.horse10Control.IsScratched = false;
            this.horse10Control.Location = new System.Drawing.Point(12, 292);
            this.horse10Control.Name = "horse10Control";
            this.horse10Control.RollsToWin = 5;
            this.horse10Control.Size = new System.Drawing.Size(513, 29);
            this.horse10Control.TabIndex = 55;
            // 
            // horse9Control
            // 
            this.horse9Control.HorseNumber = 9;
            this.horse9Control.IsScratched = false;
            this.horse9Control.Location = new System.Drawing.Point(12, 257);
            this.horse9Control.Name = "horse9Control";
            this.horse9Control.RollsToWin = 6;
            this.horse9Control.Size = new System.Drawing.Size(513, 29);
            this.horse9Control.TabIndex = 54;
            // 
            // horse8Control
            // 
            this.horse8Control.HorseNumber = 8;
            this.horse8Control.IsScratched = false;
            this.horse8Control.Location = new System.Drawing.Point(12, 222);
            this.horse8Control.Name = "horse8Control";
            this.horse8Control.RollsToWin = 7;
            this.horse8Control.Size = new System.Drawing.Size(513, 29);
            this.horse8Control.TabIndex = 53;
            // 
            // horse7Control
            // 
            this.horse7Control.HorseNumber = 7;
            this.horse7Control.IsScratched = false;
            this.horse7Control.Location = new System.Drawing.Point(12, 187);
            this.horse7Control.Name = "horse7Control";
            this.horse7Control.RollsToWin = 8;
            this.horse7Control.Size = new System.Drawing.Size(513, 29);
            this.horse7Control.TabIndex = 52;
            // 
            // horse6Control
            // 
            this.horse6Control.HorseNumber = 6;
            this.horse6Control.IsScratched = false;
            this.horse6Control.Location = new System.Drawing.Point(12, 152);
            this.horse6Control.Name = "horse6Control";
            this.horse6Control.RollsToWin = 7;
            this.horse6Control.Size = new System.Drawing.Size(513, 29);
            this.horse6Control.TabIndex = 51;
            // 
            // horse5Control
            // 
            this.horse5Control.HorseNumber = 5;
            this.horse5Control.IsScratched = false;
            this.horse5Control.Location = new System.Drawing.Point(12, 117);
            this.horse5Control.Name = "horse5Control";
            this.horse5Control.RollsToWin = 6;
            this.horse5Control.Size = new System.Drawing.Size(513, 29);
            this.horse5Control.TabIndex = 50;
            // 
            // horse4Control
            // 
            this.horse4Control.HorseNumber = 4;
            this.horse4Control.IsScratched = false;
            this.horse4Control.Location = new System.Drawing.Point(12, 82);
            this.horse4Control.Name = "horse4Control";
            this.horse4Control.RollsToWin = 5;
            this.horse4Control.Size = new System.Drawing.Size(513, 29);
            this.horse4Control.TabIndex = 49;
            // 
            // horse3Control
            // 
            this.horse3Control.HorseNumber = 3;
            this.horse3Control.IsScratched = false;
            this.horse3Control.Location = new System.Drawing.Point(12, 47);
            this.horse3Control.Name = "horse3Control";
            this.horse3Control.RollsToWin = 4;
            this.horse3Control.Size = new System.Drawing.Size(513, 29);
            this.horse3Control.TabIndex = 48;
            // 
            // horse2Control
            // 
            this.horse2Control.HorseNumber = 2;
            this.horse2Control.IsScratched = false;
            this.horse2Control.Location = new System.Drawing.Point(12, 12);
            this.horse2Control.Name = "horse2Control";
            this.horse2Control.RollsToWin = 3;
            this.horse2Control.Size = new System.Drawing.Size(513, 29);
            this.horse2Control.TabIndex = 47;
            // 
            // scoringTextBox
            // 
            this.scoringTextBox.Location = new System.Drawing.Point(534, 25);
            this.scoringTextBox.Multiline = true;
            this.scoringTextBox.Name = "scoringTextBox";
            this.scoringTextBox.Size = new System.Drawing.Size(391, 366);
            this.scoringTextBox.TabIndex = 61;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 464);
            this.Controls.Add(this.scoringTextBox);
            this.Controls.Add(this.numberOfRacesLabel);
            this.Controls.Add(this.totalRacesTextBox);
            this.Controls.Add(this.currentRaceLabel);
            this.Controls.Add(this.horse12Control);
            this.Controls.Add(this.horse11Control);
            this.Controls.Add(this.horse10Control);
            this.Controls.Add(this.horse9Control);
            this.Controls.Add(this.horse8Control);
            this.Controls.Add(this.horse7Control);
            this.Controls.Add(this.horse6Control);
            this.Controls.Add(this.horse5Control);
            this.Controls.Add(this.horse4Control);
            this.Controls.Add(this.horse3Control);
            this.Controls.Add(this.horse2Control);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletePlayerButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.nextRaceButton);
            this.Controls.Add(this.purseLabelLabel);
            this.Controls.Add(this.purseLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.rollButton);
            this.Name = "MainForm";
            this.Text = "Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label purseLabel;
        private System.Windows.Forms.Label purseLabelLabel;
        private System.Windows.Forms.Button nextRaceButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button deletePlayerButton;
        private System.Windows.Forms.Label label1;
        private HorseControl horse2Control;
        private HorseControl horse3Control;
        private HorseControl horse4Control;
        private HorseControl horse5Control;
        private HorseControl horse6Control;
        private HorseControl horse7Control;
        private HorseControl horse8Control;
        private HorseControl horse9Control;
        private HorseControl horse10Control;
        private HorseControl horse11Control;
        private HorseControl horse12Control;
        private System.Windows.Forms.Label currentRaceLabel;
        private System.Windows.Forms.TextBox totalRacesTextBox;
        private System.Windows.Forms.Label numberOfRacesLabel;
        private System.Windows.Forms.TextBox scoringTextBox;
    }
}

