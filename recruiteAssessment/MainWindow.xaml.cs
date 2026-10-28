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
            RefreshView();
        }

        Handler handler = new Handler();
        Jobs  jobs = new Jobs();

        public void RefreshView()  //updates the Listbox
        {
            txtEmployeeList.ItemsSource = null;
            txtEmployeeList.ItemsSource = handler.Contractors;

            cmbAssignWorker.ItemsSource = null;
            cmbAssignWorker.ItemsSource = handler.Contractors;


            txtJobList.ItemsSource = null;
            txtJobList.ItemsSource = handler.Jobs;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            handler.AddContractor(txtFirstName.Text, txtLastName.Text, txtStartdate.SelectedDate.Value); 

            txtFirstName.Clear(); 
            txtLastName.Clear();
            txtStartdate.SelectedDate = null; 
           
            RefreshView();

            cmbAssignWorker.SelectedIndex = -1; //combobox- assigning worker to the joblist
        }

        public void addJob_Click(object sender, RoutedEventArgs e)
        {
            handler.AddJob(txtJobTitle.Text, txtJobSalary.Text, txtJobDate.SelectedDate.Value);

            txtJobTitle.Clear();
            txtJobSalary.Clear();
            txtJobDate.SelectedDate = null;
            RefreshView();
        }

        private void delButton_Click(object sender, RoutedEventArgs e)
        {
            int index = txtEmployeeList.SelectedIndex;
            if(index < 0)
            {
                MessageBox.Show("Please select the object to delete");
            }
            else
            {
                Contractor contractor = handler.Contractors[index];
                handler.DelContractor(contractor);
                RefreshView();
            }
        }



        private void delJob_Click(object sender, RoutedEventArgs e)
        {
            int index = txtJobList.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select the object to delete");
            }
            else
            {
                Jobs job = handler.Jobs[index];
                handler.DelJob(job);
                RefreshView();
            }
        }

        private void jobCostReset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void jobCostSearch_Click(object sender, RoutedEventArgs e)
        {
            //read min, max-> if min < object's totalSalary <  max: save it to new/handler?
            //show this to the jobList
        }

        private void SearchEmployee_Click(object sender, RoutedEventArgs e)
        {
            //txtContSearch.Text.to upper/lower  %LIke  txtFirstName  txtLastName     .Contains()
            //save that to the new? or handler
            //show the result to the list
        }

        private void cmbAssignWorker_SelectionChanged(object sender, SelectionChangedEventArgs e) //combo_box click-> assign th job to the worker// maybe not needed
        {

        }
    }
}
