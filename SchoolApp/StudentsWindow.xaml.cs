using SchoolApp.BL;
using SchoolApp.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using SchoolApp.BL;
using SchoolApp.DAL;
using System.Collections.ObjectModel;

namespace SchoolApp
{
    /// <summary>
    /// Interaction logic for StudentsWindow.xaml
    /// </summary>
    public partial class StudentsWindow : Window
    {
        public ObservableCollection<Student> Students { get; set; }
        public StudentsWindow()
        {
            InitializeComponent();
            Students = new ObservableCollection<Student>(StudentManager.GetAllStudents());
            DataContext = this;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {




        }
        //public List<Students> Students { get; set; }
    }
}