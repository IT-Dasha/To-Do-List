﻿using Microsoft.Toolkit.Uwp.Notifications;
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
            this.Icon = new BitmapImage(new Uri("icon.ico", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст из TextBox
            string newItem = post_text.Text;


            // Проверяем, не пустой ли текст
            if (!string.IsNullOrWhiteSpace(newItem))
            {

                // Добавляем новый элемент в ListBox определенным цветом в соответствии выбором типа задачи
                // Создаем новый текстовый элемент
                TextBlock newTextBlock = new TextBlock();

                // Устанавливаем  
                newTextBlock.Text = newItem;

                // Устанавливаем цвет текста в зависимости от выбранного элемента
                if (list_priority.SelectedIndex == 0)
                {
                    newTextBlock.Foreground = new SolidColorBrush(Colors.White);
                    newTextBlock.Background = new SolidColorBrush(Colors.Red);
                }
                else if (list_priority.SelectedIndex == 1)
                {
                    newTextBlock.Foreground = new SolidColorBrush(Colors.Black);
                    newTextBlock.Background = new SolidColorBrush(Colors.Orange);
                }
                else if (list_priority.SelectedIndex == 2)
                {
                    newTextBlock.Foreground = new SolidColorBrush(Colors.Black);
                    newTextBlock.Background = new SolidColorBrush(Colors.Yellow);
                }

                else if (list_priority.SelectedIndex == 3)
                {
                    newTextBlock.Foreground = new SolidColorBrush(Colors.White);
                    newTextBlock.Background = new SolidColorBrush(Colors.Green);
                }

                // Добавляем новый элемент в ListBox
                list.Items.Add(newTextBlock);

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
