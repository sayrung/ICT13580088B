using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580088B
{
    public partial class MyPage3 : ContentPage
    {
		public MyPage3()
		{
			InitializeComponent();
			backButton.Clicked += BackButton_Clicked;
			backToRootButton.Clicked += BackToRootButton_Clicked;
		}

		void BackButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		void BackToRootButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PopToRootAsync();
		}
	}
}