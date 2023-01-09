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

namespace labtask10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee emp = new Employee { F_name = "Fatima", L_name = "Afzaal", gender = "Female", Cont_No = "09999999", Address = "Attock", W_No = "12", W_Name = "xyz" };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = emp;
        }
        public void changeResourceButton_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush MyBrush = Brushes.Green;
            this.Resources["brushResources"] = MyBrush;
        }
    }
    public class Employee
    {
        public String F_name { get; set; }
        public String L_name { get; set; }
        public String gender { get; set; }
        public String Cont_No { get; set; }
        public String Address { get; set; }
        public String W_No { get; set; }
        public String W_Name { get; set; }
    }
}
