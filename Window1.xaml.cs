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
using NewToDoList.src;

namespace NewToDoList
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow main;
        public Window1()
        {
            InitializeComponent();

            descriptionToDo.Text = "Описания нет";
            dateToDo.SelectedDate = new DateTime(2024, 01, 10);

            MainWindow main = (this.Owner as MainWindow);
            this.main = main;           
        }
        private void AddJob(object sender, RoutedEventArgs e)
        {
            (this.Owner as MainWindow).ToDoList.Add(new ToDo(titleToDo.Text, descriptionToDo.Text, dateToDo.SelectedDate.Value));
            titleToDo.Text = "";
            descriptionToDo.Text = "описания нет";
            dateToDo.SelectedDate = new DateTime(2024, 01, 10);

            (this.Owner as MainWindow).listToDo.Items.Refresh();
            (this.Owner as MainWindow).OnPropertyChanged();

            this.Close();
        }
    }
}
