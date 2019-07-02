using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Net.Mail;
using S22.Imap;

namespace EMailClient
{
    public partial class Page2 : Page
    {
        public static ImapClient client;
        IEnumerable<uint> uids;
        int count_letters = 30;
        ObservableCollection<LetterContainer> sub = new ObservableCollection<LetterContainer>();
        IEnumerator<uint> enumerator;
        string from = "От: ";
        string date = $"\nДата: ";
        string subject = $"\nТема письма: ";

        public Page2()
        {
            InitializeComponent();
            try
            {
                if (Properties.Settings.Default.EnglishLanguage == true)
                {
                    bAllMessage.Content = "All";
                    bDeletedMessage.Content = "Deleted";
                    l20.Content = "More";
                    from = "From: ";
                    date = $"\nDate: ";
                    subject = $"\nSubject of letter: ";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                Dispatcher.InvokeAsync(() => {

                    string hostname = Authorization.Hostname;
                    string login = Authorization.Login;
                    string pas = Authorization.Password;

                    client = new ImapClient(hostname, 993, login, pas, AuthMethod.Login, true);

                    uids = client.Search(SearchCondition.Undeleted());
                    uids = uids.Reverse();
                    enumerator = uids.GetEnumerator();
                    while ((count_letters != 0) & (enumerator.MoveNext()))
                    {
                        MailMessage m = client.GetMessage(enumerator.Current);

                        sub.Add(new LetterContainer(m, enumerator.Current));
                        count_letters--;
                    }
                    ListOfLetters.ItemsSource = sub;
                });

                Cursor = Cursors.Arrow;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public class LetterContainer: MailMessage
        {
            public LetterContainer(MailMessage _mailMessage, uint _uid)
            {
                mailMessage = _mailMessage;
                LetterUID = _uid;
                Date = _mailMessage.Date().Value.ToShortDateString();
                LetterSender = _mailMessage.From.DisplayName;
                LetterSubject = _mailMessage.Subject;

            }
            public uint LetterUID { get; set; }
            public string LetterSubject { get; set; }
            public string LetterSender { get; set; }
            public string Date { get; set; }
            public MailMessage mailMessage { get; set; }
        }

        public UriTypeConverter g = new UriTypeConverter();

     
        private void l20_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                count_letters = 30;
                Cursor = Cursors.Wait;
                if (enumerator.MoveNext())
                    do
                    {
                        MailMessage m = client.GetMessage(enumerator.Current);

                        sub.Add(new LetterContainer(m, enumerator.Current));
                        count_letters--;
                    } while ((count_letters != 0) & (enumerator.MoveNext()));
                ListOfLetters.ItemsSource = sub;
                Cursor = Cursors.Arrow;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static LetterContainer container { get; set; }

        private void ListOfLetters_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if ((ListOfLetters.SelectedItems.Count == 1))
            {
                try
                {
                    Letter letter = new Letter();
                    container = (LetterContainer)ListOfLetters.SelectedItem;

                    letter.MessageInfo.Text = from + container.LetterSender +
                                              date + container.Date +
                                              subject + container.LetterSubject;
                    string _messageBody = @"<!DOCTYPE html ><html><meta http-equiv='Content-Type' content='text/html;charset=UTF-8'><head></head><body>" + container.mailMessage.Body + "</body></html>";
                    letter.mb.NavigateToString(_messageBody);
                    letter.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bDeletedMessage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cursor = Cursors.Wait;
                sub = new ObservableCollection<LetterContainer>();
                ListOfLetters.ItemsSource = null;
                ListOfLetters.Items.Clear();
                uids = client.Search(SearchCondition.Deleted());
                uids = uids.Reverse();
                enumerator = uids.GetEnumerator();
                count_letters = 30;
                while ((count_letters != 0) & (enumerator.MoveNext()))
                {
                    MailMessage m = client.GetMessage(enumerator.Current);

                    sub.Add(new LetterContainer(m, enumerator.Current));
                    count_letters--;
                }
                ListOfLetters.ItemsSource = sub;
                Cursor = Cursors.Arrow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bAllMessage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cursor = Cursors.Wait;
                sub = new ObservableCollection<LetterContainer>();
                ListOfLetters.ItemsSource = null;
                ListOfLetters.Items.Clear();
                count_letters = 30;
                uids = client.Search(SearchCondition.Undeleted());
                uids = uids.Reverse();
                enumerator = uids.GetEnumerator();
                while ((count_letters != 0) & (enumerator.MoveNext()))
                {
                    MailMessage m = client.GetMessage(enumerator.Current);

                    sub.Add(new LetterContainer(m, enumerator.Current));
                    count_letters--;
                }

                ListOfLetters.ItemsSource = sub;
                Cursor = Cursors.Arrow;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
