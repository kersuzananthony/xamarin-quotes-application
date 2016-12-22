using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace QuotesApplication
{
	public partial class QuotesPage : ContentPage
	{
		private int _index = 0;
		private string[] _quotes = new string[]
		{
			"Life is like riding a bicycle. To keep your balance, you must keep moving.",
			"You can't blame gravity for falling in love.",
			"Look deep into nature, and then you will understand everything better."
		};

		public QuotesPage()
		{
			InitializeComponent();

			SetQuoteText();
		}

		private void SetQuoteText() {
			currentQuote.Text = this._quotes[this._index];
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			this._index++;

			if (this._index >= this._quotes.Length)
				this._index = 0;

			SetQuoteText();
		}
	}
}
