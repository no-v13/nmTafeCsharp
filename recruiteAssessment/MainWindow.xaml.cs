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

namespace recruiteAssessment
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Handler handler = new Handler();
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            handler.AddContractor(txtFirstName.Text, txtLastName.Text, txtStartdate.SelectedDate.Value); // value 를 몰랐러ㅜㅜㅜ 
            txtEmployeeList.ItemsSource = new List<string>();
            txtEmployeeList.ItemsSource = handler.Contractors;

            txtFirstName.Clear();
            txtLastName.Clear();
            txtStartdate.SelectedDate = null;
        }

        private void addJob_Click(object sender, RoutedEventArgs e)
        {
            handler.AddJob(txtJobTitle.Text, txtJobDate.SelectedDate.Value); // 쌰갈 기본 생성자 해도 이건 안되는건가
        }

        private void delButton_Click(object sender, RoutedEventArgs e)
        {
        

        }

        

        private void delJob_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtFirstName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        
    }
}
