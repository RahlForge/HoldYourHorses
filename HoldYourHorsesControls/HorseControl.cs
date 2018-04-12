using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoldYourHorsesTester
{
    public partial class HorseControl : UserControl
    {
        [Description("Number of the horse"),Category("Appearance")]
        public int HorseNumber
        {
            get { return int.Parse(horseNumberLabel.Text); }
            set { horseNumberLabel.Text = value.ToString(); }
        }

        [Description("Number of rolls required to win"),Category("Behavior")]
        public int RollsToWin
        {
            get { return horseProgressBar.Maximum / 10; }
            set { horseProgressBar.Maximum = value * 10; }
        }

        private bool isScratched;
        public bool IsScratched
        {
            get { return isScratched; }
            set
            {
                isScratched = value;
                if (isScratched)
                    horseStatusLabel.Text = "SCR";
                else
                    horseStatusLabel.Text = "";
            }
        }

        public HorseControl()
        {
            InitializeComponent();
        }

        private void HoldYourHorseContainer_Load(object sender, EventArgs e)
        {

        }

        public void ResetHorse()
        {
            IsScratched = false;
            horseProgressBar.Enabled = true;
            horseProgressBar.Value = horseProgressBar.Minimum;
        }

        public bool IsWinner()
        {
            if (horseProgressBar.Value >= horseProgressBar.Maximum)
            {
                horseStatusLabel.Text = "WIN!";
                return true;
            }
            return false;
        }

        public void PerformStep()
        {
            horseProgressBar.PerformStep();
        }
    }
}
