using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoldYourHorsesTester
{
    public partial class AddPlayerForm : Form
    {
        public string PlayerName { get; protected set; }

        public AddPlayerForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            PlayerName = playerNameTextBox.Text;
        }
    }
}
