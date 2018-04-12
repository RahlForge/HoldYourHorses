using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoldYourHorsesPlayers;

namespace HoldYourHorsesTester
{
    public partial class DeletePlayerForm : Form
    {
        public List<Player> Players { get; set; }

        public DeletePlayerForm(List<Player> players)
        {
            InitializeComponent();

            Players = players;
            foreach (Player p in Players)
                playersCheckedListBox.Items.Add(p.Name);
            playersCheckedListBox.SelectedIndex = 0;
        }

        private void okButton_Click(object sender, EventArgs e)
        {            
            for (int i = Players.Count - 1; i >= 0; i--)
                if (playersCheckedListBox.CheckedIndices.IndexOf(i) >= 0)
                    Players.RemoveAt(i);
        }
    }
}
