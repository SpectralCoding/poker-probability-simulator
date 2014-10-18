using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using DataTypes;
using Resources;

namespace Models {
	public class Card : ModelBase {
		protected CardSuit suit;
		protected CardType type;
		protected string shortTitle;
		protected string title;

		#region Public Properties
		/// <summary>
		/// Gets the suit of the card.
		/// </summary>
		public CardSuit Suit {
			get { return this.suit; }
			private set { this.suit = value; SetField(ref suit, value); }
		}
		/// <summary>
		/// Gets the type of the card.
		/// </summary>
		public CardType Type {
			get { return this.type; }
			private set { this.type = value; SetField(ref type, value); }
		}
		/// <summary>
		/// Gets the full title of the card.
		/// </summary>
		public string Title {
			get { return this.title; }
			private set { this.title = value; SetField(ref title, value); }
		}
		/// <summary>
		/// Gets the short title of the card. Example (Ace of Spades): As
		/// </summary>
		public string ShortTitle {
			get { return this.shortTitle; }
			private set { this.shortTitle = value; SetField(ref shortTitle, value); }
		}

		public BitmapSource CardImage {
			get { return Resources.Resources.CardImages[ShortTitle]; }
		}
		#endregion

		/// <summary>
		/// Initializes a new instance of the Card class.
		/// </summary>
		/// <param name="cardType">Type of card to create.</param>
		/// <param name="cardSuit">Suit of card to create.</param>
		public Card(CardType cardType, CardSuit cardSuit) {
			Type = cardType;
			Suit = cardSuit;
			ShortTitle = GetShortTitle();
			Title = GetTitle();
		}

		/// <summary>
		/// Gets the short title of the card. Example (Ace of Spades): As
		/// </summary>
		private string GetShortTitle() {
			string shortNumber = String.Empty;
			string shortSuit = String.Empty;
			switch (this.type) {
				case CardType.CutCard: shortNumber = "C"; break;
				case CardType.Two: shortNumber = "2"; break;
				case CardType.Three: shortNumber = "3"; break;
				case CardType.Four: shortNumber = "4"; break;
				case CardType.Five: shortNumber = "5"; break;
				case CardType.Six: shortNumber = "6"; break;
				case CardType.Seven: shortNumber = "7"; break;
				case CardType.Eight: shortNumber = "8"; break;
				case CardType.Nine: shortNumber = "9"; break;
				case CardType.Ten: shortNumber = "T"; break;
				case CardType.Jack: shortNumber = "J"; break;
				case CardType.Queen: shortNumber = "Q"; break;
				case CardType.King: shortNumber = "K"; break;
				case CardType.Ace: shortNumber = "A"; break;
			}
			switch (this.suit) {
				case CardSuit.Club: shortSuit = "c"; break;
				case CardSuit.Spade: shortSuit = "s"; break;
				case CardSuit.Diamond: shortSuit = "d"; break;
				case CardSuit.Heart: shortSuit = "h"; break;
			}
			return String.Format("{0}{1}", shortNumber, shortSuit);
		}

		/// <summary>
		/// Gets the full title of the card.
		/// </summary>
		private string GetTitle() {
			string englishNumber = String.Empty;
			string englishSuit = String.Empty;
			switch (this.type) {
				case CardType.CutCard: englishNumber = "CutCard"; break;
				case CardType.Two: englishNumber = "Two"; break;
				case CardType.Three: englishNumber = "Three"; break;
				case CardType.Four: englishNumber = "Four"; break;
				case CardType.Five: englishNumber = "Five"; break;
				case CardType.Six: englishNumber = "Six"; break;
				case CardType.Seven: englishNumber = "Seven"; break;
				case CardType.Eight: englishNumber = "Eight"; break;
				case CardType.Nine: englishNumber = "Nine"; break;
				case CardType.Ten: englishNumber = "Ten"; break;
				case CardType.Jack: englishNumber = "Jack"; break;
				case CardType.Queen: englishNumber = "Queen"; break;
				case CardType.King: englishNumber = "King"; break;
				case CardType.Ace: englishNumber = "Ace"; break;
			}

			switch (this.suit) {
				case CardSuit.Club: englishSuit = "Club"; break;
				case CardSuit.Spade: englishSuit = "Spade"; break;
				case CardSuit.Diamond: englishSuit = "Diamond"; break;
				case CardSuit.Heart: englishSuit = "Heart"; break;
			}
			return String.Format("{0} of {1}s", englishNumber, englishSuit);
		}

	}
}
