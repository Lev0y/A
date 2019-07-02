using System;
using System.Windows;
using System.Net.Mail;
using System.IO;

namespace EMailClient
{
    public partial class Letter : Window
    {
        string save_message = "Письмо сохранено";
        string delete_message = "Вы уверены, что хотите удалить это письмо?";
        string delete_message_header = "Удаление письма";
        string delete_message_result = "Письмо удалено";

        public Letter()
        {
            InitializeComponent();
            try
            {
                if (Properties.Settings.Default.EnglishLanguage == true)
                {
                    Title = "Letter";
                    save_message = "Letter saved";
                    delete_message = "Are you sure that you want to delete this letter?";
                    delete_message_header = "Deleting letter";
                    delete_message_result = "Letter deleted";
                }
            }       
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void SaveMessage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                string save_pass = Environment.CurrentDirectory + @"\save";
                Directory.CreateDirectory(save_pass);
                client.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                client.PickupDirectoryLocation = save_pass;
                client.Send(Page2.container.mailMessage);
                MessageBox.Show(save_message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteMessage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = MessageBox.Show(delete_message, delete_message_header, MessageBoxButton.YesNo, MessageBoxImage.None);
                uint UID = Page2.container.LetterUID;
                if (result == MessageBoxResult.Yes)
                {
                    Page2.client.DeleteMessage(UID);
                    MessageBox.Show(delete_message_result);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
