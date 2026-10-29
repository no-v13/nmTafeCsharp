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
        

        public void RefreshView()  //updates the Listbox
        {
            txtEmployeeList.ItemsSource = null;
            txtEmployeeList.ItemsSource = handler.ContractorList;

            
            lstContractors.ItemsSource = null;
            lstContractors.ItemsSource = handler.ContractorList;

            txtJobList.ItemsSource = null;
            txtJobList.ItemsSource = handler.JobList;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            handler.AddContractor(txtFirstName.Text, txtLastName.Text, txtStartdate.SelectedDate.Value); 

            txtFirstName.Clear(); 
            txtLastName.Clear();
            txtStartdate.SelectedDate = null; 
           
            RefreshView();

            
        }

        public void addJob_Click(object sender, RoutedEventArgs e)
        {
            Jobs newJob = handler.AddJob(txtJobTitle.Text, int.Parse(txtJobSalary.Text), txtJobDate.SelectedDate.Value);

            foreach (Contractor contractor in lstContractors.SelectedItems)
            {
                newJob.AssignContractorList.Add(contractor);
            }

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
                Contractor contractor = handler.ContractorList[index];
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
                Jobs job = handler.JobList[index];
                handler.DelJob(job);
                RefreshView();
            }
        }

        private void jobCostReset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void jobCostSearch_Click(object sender, RoutedEventArgs e)
        {
            List<Jobs> searchCost = new List<Jobs>();

            foreach(var cost in handler.JobList)
            {
                if (int.Parse(txtMincost.Text)<= cost.totalSalary && cost.totalSalary <= int.Parse(txtMaxcost.Text))
                {
                    searchCost.Add(cost);
                }
            }
            txtJobList.ItemsSource = searchCost;
        }

        private void SearchEmployee_Click(object sender, RoutedEventArgs e)
        {

            string keyword = txtContSearch.Text.ToLower();
            List<Contractor> searchList = new List<Contractor>();
            foreach (var word in handler.ContractorList) 
            { 
                if(word.FirstName.Contains(keyword) || word.LastName.Contains(keyword))
                {
                    searchList.Add(word);                    
                }               
            }
            txtEmployeeList.ItemsSource = searchList;
        }


    }
}
