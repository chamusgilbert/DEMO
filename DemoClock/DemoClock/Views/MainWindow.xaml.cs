using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace DemoClock.Views
{
	/// <summary>
	/// Interaction logic for PunchView.xaml
	/// </summary>
	public partial class PunchView : UserControl
	{
		private bool _shiftDown;

		public PunchView()
		{
			InitializeComponent();
		}

		private void UserControl_PreviewKeyDown(object sender, KeyEventArgs e)
		{

		}

		private void UserControl_KeyDown(object sender, KeyEventArgs e)
		{
			Console.WriteLine(e.Key);
			if (Keyboard.FocusedElement.GetType() != typeof(TextBox))
				return;

			if (e.Key == Key.Return || e.Key == Key.Enter)
			{
				var element = (FrameworkElement)Keyboard.FocusedElement;
				element.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
			}
			if (e.Key == Key.LeftShift)
			{
				_shiftDown = true;
			}
		}

		private void UserControl_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.LeftShift)
			{
				_shiftDown = false;
			}
		}

	}
}
