using System;
using System.Windows;
using System.Windows.Input;

namespace EMailClient
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public UriTypeConverter g = new UriTypeConverter();

        private void ChangePage(string pass)
        {
            try
            {
                Cursor = Cursors.Wait;
                f.Source = g.ConvertFromString(pass) as Uri;
                Cursor = Cursors.Arrow;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bWriteLetter_Click(object sender, RoutedEventArgs e)
        {
            ChangePage("SendMessage.xaml");
        }

        private void bListOfLetters_Click(object sender, RoutedEventArgs e)
        {
            ChangePage("Inbox.xaml");
        }

        private void bSettings_Click(object sender, RoutedEventArgs e)
        {
            ChangePage("Settings.xaml");
        }
    }
}
