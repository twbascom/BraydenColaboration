
using System.Runtime.CompilerServices;

namespace BraydensCardGame
{
    internal class cDeck
    {
        public List<cCard> cards = new List<cCard>();
        private const int MaxCardValue = 14;
        public List<string> suits = new List<string> {"diamond", "clubs", "square", "circle"};

        public cDeck()
        {

            cards.Clear();

            foreach (var suit in suits) {

            

                for (int x = 1; x < MaxCardValue + 1; x++) {
                    cCard card = new cCard();
                    cards.Add(card);
                    card.value = x;
                    card.suit = suit;
                }
            }
        }

        internal void add(cCard card)
        {
            cards.Add(card);
        }
    }
}