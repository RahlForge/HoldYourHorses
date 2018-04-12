using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PlayingCards.Cards;
using PlayingCards.Decks;
using HoldYourHorsesPlayers;

namespace HoldYourHorsesTester
{
    public partial class MainForm : Form
    {
        private enum GameState { Begin, Play, EndRace, WinGame }
        private GameState gameState = GameState.Begin;
        private decimal purse;
        private PokerDeck deck;
        private List<Player> players;
        private List<HorseControl> horses;
        private int winningNumber;
        private int currentRace;
        private int totalRaces;

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            horses = new List<HorseControl>();
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(HorseControl))
                {
                    horses.Add((HorseControl)c);
                }
            }

            players = new List<Player>();

            deck = new PokerDeck(new List<StandardSuit>(), 
                new List<StandardRank> { StandardRank.Ace, StandardRank.King });

            ResetForNextRace();
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private void DisplayPlayers()
        {
            scoringTextBox.Clear();
            foreach (Player p in players)
            {
                string playerShow = p.Name + " - " + String.Format("${0}", p.Winnings);
                if (p.CardCount > 0)
                {
                    playerShow += " - ";
                    foreach (StandardCard sc in p.Cards)
                    {
                        playerShow += " " + sc.rank.ToString() + " ";
                    }
                }
                scoringTextBox.AppendText(playerShow + "\n");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void DealCards()
        {
            deck.Shuffle();
            Card[,] cards = deck.Deal(players.Count, 44);

            for (int i = 0; i < cards.GetLength(0); i++)
            {
                for (int j = 0; j < cards.GetLength(1); j++)
                {
                    if (cards[i, j] != null)
                        players[i].GiveCard((StandardCard)cards[i, j]);
                }
            }

            DisplayPlayers();
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayPurse()
        {
            purseLabel.Text = String.Format("${0}", purse);
        }

        /// <summary>
        /// 
        /// </summary>
        private void DivideWinnings()
        {
            int totalCards = 0;
            foreach (Player p in players)
            {
                int numberOfCards = 0;
                foreach (StandardCard sc in p.Cards)
                {
                    if ((int)sc.rank == winningNumber)
                    {
                        numberOfCards++;
                        totalCards++;
                    }
                }

                if (numberOfCards > 0)
                {
                    p.Winnings += Math.Round(purse / 4 * numberOfCards, 2);
                }

                if (totalCards >= 4)
                {
                    return;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="roll"></param>
        /// <returns></returns>
        private HorseControl GetRolledHorse(int roll)
        {
            foreach (HorseControl hc in horses)
            {
                if (hc.HorseNumber == roll)
                {
                    return hc;
                }
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        private void ResetAll()
        {
            gameState = GameState.Begin;
            ResetForNextRace();
            currentRaceLabel.Text = "";
            addPlayerButton.Enabled = true;
            deletePlayerButton.Enabled = true;
            foreach (Player p in players)
            {
                p.Winnings = 0;
                p.ClearHand();
            }            
            DisplayPlayers();
        }

        /// <summary>
        /// 
        /// </summary>
        private void ResetForNextRace()
        {
            foreach (HorseControl hc in horses)
                hc.ResetHorse();

            foreach (Player p in players)
                p.ClearHand();

            purse = 0.0m;
            DisplayPurse();
            winningNumber = 0;
            nextRaceButton.Enabled = true;
            rollButton.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int Roll()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            return random.Next(1, 7) + random.Next(1, 7);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hc"></param>
        private void SetEndRaceState(HorseControl hc)
        {
            gameState = GameState.EndRace;
            winningNumber = hc.HorseNumber;
            DivideWinnings();
            DisplayPlayers();
            SwitchButtons();

            if (currentRace == totalRaces)
            {
                SetWinState();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetRace()
        {
            if (gameState == GameState.Begin)
            {
                totalRaces = int.Parse(totalRacesTextBox.Text);
                currentRace = 1;
                addPlayerButton.Enabled = false;
                deletePlayerButton.Enabled = false;
            }
            else
                currentRace++;

            currentRaceLabel.Text = currentRace.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetScratches()
        {
            for (int scratched = 0; scratched < 4; scratched++)
            {
                HorseControl hc = GetRolledHorse(Roll());
                if (hc.IsScratched)
                {
                    scratched--;
                    continue;
                }
                else
                    hc.IsScratched = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetWinState()
        {
            gameState = GameState.WinGame;
            decimal mostWinnings = 0;
            Player winner = null;
            foreach (Player p in players)
            {
                if (p.Winnings > mostWinnings)
                    winner = p;
            }

            using (var winGameForm = new WinGameForm(winner.Name))
            {
                var result = winGameForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ResetAll();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SwitchButtons()
        {
            rollButton.Enabled = !rollButton.Enabled;
            nextRaceButton.Enabled = !nextRaceButton.Enabled;
        }

        #region Event Handlers

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            using (var addPlayerForm = new AddPlayerForm())
            {
                var result = addPlayerForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    players.Add(new Player(addPlayerForm.PlayerName));
                }
            }

            DisplayPlayers();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deletePlayerButton_Click(object sender, EventArgs e)
        {
            using (var deletePlayerForm = new DeletePlayerForm(players))
            {
                var result = deletePlayerForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    players = deletePlayerForm.Players;
                }
            }

            DisplayPlayers();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextRaceButton_Click(object sender, EventArgs e)
        {
            if (players.Count < 2)
            {
                MessageBox.Show("You must enter at least 2 players to run a race!");
                return;
            }

            if (gameState == GameState.EndRace)
            {
                ResetForNextRace();
            }

            SetRace();
            DealCards();
            SetScratches();

            purse = 400.00m;
            DisplayPurse();
            SwitchButtons();
            gameState = GameState.Play;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rollButton_Click(object sender, EventArgs e)
        {
            var roll = Roll();
            resultLabel.Text = roll.ToString();

            if (gameState == GameState.Play)
            {
                HorseControl hc = GetRolledHorse(roll);
                if (hc.IsScratched)
                {
                    purse += 400.00m;
                    DisplayPurse();
                }
                else
                    hc.PerformStep();

                if (hc.IsWinner())
                {
                    SetEndRaceState(hc);
                }
            }
        }

        #endregion
    }
}
