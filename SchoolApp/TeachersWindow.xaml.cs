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

namespace SchoolApp
{
    /// <summary>
    /// Interaction logic for TeachersWindow.xaml
    /// </summary>
    public partial class TeachersWindow : Window
    {
        public ObservableCollection<Teacher> Teachers { get; set; }

        public TeachersWindow()
        {
            InitializeComponent();
            Teachers = new ObservableCollection<Teacher>(TecherManager.GetAllSTeachers());
            DataContext = this;
        }
        //public List<Teacher> Teachers { get; set; }
    }
}
