using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace To_Do_List
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст из TextBox
            string newItem = post_text.Text;

            // Проверяем, не пустой ли текст
            if (!string.IsNullOrWhiteSpace(newItem))
            {
                // Добавляем новый элемент в ListBox
                list.Items.Add(newItem);

                // Очищаем TextBox
                post_text.Clear();
            }
            else
            {
                MessageBox.Show("Введите текст для добавления в список.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
