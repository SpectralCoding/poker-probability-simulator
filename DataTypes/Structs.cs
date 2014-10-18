using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes {
	public enum CardSuit : int {
		/// <summary>
		/// Represents a Diamond.
		/// </summary>
		Diamond,

		/// <summary>
		/// Represents a Club.
		/// </summary>
		Club,

		/// <summary>
		/// Represents a Heart.
		/// </summary>
		Heart,

		/// <summary>
		/// Represents a Spade.
		/// </summary>
		Spade
	}

	/// <summary>
	/// Types of Cards.
	/// </summary>
	public enum CardType : int {
		/// <summary>
		/// Represents a cut card.
		/// </summary>
		CutCard = -1,

		/// <summary>
		/// Represents a Two.
		/// </summary>
		Two = 2,

		/// <summary>
		/// Represents a Three.
		/// </summary>
		Three = 3,

		/// <summary>
		/// Represents a Four.
		/// </summary>
		Four = 4,

		/// <summary>
		/// Represents a Five.
		/// </summary>
		Five = 5,

		/// <summary>
		/// Represents a Six.
		/// </summary>
		Six = 6,

		/// <summary>
		/// Represents a Seven.
		/// </summary>
		Seven = 7,

		/// <summary>
		/// Represents a Eight.
		/// </summary>
		Eight = 8,

		/// <summary>
		/// Represents a Nine.
		/// </summary>
		Nine = 9,

		/// <summary>
		/// Represents a Ten.
		/// </summary>
		Ten = 10,

		/// <summary>
		/// Represents a Jack.
		/// </summary>
		Jack = 11,

		/// <summary>
		/// Represents a Queen.
		/// </summary>
		Queen = 12,

		/// <summary>
		/// Represents a King.
		/// </summary>
		King = 13,

		/// <summary>
		/// Represents a Ace.
		/// </summary>
		Ace = 14
	}

}
