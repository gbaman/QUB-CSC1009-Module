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
	/// Interaction logic for Screen_1.xaml
	/// </summary>
	public partial class Screen_1 : UserControl
	{
		public Screen_1()
		{
			this.InitializeComponent();
			this.SizeChanged += OnWindowSizeChanged;
			this.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
			this.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
		}
		
		protected void OnWindowSizeChanged(object sender, SizeChangedEventArgs e)
		{
			double newWindowHeight = e.NewSize.Height;
			double newWindowWidth = e.NewSize.Width;
			double prevWindowHeight = e.PreviousSize.Height;
			double prevWindowWidth = e.PreviousSize.Width;
			System.Diagnostics.Debug.WriteLine(newWindowWidth);
		}
	}
}