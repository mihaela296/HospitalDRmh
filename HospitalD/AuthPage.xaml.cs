using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace HospitalD
{
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new ModelEntities()) // Используйте ваш контекст, созданный в Model.edmx
            {
                // Проверка на конкретного пользователя
                if (usernameTextBox.Text == "doroganM" && passwordBox.Password == "12345678")
                {
                    // Здесь можно перенаправить на главную страницу или панель администратора
                    NavigationService.Navigate(new PatientDashboard());
                    return;
                }

                var user = db.Users.FirstOrDefault(u => u.Username == usernameTextBox.Text && u.Password == passwordBox.Password);
                if (user != null)
                {
                    // Успешный вход
                    NavigationService.Navigate(new UserDashboard(user));
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль.");
                }
            }
        }

        private void NavigateToReg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }
    }
}