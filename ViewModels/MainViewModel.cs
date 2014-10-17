using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Models;

namespace ViewModels {
	public class MainViewModel : ViewModelBase {
		private Hand hand = new Hand();

		public Hand Hand {
			get { return this.hand; }
		}

		public string Test {
			get { return "lol"; }
		}

	}
}
