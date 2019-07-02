using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;
using System.Net.Mail;
using System.Net;
using System.Collections.Specialized;


namespace EMailClient
{
    public partial class Page1 : Page
    {
        StringCollection contacts = Properties.Settings.Default.Contacts;
        string delete_message = "Вы уверены, что хотите удалить адрес ";
        string delete_message_header = "Удаление контакта";

        public Page1()
        {
            InitializeComponent();
            try
            {
                cbReceiver.ItemsSource = contacts;
                if (Properties.Settings.Default.EnglishLanguage == true)
                {
                    delete_message = "Are you sure that you want to delete this address ";
                    delete_message_header = "Deleting contact";
                    lreceiver.Content = "Receiver";
                    lsubject.Content = "Subject of letter";
                    bSend.Content = "Send";
                    bAddAttach.Content = "Attach";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public MailMessage mailMessage = new MailMessage();

        private void bAddAttach_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                Nullable<bool> result = openFileDialog.ShowDialog();
                if (result == true)
                {
                    Attachment attachment = new Attachment(openFileDialog.FileName);
                    mailMessage.Attachments.Add(attachment);
                    lbAttaches.Items.Add(openFileDialog.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bSend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string list = cbReceiver.Text.Trim(' ');
                while (list.Contains("  "))
                    list.Replace("  ", " ");
                list.Trim(' ');
                string[] lista = list.Split(' ');

                mailMessage.From = new MailAddress(Authorization.Login);
                mailMessage.Subject = tbLetterTopic.Text;
                mailMessage.Body = tbLetterBody.Text;
                mailMessage.IsBodyHtml = true;
                foreach(string s in lista)
                    mailMessage.To.Add(new MailAddress(s));
                SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 25);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(Authorization.Login, Authorization.Password);
                smtp.Send(mailMessage);
                MessageBox.Show("Отправлено");
                if(Properties.Settings.Default.SaveContacts == true)
                {
                    foreach (string s in lista)
                        if (!contacts.Contains(s))
                            contacts.Add(s);
                    Properties.Settings.Default.Contacts = contacts;
                    Properties.Settings.Default.Save();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbAttaches_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (lbAttaches.SelectedItems.Count == 1)
                    lbAttaches.Items.Remove(lbAttaches.SelectedItem);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void cbReceiver_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (cbReceiver.SelectedItem != null)
                {
                    var result = MessageBox.Show(delete_message + cbReceiver.SelectedItem.ToString() + "?", delete_message_header, MessageBoxButton.YesNo, MessageBoxImage.None);
                    if (result.ToString() == "Yes")
                    {
                        MessageBox.Show(cbReceiver.SelectedItem.ToString());
                        contacts.Remove(cbReceiver.SelectedItem.ToString());
                        cbReceiver.ItemsSource = null;
                        cbReceiver.Items.Clear();
                        cbReceiver.ItemsSource = contacts;
                        Properties.Settings.Default.Contacts = contacts;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bSendAll_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (string s in contacts)
                    cbReceiver.Text += " " + s;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
