using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace UnoErrors
{
	public partial class MyCanvas : Canvas
	{
		internal static readonly TimeSpan WAIT = TimeSpan.FromMilliseconds(1000);

		public MyCanvas()
		{
			this.Loaded += MyCanvas_Loaded;
		}

		private async void MyCanvas_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			var referenceChild = new MyControl();
			var animatedChild = new MyControl()
			{
				Background = new SolidColorBrush(Colors.Beige)
			};

			this.Children.Add(referenceChild);
			this.Children.Add(animatedChild);

			Canvas.SetLeft(referenceChild, 100);
			Canvas.SetTop(referenceChild, 100);

			Canvas.SetLeft(animatedChild, 100);
			Canvas.SetTop(animatedChild, 100);

			NewMethod(referenceChild, animatedChild);
		}

		private async Task NewMethod(MyControl referenceChild, MyControl animatedChild)
		{
			AnimationHelper.TranslateX(animatedChild, 100);
			await Task.Delay(WAIT);

			AnimationHelper.TranslateY(animatedChild, 100);
			await Task.Delay(WAIT);

			AnimationHelper.TranslateX(animatedChild, -100);
			await Task.Delay(WAIT);

			AnimationHelper.TranslateY(animatedChild, 0);
			await Task.Delay(WAIT);

			AnimationHelper.TranslateX(animatedChild, 0);
			await Task.Delay(WAIT);
		}
	}
}