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
        Jobs  jobs = new Jobs();
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            handler.AddContractor(txtFirstName.Text, txtLastName.Text, txtStartdate.SelectedDate.Value); 

            txtFirstName.Clear();
            txtLastName.Clear();
            txtStartdate.SelectedDate = null;
        }

        public void AddJob(string jobTitle, string totalSalary, DateTime jobDate)
        {
            handler.AddJob(txtJobTitle.Text, txtJobSalary.Text, txtJobDate.SelectedDate.Value);
            txtJobList.ItemsSource = new List<string>();
            txtJobList.ItemsSource = handler.Jobs;

            txtJobTitle.Clear();
            txtJobSalary.Clear();
            txtJobDate.SelectedDate = null;
        }

        private void delButton_Click(object sender, RoutedEventArgs e)
        {
        

        }

        

        private void delJob_Click(object sender, RoutedEventArgs e)
        {

        }


        private void jobCostReset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void jobCostSearch_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
