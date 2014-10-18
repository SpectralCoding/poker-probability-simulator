using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Models {
	public class Game : ModelBase {
		private Hand hand = new Hand();
		private Deck deck = new Deck();
		private bool isGameOver = false;

		public Hand Hand {
			get { return this.hand; }
		}
		public Deck Deck {
			get { return this.deck; }
		}

		#region DelegateCommands
		public DelegateCommand<object> DealCommand { get; private set; }
		public DelegateCommand<object> ResetCommand { get; private set; }
		void DealCommand_Execute(object arg) { Deal(); }
		bool DealCommand_CanExecute(object arg) { return !this.isGameOver; }
		void ResetCommand_Execute(object arg) { Reset(); }
		bool ResetCommand_CanExecute(object arg) { return this.isGameOver; }
		#endregion

		public Game() {
			DealCommand = new DelegateCommand<object>(DealCommand_Execute, DealCommand_CanExecute);
			ResetCommand = new DelegateCommand<object>(ResetCommand_Execute, ResetCommand_CanExecute);
			Reset();
		}

		public void Deal() {
			if (Hand.Cards.Count == 0) {
				// First deal, fill up player's hand.
				FillHand();
			} else {
				// Second deal, replace non-held cards
				Hand.ReplaceNonHeld(Deck);
				// Lock the cards so that IsHeld cannot be toggled
				Hand.LockCards();
				// Game is done.
				this.isGameOver = true;
			}
		}

		public void Reset() {
			Hand.Reset();
			Deck.ResetDeck();
			Deck.Shuffle();
			this.isGameOver = false;
		}

		private void FillHand() {
			for (int i = Hand.Cards.Count; i < 5; i++) {
				Hand.AddCard(Deck.Draw());
			}
		}



	}
}
