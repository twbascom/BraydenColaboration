namespace BraydensCardGame
{
    public partial class GameForm : Form
    {
        private cGame game = new cGame();

        public GameForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            game.start();

            Playerslistbox.Items.Clear();

            foreach (var player in game.players) { 
                Playerslistbox.Items.Add(player.playerName);
            }
            
            Decklistbox.Items.Clear();

            foreach (var card in game.deck.cards) {
                string text = $"{card.value} of {card.suit}";

                Decklistbox.Items.Add(text);

            }


        }
    }
}
