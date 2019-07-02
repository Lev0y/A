using System;
using System.Windows;
using System.Windows.Input;
using S22.Imap;
using System.Net.NetworkInformation;

namespace EMailClient
{
    public partial class Authorization : Window
    {
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static string Hostname { get; set; }

        public static string internet_exception = "Ошибка подключения. Отсутсвует подклюение к интернету";
        string data_exception = "Ошибка подключения. Неверные данные";

        public Authorization()
        {
            InitializeComponent();
            try
            {
                if (Properties.Settings.Default.EnglishLanguage == true)
                {
                    blog_in.Content = "Log in";
                    llogin.Content = "Login";
                    lpassword.Content = "Password";
                    internet_exception = "Connection error. No internet connection";
                    data_exception = "Connection error. Invalid data";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private  void blog_in_Click(object sender, RoutedEventArgs e)
        {
            Login = loginbox.Text;
            Password = passwordbox.Password;
            string hostname = "imap." + loginbox.Text.Remove(0, loginbox.Text.IndexOf('@') + 1);
            Hostname = hostname;
            IPStatus ip = IPStatus.Unknown;
            try
            {
                Cursor = Cursors.Wait;
                ip = new Ping().Send("google.com").Status;
                using (ImapClient client = new ImapClient(hostname, 993, loginbox.Text, passwordbox.Password, AuthMethod.Login, true))
                {
                    MainWindow m = new MainWindow();
                    m.Show();
                    Close();
                }
            }
            catch
            {
                Cursor = Cursors.Arrow;
                if (ip == IPStatus.Success)
                {
                    MessageBox.Show(data_exception);
                }
                else
                {
                    MessageBox.Show(internet_exception);
                }
            }
        }
    }
}
