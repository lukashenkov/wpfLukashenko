using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//1. Создать сущности Employee и Department и заполните списки сущностей начальными данными.
//2. Для списка сотрудников и списка департаментов предусмотреть визуализацию(отображение). Это можно сделать, например, с использованием ComboBox или ListView.
//3. Предусмотреть возможность редактирования сотрудников и департаментов.Должна быть возможность изменить департамент у сотрудника. Список департаментов для выбора, можно выводить в ComboBox, это все можно выводить на дополнительной форме.
//4. Предусмотреть возможность создания новых сотрудников и департаментов.Реализовать данную возможность либо на форме редактирования, либо сделать новую форму.
// Лукашенко Валентина

namespace WpfLukashenko
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      public  List<Employee> listEmpl = new List<Employee>();




        public MainWindow()
        {listEmpl.Add(new Employee("ff", "gg","ff", DateTime.Today, new Department(), 1000, "арпавп"));
            InitializeComponent();
            lbEmployee.ItemsSource = listEmpl;
        }

        private void btView_Click(object sender, RoutedEventArgs e)
        {
            if (lbEmployee.SelectedIndex!=-1)
            {
                new ViewEmployee().ShowDialog();

            }
            else
            {
                MessageBox.Show("Выберите сотрудника!");
            }
            
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            new NewEmployee().ShowDialog();
        }
    }
}
