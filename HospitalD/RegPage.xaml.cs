using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace HospitalD
{
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new ModelEntities()) 
            {
                var existingUser = db.Users.FirstOrDefault(u => u.Username == usernameRegTextBox.Text);
                if (existingUser != null)
                {
                    MessageBox.Show("Пациент уже существует в базе.");
                    return;
                }

                var newUser = new User
                {
                    FullName = fullNameTextBox.Text,
                    BirthDate = birthDatePicker.SelectedDate ?? DateTime.Now,
                    PhoneNumber = phoneNumberTextBox.Text,
                    PassportSeries = passportSeriesTextBox.Text,
                    PassportNumber = passportNumberTextBox.Text,
                    Gender = (genderComboBox.SelectedItem as ComboBoxItem)?.Content.ToString(),
                    Username = usernameRegTextBox.Text,
                    Password = passwordRegBox.Password,
                    Role = "User " 
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("Регистрация прошла успешно!");
                NavigationService.Navigate(new AuthPage());
            }
        }

        private void NavigateToAuth_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}