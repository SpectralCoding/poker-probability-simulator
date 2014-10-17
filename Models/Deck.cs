using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTypes;

namespace Models {
	public class Deck : ModelBase {
		private Card[] cards = new Card[52];

		public Card[] Cards {
			get { return this.cards; }
		}

		public Deck() {
			ResetDeck();
		}

		/// <summary>
		/// Resets a deck to a brand new deck (2-A of each suit). No Jokers.
		/// </summary>
		private void ResetDeck() {
			int cardIndex = 0;
			for (int cardSuit = 0; cardSuit < 4; cardSuit++) {
				for (int cardType = 2; cardType < 15; cardType++) {
					this.cards[cardIndex] = new Card((CardType)cardType, (CardSuit)cardSuit);
					cardIndex++;
				}
			}
		}

		/// <summary>
		/// Returns a card at the current position in the deck.
		/// </summary>
		/// <param name="cardPosition">Position of card object to retrieve.</param>
		/// <returns>Card object</returns>
		public Card GetCard(int cardPosition) {
			return this.cards[cardPosition];
		}

	}
}
