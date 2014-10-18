using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTypes;
using Utilities;

namespace Models {
	public class CardInHand : Card {
		private bool isHeld = false;
		private bool isLocked = false;
		public DelegateCommand<object> ToggleHoldCommand { get; private set; }

		public bool IsHeld {
			get { return this.isHeld; }
			set {
				if (!IsLocked) {
					SetField(ref this.isHeld, value);
				}
			}
		}
		public bool IsLocked {
			get { return this.isLocked; }
			set { SetField(ref this.isLocked, value); }
		}
		public CardInHand(Card card)
			: base(card.Type, card.Suit) {
			ToggleHoldCommand = new DelegateCommand<object>(ToggleHoldCommand_Execute, ToggleHoldCommand_CanExecute);
		}

		void ToggleHoldCommand_Execute(object arg) {
			IsHeld = !IsHeld;
		}

		bool ToggleHoldCommand_CanExecute(object arg) {
			return true;
		}

	}
}
