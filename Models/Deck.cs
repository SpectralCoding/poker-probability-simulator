using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTypes;
using Utilities;

namespace Models {
	public class Deck : ModelBase {
		private Card[] cards = new Card[52];
		private int deckPosition = -1;

		public Card[] Cards {
			get { return this.cards; }
		}

		public int DeckPosition {
			get { return this.deckPosition; }
			private set { this.deckPosition = value; SetField(ref deckPosition, value); }
		}

		public Deck() {
			ResetDeck();
		}

		/// <summary>
		/// Resets a deck to a brand new deck (2-A of each suit). No Jokers.
		/// </summary>
		public void ResetDeck() {
			int cardIndex = 0;
			for (int cardSuit = 0; cardSuit < 4; cardSuit++) {
				for (int cardType = 2; cardType < 15; cardType++) {
					this.cards[cardIndex] = new Card((CardType)cardType, (CardSuit)cardSuit);
					cardIndex++;
				}
			}
			this.deckPosition = -1;
		}

		/// <summary>
		/// Returns a card at the current position in the deck.
		/// </summary>
		/// <param name="cardPosition">Position of card object to retrieve.</param>
		/// <returns>Card object</returns>
		public Card GetCard(int cardPosition) {
			return this.cards[cardPosition];
		}

		/// <summary>
		/// Shuffles the shoe with the shoe's specified algorithm.
		/// </summary>
		public void Shuffle() {
			// http://en.wikipedia.org/wiki/Shuffling
			// http://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
			int RandomPosition;
			MersenneTwister RandomMT = new MersenneTwister(Convert.ToUInt64(DateTime.Now.Ticks));
			Card tempCard;
			for (int i = 50; i > 1; i--) {
				RandomPosition = RandomMT.RandomRange(0, i);
				tempCard = this.cards[RandomPosition];
				this.cards[RandomPosition] = this.cards[i];
				this.cards[i] = tempCard;
			}
		}

		/// <summary>
		/// Returns a card from the deck and advances the deck position by one card.
		/// </summary>
		/// <returns>Returns next Card object in the deck.</returns>
		public Card Draw() {
			DeckPosition++;
			return this.cards[this.deckPosition];
		}
	}
}
