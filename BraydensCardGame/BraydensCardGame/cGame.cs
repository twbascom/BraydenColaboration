


namespace BraydensCardGame
{
    internal class cGame
    {
        public List<cPlayer> players = new List<cPlayer>();
        public cDeck deck = new cDeck();
        public cGame()
        {
        }

        internal void start()
        {
            createPlayers();
            createDeck();
        }

        private void createDeck()
        {

            deck = new cDeck();

        }

        private void createPlayers()
        {
            players.Clear();

            cPlayer player1 = new cPlayer();
            players.Add(player1);
            player1.playerName = "brayden";

            cPlayer player2 = new cPlayer();
            players.Add (player2);
            player2.playerName = "jasper";

            cPlayer player3 = new cPlayer();
            players.Add (player3);
            player3.playerName = "travis";
        }
    }
}