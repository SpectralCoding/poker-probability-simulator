using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using System.Reflection;

namespace Resources {
	public static class Resources {
		[System.Runtime.InteropServices.DllImport("gdi32.dll")]
		private static extern bool DeleteObject(IntPtr hObject);

		private static Dictionary<string, BitmapSource> cardImages = new Dictionary<string,BitmapSource>();

		/// <summary>
		/// Gets a value which contains a dictionary of card images.
		/// </summary>
		public static Dictionary<string, BitmapSource> CardImages {
			get {
				if (cardImages.Count == 0) { LoadCards(); }
				return cardImages;
			}
		}

		private static void LoadCards() {
			//cardImages = new Dictionary<string, BitmapSource>();
			string[] cardList = { "Ac", "Ad", "Ah", "As", "2c", "2d", "2h", "2s", "3c", "3d", "3h", "3s", "4c", "4d", "4h", "4s", "5c", "5d", "5h", "5s", "6c", "6d", "6h", "6s", "7c", "7d", "7h", "7s", "8c", "8d", "8h", "8s", "9c", "9d", "9h", "9s", "Tc", "Td", "Th", "Ts", "Jc", "Jd", "Jh", "Js", "Qc", "Qd", "Qh", "Qs", "Kc", "Kd", "Kh", "Ks", "Back_Blue", "Back_Red", "Cs" };
			Stream tempStream = null;
			System.Drawing.Bitmap sourceBMP = null;
			BitmapSource tempBitmapSource;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			int i = 0;
			foreach (string curCardName in cardList) {
				tempStream = executingAssembly.GetManifestResourceStream("Resources.Resources.CardImages.Card_" + curCardName + ".gif");
				sourceBMP = new System.Drawing.Bitmap(tempStream);
				tempBitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
					sourceBMP.GetHbitmap(),
					IntPtr.Zero,
					System.Windows.Int32Rect.Empty,
					BitmapSizeOptions.FromWidthAndHeight(sourceBMP.Width, sourceBMP.Height)
				);
				cardImages[curCardName] = tempBitmapSource;
				i++;
			}
			tempStream.Dispose();
			DeleteObject(sourceBMP.GetHbitmap());
		}

	}
}
