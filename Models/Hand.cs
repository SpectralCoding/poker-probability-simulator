using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DataTypes;

namespace Models {
	public class Hand : ModelBase {
		private ObservableCollection<Card> cards = new ObservableCollection<Card>();
		public ObservableCollection<Card> Cards {
			get { return this.cards; }
		}

		public Hand() {
			this.cards.Add(new Card(CardType.Ace, CardSuit.Club));
			this.cards.Add(new Card(CardType.Ace, CardSuit.Diamond));
			this.cards.Add(new Card(CardType.Ace, CardSuit.Heart));
			this.cards.Add(new Card(CardType.Ace, CardSuit.Spade));
			OnPropertyChanged("Cards");
		}

	}
}
