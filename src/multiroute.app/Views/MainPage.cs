﻿namespace multiroute.app.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		BindingContext = viewModel;
	}
}
