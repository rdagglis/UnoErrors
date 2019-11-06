using System;
using System.Collections.Generic;
using System.Text;
using Splat;
using ReactiveUI;

namespace UnoErrors
{
	public class MainPageViewModel : ReactiveObject, IRoutableViewModel, IActivatableViewModel
	{
		public ViewModelActivator Activator { get; } = new ViewModelActivator();

		public string UrlPathSegment { get; protected set; }

		public IScreen HostScreen { get; protected set; }

		public MainPageViewModel(IScreen hostScreen = null)
		{
			HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();

			UrlPathSegment = nameof(MainPageViewModel);
		}
	}
}