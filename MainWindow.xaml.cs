using NewToDoList.src;
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

namespace NewToDoList
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<ToDo> ToDoList;
        public MainWindow()
        {
            InitializeComponent();

            ToDoList = new List<ToDo>();

            ToDoList.Add(new ToDo("Дело 1", "Описание", new DateTime(2024, 01, 10)));
            ToDoList.Add(new ToDo("Дело 1", "Описание", new DateTime(2024, 01, 10)));
            ToDoList.Add(new ToDo("Дело 1", "Описание", new DateTime(2024, 01, 10)));

            listToDo.ItemsSource = ToDoList;
        }
        private void DeleteJob(object sender, RoutedEventArgs eventArgs)
        {
            ToDoList.Remove(listToDo.SelectedItem as ToDo);
            listToDo.ItemsSource = null;
            listToDo.ItemsSource = ToDoList;
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e) 
        { 
            if (listToDo.SelectedItem != null)
            {
                (listToDo.SelectedItem as ToDo).Done = true;
            }
        }
        private void CheckBox_Uncheked(object sender, RoutedEventArgs e)
        {
            if (listToDo.SelectedItem != null)
            {
                (listToDo.SelectedItem as ToDo).Done = false;
            }
        }
        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Owner = this;
            window1.Show();
        }
    }
}
