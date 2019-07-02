using System;
using System.Windows;
using System.Windows.Controls;

namespace EMailClient
{
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
            try
            {
                if (Properties.Settings.Default.EnglishLanguage == true)
                    cbLanguage.IsChecked = true;
                if (Properties.Settings.Default.SaveContacts == true)
                    cbSaveContacts.IsChecked = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void cbLanguage_Unchecked(object sender, RoutedEventArgs e)
        {
            bReference.Content = "Справка";
            lsave.Content = "Сохранять контакты после отправки писем";
            try
            {
                Properties.Settings.Default.EnglishLanguage = false;
                Properties.Settings.Default.Save();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbLanguage_Checked(object sender, RoutedEventArgs e)
        {
            bReference.Content = "Reference";
            lsave.Content = "Save contacts after sending letters";
            try
            {
                Properties.Settings.Default.EnglishLanguage = true;
                Properties.Settings.Default.Save();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSaveContacts_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                Properties.Settings.Default.SaveContacts = true;
                Properties.Settings.Default.Save();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSaveContacts_Unchecked(object sender, RoutedEventArgs e)
        {
            try
            {
                Properties.Settings.Default.SaveContacts = false;
                Properties.Settings.Default.Save();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bReference_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Reference.chm");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
