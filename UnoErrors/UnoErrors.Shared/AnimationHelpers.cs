using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Animation;

namespace UnoErrors
{
	internal static class AnimationHelper
	{
		internal static readonly TimeSpan DURATION = TimeSpan.FromMilliseconds(750);
		private static readonly EasingFunctionBase EASING = new CubicEase() { EasingMode = EasingMode.EaseInOut };

		internal static void TranslateX(UIElement element, double to)
			=> Animate(element, "(UIElement.RenderTransform).(TranslateTransform.X)", to);

		internal static void TranslateY(UIElement element, double to)
			=> Animate(element, "(UIElement.RenderTransform).(TranslateTransform.Y)", to);

		internal static void Fade(UIElement element, double to)
			=> Animate(element, "Opacity", to);

		private static void Animate(UIElement element, string targetProperty, double to)
		{
			var anim = new DoubleAnimation()
			{
				To = to,
				Duration = DURATION,
				EasingFunction = EASING
			};

			var storyboard = new Storyboard();

			Storyboard.SetTarget(anim, element);
			Storyboard.SetTargetProperty(anim, targetProperty);

			storyboard.Children.Add(anim);
			storyboard.Begin();
		}
	}
}