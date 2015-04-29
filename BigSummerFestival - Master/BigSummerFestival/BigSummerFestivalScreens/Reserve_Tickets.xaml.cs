using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BigSummerFestivalScreens
{
	/// <summary>
	/// Interaction logic for Reserve_Tickets.xaml
	/// </summary>
	public partial class Reserve_Tickets : UserControl
	{
		public Reserve_Tickets()
		{
			this.InitializeComponent();
			btn1.Click += click;
			btn2.Click += click;
		}
		
		public void click(Object sender, EventArgs e) {
			//scrollView.ScrollToVerticalOffset(scroller.HorizontalOffset + 10);
			for (int i=0; i<1030; i++) {
				scrollView.ScrollToVerticalOffset(scrollView.VerticalOffset + 1030);
			}
			
			
			//
			DoubleAnimation verticalAnimation = new DoubleAnimation();
			
			verticalAnimation.From = scrollViewer.VerticalOffset;
			verticalAnimation.To = 100;
			verticalAnimation.Duration = new Duration(1000);
			
			Storyboard storyboard = new Storyboard();
			
			storyboard.Children.Add(verticalAnimation);
			Storyboard.SetTarget(verticalAnimation, scrollViewer);
			Storyboard.SetTargetProperty(verticalAnimation, new PropertyPath(ScrollAnimationBehavior.VerticalOffsetProperty)); // Attached dependency property
			storyboard.Begin();
		}
	}
}