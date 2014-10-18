using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DataTypes;
using Utilities;

namespace Models {
	public class Hand : ModelBase {
		private ObservableCollection<CardInHand> cards = new ObservableCollection<CardInHand>();
		public ObservableCollection<CardInHand> Cards {
			get { return this.cards; }
			private set { SetField(ref cards, value); }
		}

		public Hand() {
		}

		public void AddCard(Card cardToAdd) {
			Cards.Add(new CardInHand(cardToAdd));
		}

		public void Reset() {
			Cards = new ObservableCollection<CardInHand>();
		}

		public void ReplaceNonHeld(Deck deck) {
			for (int i = 0; i < Cards.Count; i++) {
				if (!Cards[i].IsHeld) {
					Cards[i] = new CardInHand(deck.Draw());
				}
			}
		}

		public void LockCards() {
			for (int i = 0; i < Cards.Count; i++) {
				Cards[i].IsLocked = true;
			}
		}

	}
}
