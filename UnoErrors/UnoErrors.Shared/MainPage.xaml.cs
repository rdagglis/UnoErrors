using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using ReactiveUI;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace UnoErrors
{
	public sealed partial class MainPage : Page, IViewFor<MainPageViewModel>
	{
		public static readonly DependencyProperty ViewModelProperty =
			DependencyProperty.Register(
				nameof(ViewModel),
				typeof(MainPageViewModel),
				typeof(MainPage),
				new PropertyMetadata(default(MainPageViewModel)));

		public MainPageViewModel ViewModel
		{
			get => (MainPageViewModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		object IViewFor.ViewModel
		{
			get => ViewModel;
			set => ViewModel = (MainPageViewModel)value;
		}

		public MainPage()
		{
			this.InitializeComponent();

			this.ViewModel = new MainPageViewModel();

			// UNCOMMENT THIS TO MESS UP WASM
			// ------------------------------

			//this.WhenActivated(disposable =>
			//{
			//});

			// ------------------------------
		}
	}
}
