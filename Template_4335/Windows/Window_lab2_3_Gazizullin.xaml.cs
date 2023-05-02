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
using System.Windows.Shapes;
using Template_4335.Windows.Classes;
using Template_4335.Windows.Pages;

namespace Template_4335.Windows
{
    /// <summary>
    /// Логика взаимодействия для Window_lab2_3_Gazizullin.xaml
    /// </summary>
    public partial class Window_lab2_3_Gazizullin : Window
    {
        public Window_lab2_3_Gazizullin()
        {
            InitializeComponent();
            MainFrame.Navigate(new ExcelPages());
            Manager.MainFrame = MainFrame;
        }


        /// <summary>
        /// Открыть страницу для взаимодействия с Excel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExcelPageBtn_OnClick(object sender, RoutedEventArgs e) =>
            MainFrame.Navigate(new ExcelPages());

        /// <summary>
        /// Открыть страницу для взаимодействия с Word.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WordPageBtn_OnClick(object sender, RoutedEventArgs e) =>
            MainFrame.Navigate(new WordPage());

        /// <summary>
        /// Очистка таблицы из Базы Данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteDataBtn_Click(object sender, RoutedEventArgs e)
        {
            if (
                MessageBox.Show("Вы уверены в том, что хотите очистить Базу Данных?",
                                "Внимание!",
                                MessageBoxButton.YesNo,
                                MessageBoxImage.Question) == MessageBoxResult.Yes
               )
            {
                SecondaryFunctions.DeleteData();
                SecondaryFunctions.RefreshData();
            }
        }

    }
}
