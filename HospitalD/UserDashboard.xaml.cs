using System.Windows.Controls;

namespace HospitalD
{
    public partial class UserDashboard : Page
    {
        public UserDashboard(User user) // Передаем пользователя в конструктор
        {
            InitializeComponent();
            // Здесь можно использовать данные пользователя
        }
    }
}