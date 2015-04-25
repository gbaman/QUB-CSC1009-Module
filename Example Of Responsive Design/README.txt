Hi Guys I created a quick test project that contains an example of responsive design in WPF.

Feel free to mess around with it.

If you decrease the width of the window, it should change the look of the application.


Quick Explanation of how it works

In the file MainWindow.xaml.cs, there is a method that changes the style if the window width is less than 810 pixels.

If > 810, it uses DesktopStyles.xaml

if < 810, it uses MobileStyles.xaml







