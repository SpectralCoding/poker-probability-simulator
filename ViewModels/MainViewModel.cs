using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Models;
using Utilities;

namespace ViewModels {
	public class MainViewModel : ViewModelBase {

		private Game game = new Game();

		public Game Game {
			get { return this.game; }
		}

		public MainViewModel() {
			
		}


	}
}
